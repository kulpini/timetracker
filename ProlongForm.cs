using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetracker
{
    public partial class ProlongForm : Form
    {
        public ProlongForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ProlongButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(EndDateLabel.Text);
            DateTime endDate = NewEndDatePicker.Value;
            if (endDate < startDate)
                MessageBox.Show("Новая дата завершения документа не может быть ранее предыдущей!", "Ошибка!", MessageBoxButtons.OK);
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
