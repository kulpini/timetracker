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
        enum Operation
        { 
            Add,
            Delete
        }
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
                    GoToPreviousRow(index, Operation.Delete);
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
            string commandText = "SELECT ID,eventdate,organization,theme,location,participants,IIF(DATEDIFF('d',DATE(),eventdate)>=0, DATEDIFF('d',DATE(),eventdate),0) as days FROM documents ORDER BY eventdate,organization";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, connectionString);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "documents");
            DocumentsDataGrid.DataSource = dataset.Tables["documents"].DefaultView;
            DocumentsDataGrid.Columns["ID"].Visible = false;
            DocumentsDataGrid.Columns["eventdate"].Width = 95;
            DocumentsDataGrid.Columns["eventdate"].HeaderText = "Дата события";
            DocumentsDataGrid.Columns["organization"].Width = 170;
            DocumentsDataGrid.Columns["organization"].HeaderText = "Организация";
            DocumentsDataGrid.Columns["theme"].Width = 100;
            DocumentsDataGrid.Columns["theme"].HeaderText = "Тема";
            DocumentsDataGrid.Columns["location"].Width = 120;
            DocumentsDataGrid.Columns["location"].HeaderText = "Место проведения";
            DocumentsDataGrid.Columns["participants"].Width = 250;
            DocumentsDataGrid.Columns["participants"].HeaderText = "Участники";
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
            {
                int index = 0;
                if (DocumentsDataGrid.CurrentCell != null)
                    index = DocumentsDataGrid.CurrentCell.RowIndex;
                ShowDocuments();
                GoToPreviousRow(index, Operation.Add);
            }
        }

        private void ProlongButton_Click(object sender, EventArgs e)
        {
            if (DocumentsDataGrid.CurrentCell != null)
            {
                int index = DocumentsDataGrid.CurrentCell.RowIndex;
                int id = Convert.ToInt32(DocumentsDataGrid[0,index].Value);
                DateTime eventDate = Convert.ToDateTime(DocumentsDataGrid[1,index].Value);
                ProlongForm prolongForm = new ProlongForm();
                prolongForm.EventDateLabel.Text = eventDate.ToShortDateString();
                prolongForm.ShowDialog();
                if (prolongForm.DialogResult == DialogResult.OK)
                {
                    eventDate = prolongForm.NewEventDatePicker.Value.Date;
                    ProlongDocument(id, eventDate);
                    ShowDocuments();
                }
            }
            else
                MessageBox.Show("Не выбрано событие для продления!", "Ошибка!", MessageBoxButtons.OK);
        }

        private void ProlongDocument(int eventId, DateTime newDate)
        {
            string commandText = "UPDATE documents SET eventdate='" + Convert.ToString(newDate) + "' WHERE ID=" + Convert.ToString(eventId);
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
                int days = Convert.ToInt32(DocumentsDataGrid[6, i].Value);
                if (days ==0)
                    DocumentsDataGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void DocumentsDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ColourGrid();
        }

        private void GoToPreviousRow(int index,Operation operation)
        {
            if (operation == Operation.Add)
                DocumentsDataGrid.CurrentCell = DocumentsDataGrid.Rows[index].Cells[1];
            if (operation == Operation.Delete)
            {
                if (index == DocumentsDataGrid.RowCount)
                    DocumentsDataGrid.CurrentCell = DocumentsDataGrid.Rows[index-1].Cells[1];
                else
                    DocumentsDataGrid.CurrentCell = DocumentsDataGrid.Rows[index].Cells[1];
            }
        }
    }
}
