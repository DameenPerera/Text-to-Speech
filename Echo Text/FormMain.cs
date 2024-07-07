using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace Echo_Text
{
    public partial class FormMainF : Form
    {
        SpeechSynthesizer voice;

        public FormMainF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appearence();
            voice = new SpeechSynthesizer();
            selectVoice();
        }

        private string checkFiles(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Some system files were removed or deleted", "Echo Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return null;
            }
            else return filePath;
        }

        private void appearence()
        {
            try
            {
                if (Properties.Settings.Default.themeDark)
                {
                    butTheme.Image = Image.FromFile(checkFiles(Application.StartupPath + "\\Images\\ThemeLight.png"));
                    this.BackColor = Color.FromArgb(100, 100, 100);
                    rtexContents.BackColor = Color.FromArgb(80, 80, 80);
                    rtexContents.ForeColor = Color.White;
                    butMale.BackColor = butFemale.BackColor = Color.FromArgb(80, 80, 80);
                    butMale.ForeColor = butFemale.ForeColor = Color.DarkGray;
                }
                else
                {
                    butTheme.Image = Image.FromFile(checkFiles(Application.StartupPath + "\\Images\\ThemeDark.png"));
                    this.BackColor = Color.FromArgb(220, 220, 220);
                    rtexContents.BackColor = Color.FromArgb(230, 230, 230);
                    rtexContents.ForeColor = Color.Black;
                    butMale.BackColor = butFemale.BackColor = Color.FromArgb(230, 230, 230);
                    butMale.ForeColor = butFemale.ForeColor = Color.Gray;
                }
                butTheme.BackColor = butTheme.Parent.BackColor;
                panContenteBack.BackColor = rtexContents.BackColor;
                butSpeak.BackColor = butSpeak.Parent.BackColor;
                butNew.BackColor = butNew.Parent.BackColor;
                butPaste.BackColor = butPaste.Parent.BackColor;
                butSaveVoice.BackColor = butSaveVoice.Parent.BackColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echo Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectVoice()
        {
            try
            {
                if (Properties.Settings.Default.voiceMale)
                {
                    changeVoiceAppearence(butMale);
                }
                else
                {
                    changeVoiceAppearence(butFemale);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echo Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeVoiceAppearence(Control butVoice)
        {
            if (Properties.Settings.Default.themeDark)
            {
                butMale.BackColor = butFemale.BackColor = Color.FromArgb(80, 80, 80);
                butMale.ForeColor = butFemale.ForeColor = Color.DarkGray;
                butVoice.BackColor = Color.FromArgb(120, 120, 120);
                butVoice.ForeColor = Color.White;
            }
            else
            {
                butMale.BackColor = butFemale.BackColor = Color.FromArgb(230, 230, 230);
                butMale.ForeColor = butFemale.ForeColor = Color.Gray;
                butVoice.BackColor = Color.FromArgb(255, 255, 255);
                butVoice.ForeColor = Color.Black;
            }
        }

        private void butMale_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.voiceMale = true;
            Properties.Settings.Default.Save();
            selectVoice();
        }

        private void butFemale_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.voiceMale = false;
            Properties.Settings.Default.Save();
            selectVoice();
        }

        private void butTheme_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.themeDark) Properties.Settings.Default.themeDark = false;
            else Properties.Settings.Default.themeDark = true;
            Properties.Settings.Default.Save();
            appearence();
            selectVoice();
        }

        private void butSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtexContents.Text))
                {
                    if (MessageBox.Show("Please, Type or paste a text you wish to hear.\n\nDo you want to run a sample text?", "Echo Text", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        rtexContents.Text = "This is a sample text 1 2 3";
                    else
                        return;
                }
                if (Properties.Settings.Default.voiceMale)
                {
                    voice.SelectVoiceByHints(VoiceGender.Male);
                }
                else
                {
                    voice.SelectVoiceByHints(VoiceGender.Female);
                }
                if (string.IsNullOrEmpty(rtexContents.SelectedText)) voice.SpeakAsync(rtexContents.Text);
                else voice.SpeakAsync(rtexContents.SelectedText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echo Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butPlayPause_Click(object sender, EventArgs e)
        {
            voice.Pause();
            voice = new SpeechSynthesizer();
        }

        private void butPaste_Click(object sender, EventArgs e)
        {
            rtexContents.Clear();
            rtexContents.Text = Clipboard.GetText();
        }

        private void butSaveVoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtexContents.Text))
                {
                    if (MessageBox.Show("Please, Type or paste a text you wish to hear.\n\nDo you want to run a sample text?", "Echo Text", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        rtexContents.Text = "This is a sample text 1 2 3";
                    else
                        return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Wave Files|*.wav";
                    sfd.Title = "Save Voice as A Wave File";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                        if (Properties.Settings.Default.voiceMale)
                        {
                            voice.SelectVoiceByHints(VoiceGender.Male);
                        }
                        else
                        {
                            voice.SelectVoiceByHints(VoiceGender.Female);
                        }
                        voice.SetOutputToWaveStream(fs);
                        if (string.IsNullOrEmpty(rtexContents.SelectedText)) voice.Speak(rtexContents.Text);
                        else voice.Speak(rtexContents.SelectedText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echo Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
