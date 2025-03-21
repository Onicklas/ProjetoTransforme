using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculadora
{
    public partial class calculadora : Form
    {
//Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public calculadora()
        {
            InitializeComponent();
        }
        
        public void Limparcampos()
        {
            txt_num1.Clear();
            txt_num2.Clear();
            rdb_somar.Checked = false;
            rdb_subtrair.Checked = false;
            rdb_multiplicar.Checked = false;
            rbd_dividir.Checked = false;
            txt_num1.Focus();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_saor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limparcampos();

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt__TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
