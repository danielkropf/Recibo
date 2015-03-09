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
            textBox1.AutoCompleteCustomSource.Add(adicionar.Text);
            adicionar.Text = "";
        }

        private void remove(object sender, EventArgs e)
        {
            textBox1.AutoCompleteCustomSource.Remove(remover.Text);
            remover.Text = "";
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
            remover.Text = "";
            adicionar.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aqaqa(object sender, EventArgs e)
        {

        }            
    }
}
