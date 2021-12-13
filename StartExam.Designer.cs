namespace тренажер
{
    partial class StartExam
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
            this.SetLabel = new System.Windows.Forms.Label();
            this.SetWorkloadLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DavlenieСheckBox = new System.Windows.Forms.CheckBox();
            this.VlajnostCheckBox = new System.Windows.Forms.CheckBox();
            this.PulsCheckBox = new System.Windows.Forms.CheckBox();
            this.ProvodimostCheckBox = new System.Windows.Forms.CheckBox();
            this.TemperaturaCheckBox = new System.Windows.Forms.CheckBox();
            this.StartExamButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WorkComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(32, 371);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(95, 30);
            this.ReturnButton.TabIndex = 8;
            this.ReturnButton.Text = "Вернуться";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // SetLabel
            // 
            this.SetLabel.AutoSize = true;
            this.SetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetLabel.Location = new System.Drawing.Point(32, 36);
            this.SetLabel.Name = "SetLabel";
            this.SetLabel.Size = new System.Drawing.Size(382, 24);
            this.SetLabel.TabIndex = 9;
            this.SetLabel.Text = "Выберите устанавливаемые датчики:";
            this.SetLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // SetWorkloadLabel
            // 
            this.SetWorkloadLabel.AutoSize = true;
            this.SetWorkloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetWorkloadLabel.Location = new System.Drawing.Point(28, 159);
            this.SetWorkloadLabel.Name = "SetWorkloadLabel";
            this.SetWorkloadLabel.Size = new System.Drawing.Size(206, 24);
            this.SetWorkloadLabel.TabIndex = 15;
            this.SetWorkloadLabel.Text = "Выберите нагрузку:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(28, 262);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(165, 24);
            this.DateLabel.TabIndex = 17;
            this.DateLabel.Text = "Выберите дату:";
            // 
            // DavlenieСheckBox
            // 
            this.DavlenieСheckBox.AutoSize = true;
            this.DavlenieСheckBox.Location = new System.Drawing.Point(535, 189);
            this.DavlenieСheckBox.Name = "DavlenieСheckBox";
            this.DavlenieСheckBox.Size = new System.Drawing.Size(74, 17);
            this.DavlenieСheckBox.TabIndex = 19;
            this.DavlenieСheckBox.Text = "давления";
            this.DavlenieСheckBox.UseVisualStyleBackColor = true;
            // 
            // VlajnostCheckBox
            // 
            this.VlajnostCheckBox.AutoSize = true;
            this.VlajnostCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.VlajnostCheckBox.Location = new System.Drawing.Point(535, 76);
            this.VlajnostCheckBox.Name = "VlajnostCheckBox";
            this.VlajnostCheckBox.Size = new System.Drawing.Size(81, 17);
            this.VlajnostCheckBox.TabIndex = 20;
            this.VlajnostCheckBox.Text = "влажности";
            this.VlajnostCheckBox.UseVisualStyleBackColor = true;
            // 
            // PulsCheckBox
            // 
            this.PulsCheckBox.AutoSize = true;
            this.PulsCheckBox.Location = new System.Drawing.Point(535, 43);
            this.PulsCheckBox.Name = "PulsCheckBox";
            this.PulsCheckBox.Size = new System.Drawing.Size(61, 17);
            this.PulsCheckBox.TabIndex = 21;
            this.PulsCheckBox.Text = "пульса";
            this.PulsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProvodimostCheckBox
            // 
            this.ProvodimostCheckBox.AutoSize = true;
            this.ProvodimostCheckBox.Location = new System.Drawing.Point(535, 113);
            this.ProvodimostCheckBox.Name = "ProvodimostCheckBox";
            this.ProvodimostCheckBox.Size = new System.Drawing.Size(99, 17);
            this.ProvodimostCheckBox.TabIndex = 22;
            this.ProvodimostCheckBox.Text = "проводимости";
            this.ProvodimostCheckBox.UseVisualStyleBackColor = true;
            // 
            // TemperaturaCheckBox
            // 
            this.TemperaturaCheckBox.AutoSize = true;
            this.TemperaturaCheckBox.Location = new System.Drawing.Point(535, 148);
            this.TemperaturaCheckBox.Name = "TemperaturaCheckBox";
            this.TemperaturaCheckBox.Size = new System.Drawing.Size(93, 17);
            this.TemperaturaCheckBox.TabIndex = 23;
            this.TemperaturaCheckBox.Text = "температуры";
            this.TemperaturaCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartExamButton
            // 
            this.StartExamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartExamButton.Location = new System.Drawing.Point(449, 371);
            this.StartExamButton.Name = "StartExamButton";
            this.StartExamButton.Size = new System.Drawing.Size(185, 30);
            this.StartExamButton.TabIndex = 24;
            this.StartExamButton.Text = "Начать обследование";
            this.StartExamButton.UseVisualStyleBackColor = true;
            this.StartExamButton.Click += new System.EventHandler(this.StartExamButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(26, 99);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(133, 31);
            this.NameLabel.TabIndex = 25;
            this.NameLabel.Text = "пациент:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(165, 101);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(297, 29);
            this.NameTextBox.TabIndex = 26;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(36, 305);
            this.dateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 27;
            // 
            // WorkComboBox
            // 
            this.WorkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkComboBox.FormattingEnabled = true;
            this.WorkComboBox.Items.AddRange(new object[] {
            "бег",
            "ходьба",
            "велосипед",
            "силовые упражнения",
            "приседания"});
            this.WorkComboBox.Location = new System.Drawing.Point(36, 205);
            this.WorkComboBox.Name = "WorkComboBox";
            this.WorkComboBox.Size = new System.Drawing.Size(325, 21);
            this.WorkComboBox.TabIndex = 28;
            // 
            // StartExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.WorkComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.StartExamButton);
            this.Controls.Add(this.TemperaturaCheckBox);
            this.Controls.Add(this.ProvodimostCheckBox);
            this.Controls.Add(this.PulsCheckBox);
            this.Controls.Add(this.VlajnostCheckBox);
            this.Controls.Add(this.DavlenieСheckBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SetWorkloadLabel);
            this.Controls.Add(this.SetLabel);
            this.Controls.Add(this.ReturnButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StartExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация обследавания";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label SetLabel;
        private System.Windows.Forms.Label SetWorkloadLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.CheckBox DavlenieСheckBox;
        private System.Windows.Forms.CheckBox VlajnostCheckBox;
        private System.Windows.Forms.CheckBox PulsCheckBox;
        private System.Windows.Forms.CheckBox ProvodimostCheckBox;
        private System.Windows.Forms.CheckBox TemperaturaCheckBox;
        private System.Windows.Forms.Button StartExamButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox WorkComboBox;
    }
}