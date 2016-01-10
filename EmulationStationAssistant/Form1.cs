using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EmulationStationAssistant
{
    public partial class Form1 : Form
    {
        public List<ES_System> systems = new List<ES_System>();
        public OpenFileDialog openFileDialog1 = new OpenFileDialog();        
        public SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (Directory.Exists(openFileDialog1.InitialDirectory + @"\.emulationstation\"))
            {                
                openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\.emulationstation\";                
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                try
                {
                    if (!String.IsNullOrEmpty(c.Tag.ToString()))
                    {
                        Tooltip.SetToolTip(c, c.Tag.ToString());
                    }
                }
                catch { }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!validateFields()) return;
            ES_System newSystem = new ES_System();
            newSystem.name = SysName.Text;
            newSystem.fullname = SysFullname.Text;
            newSystem.path = SysPath.Text;
            newSystem.extension = SysExtension.Text;
            newSystem.command = SysCommand.Text;
            newSystem.platform = SysPlatform.Text;
            newSystem.theme = SysTheme.Text;

            bool isNewSystem = true;
            if (FindSystemByName(newSystem.fullname) != null)
            {
                isNewSystem = false;
            }

            if (isNewSystem)
            {
                systems.Add(newSystem);
                ConfigList.Items.Add(newSystem.fullname);
            }
            else
            {
                systems.Remove(FindSystemByName(newSystem.fullname));
                systems.Add(newSystem);

                ConfigList.Items.Remove(newSystem.fullname);
                ConfigList.Items.Add(newSystem.fullname);
            }

            SysName.Text = "";
            SysFullname.Text = "";
            SysPath.Text = "";
            SysExtension.Text = "";
            SysCommand.Text = "";
            SysPlatform.Text = "";
            SysTheme.Text = "";

            SysName.Focus();
        }

        private void SortUp_Click(object sender, EventArgs e)
        {
            int index = ConfigList.SelectedIndex;

            if (ConfigList.SelectedIndex == 0)
            {
                SortList(ConfigList.Items[ConfigList.SelectedIndex].ToString(), ConfigList.Items[ConfigList.Items.Count - 1].ToString());
                ConfigList.SelectedIndex = ConfigList.Items.Count - 1;
            }            
            else
            {
                SortList(ConfigList.Items[ConfigList.SelectedIndex].ToString(), ConfigList.Items[ConfigList.SelectedIndex - 1].ToString());
                ConfigList.SelectedIndex = index - 1;
            }            
        }

        private void SortDown_Click(object sender, EventArgs e)
        {
            int index = ConfigList.SelectedIndex;
            
            if (ConfigList.SelectedIndex == ConfigList.Items.Count - 1)
            {
                SortList(ConfigList.Items[ConfigList.SelectedIndex].ToString(), ConfigList.Items[0].ToString());
                ConfigList.SelectedIndex = 0;
            }            
            else
            {
                SortList(ConfigList.Items[ConfigList.SelectedIndex].ToString(), ConfigList.Items[ConfigList.SelectedIndex + 1].ToString());
                ConfigList.SelectedIndex = index + 1;
            }            
        }

        private void SortList(string itemOne, string itemTwo)
        {
            List<string> items = new List<string>();
            foreach (string item in ConfigList.Items)
            {
                if (item == itemOne)
                {
                    items.Add(itemTwo);
                }
                else if (item == itemTwo)
                {
                    items.Add(itemOne);
                }
                else
                {
                    items.Add(item);
                }
            }

            ConfigList.Items.Clear();
            foreach (string item in items)
            {
                ConfigList.Items.Add(item);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            ES_System temp = FindSystemByName(ConfigList.SelectedItem.ToString());
            SysName.Text = temp.name;
            SysFullname.Text = temp.fullname;
            SysPath.Text = temp.path;
            SysExtension.Text = temp.extension;
            SysCommand.Text = temp.command;
            SysPlatform.Text = temp.platform;
            SysTheme.Text = temp.theme;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string savedConfig = "";
            savedConfig += "<!-- This is the EmulationStation Systems configuration file. All systems must be contained within the <systemList> tag.-->" + Environment.NewLine;
            savedConfig += "<systemList>" + Environment.NewLine;
            
            foreach (ES_System sys in systems)
            {
                savedConfig += sys.format();
            }

            savedConfig += "</systemList>" + Environment.NewLine;

            saveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\.emulationstation\";
            saveFileDialog1.FileName = "es_systems.cfg";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, savedConfig);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> allLines = File.ReadAllLines(openFileDialog1.FileName).ToList<string>();
                    List<ES_System> _systems = new List<ES_System>();

                    for (int i = 0; i < allLines.Count; i++)
                    {                        
                        if (allLines[i].Contains("<name>"))
                        {
                            ES_System temp = new ES_System();                                                        
                            temp.name = allLines[i].Replace("<name>", "").Replace("</name>", "").Trim();
                            temp.fullname = allLines[i + 1].Replace("<fullname>", "").Replace("</fullname>", "").Trim();
                            temp.path = allLines[i + 2].Replace("<path>", "").Replace("</path>", "").Trim();
                            temp.extension = allLines[i + 3].Replace("<extension>", "").Replace("</extension>", "").Trim();
                            temp.command = allLines[i + 4].Replace("<command>", "").Replace("</command>", "").Trim();
                            temp.platform = allLines[i + 5].Replace("<platform>", "").Replace("</platform>", "").Trim();
                            temp.theme = allLines[i + 6].Replace("<theme>", "").Replace("</theme>", "").Trim();
                            _systems.Add(temp);
                        }                        
                    }

                    ConfigList.Items.Clear();
                    systems = _systems;
                    foreach (ES_System sys in systems)
                    {
                        ConfigList.Items.Add(sys.fullname);
                    }                    
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void SysTheme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            ES_System newSystem = new ES_System();
            newSystem.name = SysName.Text;
            newSystem.fullname = SysFullname.Text;
            newSystem.path = SysPath.Text;
            newSystem.extension = SysExtension.Text;
            newSystem.command = SysCommand.Text;
            newSystem.platform = SysPlatform.Text;
            newSystem.theme = SysTheme.Text;

            InstructionBox.Tag = newSystem.format();
            Tooltip.SetToolTip(InstructionBox, InstructionBox.Tag.ToString());
        }

        private void ConfigList_MouseHover(object sender, EventArgs e)
        {
            try
            {
                ConfigList.Tag = FindSystemByName(ConfigList.SelectedItem.ToString()).format();
                Tooltip.SetToolTip(ConfigList, ConfigList.Tag.ToString());
            }
            catch { }
        }        

        private void PathButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog x = new FolderBrowserDialog())
            {
                if (x.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SysPath.Text = openFileDialog1.FileName;
                }
            }
        }

        /// <summary>
        /// Finds the system by fullname
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private ES_System FindSystemByName(string name)
        {
            foreach (ES_System sys in systems)
            {
                if (sys.fullname == name)
                {
                    return sys;
                }
            }

            return null;
        }

        /// <summary>
        /// Validates all fields are not empty.
        /// </summary>
        /// <returns></returns>
        private bool validateFields()
        {
            bool returnValue = true;
            
            if (String.IsNullOrEmpty(SysName.Text))
            {
                returnValue = false;
            }
            else if (String.IsNullOrEmpty(SysFullname.Text))
            {
                returnValue = false;
            }
            else if (String.IsNullOrEmpty(SysPath.Text))
            {
                returnValue = false;
            }
            else if (String.IsNullOrEmpty(SysExtension.Text))
            {
                returnValue = false;
            }
            else if (String.IsNullOrEmpty(SysCommand.Text))
            {
                returnValue = false;
            }
            else if (String.IsNullOrEmpty(SysPlatform.Text))
            {
                returnValue = false;
            }
            else if (String.IsNullOrEmpty(SysTheme.Text))
            {
                returnValue = false;
            }

            return returnValue;
        }
    }

    public class ES_System
    {
        public string name { get; set; }
        public string fullname { get; set; }
        public string path { get; set; }
        public string extension { get; set; }
        public string command { get; set; }
        public string platform { get; set; }
        public string theme { get; set; }

        public string format()
        {
            string output = "";

            output += "<system>" + Environment.NewLine;
            output += "<name>" + name + "</name>" + Environment.NewLine;
            output += "<fullname>" + fullname + "</fullname>" + Environment.NewLine;
            output += "<path>" + path + "</path>" + Environment.NewLine;
            output += "<extension>" + extension + "</extension>" + Environment.NewLine;
            output += "<command>" + command + "</command>" + Environment.NewLine;
            output += "<platform>" + platform + "</platform>" + Environment.NewLine;
            output += "<theme>" + theme + "</theme>" + Environment.NewLine;
            output += "</system>" + Environment.NewLine;

            return output;
        }
    }
}
