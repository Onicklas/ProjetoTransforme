using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void gpb_lala_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_nome.Text.Equals(""))
            {
                MessageBox.Show("por favor inserir valoes válidos");
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbb_listarnomes.Items.Add(txt_nome.Text);
                    txt_nome.Focus();
                    txt_nome.Clear();
                }
            }
        }

        private void ckb_livros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_livros.Checked)
            {
                lbx_listarnomes.Items.Add("Livros");
            }
            else
            {
                lbx_listarnomes.Items.Remove("Livros");
            }
        }

        private void ckb_computador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_computador.Checked)
            {
                lbx_listarnomes.Items.Add("Computador");
            }
            else
            {
                lbx_listarnomes.Items.Remove("Computador");
            }
        }

        private void ckb_mesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_mesa.Checked)
            {
                lbx_listarnomes.Items.Add("Mesa");
            }
            else
            {
                lbx_listarnomes.Items.Remove("Mesa");
            }
        }

        private void ckb_banana_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_banana.Checked)
            {
                lbx_listarnomes.Items.Add("Banana");
            }
            else
            {
                lbx_listarnomes.Items.Remove("Banana");
            }
        }
    }
}
