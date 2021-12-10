namespace тренажер
{
    partial class Main
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
            this.ListButton = new System.Windows.Forms.Button();
            this.StartExamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListButton
            // 
            this.ListButton.Location = new System.Drawing.Point(97, 178);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(150, 60);
            this.ListButton.TabIndex = 0;
            this.ListButton.Text = "Список пациентов";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // StartExamButton
            // 
            this.StartExamButton.Location = new System.Drawing.Point(403, 178);
            this.StartExamButton.Name = "StartExamButton";
            this.StartExamButton.Size = new System.Drawing.Size(150, 60);
            this.StartExamButton.TabIndex = 1;
            this.StartExamButton.Text = "Начать обследование";
            this.StartExamButton.UseVisualStyleBackColor = true;
            this.StartExamButton.Click += new System.EventHandler(this.StartExamButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.StartExamButton);
            this.Controls.Add(this.ListButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Button StartExamButton;
    }
}