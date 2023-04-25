using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FmInicio : Form
    {
        public FmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            float numero;
            bool ehNumerico1 = float.TryParse(textBoxBase.Text, out numero);
            bool ehNumerico2 = float.TryParse(textBoxAltura.Text, out numero);

            if ((textBoxBase.Text != "") && (textBoxAltura.Text != "") && ehNumerico1 && ehNumerico2)
            {
                float res = float.Parse(textBoxBase.Text) * float.Parse(textBoxAltura.Text) / 2;
                textBoxArea.Text = res.ToString();
                labelMsg.Text = "Feito com sucesso!";
            }else if((textBoxBase.Text != "") || (textBoxAltura.Text != ""))
            {
                labelMsg.Text = "Digite valores numéricos!";
            }
            else
            {
                labelMsg.Text = "Digite valores de base e altura!";
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxBase.Text = null;
            textBoxAltura.Text = null;
            textBoxArea.Text= null;
            labelMsg.Text = null;
        }
    }
}
