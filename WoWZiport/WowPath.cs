using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WoWZiport {
  class WowPath {
    private string wowPath = null;

    #region Private

    // Gets the default drive letter
    private string getDefaultDriveLetter() {
      return Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
    }

    // Get a list of default wow directories
    private List<string> getDefaultWowDirectories(string defaultDrive) {
      return new List<string> {
        
        $@"{defaultDrive}Program Files (x86)\World of Warcraft\",
        $@"{defaultDrive}Program Files\World of Warcraft\",
      };
    }

    // Given a list of directories, check if one is valid and returns it.
    private string checkWowDirectories(List<string> paths) {
      string wowPath = null;
      foreach (var path in paths) {
        if (isValid(path)) { wowPath = path; break; }
      }
      return wowPath;
    }

    private string normalizePath(string path) {
      if(path == null) return null;
      string sep = "/";
      if (!path.EndsWith( sep)) { path += sep; }
      path = path.Replace("\\", sep);
      return path;
    }
    #endregion



    #region Public
    public string searchPath() {
      // Checks if the config path exists in the settings and if it is valid
      string configWoWPath = getSettingsPath();
      if (!String.IsNullOrEmpty(configWoWPath) && isValid(configWoWPath)) {
        wowPath = configWoWPath;
      }

      // Checks the default wow paths
      if (String.IsNullOrEmpty(wowPath)) {
        string defaultDrive = getDefaultDriveLetter();
        List<string> paths = getDefaultWowDirectories(defaultDrive);
        wowPath = checkWowDirectories(paths);
      }

      wowPath = normalizePath(wowPath);

      if (!String.IsNullOrEmpty(wowPath)) {
        setSettingsPath(wowPath);
      }



      return wowPath;
    }

    public bool isValid() {
      return isValid(this.wowPath);
    }

    public bool isValid(string path) {
      path = normalizePath(path);
      return File.Exists($@"{path}Wow.exe");
    }

    private string getSettingsPath() {
      return Properties.Settings.Default.WoWPath.Trim();
    }

    public void setSettingsPath(string path) {
      Properties.Settings.Default.WoWPath = path.Trim();
      Properties.Settings.Default.Save();
    }


    public string get() {
      return wowPath;
    }

    public void set(string path) {
      path = normalizePath(path);
      setSettingsPath(path);
      this.wowPath = path;
    }

    #endregion

  }
}
