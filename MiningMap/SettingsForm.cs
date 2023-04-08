using System;
using System.Configuration;
using System.Windows.Forms;

namespace MiningMap
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            textBoxServerName.Text = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        }

        private void saveSettings(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["DB"].ConnectionString = textBoxServerName.Text;
            config.Save(ConfigurationSaveMode.Modified);
            Close();
        }
    }
}
