using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_B11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daftar_bimbel_baruDataSet.pendaftaran' table. You can move, or remove it, as needed.
            this.pendaftaranTableAdapter.Fill(this.daftar_bimbel_baruDataSet.pendaftaran);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
