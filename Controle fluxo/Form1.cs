using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_fluxo
{
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
            Desabilitarcampos();
            Carregarcombo();
        }
             
        public double salariofolha, impostoderenda, salarioliquido = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btt_limpar_Click(object sender, EventArgs e)
        {
            Limparcampos();
        }
        private void Limparcampos()
        {
            txt_salario.Clear();
            cbb_clubedelazer.Text = "";
            txt_salariofolha.Clear();
            txt_salarioliquido.Clear();
            ckb_planodesaude.Checked = false;
        }
        private void Desabilitarcampos()
        {
            txt_salariofolha.Enabled = false;
            txt_impostoderenda.Enabled = false;
            txt_salarioliquido.Enabled = false;
        }
        public void Carregarcombo()
        {
            cbb_clubedelazer.Items.Add("Clube A");
            cbb_clubedelazer.Items.Add("Clube B");
            cbb_clubedelazer.Items.Add("Clube C");
        }

        private void txt_dotadafolha_TextChanged(object sender, EventArgs e)
        {
            txt_salariofolha.Text = txt_salario.Text.Trim();
        }

        private void btt_calcular_Click(object sender, EventArgs e)
        {
            double salariofolha, impostoderenda, salarioliquido = 0;

            salariofolha = Convert.ToDouble(txt_salariofolha);
            impostoderenda = Convert.ToDouble(txt_impostoderenda);
            salarioliquido = Convert.ToDouble(txt_salarioliquido);
            
            salarioliquido= salariofolha - impostoderenda;

            if(salariofolha < 2259.20)
            {
                salarioliquido = 0;
            }
            else if (salariofolha >= 2259.21 && salariofolha <= 2826.65)
            {
                salarioliquido = salariofolha - (salariofolha * 7.5 / 100);
            }
            else if (salariofolha >= 2826.66 && salariofolha <= 3751.05)
            {
                salarioliquido = salariofolha - (salariofolha * 15 / 100);
            }
            else if (salariofolha >= 3751.06 && salariofolha <= 4664.68)
            {
                salarioliquido = salariofolha - (salariofolha * 22.5 / 100);
            }
            else if (salariofolha >= 4664.69)
            {
                salarioliquido = salariofolha - (salariofolha * 27.5 / 100);
            }
            txt_salarioliquido.Text = Convert.ToString(salarioliquido);

        }
        public double Salario
        private void ckb_planodesaude_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_planodesaude.Checked)
            {
                txt_salariofolha = txt_salariofolha - 200;
                txt_salarioliquido.Text = txt_salariofolha.ToString();
            }
            else
            {

            }
        }
    }
}
