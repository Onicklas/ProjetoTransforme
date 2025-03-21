using System;
<<<<<<< HEAD
using System.Runtime.InteropServices;
=======
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
>>>>>>> bba9dfae79ec3a7c6369ce07296ddf9471969a87
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LojahAbc
{
    public partial class frmfuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
<<<<<<< HEAD

=======
>>>>>>> bba9dfae79ec3a7c6369ce07296ddf9471969a87
        public frmfuncionarios()
        {
            InitializeComponent();
            //desabilitar os campos
            DesabilitarCampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmfuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios pesquisa = new frmPesquisarFuncionarios();
            pesquisa.ShowDialog();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal prinprin = new frmMenuPrincipal();
            prinprin.Show();
            this.Hide();
        }
        //desabilitando os componentes
        public void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtCodigo.Enabled = false;
            mskCPF.Enabled = false;
            dtpDataNascimento.Enabled = false;
            mskCelular.Enabled = false;
            gpbGenero.Enabled = false;

            mskCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtEstado.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            cbbUF.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }
        public void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCodigo.Clear();
            mskCPF.Clear();
            dtpDataNascimento.Text = "";
            mskCelular.Clear();

            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;
            rbtOutro.Checked = false;

            mskCEP.Clear();
            txtLogradouro.Clear();
            txtComplemento.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            cbbUF.Text = "";

        }
        public void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtCodigo.Enabled = true;
            mskCPF.Enabled = true;
            dtpDataNascimento.Enabled = true;
            mskCelular.Enabled = true;
            gpbGenero.Enabled = true;

            mskCEP.Enabled = true;
            txtLogradouro.Enabled = true;
            txtComplemento.Enabled = true;
            txtEstado.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            cbbUF.Enabled = true;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            bntNovo.Enabled = false;
            txtNome.Focus();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") ||
                txtEmail.Text.Equals("") ||
                mskCPF.Text.Equals("   .   .   -") ||
                mskCelular.Text.Equals("     -") ||
                txtLogradouro.Text.Equals("") ||
                txtComplemento.Text.Equals("") ||
                mskCEP.Text.Equals("     -") ||
                txtEstado.Text.Equals("") ||
                txtCidade.Text.Equals("") ||
                txtNumero.Text.Equals("") ||
                cbbUF.Text.Equals(""))
            {
                MessageBox.Show("Preencha os campos.");
            }
            else
            {
                MessageBox.Show("cadastro com sucesso!");
                LimparCampos();
                DesabilitarCampos();
                bntNovo.Enabled = true;
                bntNovo.Focus();
            }
        }
    }

}

