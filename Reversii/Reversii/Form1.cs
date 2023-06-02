using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversii
{
    public partial class Form1 : Form
    {
        Start start = new Start();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount= 8;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        Image Back = Image.FromFile("E.bmp");

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = start.fieldFill()[i,j];
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            start.fieldFill(e.RowIndex, e.ColumnIndex);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = start.fieldFill()[i, j];
                }
            }

        }
    }
}
