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
            nomes = textBox1;
            descricoes = descricao;
        }
        public static TextBox nomes { get; set; }
        public static TextBox descricoes { get; set; }

        private void add(object sender, EventArgs e)
        {
            textBox1.AutoCompleteCustomSource.Add(textBox1.Text);
            Class1 classe1 = new Class1();
            Class2 classe2 = new Class2();
            classe1.addAluno();
            classe2.newArquivoAlunos();
            classe2.saveAlunos();
        }

        private void remove(object sender, EventArgs e)
        {
            textBox1.AutoCompleteCustomSource.Remove(textBox1.Text);
            Class1 classe1 = new Class1();
            Class2 classe2 = new Class2();
            classe1.removeAluno();
            classe2.newArquivoAlunos();
            classe2.saveAlunos();
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
            descricao.Text = "";
            valor.Text = "";
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
            Class1 classe1 = new Class1();
            classe1.addDescricao();
        }

        private void remove2(object sender, EventArgs e)
        {
            descricao.AutoCompleteCustomSource.Remove(descricao.Text);
            Class1 classe1 = new Class1();
            classe1.removeDescricao();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class2 classe2 = new Class2();
            classe2.loadAlunos();
        }            
    }
}
