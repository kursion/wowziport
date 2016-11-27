using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using WoWZiport;

using System.IO;
using System.IO.Compression;

namespace WoWAddonSync {
  public partial class Form1 : Form {

    private WowPath wowPath = null;

    private string exportAccountDir, exportRealmDir, exportCharacterDir;
    private string importAccountDir, importRealmDir, importCharacterDir, importArchiveFilename;
    private bool importWTF;
    private string progressText;

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Shown(object sender, EventArgs e) {
      labelExport_ProgressBar.BackColor = System.Drawing.Color.Transparent;
      InitializeWowPath();
      updateExport();
      updateImport();
      
    }

    #region WowPath
    private void InitializeWowPath() {
      this.wowPath = new WowPath();
      this.wowPath.searchPath();
      checkWowPath();
    }

    private void checkWowPath() {
      if (wowPath.isValid()) {
        string wowDir = wowPath.get();
        textBoxWowPath.Text = wowPath.get();
      } else {
        onWowPathError();
      }
    }

    private void onWowPathError() {
      tabControl1.SelectTab("tabSettings");
      textBoxWowPath.Focus();
      labelWowPath.ForeColor = Color.Red;
      tabImport.Enabled = false;
      tabExport.Enabled = false;
      alert("WoW Path", "Please specify a valid wow folder!");
    }

    private void onWowPathOK(string value) {
      labelWowPath.ForeColor = Color.Black;
      tabImport.Enabled = true;
      tabExport.Enabled = true;
      wowPath.set(value);
    }

    private void buttonWowPath_checkSave_Click(object sender, EventArgs e) {
      settings_checkSave();
    }

    private void settings_checkSave() {
      string path = textBoxWowPath.Text;
      if (wowPath.isValid(path)) {
        onWowPathOK(path);
      } else {
        onWowPathError();
      }
    }

    private void textboxWowPath_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        buttonWowPath_checkSave_Click(this, new EventArgs());
      }
    }
    #endregion

    private void buttonExport_Click(object sender, EventArgs e) {
      exportAccountDir = listBoxExport_Account.SelectedItem.ToString();
      exportRealmDir = listBoxExport_Realm.SelectedItem.ToString();
      exportCharacterDir = listBoxExport_Character.SelectedItem.ToString();

      if (backgroundWorkerExport.IsBusy != true) {
        backgroundWorkerExport.RunWorkerAsync();
      }
    }


    private void backgroundWorkerExport_DoWork(object sender, DoWorkEventArgs e) {
      BackgroundWorker worker = sender as BackgroundWorker;

      progressText = "Initializing..."; worker.ReportProgress(0);
      string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
      string outputDir = $"{getExportFolder()}-{datetime}\\";
      string wowWTFDir = $"{wowPath.get()}WTF/Account/{exportAccountDir}/{exportRealmDir}/{exportCharacterDir}/";
      string wowAddOnsDir = $"{wowPath.get()}Interface/AddOns/";
      string zipWTF = $"{outputDir}wtf.zip";
      string zipAddOns = $"{outputDir}addons.zip";
      string outputArchiveName = $"wowziport-{exportRealmDir}-{exportCharacterDir}-{datetime}.zip";
      string outputFile = $"{outputDir}../{outputArchiveName}";

      progressText = $"Creating temporary output directory...";

      if (Directory.Exists(outputDir)) {
        alert("Output directory", $"The output directory '{outputDir}' already exists, please move or delete it before extraction!");
        return;
      }
      if (!Directory.Exists(wowAddOnsDir)) { Directory.CreateDirectory(wowAddOnsDir); }
      Directory.CreateDirectory(outputDir); 
      worker.ReportProgress(5);

      // Creating zip files
      progressText = "Zipping WTF directory...";
      ZipFile.CreateFromDirectory(wowWTFDir, zipWTF); worker.ReportProgress(10);
      progressText = "Zipping AddOns directory...";
      ZipFile.CreateFromDirectory(wowAddOnsDir, zipAddOns); worker.ReportProgress(50);
      progressText = "Creating WoWZiport archive...";
      ZipFile.CreateFromDirectory(outputDir, outputFile); worker.ReportProgress(80);

      progressText = "Deleting temporary output directory...";
      Directory.Delete(outputDir, true);
      worker.ReportProgress(100);

      progressText = $"Done {outputArchiveName}";
      MessageBox.Show($"Extraction done {outputArchiveName}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
      worker.ReportProgress(0);

    }

    private void backgroundWorkerExport_ProgressChanged(object sender, ProgressChangedEventArgs e) {
      progressBarExport.Value = (e.ProgressPercentage);
      if(progressBarExport.Value == 0) {
        buttonExport.Enabled = true;
        labelExport_ProgressBar.Text = "";
        labelExport_ProgressBar.Visible = false;
      } else {
        buttonExport.Enabled = false;
        labelExport_ProgressBar.Text = $"{progressText} ({e.ProgressPercentage}%)";
        labelExport_ProgressBar.Visible = true;
      }
    }

    private void updateExport() {
      if (this.wowPath.isValid()) {
        updateListBoxes(listBoxExport_Account, "WTF/Account");
        textBoxExport_Path.Text = getExportFolder();
      } else {
        tabExport.Enabled = false;
      }
    }

    private void updateImport() {
      if(this.wowPath.isValid()) { 
        updateListBoxes(listBoxImport_Account, "WTF/Account");
      } else {
        tabImport.Enabled = false;
      }
    }

    private void updateListBoxes(ListBox lb, string subfolder) {
      lb.Items.Clear();
      string dirWTF = $"{wowPath.get()}/{subfolder}/";
      List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirWTF));
      foreach (string dir in dirs) {
        string directoryName = dirName(dir);
        if (!directoryName.Equals("SavedVariables")) {
          lb.Items.Add(directoryName);
        }
      }
      if (lb.Items.Count > 0) {
        lb.SetSelected(0, true);
      } 
    }

    private void listBoxExport_Account_SelectedIndexChanged(object sender, EventArgs e) {
      string account = listBoxExport_Account.SelectedItem.ToString();
      listBoxExport_Character.Items.Clear();
      updateListBoxes(listBoxExport_Realm, $"WTF/Account/{account}");
    }

    private void listBoxExport_Realm_SelectedIndexChanged(object sender, EventArgs e) {
      string account = listBoxExport_Account.SelectedItem.ToString();
      string realm = listBoxExport_Realm.SelectedItem.ToString();
      updateListBoxes(listBoxExport_Character, $"WTF/Account/{account}/{realm}");
    }

    private void listBoxImport_Account_SelectedIndexChanged(object sender, EventArgs e) {
      string account = listBoxImport_Account.SelectedItem.ToString();
      listBoxImport_Character.Items.Clear();
      updateListBoxes(listBoxImport_Realm, $"WTF/Account/{account}");
    }


    private void listBoxImport_Realm_SelectedIndexChanged(object sender, EventArgs e) {
      string account = listBoxImport_Account.SelectedItem.ToString();
      string realm = listBoxImport_Realm.SelectedItem.ToString();
      updateListBoxes(listBoxImport_Character, $"WTF/Account/{account}/{realm}");
    }


    private void buttonImport_Browse_Click(object sender, EventArgs e) {
      openFileDialogImport.Filter = "WoWZiport archive *.zip|*.zip";
      DialogResult result = openFileDialogImport.ShowDialog();
      if (result == DialogResult.OK) {
        string file = openFileDialogImport.FileName;
        textBoxImport_Path.Text = file;
        buttonImport.Enabled = true;
      }
    }

    private void buttonImport_Click(object sender, EventArgs e) {
      string archiveFilename = textBoxImport_Path.Text;
      if (!File.Exists(archiveFilename)) {
        alert("Import archive", $"The archive '{archiveFilename}' does not exists!");
        return;
      }
      buttonImport.Enabled = false;
      importArchiveFilename = archiveFilename;
      importAccountDir = listBoxImport_Account.SelectedItem.ToString();
      importRealmDir = listBoxImport_Realm.SelectedItem.ToString();
      importCharacterDir = listBoxImport_Character.SelectedItem.ToString();
      importWTF = checkBoxImport_WTF.Checked;

      if (backgroundWorkerImport.IsBusy != true) {
        backgroundWorkerImport.RunWorkerAsync();
      }
    }

    private void buttonSettings_Browse_Click(object sender, EventArgs e) {
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
        textBoxWowPath.Text = folderBrowserDialog1.SelectedPath;
        settings_checkSave();
      }
    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void label3_Click(object sender, EventArgs e) {

    }

    private void richTextBox_Information_TextChanged(object sender, EventArgs e) {

    }

    private void backgroundWorkerImport_DoWork(object sender, DoWorkEventArgs e) {
      BackgroundWorker worker = sender as BackgroundWorker;

      progressText = "Initializing..."; worker.ReportProgress(0);
      string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
      string wowDir = wowPath.get();
      string wowWTFDir = $"{wowDir}WTF/Account/{importAccountDir}/{importRealmDir}/{importCharacterDir}/";
      string wowAddOnsDir = $"{wowDir}Interface/AddOns/";
      string zipWTFBackup = $"{wowWTFDir}../wowziport-backup-WTF-{importCharacterDir}-{datetime}.zip";
      string zipAddOnsBackup = $"{wowAddOnsDir}../wowziport-backup-AddOns-{datetime}.zip";
      string zipWTFExtracted = $"{wowDir}wtf.zip";
      string zipAddOnsExtracted = $"{wowDir}addons.zip";


      // Extracting main archive
      progressText = "Extracting archive to WOW directory..."; worker.ReportProgress(10);
      ZipFile.ExtractToDirectory(importArchiveFilename, wowDir);
      if (!File.Exists(zipWTFExtracted) || !File.Exists(zipAddOnsExtracted)) {
        alert("Corrupted package", "The package that you are trying to import is not valid!");
        if (File.Exists(zipWTFExtracted)) { File.Delete(zipWTFExtracted); }
        if (File.Exists(zipAddOnsExtracted)) { File.Delete(zipAddOnsExtracted); }
        return;
      }

      // Backup of wtf (with timestamp)
      if (importWTF) {
        progressText = "Backuping WTF directory..."; worker.ReportProgress(30);
        ZipFile.CreateFromDirectory(wowWTFDir, zipWTFBackup);
      } 

      // Remove wtf.zip file if not importWTF checked and was extracted
      if (!importWTF) {
        if (File.Exists(zipWTFExtracted)) { File.Delete(zipWTFExtracted); }
      }
      
      // Backup of addons (with timestamp)
      progressText = "Backuping AddOns directory..."; worker.ReportProgress(50);
      ZipFile.CreateFromDirectory(wowAddOnsDir, zipAddOnsBackup);

      // Remove wtf dir
      if (importWTF) {
        progressText = "Removing WTF directory..."; worker.ReportProgress(60);
        Directory.Delete(wowWTFDir, true);
      }

      // Remove addons dir
      progressText = "Removing AddOns directory..."; worker.ReportProgress(80);
      Directory.Delete(wowAddOnsDir, true);

      // Extract addon dir into wowAddOnsDir
      progressText = "Extracting addons (might take few minutes)..."; worker.ReportProgress(85);
      ZipFile.ExtractToDirectory(zipAddOnsExtracted, wowAddOnsDir);
      File.Delete(zipAddOnsExtracted);

      // Extract wtf dir into wowWTFDir
      if (importWTF) {
        progressText = $"Extracting WTF for {importAccountDir}/{importRealmDir}/{importCharacterDir}..."; worker.ReportProgress(95);
        ZipFile.ExtractToDirectory(zipWTFExtracted, wowWTFDir);
        File.Delete(zipWTFExtracted);
      }

      worker.ReportProgress(100);
      MessageBox.Show("Import done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
      worker.ReportProgress(0);
    }

    private void backgroundWorkerImport_ProgressChanged(object sender, ProgressChangedEventArgs e) {
      progressBarImport.Value = (e.ProgressPercentage);
      if (progressBarImport.Value == 0) {
        buttonImport.Enabled = true;
        labelImport_ProgressBar.Text = "";
        labelImport_ProgressBar.Visible = false;
      } else {
        buttonImport.Enabled = false;
        labelImport_ProgressBar.Text = $"{progressText} ({e.ProgressPercentage}%)";
        labelImport_ProgressBar.Visible = true;
      }
    }




    // TOOLS
    private string getExportFolder() {
      return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\WoWZiport-export-tmp";
    }



    private string dirName(string dir) {
      return dir.Substring(dir.LastIndexOf('/') + 1);
    }

    private void alert(string title, string msg) {
      MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

  }
}
