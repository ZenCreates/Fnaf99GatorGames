using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Fnaf99
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            if (Program.settings.appversion != Program.settings.newestappversion)
            {
                label1.Text = $"App Version: {Program.settings.appversion}, Newest Version: {Program.settings.newestappversion} \n made by 1987kostya \n Redesigned by Zen and M4X4 for GG";
                Update.Visible = true;

            }
            else
            {
                label1.Text = $"Current Version: {Program.settings.newestappversion} \n made by 1987kostya \n Redesigned by Zen and M4X4 for GG";
            }
            
        }

        private void donateBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.donationalerts.com/r/1987kostya");
        }

        private void youtubeBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCZIXxTGxnemIujXCXOKjs7g");
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Update_Click(object sender, EventArgs e)
        {
            Process.Start($"https://github.com/ZenCreates/Fnaf99GatorGames/releases/download/{Program.settings.newestappversion}/Debug.zip");
            Application.Exit();
        }
    }
}
