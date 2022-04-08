using System.Diagnostics;
using System.IO;

namespace Wow_realmlist_changer
{
    public partial class Mainwindow : Form
    {
        private string path = @"Enter a path (eg.C:\World of Warcraft\)";
        private IList<string> content = new List<string>();
        private int realmlistIndex;
        private int realmnameIndex;

        public Mainwindow()
        {
            InitializeComponent();

            SetToTauri.MouseEnter += SetToTauri_Enter;
            SetToTauri.MouseLeave += SetToTauri_Leave;

            SetToMistblade.MouseEnter += SetToMistblade_Enter;
            SetToMistblade.MouseLeave += SetToMistblade_Leave;

            Launch.MouseEnter += Launch_Enter;
            Launch.MouseLeave += Launch_Leave;
        }


        private void Mainwindow_Load(object sender, EventArgs e)
        {
            if (File.Exists("path.txt"))
            {
                path = File.ReadAllLines("path.txt")[0];
                input.Text = path;
            }

            if (IsExists())
            {
                content = File.ReadAllLines(path + @"\WTF\Config.wtf").ToList();

                for (int i = 0; i < content.Count; i++)
                {
                    if (content[i].Contains(@"SET realmlist ""logon.stormforge.gg""") || content[i].Contains(@"set realmlist ""logon.stormforge.gg"""))
                    {
                        infobox.Text = "Realmlist is Mistblade at the moment";
                    }

                    if (content[i].Contains(@"SET realmlist ""hu.logon.tauri.hu""") || content[i].Contains(@"set realmlist ""hu.logon.tauri.hu"""))
                    {
                        infobox.Text = "Realmlist is Tauriwow at the moment";
                    }
                }
            }
        }


        private void SetToTauri_Click(object sender, EventArgs e)
        {
            path = input.Text;

            File.WriteAllText("path.txt", path);

            if (IsExists())
            {
                content = File.ReadAllLines(path + @"\WTF\Config.wtf").ToList();

                for (int i = 0; i < content.Count; i++)
                {
                    if (content[i].Contains("SET realmlist") || content[i].Contains("set realmlist"))
                    {
                        realmlistIndex = i;
                    }

                    if (content[i].Contains("SET realmName") || content[i].Contains("set realmName"))
                    {
                        realmnameIndex = i;
                    }
                }

                content.Remove(@"SET realmlist ""logon.stormforge.gg""");

                if (!content.Contains(@"SET realmlist ""hu.logon.tauri.hu"""))
                {
                    content.Add(@"SET realmlist ""hu.logon.tauri.hu""");
                }


                content.Remove(@"SET realmName ""Mistblade""");

                if (!content.Contains(@"SET realmName ""[HU] Tauri WoW Server"""))
                {
                    content.Add(@"SET realmName ""[HU] Tauri WoW Server""");
                }

                File.WriteAllLines(path + @"\WTF\Config.wtf", content);

                infobox.Text = "Realmlist is now Tauriwow";
            }

            if (!IsExists())
            {
                infobox.Text = "No config.wtf file found";
            }
        }


        private void SetToMistblade_Click(object sender, EventArgs e)
        {
            path = input.Text;

            File.WriteAllText("path.txt", path);

            if (IsExists())
            {
                content = File.ReadAllLines(path + @"\WTF\Config.wtf").ToList();

                for (int i = 0; i < content.Count; i++)
                {
                    if (content[i].Contains("SET realmlist") || content[i].Contains("set realmlist"))
                    {
                        realmlistIndex = i;
                    }
                }

                content.Remove(@"SET realmlist ""hu.logon.tauri.hu""");

                if (!content.Contains(@"SET realmlist ""logon.stormforge.gg"""))
                {
                    content.Add(@"SET realmlist ""logon.stormforge.gg""");
                }


                content.Remove(@"SET realmName ""[HU] Tauri WoW Server""");

                if (!content.Contains(@"SET realmName ""Mistblade"""))
                {
                    content.Add(@"SET realmName ""Mistblade""");
                }


                File.WriteAllLines(path + @"\WTF\Config.wtf", content);


                infobox.Text = "Realmlist is now mistblade";
            }

            if (!IsExists())
            {
                infobox.Text = "No config.wtf file found";
            }
        }


        private async void Launch_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;

            using (Process wow = new Process())
            {
                if (Is32bit.Checked)
                {
                    wow.StartInfo.FileName = path + "Wow.exe";
                    wow.Start();
                }
                else
                {
                    wow.StartInfo.FileName = path + "Wow-64.exe";
                    wow.Start();
                }
            }

            if (autoShutdown.Checked)
            {
                await Task.Delay(5000);
                Application.Exit();
            }
        }


        private async void SetToTauri_Enter(object? sender, EventArgs e) => AnimateIn(sender);
        private async void SetToTauri_Leave(object? sender, EventArgs e) => AnimateOut(sender);


        private async void SetToMistblade_Enter(object? sender, EventArgs e) => AnimateIn(sender);
        private async void SetToMistblade_Leave(object? sender, EventArgs e) => AnimateOut(sender);


        private async void Launch_Enter(object? sender, EventArgs e) => AnimateIn(sender);
        private async void Launch_Leave(object? sender, EventArgs e) => AnimateOut(sender);


        private bool IsExists()
        {
            if (File.Exists(path + @"\WTF\Config.wtf")) return true;
            else return false;
        }


        private async void AnimateIn(object? sender)
        {
            for (int i = 0; i <= 5; i++)
            {
                ((Button)sender).BackColor = Color.FromArgb(i * 51, i * 51, i * 51);
                ((Button)sender).ForeColor = Color.FromArgb(255 - (i * 51), 255 - (i * 51), 255 - (i * 51));
                await Task.Delay(1);
            }
        }


        private async void AnimateOut(object? sender)
        {
            for (int i = 0; i <= 5; i++)
            {
                    ((Button)sender).BackColor = Color.FromArgb(255 - (i * 51), 255 - (i * 51), 255 - (i * 51));
                    ((Button)sender).ForeColor = Color.FromArgb(i * 51, i * 51, i * 51);
                    await Task.Delay(1);
            }
        }
    }
}