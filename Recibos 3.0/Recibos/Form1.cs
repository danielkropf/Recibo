using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add(object sender, EventArgs e)
        {
            textBox1.AutoCompleteCustomSource.Add(textBox1.Text);
        }

        private void remove(object sender, EventArgs e)
        {
            textBox1.AutoCompleteCustomSource.Remove(textBox1.Text);
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
            descricao.Text = "";
            valor.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 127 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void add2(object sender, EventArgs e)
        {
            descricao.AutoCompleteCustomSource.Add(descricao.Text);
        }

        private void remove2(object sender, EventArgs e)
        {
            descricao.AutoCompleteCustomSource.Remove(descricao.Text);
        }            
    }
}
