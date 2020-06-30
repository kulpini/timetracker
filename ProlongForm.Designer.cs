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
            this.NewEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.ProlongButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewEndDatePicker
            // 
            this.NewEndDatePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewEndDatePicker.Location = new System.Drawing.Point(252, 60);
            this.NewEndDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.NewEndDatePicker.Name = "NewEndDatePicker";
            this.NewEndDatePicker.Size = new System.Drawing.Size(151, 26);
            this.NewEndDatePicker.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Продлить документ до даты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Текущая дата завершения: ";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EndDateLabel.Location = new System.Drawing.Point(248, 19);
            this.EndDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(155, 19);
            this.EndDateLabel.TabIndex = 19;
            this.EndDateLabel.Text = "01.01.2020";
            this.EndDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProlongButton
            // 
            this.ProlongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProlongButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProlongButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.ProlongButton.Location = new System.Drawing.Point(27, 106);
            this.ProlongButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProlongButton.Name = "ProlongButton";
            this.ProlongButton.Size = new System.Drawing.Size(158, 36);
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
            this.CancelButton.Location = new System.Drawing.Point(245, 106);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(158, 36);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProlongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 157);
            this.Controls.Add(this.ProlongButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.NewEndDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProlongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Продление даты завершения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker NewEndDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Button ProlongButton;
        private System.Windows.Forms.Button CancelButton;
    }
}