namespace EmulationStationAssistant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConfigList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SortUp = new System.Windows.Forms.Button();
            this.SortDown = new System.Windows.Forms.Button();
            this.SysName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SysFullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SysPath = new System.Windows.Forms.TextBox();
            this.PathButton = new System.Windows.Forms.Button();
            this.SysExtension = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SysPlatform = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SysCommand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SysTheme = new System.Windows.Forms.ComboBox();
            this.InstructionBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ConfigList
            // 
            this.ConfigList.FormattingEnabled = true;
            this.ConfigList.Location = new System.Drawing.Point(267, 12);
            this.ConfigList.Name = "ConfigList";
            this.ConfigList.Size = new System.Drawing.Size(190, 420);
            this.ConfigList.TabIndex = 9;
            this.ConfigList.MouseHover += new System.EventHandler(this.ConfigList_MouseHover);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(70, 192);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add To Config";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SortUp
            // 
            this.SortUp.Location = new System.Drawing.Point(267, 447);
            this.SortUp.Name = "SortUp";
            this.SortUp.Size = new System.Drawing.Size(53, 23);
            this.SortUp.TabIndex = 10;
            this.SortUp.Text = "Up";
            this.SortUp.UseVisualStyleBackColor = true;
            this.SortUp.Click += new System.EventHandler(this.SortUp_Click);
            // 
            // SortDown
            // 
            this.SortDown.Location = new System.Drawing.Point(404, 447);
            this.SortDown.Name = "SortDown";
            this.SortDown.Size = new System.Drawing.Size(53, 23);
            this.SortDown.TabIndex = 12;
            this.SortDown.Text = "Down";
            this.SortDown.UseVisualStyleBackColor = true;
            this.SortDown.Click += new System.EventHandler(this.SortDown_Click);
            // 
            // SysName
            // 
            this.SysName.FormattingEnabled = true;
            this.SysName.Items.AddRange(new object[] {
            "3do",
            "amiga",
            "amstradcpc",
            "apple2",
            "arcade",
            "atari800",
            "atari2600",
            "atari5200",
            "atari7800",
            "atarilynx",
            "atarist",
            "atarijaguar",
            "atarijaguarcd",
            "atarixe",
            "colecovision",
            "c64",
            "intellivision",
            "macintosh",
            "xbox",
            "xbox360",
            "msx",
            "neogeo",
            "ngp",
            "ngpc",
            "n3ds",
            "n64",
            "nds",
            "nes",
            "gb",
            "gba",
            "gbc",
            "gc",
            "wii",
            "wiiu",
            "pc",
            "sega32x",
            "segacd",
            "dreamcast",
            "gamegear",
            "genesis",
            "mastersystem",
            "megadrive",
            "saturn",
            "psx",
            "ps2",
            "ps3",
            "ps4",
            "psvita",
            "psp",
            "snes",
            "pcengine",
            "wonderswan",
            "wonderswancolor",
            "zxspectrum",
            "ignore"});
            this.SysName.Location = new System.Drawing.Point(70, 12);
            this.SysName.Name = "SysName";
            this.SysName.Size = new System.Drawing.Size(191, 21);
            this.SysName.TabIndex = 0;
            this.SysName.Tag = "A short identifier for the system. Used in some folder structures and error messa" +
    "ges.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fullname";
            // 
            // SysFullname
            // 
            this.SysFullname.Location = new System.Drawing.Point(70, 35);
            this.SysFullname.Name = "SysFullname";
            this.SysFullname.Size = new System.Drawing.Size(191, 20);
            this.SysFullname.TabIndex = 1;
            this.SysFullname.Tag = "A \"pretty\" name, displayed in the menus and such. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Path";
            // 
            // SysPath
            // 
            this.SysPath.Location = new System.Drawing.Point(101, 62);
            this.SysPath.Name = "SysPath";
            this.SysPath.Size = new System.Drawing.Size(160, 20);
            this.SysPath.TabIndex = 3;
            this.SysPath.Tag = resources.GetString("SysPath.Tag");
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(70, 59);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(25, 23);
            this.PathButton.TabIndex = 2;
            this.PathButton.Text = "...";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // SysExtension
            // 
            this.SysExtension.Location = new System.Drawing.Point(70, 88);
            this.SysExtension.Name = "SysExtension";
            this.SysExtension.Size = new System.Drawing.Size(191, 20);
            this.SysExtension.TabIndex = 4;
            this.SysExtension.Tag = "A list of extensions to search for, delimited by commas or spaces. You MUST inclu" +
    "de the period at the start of the extension! It\'s also case sensitive.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Extension";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Platform";
            // 
            // SysPlatform
            // 
            this.SysPlatform.FormattingEnabled = true;
            this.SysPlatform.Items.AddRange(new object[] {
            "3do",
            "amiga",
            "amstradcpc",
            "apple2",
            "arcade",
            "atari800",
            "atari2600",
            "atari5200",
            "atari7800",
            "atarilynx",
            "atarist",
            "atarijaguar",
            "atarijaguarcd",
            "atarixe",
            "colecovision",
            "c64",
            "intellivision",
            "macintosh",
            "xbox",
            "xbox360",
            "msx",
            "neogeo",
            "ngp",
            "ngpc",
            "n3ds",
            "n64",
            "nds",
            "nes",
            "gb",
            "gba",
            "gbc",
            "gc",
            "wii",
            "wiiu",
            "pc",
            "sega32x",
            "segacd",
            "dreamcast",
            "gamegear",
            "genesis",
            "mastersystem",
            "megadrive",
            "saturn",
            "psx",
            "ps2",
            "ps3",
            "ps4",
            "psvita",
            "psp",
            "snes",
            "pcengine",
            "wonderswan",
            "wonderswancolor",
            "zxspectrum",
            "ignore"});
            this.SysPlatform.Location = new System.Drawing.Point(70, 140);
            this.SysPlatform.Name = "SysPlatform";
            this.SysPlatform.Size = new System.Drawing.Size(191, 21);
            this.SysPlatform.TabIndex = 6;
            this.SysPlatform.Tag = resources.GetString("SysPlatform.Tag");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Command";
            // 
            // SysCommand
            // 
            this.SysCommand.Location = new System.Drawing.Point(70, 114);
            this.SysCommand.Name = "SysCommand";
            this.SysCommand.Size = new System.Drawing.Size(191, 20);
            this.SysCommand.TabIndex = 5;
            this.SysCommand.Tag = resources.GetString("SysCommand.Tag");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Theme";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(335, 447);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(53, 23);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(6, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 1);
            this.panel1.TabIndex = 20;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 447);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(45, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(63, 447);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(45, 23);
            this.LoadButton.TabIndex = 14;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.Load_Click);
            // 
            // SysTheme
            // 
            this.SysTheme.FormattingEnabled = true;
            this.SysTheme.Items.AddRange(new object[] {
            "3do",
            "amiga",
            "amstradcpc",
            "apple2",
            "art",
            "atari2600",
            "atari5200",
            "atari7800",
            "atari800",
            "atarijaguar",
            "atarijaguarcd",
            "atarist",
            "atarifalcon",
            "atarixe",
            "c64",
            "colecovision",
            "amstradcpc",
            "fba",
            "gamegear",
            "gb",
            "gba",
            "gbc",
            "gc",
            "intellivision",
            "macintosh",
            "mame",
            "mastersystem",
            "megadrive",
            "n64",
            "neogeo",
            "nes",
            "ngp",
            "ngpc",
            "pc",
            "pcengine",
            "ports",
            "psx",
            "scummvm",
            "sega32x",
            "segacd",
            "snes",
            "zmachine",
            "zxspectrum"});
            this.SysTheme.Location = new System.Drawing.Point(70, 165);
            this.SysTheme.Name = "SysTheme";
            this.SysTheme.Size = new System.Drawing.Size(191, 21);
            this.SysTheme.TabIndex = 7;
            this.SysTheme.Tag = resources.GetString("SysTheme.Tag");
            this.SysTheme.SelectedIndexChanged += new System.EventHandler(this.SysTheme_SelectedIndexChanged);
            // 
            // InstructionBox
            // 
            this.InstructionBox.BackColor = System.Drawing.SystemColors.Control;
            this.InstructionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructionBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InstructionBox.Location = new System.Drawing.Point(8, 228);
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.ReadOnly = true;
            this.InstructionBox.Size = new System.Drawing.Size(253, 204);
            this.InstructionBox.TabIndex = 24;
            this.InstructionBox.Text = resources.GetString("InstructionBox.Text");
            this.InstructionBox.MouseHover += new System.EventHandler(this.richTextBox1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 482);
            this.Controls.Add(this.InstructionBox);
            this.Controls.Add(this.SysTheme);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SysCommand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SysPlatform);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SysExtension);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.SysPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SysFullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SysName);
            this.Controls.Add(this.SortDown);
            this.Controls.Add(this.SortUp);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ConfigList);
            this.Name = "Form1";
            this.Text = "Emulation Station Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ConfigList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SortUp;
        private System.Windows.Forms.Button SortDown;
        private System.Windows.Forms.ComboBox SysName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SysFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SysPath;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.TextBox SysExtension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SysPlatform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SysCommand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.ComboBox SysTheme;
        private System.Windows.Forms.RichTextBox InstructionBox;
    }
}

