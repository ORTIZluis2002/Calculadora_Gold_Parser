using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.goldparser;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        MyParser parser;
        public Form1()
        {
            parser = new MyParser(Application.StartupPath + "\\calculadora.cgt");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser.Parse(textEntrada.Text);
            textResultado.Text = parser.resultado;
        }

        private void textEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
