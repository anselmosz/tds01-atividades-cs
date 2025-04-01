using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_De_Pagamento
{
    public partial class frmFolhaDePagamento : Form
    {
        public frmFolhaDePagamento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, impostoDeRenda;

            salario = 0;
            impostoDeRenda = 0;

            try
            {
                salario = Convert.ToDouble(txtbSalarioInput.Text);

                if (ckbPlanoDeSaude.Checked == true)
                {
                    salario = salario - 400;
                }

                if (cmbClubes.SelectedIndex == 1)
                {
                    salario = salario - 100;
                }
                if (cmbClubes.SelectedIndex == 2)
                {
                    salario = salario - 50;
                }
                if (cmbClubes.SelectedIndex == 3)
                {
                    salario = salario - 30;
                }

                if (salario < 2259.21)
                {
                    impostoDeRenda = 0;
                }
                else
                {
                    if (salario > 2259.20 && salario < 2826.66)
                    {
                        impostoDeRenda = (salario / 100) * 7.5;
                    }
                    if (salario > 2826.65 && salario < 3751.06)
                    {
                        impostoDeRenda = (salario / 100) * 15;
                    }
                    if (salario > 3751.05 && salario < 4664.69)
                    {
                        impostoDeRenda = (salario / 100) * 22.5;
                    }
                    if (salario > 4664.68)
                    {
                        impostoDeRenda = (salario / 100) * 27.5;
                    }
                }

                txtbImpostoDeRenda.Text = impostoDeRenda.ToString();
                salario = salario - impostoDeRenda;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir apenas valores válidos!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtbSalarioInput.Clear();
                txtbSalarioInput.Focus();
                txtbImpostoDeRenda.Clear();
                txtbSalarioBruto.Clear();
                txtbSalarioLiq.Clear();
                ckbPlanoDeSaude.Checked = false;
                cmbClubes.SelectedIndex = 0;
            }

            txtbSalarioLiq.Text = Convert.ToString(salario);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbSalarioInput.Clear();
            txtbSalarioInput.Focus();
            txtbImpostoDeRenda.Clear();
            txtbSalarioBruto.Clear();
            txtbSalarioLiq.Clear();
            ckbPlanoDeSaude.Checked = false;
            cmbClubes.SelectedIndex = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbSalarioInput_TextChanged(object sender, EventArgs e)
        {
            txtbSalarioBruto.Text = txtbSalarioInput.Text;
        }
    }
}
