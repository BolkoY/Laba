namespace тренажер
{
    partial class List
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
            this.ListPanel = new System.Windows.Forms.Panel();
            this.ListLabel = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ListPanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListPanel
            // 
            this.ListPanel.Controls.Add(this.ListLabel);
            this.ListPanel.Controls.Add(this.ListBox);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListPanel.Location = new System.Drawing.Point(0, 0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(664, 325);
            this.ListPanel.TabIndex = 0;
            this.ListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ListPanel_Paint);
            // 
            // ListLabel
            // 
            this.ListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListLabel.Location = new System.Drawing.Point(0, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(664, 45);
            this.ListLabel.TabIndex = 1;
            this.ListLabel.Text = "Список пациентов";
            this.ListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBox
            // 
            this.ListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(0, 48);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(664, 277);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.UpdateButton);
            this.AddPanel.Controls.Add(this.ReturnButton);
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddPanel.Location = new System.Drawing.Point(0, 331);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(664, 100);
            this.AddPanel.TabIndex = 1;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(24, 25);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(95, 30);
            this.ReturnButton.TabIndex = 8;
            this.ReturnButton.Text = "Вернуться";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(260, 11);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(145, 59);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Дабавить пациента";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(533, 25);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(95, 30);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.ListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список пациентов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.List_FormClosed);
            this.Load += new System.EventHandler(this.List_Load);
            this.ListPanel.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}