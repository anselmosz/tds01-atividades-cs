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
            double salarioBruto, impostoDeRenda, descontoClube, descontoPlanoDeSaude, salarioLiq;

            salarioBruto = 0;
            impostoDeRenda = 0;
            descontoClube = 0;
            descontoPlanoDeSaude = 0;

            try
            {
                salarioBruto = Convert.ToDouble(txtbSalarioInput.Text);

                if (salarioBruto < 2259.21)
                {
                    impostoDeRenda = 0;
                }
                else
                {
                    if (salarioBruto > 2259.20 && salarioBruto < 2826.66)
                    {
                        impostoDeRenda = (salarioBruto / 100) * 7.5;
                    }
                    if (salarioBruto > 2826.65 && salarioBruto < 3751.06)
                    {
                        impostoDeRenda = (salarioBruto / 100) * 15;
                    }
                    if (salarioBruto > 3751.05 && salarioBruto < 4664.69)
                    {
                        impostoDeRenda = (salarioBruto / 100) * 22.5;
                    }
                    if (salarioBruto > 4664.68)
                    {
                        impostoDeRenda = (salarioBruto / 100) * 27.5;
                    }
                }
                txtbImpostoDeRenda.Text = impostoDeRenda.ToString();

                if (ckbPlanoDeSaude.Checked == true)
                {
                    descontoPlanoDeSaude = 400;
                }

                if (cmbClubes.SelectedIndex == 1)
                {
                    descontoClube = 100;
                }
                if (cmbClubes.SelectedIndex == 2)
                {
                    descontoClube = 50;
                }
                if (cmbClubes.SelectedIndex == 3)
                {
                    descontoClube = 30;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir apenas valores válidos!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtbSalarioInput.Clear();
                txtbImpostoDeRenda.Clear();
                txtbSalarioBruto.Clear();
                txtbSalarioLiq.Clear();
                ckbPlanoDeSaude.Checked = false;
            }

            salarioLiq = salarioBruto - impostoDeRenda - descontoPlanoDeSaude - descontoClube;

            txtbSalarioLiq.Text = Convert.ToString(salarioLiq);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbSalarioInput.Clear();
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
    }
}
