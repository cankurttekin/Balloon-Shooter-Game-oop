namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skorGoster = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.okgosterge = new System.Windows.Forms.Label();
            this.seviyeGosterge = new System.Windows.Forms.Label();
            this.oyunSeviye = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxAyarlar = new System.Windows.Forms.GroupBox();
            this.renkButton = new System.Windows.Forms.Button();
            this.balonComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.okcuComboBox = new System.Windows.Forms.ComboBox();
            this.renkOnizlemePb = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ayarlarButton = new System.Windows.Forms.Button();
            this.oncekiOyuncuLabel = new System.Windows.Forms.Label();
            this.oncekiOyuncuButton = new System.Windows.Forms.Button();
            this.yeniOyunButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renkOnizlemePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // skorGoster
            // 
            this.skorGoster.BackColor = System.Drawing.Color.Transparent;
            this.skorGoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skorGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorGoster.Location = new System.Drawing.Point(0, 0);
            this.skorGoster.Name = "skorGoster";
            this.skorGoster.Size = new System.Drawing.Size(882, 553);
            this.skorGoster.TabIndex = 5;
            this.skorGoster.Text = "0";
            this.skorGoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timerOyun);
            // 
            // okgosterge
            // 
            this.okgosterge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okgosterge.BackColor = System.Drawing.Color.Transparent;
            this.okgosterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okgosterge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okgosterge.Location = new System.Drawing.Point(760, 50);
            this.okgosterge.Name = "okgosterge";
            this.okgosterge.Size = new System.Drawing.Size(122, 20);
            this.okgosterge.TabIndex = 6;
            this.okgosterge.Text = "OK: SINIRSIZ";
            this.okgosterge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // seviyeGosterge
            // 
            this.seviyeGosterge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seviyeGosterge.BackColor = System.Drawing.Color.Transparent;
            this.seviyeGosterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seviyeGosterge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seviyeGosterge.Location = new System.Drawing.Point(760, 30);
            this.seviyeGosterge.Name = "seviyeGosterge";
            this.seviyeGosterge.Size = new System.Drawing.Size(122, 20);
            this.seviyeGosterge.TabIndex = 17;
            this.seviyeGosterge.Text = "SEVİYE: 1";
            this.seviyeGosterge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // oyunSeviye
            // 
            this.oyunSeviye.Tick += new System.EventHandler(this.oyunSeviye_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(513, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "OYUNCU: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.arkaplan1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBoxAyarlar);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.ayarlarButton);
            this.panel1.Controls.Add(this.oncekiOyuncuLabel);
            this.panel1.Controls.Add(this.oncekiOyuncuButton);
            this.panel1.Controls.Add(this.yeniOyunButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 553);
            this.panel1.TabIndex = 12;
            // 
            // groupBoxAyarlar
            // 
            this.groupBoxAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAyarlar.Controls.Add(this.renkButton);
            this.groupBoxAyarlar.Controls.Add(this.balonComboBox);
            this.groupBoxAyarlar.Controls.Add(this.label4);
            this.groupBoxAyarlar.Controls.Add(this.label8);
            this.groupBoxAyarlar.Controls.Add(this.okcuComboBox);
            this.groupBoxAyarlar.Controls.Add(this.renkOnizlemePb);
            this.groupBoxAyarlar.Controls.Add(this.label14);
            this.groupBoxAyarlar.Location = new System.Drawing.Point(12, 30);
            this.groupBoxAyarlar.Name = "groupBoxAyarlar";
            this.groupBoxAyarlar.Size = new System.Drawing.Size(354, 195);
            this.groupBoxAyarlar.TabIndex = 32;
            this.groupBoxAyarlar.TabStop = false;
            this.groupBoxAyarlar.Text = "AYARLAR";
            this.groupBoxAyarlar.Visible = false;
            // 
            // renkButton
            // 
            this.renkButton.AutoSize = true;
            this.renkButton.Location = new System.Drawing.Point(192, 123);
            this.renkButton.Name = "renkButton";
            this.renkButton.Size = new System.Drawing.Size(91, 27);
            this.renkButton.TabIndex = 17;
            this.renkButton.Text = "RENK SEÇ";
            this.renkButton.UseVisualStyleBackColor = true;
            this.renkButton.Click += new System.EventHandler(this.renkButton_Click);
            // 
            // balonComboBox
            // 
            this.balonComboBox.FormattingEnabled = true;
            this.balonComboBox.Location = new System.Drawing.Point(162, 84);
            this.balonComboBox.Name = "balonComboBox";
            this.balonComboBox.Size = new System.Drawing.Size(121, 24);
            this.balonComboBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "OKÇU: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(43, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "BALON: ";
            // 
            // okcuComboBox
            // 
            this.okcuComboBox.FormattingEnabled = true;
            this.okcuComboBox.Location = new System.Drawing.Point(162, 40);
            this.okcuComboBox.Name = "okcuComboBox";
            this.okcuComboBox.Size = new System.Drawing.Size(121, 24);
            this.okcuComboBox.TabIndex = 30;
            // 
            // renkOnizlemePb
            // 
            this.renkOnizlemePb.BackColor = System.Drawing.Color.White;
            this.renkOnizlemePb.Location = new System.Drawing.Point(162, 127);
            this.renkOnizlemePb.Name = "renkOnizlemePb";
            this.renkOnizlemePb.Size = new System.Drawing.Size(24, 24);
            this.renkOnizlemePb.TabIndex = 25;
            this.renkOnizlemePb.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(43, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "ZEMİN RENGİ:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::WindowsFormsApp3.Properties.Resources.okcuoyunu;
            this.pictureBox3.Location = new System.Drawing.Point(204, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(503, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(375, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // ayarlarButton
            // 
            this.ayarlarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ayarlarButton.BackColor = System.Drawing.Color.FloralWhite;
            this.ayarlarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarlarButton.Location = new System.Drawing.Point(375, 476);
            this.ayarlarButton.MaximumSize = new System.Drawing.Size(150, 50);
            this.ayarlarButton.MinimumSize = new System.Drawing.Size(150, 50);
            this.ayarlarButton.Name = "ayarlarButton";
            this.ayarlarButton.Size = new System.Drawing.Size(150, 50);
            this.ayarlarButton.TabIndex = 16;
            this.ayarlarButton.Text = "AYARLAR";
            this.ayarlarButton.UseVisualStyleBackColor = false;
            this.ayarlarButton.Click += new System.EventHandler(this.ayarlarButton_Click);
            // 
            // oncekiOyuncuLabel
            // 
            this.oncekiOyuncuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.oncekiOyuncuLabel.BackColor = System.Drawing.Color.Transparent;
            this.oncekiOyuncuLabel.Location = new System.Drawing.Point(275, 388);
            this.oncekiOyuncuLabel.Name = "oncekiOyuncuLabel";
            this.oncekiOyuncuLabel.Size = new System.Drawing.Size(361, 17);
            this.oncekiOyuncuLabel.TabIndex = 13;
            this.oncekiOyuncuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oncekiOyuncuButton
            // 
            this.oncekiOyuncuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.oncekiOyuncuButton.BackColor = System.Drawing.Color.FloralWhite;
            this.oncekiOyuncuButton.Enabled = false;
            this.oncekiOyuncuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oncekiOyuncuButton.Location = new System.Drawing.Point(375, 408);
            this.oncekiOyuncuButton.MaximumSize = new System.Drawing.Size(150, 50);
            this.oncekiOyuncuButton.MinimumSize = new System.Drawing.Size(150, 50);
            this.oncekiOyuncuButton.Name = "oncekiOyuncuButton";
            this.oncekiOyuncuButton.Size = new System.Drawing.Size(150, 50);
            this.oncekiOyuncuButton.TabIndex = 14;
            this.oncekiOyuncuButton.Text = "ÖNCEKİ OYUNCU";
            this.oncekiOyuncuButton.UseVisualStyleBackColor = false;
            this.oncekiOyuncuButton.Click += new System.EventHandler(this.oncekiOyuncuButton_Click);
            // 
            // yeniOyunButton
            // 
            this.yeniOyunButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yeniOyunButton.BackColor = System.Drawing.Color.FloralWhite;
            this.yeniOyunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniOyunButton.Location = new System.Drawing.Point(375, 310);
            this.yeniOyunButton.MaximumSize = new System.Drawing.Size(150, 50);
            this.yeniOyunButton.MinimumSize = new System.Drawing.Size(150, 50);
            this.yeniOyunButton.Name = "yeniOyunButton";
            this.yeniOyunButton.Size = new System.Drawing.Size(150, 50);
            this.yeniOyunButton.TabIndex = 11;
            this.yeniOyunButton.Text = "YENİ OYUNCU";
            this.yeniOyunButton.UseVisualStyleBackColor = false;
            this.yeniOyunButton.Click += new System.EventHandler(this.yeniOyunButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skorGoster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seviyeGosterge);
            this.Controls.Add(this.okgosterge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Okçu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bas);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cek);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxAyarlar.ResumeLayout(false);
            this.groupBoxAyarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renkOnizlemePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label skorGoster;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label okgosterge;
        private System.Windows.Forms.Button yeniOyunButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button oncekiOyuncuButton;
        private System.Windows.Forms.Label oncekiOyuncuLabel;
        private System.Windows.Forms.Label seviyeGosterge;
        private System.Windows.Forms.Timer oyunSeviye;
        private System.Windows.Forms.Button ayarlarButton;
        private System.Windows.Forms.Button renkButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox renkOnizlemePb;
        private System.Windows.Forms.ComboBox okcuComboBox;
        private System.Windows.Forms.ComboBox balonComboBox;
        private System.Windows.Forms.GroupBox groupBoxAyarlar;
    }
}

