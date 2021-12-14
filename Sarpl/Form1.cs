using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Sarpl
{
    public partial class Form1 : Form
    {
        private String dbFileName = "data.db";
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;

        private Form2 form2;
        private Form3 form3;
        public Form1()
        {
            InitializeComponent();
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();
            form2 = new Form2();
            form2.Setform1(this);
            form3 = new Form3(this);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3.Show();
            Hide();
        }
    }
}
