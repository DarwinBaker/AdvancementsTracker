using System;
using System.Windows.Forms;

namespace AdvancementsTracker.Forms
{
    public partial class FPreferences : Form
    {
        public FPreferences()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            checkUseDefault.Checked    = Preferences.UseDefaultSavesFolder;
            textCustomSavesFolder.Text = Preferences.CustomSavesFolder;
            numRefreshDelay.Value      = Preferences.RefreshInterval;
        }

        private void SaveSettings()
        {
            Preferences.UseDefaultSavesFolder = checkUseDefault.Checked;
            Preferences.CustomSavesFolder     = textCustomSavesFolder.Text;
            Preferences.RefreshInterval       = (int)numRefreshDelay.Value;
            Preferences.Save();
        }

        private void BrowseFolder()
        {
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                    textCustomSavesFolder.Text = dialog.SelectedPath;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            if (sender == buttonBrowse)
                BrowseFolder();
            else 
            {
                if (sender == buttonSave)
                    SaveSettings();
                Close();
            }
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            textCustomSavesFolder.Enabled = !checkUseDefault.Checked;
        }
    }
}
