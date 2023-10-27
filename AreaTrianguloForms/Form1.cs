using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Tentar executar o código: 
            try
            {
                // Declarar as variáveis que irão receber os valores dos textboxes: 
                double b, height, result;

                // Obter os valores dos textboxes:
                b = double.Parse(txtBase.Text);
                height = double.Parse(txtHeight.Text);

                // Programar o cálculo da área do triângulo:
                result = (b * height) / 2;

                // Obter o valor da área do triângulo: 
                txtResult.Text = result.ToString();
            }
            // Caso alguma situação quebre o código: 
            catch
            {
                MessageBox.Show("Dados inválidos informados!");
                // Limpar os txbs:
                txtResult.Clear();
                txtBase.Clear();
                txtHeight.Clear();
            }
        }
    }
}
