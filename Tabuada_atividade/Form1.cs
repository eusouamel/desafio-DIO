using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada_atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num, tab, cont;

            num = int.Parse(txtNumero.Text);

            for (cont = 1; cont <= 10; cont++)
            {
                tab = num * cont;
                lstTabuada.Items.Add(num + " X " + cont + " = " + tab);
            }
        }
    }
}
