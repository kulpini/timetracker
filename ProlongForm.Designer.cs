namespace timetracker
{
    partial class ProlongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProlongForm));
            this.NewEventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.ProlongButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewEventDatePicker
            // 
            this.NewEventDatePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewEventDatePicker.Location = new System.Drawing.Point(336, 74);
            this.NewEventDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewEventDatePicker.Name = "NewEventDatePicker";
            this.NewEventDatePicker.Size = new System.Drawing.Size(200, 30);
            this.NewEventDatePicker.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(31, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Перенести событие на дату";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Текущая дата события: ";
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventDateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EventDateLabel.Location = new System.Drawing.Point(331, 23);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(207, 23);
            this.EventDateLabel.TabIndex = 19;
            this.EventDateLabel.Text = "01.01.2020";
            this.EventDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProlongButton
            // 
            this.ProlongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProlongButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProlongButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.ProlongButton.Location = new System.Drawing.Point(36, 130);
            this.ProlongButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProlongButton.Name = "ProlongButton";
            this.ProlongButton.Size = new System.Drawing.Size(211, 44);
            this.ProlongButton.TabIndex = 21;
            this.ProlongButton.Text = "Продлить";
            this.ProlongButton.UseVisualStyleBackColor = true;
            this.ProlongButton.Click += new System.EventHandler(this.ProlongButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.CancelButton.Location = new System.Drawing.Point(327, 130);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(211, 44);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProlongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 193);
            this.Controls.Add(this.ProlongButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EventDateLabel);
            this.Controls.Add(this.NewEventDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProlongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Продление даты события";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker NewEventDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label EventDateLabel;
        private System.Windows.Forms.Button ProlongButton;
        private System.Windows.Forms.Button CancelButton;
    }
}