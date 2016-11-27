namespace WoWAddonSync {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabWelcome = new System.Windows.Forms.TabPage();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tabImport = new System.Windows.Forms.TabPage();
      this.buttonImport_Browse = new System.Windows.Forms.Button();
      this.labelImport_Options = new System.Windows.Forms.Label();
      this.checkBoxImport_WTF = new System.Windows.Forms.CheckBox();
      this.labelImport_ProgressBar = new System.Windows.Forms.Label();
      this.labelImport_Title = new System.Windows.Forms.Label();
      this.progressBarImport = new System.Windows.Forms.ProgressBar();
      this.labelImport_Path = new System.Windows.Forms.Label();
      this.textBoxImport_Path = new System.Windows.Forms.TextBox();
      this.buttonImport = new System.Windows.Forms.Button();
      this.listBoxImport_Character = new System.Windows.Forms.ListBox();
      this.labelImport_Character = new System.Windows.Forms.Label();
      this.listBoxImport_Realm = new System.Windows.Forms.ListBox();
      this.labelImport_Realm = new System.Windows.Forms.Label();
      this.listBoxImport_Account = new System.Windows.Forms.ListBox();
      this.labelImport_Account = new System.Windows.Forms.Label();
      this.tabExport = new System.Windows.Forms.TabPage();
      this.labelExport_ProgressBar = new System.Windows.Forms.Label();
      this.labelExport_Title = new System.Windows.Forms.Label();
      this.progressBarExport = new System.Windows.Forms.ProgressBar();
      this.labelExport_Path = new System.Windows.Forms.Label();
      this.textBoxExport_Path = new System.Windows.Forms.TextBox();
      this.buttonExport = new System.Windows.Forms.Button();
      this.listBoxExport_Character = new System.Windows.Forms.ListBox();
      this.labelExport_Character = new System.Windows.Forms.Label();
      this.listBoxExport_Realm = new System.Windows.Forms.ListBox();
      this.labelExport_Realm = new System.Windows.Forms.Label();
      this.listBoxExport_Account = new System.Windows.Forms.ListBox();
      this.labelExport_Account = new System.Windows.Forms.Label();
      this.tabSettings = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.buttonWowPath_checkSave = new System.Windows.Forms.Button();
      this.labelWowPath = new System.Windows.Forms.Label();
      this.textBoxWowPath = new System.Windows.Forms.TextBox();
      this.backgroundWorkerExport = new System.ComponentModel.BackgroundWorker();
      this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
      this.backgroundWorkerImport = new System.ComponentModel.BackgroundWorker();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.buttonSettings_Browse = new System.Windows.Forms.Button();
      this.richTextBox_Information = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.labelCredits = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabWelcome.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.tabImport.SuspendLayout();
      this.tabExport.SuspendLayout();
      this.tabSettings.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabWelcome);
      this.tabControl1.Controls.Add(this.tabImport);
      this.tabControl1.Controls.Add(this.tabExport);
      this.tabControl1.Controls.Add(this.tabSettings);
      this.tabControl1.Location = new System.Drawing.Point(13, 13);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(502, 413);
      this.tabControl1.TabIndex = 0;
      // 
      // tabWelcome
      // 
      this.tabWelcome.Controls.Add(this.labelCredits);
      this.tabWelcome.Controls.Add(this.label1);
      this.tabWelcome.Controls.Add(this.richTextBox_Information);
      this.tabWelcome.Controls.Add(this.richTextBox1);
      this.tabWelcome.Controls.Add(this.pictureBox1);
      this.tabWelcome.Location = new System.Drawing.Point(4, 22);
      this.tabWelcome.Name = "tabWelcome";
      this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
      this.tabWelcome.Size = new System.Drawing.Size(494, 387);
      this.tabWelcome.TabIndex = 3;
      this.tabWelcome.Text = "Welcome";
      this.tabWelcome.UseVisualStyleBackColor = true;
      // 
      // richTextBox1
      // 
      this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
      this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBox1.Location = new System.Drawing.Point(10, 119);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
      this.richTextBox1.Size = new System.Drawing.Size(478, 46);
      this.richTextBox1.TabIndex = 3;
      this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::WoWZiport.Properties.Resources.logo_title;
      this.pictureBox1.InitialImage = null;
      this.pictureBox1.Location = new System.Drawing.Point(7, 7);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(481, 105);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // tabImport
      // 
      this.tabImport.Controls.Add(this.buttonImport_Browse);
      this.tabImport.Controls.Add(this.labelImport_Options);
      this.tabImport.Controls.Add(this.checkBoxImport_WTF);
      this.tabImport.Controls.Add(this.labelImport_ProgressBar);
      this.tabImport.Controls.Add(this.labelImport_Title);
      this.tabImport.Controls.Add(this.progressBarImport);
      this.tabImport.Controls.Add(this.labelImport_Path);
      this.tabImport.Controls.Add(this.textBoxImport_Path);
      this.tabImport.Controls.Add(this.buttonImport);
      this.tabImport.Controls.Add(this.listBoxImport_Character);
      this.tabImport.Controls.Add(this.labelImport_Character);
      this.tabImport.Controls.Add(this.listBoxImport_Realm);
      this.tabImport.Controls.Add(this.labelImport_Realm);
      this.tabImport.Controls.Add(this.listBoxImport_Account);
      this.tabImport.Controls.Add(this.labelImport_Account);
      this.tabImport.Location = new System.Drawing.Point(4, 22);
      this.tabImport.Name = "tabImport";
      this.tabImport.Padding = new System.Windows.Forms.Padding(3);
      this.tabImport.Size = new System.Drawing.Size(494, 387);
      this.tabImport.TabIndex = 0;
      this.tabImport.Text = "Import";
      this.tabImport.UseVisualStyleBackColor = true;
      // 
      // buttonImport_Browse
      // 
      this.buttonImport_Browse.Location = new System.Drawing.Point(343, 241);
      this.buttonImport_Browse.Name = "buttonImport_Browse";
      this.buttonImport_Browse.Size = new System.Drawing.Size(75, 23);
      this.buttonImport_Browse.TabIndex = 26;
      this.buttonImport_Browse.Text = "Browse";
      this.buttonImport_Browse.UseVisualStyleBackColor = true;
      this.buttonImport_Browse.Click += new System.EventHandler(this.buttonImport_Browse_Click);
      // 
      // labelImport_Options
      // 
      this.labelImport_Options.AutoSize = true;
      this.labelImport_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelImport_Options.Location = new System.Drawing.Point(271, 136);
      this.labelImport_Options.Name = "labelImport_Options";
      this.labelImport_Options.Size = new System.Drawing.Size(54, 13);
      this.labelImport_Options.TabIndex = 25;
      this.labelImport_Options.Text = "Options:";
      // 
      // checkBoxImport_WTF
      // 
      this.checkBoxImport_WTF.AutoSize = true;
      this.checkBoxImport_WTF.Checked = true;
      this.checkBoxImport_WTF.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxImport_WTF.Location = new System.Drawing.Point(328, 136);
      this.checkBoxImport_WTF.Name = "checkBoxImport_WTF";
      this.checkBoxImport_WTF.Size = new System.Drawing.Size(106, 17);
      this.checkBoxImport_WTF.TabIndex = 24;
      this.checkBoxImport_WTF.Text = "Import WTF data";
      this.checkBoxImport_WTF.UseVisualStyleBackColor = true;
      // 
      // labelImport_ProgressBar
      // 
      this.labelImport_ProgressBar.AutoSize = true;
      this.labelImport_ProgressBar.Location = new System.Drawing.Point(180, 362);
      this.labelImport_ProgressBar.Name = "labelImport_ProgressBar";
      this.labelImport_ProgressBar.Size = new System.Drawing.Size(0, 13);
      this.labelImport_ProgressBar.TabIndex = 23;
      // 
      // labelImport_Title
      // 
      this.labelImport_Title.AutoSize = true;
      this.labelImport_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelImport_Title.ForeColor = System.Drawing.SystemColors.ScrollBar;
      this.labelImport_Title.Location = new System.Drawing.Point(373, 3);
      this.labelImport_Title.Name = "labelImport_Title";
      this.labelImport_Title.Size = new System.Drawing.Size(114, 37);
      this.labelImport_Title.TabIndex = 22;
      this.labelImport_Title.Text = "Import";
      // 
      // progressBarImport
      // 
      this.progressBarImport.Location = new System.Drawing.Point(181, 321);
      this.progressBarImport.Name = "progressBarImport";
      this.progressBarImport.Size = new System.Drawing.Size(307, 37);
      this.progressBarImport.TabIndex = 21;
      // 
      // labelImport_Path
      // 
      this.labelImport_Path.AutoSize = true;
      this.labelImport_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelImport_Path.Location = new System.Drawing.Point(6, 246);
      this.labelImport_Path.Name = "labelImport_Path";
      this.labelImport_Path.Size = new System.Drawing.Size(67, 13);
      this.labelImport_Path.TabIndex = 20;
      this.labelImport_Path.Text = "Import file:";
      // 
      // textBoxImport_Path
      // 
      this.textBoxImport_Path.Location = new System.Drawing.Point(88, 243);
      this.textBoxImport_Path.Name = "textBoxImport_Path";
      this.textBoxImport_Path.ReadOnly = true;
      this.textBoxImport_Path.Size = new System.Drawing.Size(249, 20);
      this.textBoxImport_Path.TabIndex = 19;
      // 
      // buttonImport
      // 
      this.buttonImport.Enabled = false;
      this.buttonImport.Location = new System.Drawing.Point(9, 321);
      this.buttonImport.Name = "buttonImport";
      this.buttonImport.Size = new System.Drawing.Size(165, 37);
      this.buttonImport.TabIndex = 18;
      this.buttonImport.Text = "Import interface";
      this.buttonImport.UseVisualStyleBackColor = true;
      this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
      // 
      // listBoxImport_Character
      // 
      this.listBoxImport_Character.FormattingEnabled = true;
      this.listBoxImport_Character.Location = new System.Drawing.Point(88, 132);
      this.listBoxImport_Character.Name = "listBoxImport_Character";
      this.listBoxImport_Character.Size = new System.Drawing.Size(160, 95);
      this.listBoxImport_Character.TabIndex = 17;
      // 
      // labelImport_Character
      // 
      this.labelImport_Character.AutoSize = true;
      this.labelImport_Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelImport_Character.Location = new System.Drawing.Point(6, 145);
      this.labelImport_Character.Name = "labelImport_Character";
      this.labelImport_Character.Size = new System.Drawing.Size(66, 13);
      this.labelImport_Character.TabIndex = 16;
      this.labelImport_Character.Text = "Character:";
      // 
      // listBoxImport_Realm
      // 
      this.listBoxImport_Realm.FormattingEnabled = true;
      this.listBoxImport_Realm.Location = new System.Drawing.Point(328, 70);
      this.listBoxImport_Realm.Name = "listBoxImport_Realm";
      this.listBoxImport_Realm.Size = new System.Drawing.Size(160, 43);
      this.listBoxImport_Realm.TabIndex = 15;
      this.listBoxImport_Realm.SelectedIndexChanged += new System.EventHandler(this.listBoxImport_Realm_SelectedIndexChanged);
      // 
      // labelImport_Realm
      // 
      this.labelImport_Realm.AutoSize = true;
      this.labelImport_Realm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelImport_Realm.Location = new System.Drawing.Point(271, 83);
      this.labelImport_Realm.Name = "labelImport_Realm";
      this.labelImport_Realm.Size = new System.Drawing.Size(46, 13);
      this.labelImport_Realm.TabIndex = 14;
      this.labelImport_Realm.Text = "Realm:";
      // 
      // listBoxImport_Account
      // 
      this.listBoxImport_Account.FormattingEnabled = true;
      this.listBoxImport_Account.Location = new System.Drawing.Point(88, 70);
      this.listBoxImport_Account.Name = "listBoxImport_Account";
      this.listBoxImport_Account.Size = new System.Drawing.Size(160, 43);
      this.listBoxImport_Account.TabIndex = 13;
      this.listBoxImport_Account.SelectedIndexChanged += new System.EventHandler(this.listBoxImport_Account_SelectedIndexChanged);
      // 
      // labelImport_Account
      // 
      this.labelImport_Account.AutoSize = true;
      this.labelImport_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelImport_Account.Location = new System.Drawing.Point(6, 83);
      this.labelImport_Account.Name = "labelImport_Account";
      this.labelImport_Account.Size = new System.Drawing.Size(58, 13);
      this.labelImport_Account.TabIndex = 12;
      this.labelImport_Account.Text = "Account:";
      // 
      // tabExport
      // 
      this.tabExport.Controls.Add(this.labelExport_ProgressBar);
      this.tabExport.Controls.Add(this.labelExport_Title);
      this.tabExport.Controls.Add(this.progressBarExport);
      this.tabExport.Controls.Add(this.labelExport_Path);
      this.tabExport.Controls.Add(this.textBoxExport_Path);
      this.tabExport.Controls.Add(this.buttonExport);
      this.tabExport.Controls.Add(this.listBoxExport_Character);
      this.tabExport.Controls.Add(this.labelExport_Character);
      this.tabExport.Controls.Add(this.listBoxExport_Realm);
      this.tabExport.Controls.Add(this.labelExport_Realm);
      this.tabExport.Controls.Add(this.listBoxExport_Account);
      this.tabExport.Controls.Add(this.labelExport_Account);
      this.tabExport.Location = new System.Drawing.Point(4, 22);
      this.tabExport.Name = "tabExport";
      this.tabExport.Padding = new System.Windows.Forms.Padding(3);
      this.tabExport.Size = new System.Drawing.Size(494, 387);
      this.tabExport.TabIndex = 1;
      this.tabExport.Text = "Export";
      this.tabExport.UseVisualStyleBackColor = true;
      // 
      // labelExport_ProgressBar
      // 
      this.labelExport_ProgressBar.AutoSize = true;
      this.labelExport_ProgressBar.Location = new System.Drawing.Point(180, 361);
      this.labelExport_ProgressBar.Name = "labelExport_ProgressBar";
      this.labelExport_ProgressBar.Size = new System.Drawing.Size(0, 13);
      this.labelExport_ProgressBar.TabIndex = 11;
      // 
      // labelExport_Title
      // 
      this.labelExport_Title.AutoSize = true;
      this.labelExport_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExport_Title.ForeColor = System.Drawing.SystemColors.ScrollBar;
      this.labelExport_Title.Location = new System.Drawing.Point(373, 3);
      this.labelExport_Title.Name = "labelExport_Title";
      this.labelExport_Title.Size = new System.Drawing.Size(115, 37);
      this.labelExport_Title.TabIndex = 10;
      this.labelExport_Title.Text = "Export";
      // 
      // progressBarExport
      // 
      this.progressBarExport.Location = new System.Drawing.Point(181, 321);
      this.progressBarExport.Name = "progressBarExport";
      this.progressBarExport.Size = new System.Drawing.Size(307, 37);
      this.progressBarExport.TabIndex = 9;
      // 
      // labelExport_Path
      // 
      this.labelExport_Path.AutoSize = true;
      this.labelExport_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExport_Path.Location = new System.Drawing.Point(6, 246);
      this.labelExport_Path.Name = "labelExport_Path";
      this.labelExport_Path.Size = new System.Drawing.Size(77, 13);
      this.labelExport_Path.TabIndex = 8;
      this.labelExport_Path.Text = "Export Path:";
      // 
      // textBoxExport_Path
      // 
      this.textBoxExport_Path.Location = new System.Drawing.Point(88, 243);
      this.textBoxExport_Path.Name = "textBoxExport_Path";
      this.textBoxExport_Path.ReadOnly = true;
      this.textBoxExport_Path.Size = new System.Drawing.Size(249, 20);
      this.textBoxExport_Path.TabIndex = 7;
      // 
      // buttonExport
      // 
      this.buttonExport.Location = new System.Drawing.Point(9, 321);
      this.buttonExport.Name = "buttonExport";
      this.buttonExport.Size = new System.Drawing.Size(165, 37);
      this.buttonExport.TabIndex = 6;
      this.buttonExport.Text = "Export interface";
      this.buttonExport.UseVisualStyleBackColor = true;
      this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
      // 
      // listBoxExport_Character
      // 
      this.listBoxExport_Character.FormattingEnabled = true;
      this.listBoxExport_Character.Location = new System.Drawing.Point(88, 132);
      this.listBoxExport_Character.Name = "listBoxExport_Character";
      this.listBoxExport_Character.Size = new System.Drawing.Size(160, 95);
      this.listBoxExport_Character.TabIndex = 5;
      // 
      // labelExport_Character
      // 
      this.labelExport_Character.AutoSize = true;
      this.labelExport_Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExport_Character.Location = new System.Drawing.Point(6, 145);
      this.labelExport_Character.Name = "labelExport_Character";
      this.labelExport_Character.Size = new System.Drawing.Size(66, 13);
      this.labelExport_Character.TabIndex = 4;
      this.labelExport_Character.Text = "Character:";
      // 
      // listBoxExport_Realm
      // 
      this.listBoxExport_Realm.FormattingEnabled = true;
      this.listBoxExport_Realm.Location = new System.Drawing.Point(328, 70);
      this.listBoxExport_Realm.Name = "listBoxExport_Realm";
      this.listBoxExport_Realm.Size = new System.Drawing.Size(160, 43);
      this.listBoxExport_Realm.TabIndex = 3;
      this.listBoxExport_Realm.SelectedIndexChanged += new System.EventHandler(this.listBoxExport_Realm_SelectedIndexChanged);
      // 
      // labelExport_Realm
      // 
      this.labelExport_Realm.AutoSize = true;
      this.labelExport_Realm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExport_Realm.Location = new System.Drawing.Point(271, 83);
      this.labelExport_Realm.Name = "labelExport_Realm";
      this.labelExport_Realm.Size = new System.Drawing.Size(46, 13);
      this.labelExport_Realm.TabIndex = 2;
      this.labelExport_Realm.Text = "Realm:";
      // 
      // listBoxExport_Account
      // 
      this.listBoxExport_Account.FormattingEnabled = true;
      this.listBoxExport_Account.Location = new System.Drawing.Point(88, 70);
      this.listBoxExport_Account.Name = "listBoxExport_Account";
      this.listBoxExport_Account.Size = new System.Drawing.Size(160, 43);
      this.listBoxExport_Account.TabIndex = 1;
      this.listBoxExport_Account.SelectedIndexChanged += new System.EventHandler(this.listBoxExport_Account_SelectedIndexChanged);
      // 
      // labelExport_Account
      // 
      this.labelExport_Account.AutoSize = true;
      this.labelExport_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExport_Account.Location = new System.Drawing.Point(6, 83);
      this.labelExport_Account.Name = "labelExport_Account";
      this.labelExport_Account.Size = new System.Drawing.Size(58, 13);
      this.labelExport_Account.TabIndex = 0;
      this.labelExport_Account.Text = "Account:";
      // 
      // tabSettings
      // 
      this.tabSettings.BackColor = System.Drawing.Color.White;
      this.tabSettings.Controls.Add(this.buttonSettings_Browse);
      this.tabSettings.Controls.Add(this.label2);
      this.tabSettings.Controls.Add(this.buttonWowPath_checkSave);
      this.tabSettings.Controls.Add(this.labelWowPath);
      this.tabSettings.Controls.Add(this.textBoxWowPath);
      this.tabSettings.Location = new System.Drawing.Point(4, 22);
      this.tabSettings.Name = "tabSettings";
      this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
      this.tabSettings.Size = new System.Drawing.Size(494, 387);
      this.tabSettings.TabIndex = 2;
      this.tabSettings.Text = "Settings";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
      this.label2.Location = new System.Drawing.Point(348, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(140, 37);
      this.label2.TabIndex = 11;
      this.label2.Text = "Settings";
      // 
      // buttonWowPath_checkSave
      // 
      this.buttonWowPath_checkSave.Location = new System.Drawing.Point(388, 333);
      this.buttonWowPath_checkSave.Name = "buttonWowPath_checkSave";
      this.buttonWowPath_checkSave.Size = new System.Drawing.Size(100, 48);
      this.buttonWowPath_checkSave.TabIndex = 2;
      this.buttonWowPath_checkSave.Text = "Check && Save";
      this.buttonWowPath_checkSave.UseVisualStyleBackColor = true;
      this.buttonWowPath_checkSave.Click += new System.EventHandler(this.buttonWowPath_checkSave_Click);
      // 
      // labelWowPath
      // 
      this.labelWowPath.AutoSize = true;
      this.labelWowPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWowPath.Location = new System.Drawing.Point(6, 72);
      this.labelWowPath.Name = "labelWowPath";
      this.labelWowPath.Size = new System.Drawing.Size(141, 13);
      this.labelWowPath.TabIndex = 1;
      this.labelWowPath.Text = "Word Of Warcraft Path:";
      // 
      // textBoxWowPath
      // 
      this.textBoxWowPath.Location = new System.Drawing.Point(153, 69);
      this.textBoxWowPath.Name = "textBoxWowPath";
      this.textBoxWowPath.Size = new System.Drawing.Size(229, 20);
      this.textBoxWowPath.TabIndex = 0;
      this.textBoxWowPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxWowPath_KeyDown);
      // 
      // backgroundWorkerExport
      // 
      this.backgroundWorkerExport.WorkerReportsProgress = true;
      this.backgroundWorkerExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerExport_DoWork);
      this.backgroundWorkerExport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerExport_ProgressChanged);
      // 
      // backgroundWorkerImport
      // 
      this.backgroundWorkerImport.WorkerReportsProgress = true;
      this.backgroundWorkerImport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerImport_DoWork);
      this.backgroundWorkerImport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerImport_ProgressChanged);
      // 
      // buttonSettings_Browse
      // 
      this.buttonSettings_Browse.Location = new System.Drawing.Point(388, 67);
      this.buttonSettings_Browse.Name = "buttonSettings_Browse";
      this.buttonSettings_Browse.Size = new System.Drawing.Size(100, 23);
      this.buttonSettings_Browse.TabIndex = 12;
      this.buttonSettings_Browse.Text = "Browse";
      this.buttonSettings_Browse.UseVisualStyleBackColor = true;
      this.buttonSettings_Browse.Click += new System.EventHandler(this.buttonSettings_Browse_Click);
      // 
      // richTextBox_Information
      // 
      this.richTextBox_Information.BackColor = System.Drawing.SystemColors.Window;
      this.richTextBox_Information.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBox_Information.Location = new System.Drawing.Point(10, 233);
      this.richTextBox_Information.Name = "richTextBox_Information";
      this.richTextBox_Information.ReadOnly = true;
      this.richTextBox_Information.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
      this.richTextBox_Information.Size = new System.Drawing.Size(478, 113);
      this.richTextBox_Information.TabIndex = 4;
      this.richTextBox_Information.Text = resources.GetString("richTextBox_Information.Text");
      this.richTextBox_Information.TextChanged += new System.EventHandler(this.richTextBox_Information_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
      this.label1.Location = new System.Drawing.Point(299, 189);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(189, 37);
      this.label1.TabIndex = 12;
      this.label1.Text = "Information";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // labelCredits
      // 
      this.labelCredits.AutoSize = true;
      this.labelCredits.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelCredits.Location = new System.Drawing.Point(244, 371);
      this.labelCredits.Name = "labelCredits";
      this.labelCredits.Size = new System.Drawing.Size(251, 14);
      this.labelCredits.TabIndex = 13;
      this.labelCredits.Text = "© 2016 - WoWZiport v 1.0 - Yves Lange (Kursion)";
      this.labelCredits.Click += new System.EventHandler(this.label3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(527, 438);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "WoWZiport";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.tabControl1.ResumeLayout(false);
      this.tabWelcome.ResumeLayout(false);
      this.tabWelcome.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.tabImport.ResumeLayout(false);
      this.tabImport.PerformLayout();
      this.tabExport.ResumeLayout(false);
      this.tabExport.PerformLayout();
      this.tabSettings.ResumeLayout(false);
      this.tabSettings.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabImport;
    private System.Windows.Forms.TabPage tabExport;
    private System.Windows.Forms.TabPage tabSettings;
    private System.Windows.Forms.TextBox textBoxWowPath;
    private System.Windows.Forms.TabPage tabWelcome;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Label labelWowPath;
    private System.Windows.Forms.Button buttonWowPath_checkSave;
    private System.Windows.Forms.Label labelExport_Account;
    private System.Windows.Forms.ListBox listBoxExport_Account;
    private System.Windows.Forms.ListBox listBoxExport_Realm;
    private System.Windows.Forms.Label labelExport_Realm;
    private System.Windows.Forms.Label labelExport_Path;
    private System.Windows.Forms.TextBox textBoxExport_Path;
    private System.Windows.Forms.Button buttonExport;
    private System.Windows.Forms.ListBox listBoxExport_Character;
    private System.Windows.Forms.Label labelExport_Character;
    private System.Windows.Forms.ProgressBar progressBarExport;
    private System.ComponentModel.BackgroundWorker backgroundWorkerExport;
    private System.Windows.Forms.Label labelExport_Title;
    private System.Windows.Forms.Label labelExport_ProgressBar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label labelImport_ProgressBar;
    private System.Windows.Forms.Label labelImport_Title;
    private System.Windows.Forms.ProgressBar progressBarImport;
    private System.Windows.Forms.Label labelImport_Path;
    private System.Windows.Forms.TextBox textBoxImport_Path;
    private System.Windows.Forms.Button buttonImport;
    private System.Windows.Forms.ListBox listBoxImport_Character;
    private System.Windows.Forms.Label labelImport_Character;
    private System.Windows.Forms.ListBox listBoxImport_Realm;
    private System.Windows.Forms.Label labelImport_Realm;
    private System.Windows.Forms.ListBox listBoxImport_Account;
    private System.Windows.Forms.Label labelImport_Account;
    private System.Windows.Forms.Label labelImport_Options;
    private System.Windows.Forms.CheckBox checkBoxImport_WTF;
    private System.Windows.Forms.Button buttonImport_Browse;
    private System.Windows.Forms.OpenFileDialog openFileDialogImport;
    private System.ComponentModel.BackgroundWorker backgroundWorkerImport;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Button buttonSettings_Browse;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox richTextBox_Information;
    private System.Windows.Forms.Label labelCredits;
  }
}

