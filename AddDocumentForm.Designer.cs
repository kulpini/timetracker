namespace timetracker
{
    partial class AddDocumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDocumentForm));
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FullnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrganizationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DocumentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReceiptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.CancelButton.Location = new System.Drawing.Point(412, 280);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(158, 36);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddButton.Location = new System.Drawing.Point(94, 280);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(158, 36);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // FullnameTextBox
            // 
            this.FullnameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullnameTextBox.Location = new System.Drawing.Point(80, 21);
            this.FullnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FullnameTextBox.Name = "FullnameTextBox";
            this.FullnameTextBox.Size = new System.Drawing.Size(559, 26);
            this.FullnameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(22, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата поступления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата рождения";
            // 
            // OrganizationTextBox
            // 
            this.OrganizationTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrganizationTextBox.Location = new System.Drawing.Point(159, 102);
            this.OrganizationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrganizationTextBox.Name = "OrganizationTextBox";
            this.OrganizationTextBox.Size = new System.Drawing.Size(480, 26);
            this.OrganizationTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(22, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название органа";
            // 
            // DocumentTextBox
            // 
            this.DocumentTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentTextBox.Location = new System.Drawing.Point(159, 143);
            this.DocumentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DocumentTextBox.Name = "DocumentTextBox";
            this.DocumentTextBox.Size = new System.Drawing.Size(318, 26);
            this.DocumentTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(22, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер документа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(22, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата завершения";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDatePicker.Location = new System.Drawing.Point(159, 59);
            this.BirthDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(151, 26);
            this.BirthDatePicker.TabIndex = 15;
            this.BirthDatePicker.ValueChanged += new System.EventHandler(this.BirthDatePicker_ValueChanged);
            // 
            // ReceiptDatePicker
            // 
            this.ReceiptDatePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReceiptDatePicker.Location = new System.Drawing.Point(159, 181);
            this.ReceiptDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReceiptDatePicker.Name = "ReceiptDatePicker";
            this.ReceiptDatePicker.Size = new System.Drawing.Size(151, 26);
            this.ReceiptDatePicker.TabIndex = 16;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDatePicker.Location = new System.Drawing.Point(159, 222);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(151, 26);
            this.EndDatePicker.TabIndex = 17;
            // 
            // AddDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 336);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.ReceiptDatePicker);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DocumentTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrganizationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullnameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление нового документа";
            this.Load += new System.EventHandler(this.AddDocumentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrganizationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DocumentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.DateTimePicker ReceiptDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
    }
}