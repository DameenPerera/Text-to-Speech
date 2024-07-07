namespace Echo_Text
{
    partial class FormMainF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainF));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butSaveVoice = new Echo_Text.ETButton();
            this.butPaste = new Echo_Text.ETButton();
            this.butNew = new Echo_Text.ETButton();
            this.butSpeak = new Echo_Text.ETButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butTheme = new Echo_Text.ETButton();
            this.butFemale = new Echo_Text.ETButton();
            this.butMale = new Echo_Text.ETButton();
            this.panContenteBack = new System.Windows.Forms.Panel();
            this.rtexContents = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panContenteBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butSaveVoice);
            this.panel1.Controls.Add(this.butPaste);
            this.panel1.Controls.Add(this.butNew);
            this.panel1.Controls.Add(this.butSpeak);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 62);
            this.panel1.TabIndex = 0;
            // 
            // butSaveVoice
            // 
            this.butSaveVoice.BackColor = System.Drawing.SystemColors.Control;
            this.butSaveVoice.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butSaveVoice.BorderRadius = 33;
            this.butSaveVoice.BorderSize = 0;
            this.butSaveVoice.FlatAppearance.BorderSize = 0;
            this.butSaveVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSaveVoice.ForeColor = System.Drawing.Color.White;
            this.butSaveVoice.Image = ((System.Drawing.Image)(resources.GetObject("butSaveVoice.Image")));
            this.butSaveVoice.Location = new System.Drawing.Point(201, 9);
            this.butSaveVoice.Name = "butSaveVoice";
            this.butSaveVoice.Size = new System.Drawing.Size(45, 45);
            this.butSaveVoice.TabIndex = 8;
            this.toolTip.SetToolTip(this.butSaveVoice, "Save Voice as a Wave Audio File");
            this.butSaveVoice.UseVisualStyleBackColor = false;
            this.butSaveVoice.Click += new System.EventHandler(this.butSaveVoice_Click);
            // 
            // butPaste
            // 
            this.butPaste.BackColor = System.Drawing.SystemColors.Control;
            this.butPaste.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butPaste.BorderRadius = 33;
            this.butPaste.BorderSize = 0;
            this.butPaste.FlatAppearance.BorderSize = 0;
            this.butPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPaste.ForeColor = System.Drawing.Color.White;
            this.butPaste.Image = ((System.Drawing.Image)(resources.GetObject("butPaste.Image")));
            this.butPaste.Location = new System.Drawing.Point(136, 9);
            this.butPaste.Name = "butPaste";
            this.butPaste.Size = new System.Drawing.Size(45, 45);
            this.butPaste.TabIndex = 7;
            this.toolTip.SetToolTip(this.butPaste, "Paste Copied Text");
            this.butPaste.UseVisualStyleBackColor = false;
            this.butPaste.Click += new System.EventHandler(this.butPaste_Click);
            // 
            // butNew
            // 
            this.butNew.BackColor = System.Drawing.SystemColors.Control;
            this.butNew.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butNew.BorderRadius = 33;
            this.butNew.BorderSize = 0;
            this.butNew.FlatAppearance.BorderSize = 0;
            this.butNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNew.ForeColor = System.Drawing.Color.White;
            this.butNew.Image = ((System.Drawing.Image)(resources.GetObject("butNew.Image")));
            this.butNew.Location = new System.Drawing.Point(74, 9);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(45, 45);
            this.butNew.TabIndex = 6;
            this.toolTip.SetToolTip(this.butNew, "New Voice");
            this.butNew.UseVisualStyleBackColor = false;
            this.butNew.Click += new System.EventHandler(this.butPlayPause_Click);
            // 
            // butSpeak
            // 
            this.butSpeak.BackColor = System.Drawing.SystemColors.Control;
            this.butSpeak.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butSpeak.BorderRadius = 33;
            this.butSpeak.BorderSize = 0;
            this.butSpeak.FlatAppearance.BorderSize = 0;
            this.butSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSpeak.ForeColor = System.Drawing.Color.White;
            this.butSpeak.Image = ((System.Drawing.Image)(resources.GetObject("butSpeak.Image")));
            this.butSpeak.Location = new System.Drawing.Point(12, 9);
            this.butSpeak.Name = "butSpeak";
            this.butSpeak.Size = new System.Drawing.Size(45, 45);
            this.butSpeak.TabIndex = 5;
            this.toolTip.SetToolTip(this.butSpeak, "Start Voice");
            this.butSpeak.UseVisualStyleBackColor = false;
            this.butSpeak.Click += new System.EventHandler(this.butSpeak_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butTheme);
            this.panel2.Controls.Add(this.butFemale);
            this.panel2.Controls.Add(this.butMale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 69);
            this.panel2.TabIndex = 1;
            // 
            // butTheme
            // 
            this.butTheme.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butTheme.BackColor = System.Drawing.SystemColors.Control;
            this.butTheme.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butTheme.BorderRadius = 40;
            this.butTheme.BorderSize = 0;
            this.butTheme.FlatAppearance.BorderSize = 0;
            this.butTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTheme.ForeColor = System.Drawing.Color.White;
            this.butTheme.Image = ((System.Drawing.Image)(resources.GetObject("butTheme.Image")));
            this.butTheme.Location = new System.Drawing.Point(621, 13);
            this.butTheme.Name = "butTheme";
            this.butTheme.Size = new System.Drawing.Size(45, 45);
            this.butTheme.TabIndex = 2;
            this.toolTip.SetToolTip(this.butTheme, "Change Theme");
            this.butTheme.UseVisualStyleBackColor = false;
            this.butTheme.Click += new System.EventHandler(this.butTheme_Click);
            // 
            // butFemale
            // 
            this.butFemale.BackColor = System.Drawing.Color.Gainsboro;
            this.butFemale.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butFemale.BorderRadius = 40;
            this.butFemale.BorderSize = 0;
            this.butFemale.FlatAppearance.BorderSize = 0;
            this.butFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFemale.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFemale.ForeColor = System.Drawing.Color.Black;
            this.butFemale.Image = ((System.Drawing.Image)(resources.GetObject("butFemale.Image")));
            this.butFemale.Location = new System.Drawing.Point(163, 13);
            this.butFemale.Name = "butFemale";
            this.butFemale.Size = new System.Drawing.Size(145, 45);
            this.butFemale.TabIndex = 1;
            this.butFemale.Text = "   Female Voice";
            this.butFemale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.butFemale, "Femaie Voice");
            this.butFemale.UseVisualStyleBackColor = false;
            this.butFemale.Click += new System.EventHandler(this.butFemale_Click);
            // 
            // butMale
            // 
            this.butMale.BackColor = System.Drawing.Color.Gainsboro;
            this.butMale.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butMale.BorderRadius = 40;
            this.butMale.BorderSize = 0;
            this.butMale.FlatAppearance.BorderSize = 0;
            this.butMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMale.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMale.ForeColor = System.Drawing.Color.Black;
            this.butMale.Image = ((System.Drawing.Image)(resources.GetObject("butMale.Image")));
            this.butMale.Location = new System.Drawing.Point(12, 13);
            this.butMale.Name = "butMale";
            this.butMale.Size = new System.Drawing.Size(145, 45);
            this.butMale.TabIndex = 0;
            this.butMale.Text = "   Male Voice";
            this.butMale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.butMale, "Male Voice");
            this.butMale.UseVisualStyleBackColor = false;
            this.butMale.Click += new System.EventHandler(this.butMale_Click);
            // 
            // panContenteBack
            // 
            this.panContenteBack.Controls.Add(this.rtexContents);
            this.panContenteBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContenteBack.Location = new System.Drawing.Point(0, 69);
            this.panContenteBack.Name = "panContenteBack";
            this.panContenteBack.Padding = new System.Windows.Forms.Padding(5);
            this.panContenteBack.Size = new System.Drawing.Size(678, 419);
            this.panContenteBack.TabIndex = 2;
            // 
            // rtexContents
            // 
            this.rtexContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtexContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtexContents.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtexContents.Location = new System.Drawing.Point(5, 5);
            this.rtexContents.Name = "rtexContents";
            this.rtexContents.Size = new System.Drawing.Size(668, 409);
            this.rtexContents.TabIndex = 0;
            this.rtexContents.Text = "";
            // 
            // FormMainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 550);
            this.Controls.Add(this.panContenteBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Echo Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panContenteBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panContenteBack;
        private System.Windows.Forms.RichTextBox rtexContents;
        private ETButton butMale;
        private ETButton butFemale;
        private ETButton butTheme;
        private ETButton butSpeak;
        private ETButton butNew;
        private System.Windows.Forms.ToolTip toolTip;
        private ETButton butPaste;
        private ETButton butSaveVoice;
    }
}

