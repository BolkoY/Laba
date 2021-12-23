namespace тренажер
{
    partial class Exam
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.NameListBox = new System.Windows.Forms.ListBox();
            this.AgeListBox = new System.Windows.Forms.ListBox();
            this.DateListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypWorkloadLabel = new System.Windows.Forms.Label();
            this.SexListBox = new System.Windows.Forms.ListBox();
            this.WorkListBox = new System.Windows.Forms.ListBox();
            this.TemperaturaPictureBox = new System.Windows.Forms.PictureBox();
            this.PulsPictureBox = new System.Windows.Forms.PictureBox();
            this.ProvodimostPictureBox = new System.Windows.Forms.PictureBox();
            this.DavleniePictureBox = new System.Windows.Forms.PictureBox();
            this.VlajnostPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.TemperaturaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PulsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvodimostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DavleniePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VlajnostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(953, 448);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(95, 30);
            this.ReturnButton.TabIndex = 9;
            this.ReturnButton.Text = "Вернуться";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeLabel.Location = new System.Drawing.Point(24, 100);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(129, 31);
            this.AgeLabel.TabIndex = 10;
            this.AgeLabel.Text = "возраст:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(20, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(133, 31);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "пациент:";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexLabel.Location = new System.Drawing.Point(533, 99);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(71, 31);
            this.SexLabel.TabIndex = 12;
            this.SexLabel.Text = "пол:";
            // 
            // NameListBox
            // 
            this.NameListBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.ItemHeight = 30;
            this.NameListBox.Location = new System.Drawing.Point(170, 57);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.Size = new System.Drawing.Size(337, 30);
            this.NameListBox.TabIndex = 13;
            // 
            // AgeListBox
            // 
            this.AgeListBox.BackColor = System.Drawing.SystemColors.Control;
            this.AgeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.AgeListBox.FormattingEnabled = true;
            this.AgeListBox.ItemHeight = 30;
            this.AgeListBox.Location = new System.Drawing.Point(170, 101);
            this.AgeListBox.Name = "AgeListBox";
            this.AgeListBox.Size = new System.Drawing.Size(167, 30);
            this.AgeListBox.TabIndex = 14;
            // 
            // DateListBox
            // 
            this.DateListBox.BackColor = System.Drawing.SystemColors.Control;
            this.DateListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.DateListBox.FormattingEnabled = true;
            this.DateListBox.ItemHeight = 30;
            this.DateListBox.Location = new System.Drawing.Point(632, 57);
            this.DateListBox.Name = "DateListBox";
            this.DateListBox.Size = new System.Drawing.Size(315, 30);
            this.DateListBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(526, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "дата:";
            // 
            // TypWorkloadLabel
            // 
            this.TypWorkloadLabel.AutoSize = true;
            this.TypWorkloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypWorkloadLabel.Location = new System.Drawing.Point(20, 165);
            this.TypWorkloadLabel.Name = "TypWorkloadLabel";
            this.TypWorkloadLabel.Size = new System.Drawing.Size(196, 31);
            this.TypWorkloadLabel.TabIndex = 17;
            this.TypWorkloadLabel.Text = "тип нагрузки:";
            // 
            // SexListBox
            // 
            this.SexListBox.BackColor = System.Drawing.SystemColors.Control;
            this.SexListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SexListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.SexListBox.FormattingEnabled = true;
            this.SexListBox.ItemHeight = 30;
            this.SexListBox.Location = new System.Drawing.Point(632, 101);
            this.SexListBox.Name = "SexListBox";
            this.SexListBox.Size = new System.Drawing.Size(167, 30);
            this.SexListBox.TabIndex = 18;
            // 
            // WorkListBox
            // 
            this.WorkListBox.BackColor = System.Drawing.SystemColors.Control;
            this.WorkListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.WorkListBox.FormattingEnabled = true;
            this.WorkListBox.ItemHeight = 30;
            this.WorkListBox.Location = new System.Drawing.Point(260, 166);
            this.WorkListBox.Name = "WorkListBox";
            this.WorkListBox.Size = new System.Drawing.Size(400, 30);
            this.WorkListBox.TabIndex = 19;
            // 
            // TemperaturaPictureBox
            // 
            this.TemperaturaPictureBox.Image = global::тренажер.Properties.Resources.температура;
            this.TemperaturaPictureBox.Location = new System.Drawing.Point(1108, 171);
            this.TemperaturaPictureBox.Name = "TemperaturaPictureBox";
            this.TemperaturaPictureBox.Size = new System.Drawing.Size(91, 60);
            this.TemperaturaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TemperaturaPictureBox.TabIndex = 25;
            this.TemperaturaPictureBox.TabStop = false;
            this.TemperaturaPictureBox.Visible = false;
            // 
            // PulsPictureBox
            // 
            this.PulsPictureBox.Image = global::тренажер.Properties.Resources.пульс;
            this.PulsPictureBox.Location = new System.Drawing.Point(1040, 257);
            this.PulsPictureBox.Name = "PulsPictureBox";
            this.PulsPictureBox.Size = new System.Drawing.Size(100, 50);
            this.PulsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PulsPictureBox.TabIndex = 24;
            this.PulsPictureBox.TabStop = false;
            this.PulsPictureBox.Visible = false;
            // 
            // ProvodimostPictureBox
            // 
            this.ProvodimostPictureBox.Image = global::тренажер.Properties.Resources.проводимость;
            this.ProvodimostPictureBox.Location = new System.Drawing.Point(1221, 171);
            this.ProvodimostPictureBox.Name = "ProvodimostPictureBox";
            this.ProvodimostPictureBox.Size = new System.Drawing.Size(100, 50);
            this.ProvodimostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProvodimostPictureBox.TabIndex = 23;
            this.ProvodimostPictureBox.TabStop = false;
            this.ProvodimostPictureBox.Visible = false;
            // 
            // DavleniePictureBox
            // 
            this.DavleniePictureBox.Image = global::тренажер.Properties.Resources.давление;
            this.DavleniePictureBox.Location = new System.Drawing.Point(1221, 99);
            this.DavleniePictureBox.Name = "DavleniePictureBox";
            this.DavleniePictureBox.Size = new System.Drawing.Size(100, 66);
            this.DavleniePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DavleniePictureBox.TabIndex = 22;
            this.DavleniePictureBox.TabStop = false;
            this.DavleniePictureBox.Visible = false;
            // 
            // VlajnostPictureBox
            // 
            this.VlajnostPictureBox.Image = global::тренажер.Properties.Resources.влажность;
            this.VlajnostPictureBox.Location = new System.Drawing.Point(979, 151);
            this.VlajnostPictureBox.Name = "VlajnostPictureBox";
            this.VlajnostPictureBox.Size = new System.Drawing.Size(46, 58);
            this.VlajnostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VlajnostPictureBox.TabIndex = 21;
            this.VlajnostPictureBox.TabStop = false;
            this.VlajnostPictureBox.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::тренажер.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(953, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 302);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.ProvodimostPictureBox);
            this.Controls.Add(this.TemperaturaPictureBox);
            this.Controls.Add(this.PulsPictureBox);
            this.Controls.Add(this.DavleniePictureBox);
            this.Controls.Add(this.VlajnostPictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.WorkListBox);
            this.Controls.Add(this.SexListBox);
            this.Controls.Add(this.TypWorkloadLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateListBox);
            this.Controls.Add(this.AgeListBox);
            this.Controls.Add(this.NameListBox);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.ReturnButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обследование";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exam_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TemperaturaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PulsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvodimostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DavleniePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VlajnostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.ListBox NameListBox;
        private System.Windows.Forms.ListBox AgeListBox;
        private System.Windows.Forms.ListBox DateListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TypWorkloadLabel;
        private System.Windows.Forms.ListBox SexListBox;
        private System.Windows.Forms.ListBox WorkListBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox VlajnostPictureBox;
        private System.Windows.Forms.PictureBox DavleniePictureBox;
        private System.Windows.Forms.PictureBox ProvodimostPictureBox;
        private System.Windows.Forms.PictureBox PulsPictureBox;
        private System.Windows.Forms.PictureBox TemperaturaPictureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}