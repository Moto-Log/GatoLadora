using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora;

namespace Calculadora
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
            txtOperando.Focus();
            txtOperando.Enabled = true;
        }


        Memento memento = new ConcreteMemento();

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora(txtOperando.Text, lblOp.Text, txtOperador.Text);//será sempre necessario instanciar novos objetos, para~não envia-los com a mesma assinatura para a pilha e alterar todos os dados;
            memento.Salvar(calculadora);
            try
            {
                txtResultado.Text = Convert.ToString(calculadora.calcular(Convert.ToDouble(txtOperando.Text), Convert.ToDouble(txtOperador.Text), lblOp.Text));
                txtOperando.Clear();
                txtOperando.Focus();
                btnRefazer.Enabled = false;
                btnDesfazer.Enabled = true;
                txtOperador.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Reveja seus conceitos", "MIAU!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); 
            }
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtOperador.Enabled = true;
            txtOperador.Focus();
            txtOperador.Clear();
            lblOp.Text = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtOperador.Enabled = true;
            txtOperador.Focus();
            txtOperador.Clear();
            lblOp.Text = "-";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            txtOperador.Enabled = true;
            txtOperador.Focus();
            txtOperador.Clear();
            lblOp.Text = "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtOperador.Enabled = true;
            txtOperador.Focus();
            txtOperador.Clear();
            lblOp.Text = "/";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "1";
            }
            else
            {
                txtOperando.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "2";
            }
            else
            {
                txtOperando.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "3";
            }
            else
            {
                txtOperando.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "4";
            }
            else
            {
                txtOperando.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "5";
            }
            else
            {
                txtOperando.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "6";
            }
            else
            {
                txtOperando.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "7";
            }
            else
            {
                txtOperando.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "8";
            }
            else
            {
                txtOperando.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "9";
            }
            else
            {
                txtOperando.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += "0";
            }
            else
            {
                txtOperando.Text += "0";
            }
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            if (txtOperador.Enabled)
            {
                txtOperador.Text += ",";
            }
            else
            {
                txtOperando.Text += ",";
            }
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora("","","");//sempre instanciamos novos objetos pra não modificar a pilha inteira
            calculadora = memento.desfazer();
            if (calculadora == null)
            {
                btnDesfazer.Enabled = false;
            }
            else
            {
                btnRefazer.Enabled = true;
                txtOperador.Text = calculadora.operador;
                lblOp.Text = calculadora.operacao;
                txtOperando.Text = calculadora.operando;
            }
        }

        private void btnRefazer_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora("", "", "");//sempre instanciamos novos objetos pra não modificar a pilha inteira
            calculadora = memento.refazer();
            if (calculadora == null)
            {
                btnRefazer.Enabled = false;
            }
            else
            {
                txtOperador.Text = calculadora.operador;
                lblOp.Text = calculadora.operacao;
                txtOperando.Text = calculadora.operando;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOperador.Clear();
            txtOperando.Clear();
            lblOp.Text = "";
            txtResultado.Clear();
        }
    }
}
