using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetracker
{
    public partial class MainForm : Form
    {
        static string pathToDB = AppDomain.CurrentDomain.BaseDirectory + "\\documents.mdb";
        public string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + pathToDB;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DocumentsDataGrid.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Удалить запись?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = DocumentsDataGrid.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(DocumentsDataGrid[0, index].Value);
                    DeleteDocument(id);
                    ShowDocuments();
                }
            }
            else
                MessageBox.Show("Не выбрана запись для удаления!", "Ошибка!", MessageBoxButtons.OK);
        }

        private void DeleteDocument(int id)
        {
            string commandText = "DELETE FROM documents WHERE ID=" + Convert.ToString(id);
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ShowDocuments()
        {
            string commandText = "SELECT ID,fullname,birthdate,organization,document,receiptdate,enddate,IIF(DATEDIFF('d',DATE(),enddate)>=0, DATEDIFF('d',DATE(),enddate),0) as days FROM documents ORDER BY receiptdate,fullname";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "documents");
            DocumentsDataGrid.DataSource = dataset.Tables["documents"].DefaultView;
            DocumentsDataGrid.Columns["ID"].Visible = false;
            DocumentsDataGrid.Columns["fullname"].Width = 250;
            DocumentsDataGrid.Columns["fullname"].HeaderText = "ФИО";
            DocumentsDataGrid.Columns["birthdate"].Width = 90;
            DocumentsDataGrid.Columns["birthdate"].HeaderText = "Дата рождения";
            DocumentsDataGrid.Columns["organization"].Width = 170;
            DocumentsDataGrid.Columns["organization"].HeaderText = "Организация";
            DocumentsDataGrid.Columns["document"].Width = 100;
            DocumentsDataGrid.Columns["document"].HeaderText = "№ документа";
            DocumentsDataGrid.Columns["receiptdate"].Width = 95;
            DocumentsDataGrid.Columns["receiptdate"].HeaderText = "Дата поступления";
            DocumentsDataGrid.Columns["enddate"].Width = 95;
            DocumentsDataGrid.Columns["enddate"].HeaderText = "Дата завершения";
            DocumentsDataGrid.Columns["days"].Width = 70;
            DocumentsDataGrid.Columns["days"].HeaderText = "Дней осталось";
            ColourGrid();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowDocuments();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDocumentForm addForm = new AddDocumentForm { connectionString = this.connectionString};
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
                ShowDocuments();
        }

        private void ProlongButton_Click(object sender, EventArgs e)
        {
            if (DocumentsDataGrid.CurrentCell != null)
            {
                int index = DocumentsDataGrid.CurrentCell.RowIndex;
                int id = Convert.ToInt32(DocumentsDataGrid[0,index].Value);
                DateTime endDate = Convert.ToDateTime(DocumentsDataGrid[6,index].Value);
                ProlongForm prolongForm = new ProlongForm();
                prolongForm.EndDateLabel.Text = endDate.ToShortDateString();
                prolongForm.ShowDialog();
                if (prolongForm.DialogResult == DialogResult.OK)
                {
                    endDate = prolongForm.NewEndDatePicker.Value.Date;
                    ProlongDocument(id, endDate);
                    ShowDocuments();
                }
            }
            else
                MessageBox.Show("Не выбран документ для продления!", "Ошибка!", MessageBoxButtons.OK);
        }

        private void ProlongDocument(int documentId, DateTime newDate)
        {
            string commandText = "UPDATE documents SET enddate='" + Convert.ToString(newDate) + "' WHERE ID=" + Convert.ToString(documentId);
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ColourGrid()
        { 
            for (int i=0;i<DocumentsDataGrid.RowCount;i++)
            {
                int days = Convert.ToInt32(DocumentsDataGrid[7, i].Value);
                if (days ==0)
                    DocumentsDataGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
