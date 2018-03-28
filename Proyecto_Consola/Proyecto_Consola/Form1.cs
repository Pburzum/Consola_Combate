using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Consola
{
    public partial class Form1 : Form
    {

        private int exp;
        public Form1()
        {
            InitializeComponent();
            barraVida.Value = barraVida.Maximum;
            n_de_vida.Text = barraVida.Maximum.ToString();
            m_de_vida.Text = barraVida.Maximum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barraExp.Increment(10);
            exp = Int32.Parse(lbl_n_exp.Text);
            exp += 10;
            lbl_n_exp.Text = exp.ToString();
        }

        
    }
}
