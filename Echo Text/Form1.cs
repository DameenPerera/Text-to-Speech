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

namespace Echo_Text
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer voice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appearence();
            voice = new SpeechSynthesizer();
            selectVoice();
        }

        private void appearence()
        {
            if (Properties.Settings.Default.themeDark)
            {
                butTheme.Image = Image.FromFile("Images\\ThemeLight.png");
                this.BackColor = Color.FromArgb(100, 100, 100);
                rtexContents.BackColor = Color.FromArgb(80, 80, 80);
                rtexContents.ForeColor = Color.White;
                butMale.BackColor = butFemale.BackColor = Color.FromArgb(80, 80, 80);
                butMale.ForeColor = butFemale.ForeColor = Color.DarkGray;
            }
            else
            {
                butTheme.Image = Image.FromFile("Images\\ThemeDark.png");
                this.BackColor = Color.FromArgb(220, 220, 220);
                rtexContents.BackColor = Color.FromArgb(230, 230, 230);
                rtexContents.ForeColor = Color.Black;
                butMale.BackColor = butFemale.BackColor = Color.FromArgb(230, 230, 230);
                butMale.ForeColor = butFemale.ForeColor = Color.Gray;
            }
            butTheme.BackColor = butTheme.Parent.BackColor;
            panContenteBack.BackColor = rtexContents.BackColor;
            butSpeak.BackColor = butSpeak.Parent.BackColor;
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

        bool voicePlay = false;

        private void butSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.voiceMale)
                {
                    voice.SelectVoiceByHints(VoiceGender.Male);
                }
                else
                {
                    voice.SelectVoiceByHints(VoiceGender.Female);
                }
                voice.SpeakAsync(rtexContents.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echo Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
