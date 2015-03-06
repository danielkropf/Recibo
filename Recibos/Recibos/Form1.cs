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
        AutoCompleteStringCollection source;
        public Form1()
        {
            InitializeComponent();

            // Create the list to use as the custom source.  
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(new string[]
                    {
                        "January",
                        "February",
                        "March",
                        "April",
                        "May",
                        "June",
                        "July",
                        "August",
                        "September",
                        "October",
                        "November",
                        "December"
                    });

            // Create and initialize the text box. 
            var textBox = new TextBox
            {
                AutoCompleteCustomSource = source,
                AutoCompleteMode =
                    AutoCompleteMode.SuggestAppend,
                AutoCompleteSource =
                    AutoCompleteSource.CustomSource,
                Location = new Point(20, 20),
                Width = ClientRectangle.Width - 40,
                Visible = true
            };

            // Add the text box to the form.
            Controls.Add(textBox);
        }
        
        private void add(object sender, EventArgs e)
        {
            source.Add(adicionar.Text);
            adicionar.Text = "";
        }
    }
}
