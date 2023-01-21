using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Fnaf99
{
    public partial class SettingsForm : Form
    {
        TextBox boxthing;
        public SettingsForm()
        {
            InitializeComponent();
            boxthing = pakPath;
            aes.Text = Program.settings.AESKey;
            exeName.Text = Program.settings.gameName;
            pakPath.Text = Program.settings.pakFolder;
            unrealVersion.Text = Program.settings.ue4version;
        }

        private void aes_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Program.settings.AESKey = aes.Text;
            Program.settings.gameName = exeName.Text;
            Program.settings.pakFolder = pakPath.Text;
            Program.settings.ue4version = unrealVersion.Text;
            var newSettings = JsonConvert.SerializeObject(Program.settings);
            File.WriteAllText("settings.json", newSettings);
            Application.Restart();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pakPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void unrealVersion_TextChanged(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void exeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {  
            var newForm = new AboutForm();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aes.Text = Program.settings.AESKey;
            exeName.Text = Program.settings.gameName;
            pakPath.Text = Program.settings.pakFolder;
            unrealVersion.Text = Program.settings.ue4version;
            this.Close();
        }
        [STAThread]
        private void ShowFolderBrowserDialog()
        {
            // Create a new folder browser dialog
            OpenFileDialog folderBrowserDialog1 = new OpenFileDialog();

            // Set the dialog to start in the current directory
            folderBrowserDialog1.FileName = Environment.CurrentDirectory;

            // Show the dialog and get the result
            DialogResult result = folderBrowserDialog1.ShowDialog();

            // If the user clicked the OK button, retrieve the selected folder path
            if (result == DialogResult.OK)
            {
                pakPath.Text = folderBrowserDialog1.FileName;
                // Do something with the selected folder here...
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the current thread is an STA thread
            if (Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
            {
                // If not, marshal the call to the STA thread
                this.Invoke((MethodInvoker)delegate
                {
                    ShowFolderBrowserDialog();
                });
            }
            else
            {
                // If it is already an STA thread, call the function directly
                ShowFolderBrowserDialog();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

 
        private void sb_Click(object sender, EventArgs e)
        {
            aes.Text = "0x85F7D4007015493ED0359C9007266038F8F7B1F96988F19A610103874CC95286";
            unrealVersion.Text = "ue4.24";
            exeName.Text = "fnaf9-Win64-Shipping";
        }

        private void hw_Click(object sender, EventArgs e)
        {
            aes.Text = "0x710891DF17EAFFCA17CB0620F0F0DCA90A00C657F49BC131D4110B265EC2E41E";
            unrealVersion.Text = "ue4.23";
            exeName.Text = "freddys-Win64-Shipping";
        }
        bool enabled = false;
        private void mv_Click(object sender, EventArgs e)
        {
            if (enabled == false)
            {
                enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                exeName.Visible = true;
                unrealVersion.Visible = true;
            }
            else if (enabled == true)
            {
                enabled = false;
                label2.Visible = false;
                label3.Visible = false;
                exeName.Visible = false;
                unrealVersion.Visible = false;
            }
        }
    }
}
