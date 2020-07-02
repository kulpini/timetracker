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
            if (ThemeTextBox.Text == "")
                MessageBox.Show("Не задана тема!", "Ошибка!", MessageBoxButtons.OK);
            else if (OrganizationTextBox.Text == "")
                MessageBox.Show("Не задана организация!", "Ошибка!", MessageBoxButtons.OK);
            else
            {
                DateTime eventDate = EventDatePicker.Value;
                int days = (eventDate - DateTime.Today).Days;
                if (days < 0)
                    MessageBox.Show("Дата события не может быть ранее сегодняшней даты!", "Ошибка!", MessageBoxButtons.OK);                else
                {
                    AddDocument();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void AddDocument()
        {
            string commandText;
            string organization = OrganizationTextBox.Text;
            string theme = ThemeTextBox.Text;
            string eventDate = Convert.ToString(EventDatePicker.Value.Date);
            string location = LocationTextBox.Text;
            string participants = ParticipantsTextBox.Text;
            commandText = "INSERT INTO documents (eventdate,organization,theme,location,participants) VALUES ('";
            commandText += eventDate + "','" + organization + "','" + theme + "','" + location + "','" + participants + "')";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
