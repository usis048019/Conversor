using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversiones
{
    public partial class Form1 : Form
    {
        Class1  convertir= new Class1();

        public Form1()
        {
            InitializeComponent();
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboDeMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnMon_Click(object sender, EventArgs e)
        {
            lbl1.Text = Math.Round(convertir.convertir(double.Parse(txt1.Text), cboDe1.SelectedIndex, cboA1.SelectedIndex, 0), 2).ToString();
        }

        private void BtnLong_Click(object sender, EventArgs e)
        {
            lbl2.Text = Math.Round(convertir.convertir(double.Parse(txt2.Text), cboA2.SelectedIndex, cboDe2.SelectedIndex, 4),2).ToString();
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            lbl3.Text = Math.Round(convertir.convertir(double.Parse(txt3.Text), cboA3.SelectedIndex, cboDe3.SelectedIndex, 3),4).ToString();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            lbl4.Text = Math.Round(convertir.convertir(double.Parse(txt4.Text), cboA4.SelectedIndex, cboDe4.SelectedIndex, 1),10).ToString();
        }

        private void BtnAlmacenaje_Click(object sender, EventArgs e)
        {
            lbl5.Text = Math.Round(convertir.convertir(double.Parse(txt5.Text), cboA5.SelectedIndex, cboDe5.SelectedIndex, 4),10).ToString();
        }
    }
}
