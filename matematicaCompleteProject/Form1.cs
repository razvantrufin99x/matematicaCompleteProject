using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace matematicaCompleteProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            numarnatural a = new numarnatural();
            a.valoare = 10;
            numarnatural b = new numarnatural();
            b.valoare = 20;
            numarnatural c = new numarnatural();
            c.valoare = a.adunare(b.valoare);
            Text = c.valoare.ToString();

        }
    }
}
