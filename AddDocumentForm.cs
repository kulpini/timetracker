using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetracker
{
    public partial class AddDocumentForm : Form
    {
        public string connectionString;
        public AddDocumentForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FullnameTextBox.Text == "")
                MessageBox.Show("Не заданы ФИО!", "Ошибка!", MessageBoxButtons.OK);
            else if (OrganizationTextBox.Text == "")
                MessageBox.Show("Не задано название органа", "Ошибка!", MessageBoxButtons.OK);
            else
            {
                DateTime startDate = ReceiptDatePicker.Value;
                DateTime endDate = EndDatePicker.Value;
                int days = (endDate - startDate).Days;
                if (days < 0)
                    MessageBox.Show("Дата завершения не может быть ранее Даты поступления!", "Ошибка!", MessageBoxButtons.OK);
                else
                {
                    AddDocument();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void AddDocumentForm_Load(object sender, EventArgs e)
        {
            BirthDatePicker.Format = DateTimePickerFormat.Custom;
            BirthDatePicker.CustomFormat = " ";
        }

        private void AddDocument()
        {
            string commandText;
            string fullname = FullnameTextBox.Text;
            string organization = OrganizationTextBox.Text;
            string document = DocumentTextBox.Text;
            string startDate = Convert.ToString(ReceiptDatePicker.Value.Date);
            string endDate = Convert.ToString(EndDatePicker.Value.Date);
            if (BirthDatePicker.Format == DateTimePickerFormat.Custom)
            {
                commandText = "INSERT INTO documents (fullname,organization,document,receiptdate,enddate) VALUES ('";
                commandText += fullname+"','"+organization+"','"+document+"','"+startDate+"','"+endDate+"')";
            }
            else
            {
                string birthDate = Convert.ToString(BirthDatePicker.Value.Date);
                commandText = "INSERT INTO documents (fullname,birthdate,organization,document,receiptdate,enddate) VALUES ('";
                commandText += fullname + "','" +birthDate + "','" + organization + "','" +document+"','"+ startDate + "','" + endDate + "')";
            }
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BirthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            BirthDatePicker.Format = DateTimePickerFormat.Long;
        }
    }
}
