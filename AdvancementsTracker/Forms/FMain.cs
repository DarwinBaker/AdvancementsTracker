using AdvancementsTracker.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace AdvancementsTracker.Forms
{
    public partial class FMain : Form
    {
        public const string TRACKER_VERSION      = "1.2";
        public const string MINECRAFT_VERSION    = "1.16";
        public const string DIR_ADVANCEMENTS     = "assets/advancements/";
        public const string DIR_POTIONS          = "assets/potions/";

        private AdvJSON json;
        private List<Advancement> advancements;
        private List<Control> movingControls;

        public FMain()
        {
            InitializeComponent();
            Preferences.Load();
            Text = "CTM's Advancement Tracker " + TRACKER_VERSION;
            labelMinecraftVersion.Text = "For Minecraft " + MINECRAFT_VERSION;

            json = new AdvJSON();
            advancements = new List<Advancement>();
            movingControls = new List<Control>();

            ReadAdvancementSet("adventure", flowAdventure);
            ReadAdvancementSet("husbandry", flowHusbandry);
            ReadAdvancementSet("minecraft", flowMinecraft);
            ReadAdvancementSet("nether", flowNether);
            ReadAdvancementSet("end", flowEnd);
            ReadPotionSet();

            worker.RunWorkerAsync();
        }

        //Function to read advancement list and add related control to appropriate panel
        private void ReadAdvancementSet(string set, FlowLayoutPanel basicAdvPanel)
        {
            var doc = new XmlDocument();
            using (var stream = File.OpenRead(Path.Combine(DIR_ADVANCEMENTS, set + ".xml")))
            {
                doc.Load(stream);
                foreach (XmlNode advNode in doc.SelectSingleNode("advancements").ChildNodes)
                {
                    var adv = new Advancement(advNode);
                    advancements.Add(adv);

                    //Create advancement control and add to form
                    if (adv.HasCriteria)
                        flowCriteria.Controls.Add(new CAdvCriteria(adv));
                    else
                        basicAdvPanel.Controls.Add(new CAdvBasic(adv));
                }
            }
        }

        //Function to read potion list for hdwgh
        private void ReadPotionSet()
        {
            var doc = new XmlDocument();
            using (var stream = File.OpenRead(Path.Combine(DIR_POTIONS, "potions.xml")))
            {
                doc.Load(stream);
                XmlNode root = doc.SelectSingleNode("potions");
                foreach (XmlNode potionNode in root.ChildNodes)
                    flowPotions.Controls.Add(new CPotion(new Potion(potionNode)));
            }
        }

        //Async function to get latest completed advancements
        private void OnDoWork(object sender, DoWorkEventArgs e)
        {
            //Slow outer loop for reading advancement file every <configured timespan>
            while (!worker.CancellationPending)
            {
                try
                {
                    //Get most recent save
                    var worlds = new DirectoryInfo(Preferences.SavesFolder)?.GetDirectories().OrderBy(d => d.LastAccessTime).ToList();
                    if (worlds.Count > 0)
                    {
                        //Get advancements file and read it
                        var file = new DirectoryInfo(Path.Combine(worlds.Last().FullName, "advancements")).GetFiles().First().FullName;
                        json.Open(file);
                        json.Update();
                        worker.ReportProgress(0);
                    }
                }
                catch (Exception) 
                {
                    //Something went wrong, probably file missing
                    if (json.IsOpen)
                    {
                        json.Close();
                        worker.ReportProgress(0);
                    }
                }

                //Fast inner loop for more responsive thread cancellation
                int fastSleepTimer = 0;
                while (fastSleepTimer < Preferences.RefreshInterval && !worker.CancellationPending)
                {
                    Thread.Sleep(50);
                    fastSleepTimer += 50;
                }
            }
        }

        //Function to refresh advancement states and UI
        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int completed = 0;
            foreach (var advancement in advancements)
            { 
                advancement.Update(json);
                if (advancement.IsCompleted)
                    completed++;
            }
            int percent = (int)((double)completed / advancements.Count * 100);
            labelProgress.Text = "Advancements Completed: " + completed + " / " + advancements.Count;
            labelPercent.Text = "(" + percent + "%)";
            progress.Value = percent;

            string save = json.CurrentSave;
            if (save != null)
                labelCurrentSave.Text = "Currently Reading Save: \"" + save + "\"";
            else
                labelCurrentSave.Text = "Not Reading Save Yet.";
        }

        private void OnWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.Exit();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (sender == buttonExit)
                Close();
            else if (sender == buttonPreferences)
                using (var dialog = new FPreferences())
                    dialog.ShowDialog();
            else if (sender == buttonDonate)
                Process.Start("https://www.paypal.com/donate?hosted_button_id=EN29468P8CY24");
        }

        private void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/DarwinBaker/AdvancementsTracker");
        }

        //Dumb function to clear controls while dragging window so it isn't laggy because GDI is bad
        private void OnResizeBegin(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
                movingControls.Add(control);
            Controls.Clear();
        }

        //Dumb function to restore controls after dragging window
        private void OnResizeEnd(object sender, EventArgs e)
        {
            foreach (Control control in movingControls)
                Controls.Add(control);
            movingControls.Clear();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = false;
                worker.CancelAsync();
            }
        }
    }
}
