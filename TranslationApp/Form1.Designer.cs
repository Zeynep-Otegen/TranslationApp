using System;

namespace TranslationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSourceLang = new System.Windows.Forms.Label();
            this.cmbSourceLang = new System.Windows.Forms.ComboBox();
            this.lblTargetLang = new System.Windows.Forms.Label();
            this.cmbTargetLang = new System.Windows.Forms.ComboBox();
            this.txtSourceText = new System.Windows.Forms.TextBox();
            this.txtTranslatedText = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.lblSourceText = new System.Windows.Forms.Label();
            this.lblTranslatedText = new System.Windows.Forms.Label();
            this.btnSwapLanguages = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSourceLang
            // 
            this.lblSourceLang.AutoSize = true;
            this.lblSourceLang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSourceLang.Location = new System.Drawing.Point(16, 86);
            this.lblSourceLang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceLang.Name = "lblSourceLang";
            this.lblSourceLang.Size = new System.Drawing.Size(87, 20);
            this.lblSourceLang.TabIndex = 0;
            this.lblSourceLang.Text = "Kaynak Dil:";
            // 
            // cmbSourceLang
            // 
            this.cmbSourceLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceLang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSourceLang.FormattingEnabled = true;
            this.cmbSourceLang.Location = new System.Drawing.Point(120, 82);
            this.cmbSourceLang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSourceLang.Name = "cmbSourceLang";
            this.cmbSourceLang.Size = new System.Drawing.Size(239, 28);
            this.cmbSourceLang.TabIndex = 1;
            // 
            // lblTargetLang
            // 
            this.lblTargetLang.AutoSize = true;
            this.lblTargetLang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTargetLang.Location = new System.Drawing.Point(429, 86);
            this.lblTargetLang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTargetLang.Name = "lblTargetLang";
            this.lblTargetLang.Size = new System.Drawing.Size(78, 20);
            this.lblTargetLang.TabIndex = 2;
            this.lblTargetLang.Text = "Hedef Dil:";
            // 
            // cmbTargetLang
            // 
            this.cmbTargetLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetLang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTargetLang.FormattingEnabled = true;
            this.cmbTargetLang.Location = new System.Drawing.Point(511, 82);
            this.cmbTargetLang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTargetLang.Name = "cmbTargetLang";
            this.cmbTargetLang.Size = new System.Drawing.Size(239, 28);
            this.cmbTargetLang.TabIndex = 3;
            // 
            // txtSourceText
            // 
            this.txtSourceText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSourceText.Location = new System.Drawing.Point(20, 160);
            this.txtSourceText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSourceText.Multiline = true;
            this.txtSourceText.Name = "txtSourceText";
            this.txtSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSourceText.Size = new System.Drawing.Size(701, 184);
            this.txtSourceText.TabIndex = 4;
            this.txtSourceText.Text = "Buraya çevrilecek metni yazın...";
            this.txtSourceText.TextChanged += new System.EventHandler(this.txtSourceText_TextChanged);
            this.txtSourceText.Enter += new System.EventHandler(this.txtSourceText_Enter);
            this.txtSourceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSourceText_KeyDown);
            // 
            // txtTranslatedText
            // 
            this.txtTranslatedText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTranslatedText.Location = new System.Drawing.Point(20, 394);
            this.txtTranslatedText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTranslatedText.Multiline = true;
            this.txtTranslatedText.Name = "txtTranslatedText";
            this.txtTranslatedText.ReadOnly = true;
            this.txtTranslatedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTranslatedText.Size = new System.Drawing.Size(701, 184);
            this.txtTranslatedText.TabIndex = 5;
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTranslate.ForeColor = System.Drawing.Color.White;
            this.btnTranslate.Location = new System.Drawing.Point(20, 591);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(160, 49);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Çevir";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // lblSourceText
            // 
            this.lblSourceText.AutoSize = true;
            this.lblSourceText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSourceText.Location = new System.Drawing.Point(16, 135);
            this.lblSourceText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceText.Name = "lblSourceText";
            this.lblSourceText.Size = new System.Drawing.Size(128, 20);
            this.lblSourceText.TabIndex = 7;
            this.lblSourceText.Text = "Çevrilecek Metin:";
            // 
            // lblTranslatedText
            // 
            this.lblTranslatedText.AutoSize = true;
            this.lblTranslatedText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTranslatedText.Location = new System.Drawing.Point(16, 369);
            this.lblTranslatedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTranslatedText.Name = "lblTranslatedText";
            this.lblTranslatedText.Size = new System.Drawing.Size(114, 20);
            this.lblTranslatedText.TabIndex = 8;
            this.lblTranslatedText.Text = "Çevrilen Metin:";
            // 
            // btnSwapLanguages
            // 
            this.btnSwapLanguages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSwapLanguages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwapLanguages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSwapLanguages.ForeColor = System.Drawing.Color.White;
            this.btnSwapLanguages.Location = new System.Drawing.Point(368, 80);
            this.btnSwapLanguages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSwapLanguages.Name = "btnSwapLanguages";
            this.btnSwapLanguages.Size = new System.Drawing.Size(53, 37);
            this.btnSwapLanguages.TabIndex = 9;
            this.btnSwapLanguages.Text = "⇄";
            this.btnSwapLanguages.UseVisualStyleBackColor = false;
            this.btnSwapLanguages.Click += new System.EventHandler(this.btnSwapLanguages_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(188, 591);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 49);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatus.Location = new System.Drawing.Point(16, 652);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 20);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Hazır";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 62);
            this.panel1.TabIndex = 12;
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblCharCount.Location = new System.Drawing.Point(667, 135);
            this.lblCharCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(46, 19);
            this.lblCharCount.TabIndex = 13;
            this.lblCharCount.Text = "0/500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 690);
            this.Controls.Add(this.lblCharCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSwapLanguages);
            this.Controls.Add(this.lblTranslatedText);
            this.Controls.Add(this.lblSourceText);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtTranslatedText);
            this.Controls.Add(this.txtSourceText);
            this.Controls.Add(this.cmbTargetLang);
            this.Controls.Add(this.lblTargetLang);
            this.Controls.Add(this.cmbSourceLang);
            this.Controls.Add(this.lblSourceLang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çeviri Uygulaması - MyMemory API";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Designer değişkenleri
        private System.Windows.Forms.Label lblSourceLang;
        private System.Windows.Forms.ComboBox cmbSourceLang;
        private System.Windows.Forms.Label lblTargetLang;
        private System.Windows.Forms.ComboBox cmbTargetLang;
        private System.Windows.Forms.TextBox txtSourceText;
        private System.Windows.Forms.TextBox txtTranslatedText;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label lblSourceText;
        private System.Windows.Forms.Label lblTranslatedText;
        private System.Windows.Forms.Button btnSwapLanguages;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCharCount;

        // Placeholder metin için event handler
        private void txtSourceText_Enter(object sender, EventArgs e)
        {
            if (txtSourceText.Text == "Buraya çevrilecek metni yazın...")
            {
                txtSourceText.Text = "";
                txtSourceText.ForeColor = System.Drawing.Color.Black;
            }
        }

        // Karakter sayacı için
        private void txtSourceText_TextChanged(object sender, EventArgs e)
        {
            int charCount = txtSourceText.Text.Length;
            lblCharCount.Text = $"{charCount}/500";

            // Renk değiştir
            if (charCount > 450)
                lblCharCount.ForeColor = System.Drawing.Color.Red;
            else if (charCount > 400)
                lblCharCount.ForeColor = System.Drawing.Color.Orange;
            else
                lblCharCount.ForeColor = System.Drawing.Color.Gray;
        }
    }
}