using System;
using System.Windows.Forms;
<<<<<<< HEAD
//using System.Runtime.InteropServices;
=======
using System.Runtime.InteropServices;
>>>>>>> bba9dfae79ec3a7c6369ce07296ddf9471969a87

namespace LojahAbc
{
    public partial class frmPesquisarFuncionarios : Form
    {
<<<<<<< HEAD
        /*Criando variáveis para controle do menu
=======
        //Criando variáveis para controle do menu
>>>>>>> bba9dfae79ec3a7c6369ce07296ddf9471969a87
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
<<<<<<< HEAD
        */
=======
>>>>>>> bba9dfae79ec3a7c6369ce07296ddf9471969a87
        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            DesabilitarCampos();
        }
        public void DesabilitarCampos()
        {
            rbtCodigo.Checked = false;
            rbtnome.Checked = false;
            txtDescricao.Focus();
        }
        public void Limparcampos()
        {
            rbtCodigo.Checked = false;
            rbtnome.Checked = false;
            txtDescricao.Clear();
            txtDescricao.Focus();
            ltbpesquisar.Items.Clear();
        }

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            ltbpesquisar.Items.Clear();
            ltbpesquisar.Items.Add(txtDescricao.Text);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limparcampos
            Limparcampos();
        }

        private void ltbpesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPesquisarFuncionarios_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            /*IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            */
=======
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
>>>>>>> bba9dfae79ec3a7c6369ce07296ddf9471969a87
        }

        private void gpbPesquisarPor_Enter(object sender, EventArgs e)
        {

        }
    }
}
