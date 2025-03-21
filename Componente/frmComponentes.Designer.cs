namespace Componente
{
    partial class frmComponentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.pcb_gif = new System.Windows.Forms.PictureBox();
            this.gpb_lala = new System.Windows.Forms.GroupBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbx_listarnomes = new System.Windows.Forms.ListBox();
            this.lbl_listarnome = new System.Windows.Forms.Label();
            this.lbl_Listarnomes = new System.Windows.Forms.Label();
            this.cbb_listarnomes = new System.Windows.Forms.ComboBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_escolha = new System.Windows.Forms.Label();
            this.ckb_livros = new System.Windows.Forms.CheckBox();
            this.ckb_computador = new System.Windows.Forms.CheckBox();
            this.ckb_mesa = new System.Windows.Forms.CheckBox();
            this.ckb_banana = new System.Windows.Forms.CheckBox();
            this.pcb_imagens = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_gif)).BeginInit();
            this.gpb_lala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagens)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_gif
            // 
            this.pcb_gif.Image = ((System.Drawing.Image)(resources.GetObject("pcb_gif.Image")));
            this.pcb_gif.Location = new System.Drawing.Point(233, 12);
            this.pcb_gif.Name = "pcb_gif";
            this.pcb_gif.Size = new System.Drawing.Size(295, 153);
            this.pcb_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_gif.TabIndex = 1;
            this.pcb_gif.TabStop = false;
            // 
            // gpb_lala
            // 
            this.gpb_lala.Controls.Add(this.pcb_imagens);
            this.gpb_lala.Controls.Add(this.ckb_banana);
            this.gpb_lala.Controls.Add(this.ckb_mesa);
            this.gpb_lala.Controls.Add(this.ckb_computador);
            this.gpb_lala.Controls.Add(this.ckb_livros);
            this.gpb_lala.Controls.Add(this.lbl_escolha);
            this.gpb_lala.Controls.Add(this.txt_nome);
            this.gpb_lala.Controls.Add(this.cbb_listarnomes);
            this.gpb_lala.Controls.Add(this.lbl_Listarnomes);
            this.gpb_lala.Controls.Add(this.lbl_listarnome);
            this.gpb_lala.Controls.Add(this.lbx_listarnomes);
            this.gpb_lala.Controls.Add(this.lbl_nome);
            this.gpb_lala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_lala.Location = new System.Drawing.Point(12, 171);
            this.gpb_lala.Name = "gpb_lala";
            this.gpb_lala.Size = new System.Drawing.Size(760, 378);
            this.gpb_lala.TabIndex = 0;
            this.gpb_lala.TabStop = false;
            this.gpb_lala.Text = "Componentes";
            this.gpb_lala.Enter += new System.EventHandler(this.gpb_lala_Enter);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(14, 30);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(51, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbx_listarnomes
            // 
            this.lbx_listarnomes.FormattingEnabled = true;
            this.lbx_listarnomes.ItemHeight = 20;
            this.lbx_listarnomes.Location = new System.Drawing.Point(18, 202);
            this.lbx_listarnomes.Name = "lbx_listarnomes";
            this.lbx_listarnomes.Size = new System.Drawing.Size(339, 124);
            this.lbx_listarnomes.TabIndex = 7;
            // 
            // lbl_listarnome
            // 
            this.lbl_listarnome.AutoSize = true;
            this.lbl_listarnome.Location = new System.Drawing.Point(14, 172);
            this.lbl_listarnome.Name = "lbl_listarnome";
            this.lbl_listarnome.Size = new System.Drawing.Size(86, 20);
            this.lbl_listarnome.TabIndex = 2;
            this.lbl_listarnome.Text = "listar nome";
            // 
            // lbl_Listarnomes
            // 
            this.lbl_Listarnomes.AutoSize = true;
            this.lbl_Listarnomes.Location = new System.Drawing.Point(14, 78);
            this.lbl_Listarnomes.Name = "lbl_Listarnomes";
            this.lbl_Listarnomes.Size = new System.Drawing.Size(100, 20);
            this.lbl_Listarnomes.TabIndex = 3;
            this.lbl_Listarnomes.Text = "Listar nomes";
            // 
            // cbb_listarnomes
            // 
            this.cbb_listarnomes.FormattingEnabled = true;
            this.cbb_listarnomes.Location = new System.Drawing.Point(120, 75);
            this.cbb_listarnomes.Name = "cbb_listarnomes";
            this.cbb_listarnomes.Size = new System.Drawing.Size(121, 28);
            this.cbb_listarnomes.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(71, 30);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(286, 26);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nome_KeyDown);
            // 
            // lbl_escolha
            // 
            this.lbl_escolha.AutoSize = true;
            this.lbl_escolha.Location = new System.Drawing.Point(406, 36);
            this.lbl_escolha.Name = "lbl_escolha";
            this.lbl_escolha.Size = new System.Drawing.Size(66, 20);
            this.lbl_escolha.TabIndex = 6;
            this.lbl_escolha.Text = "Escolha";
            // 
            // ckb_livros
            // 
            this.ckb_livros.AutoSize = true;
            this.ckb_livros.Location = new System.Drawing.Point(410, 59);
            this.ckb_livros.Name = "ckb_livros";
            this.ckb_livros.Size = new System.Drawing.Size(69, 24);
            this.ckb_livros.TabIndex = 3;
            this.ckb_livros.Text = "Livros";
            this.ckb_livros.UseVisualStyleBackColor = true;
            this.ckb_livros.CheckedChanged += new System.EventHandler(this.ckb_livros_CheckedChanged);
            // 
            // ckb_computador
            // 
            this.ckb_computador.AutoSize = true;
            this.ckb_computador.Location = new System.Drawing.Point(410, 89);
            this.ckb_computador.Name = "ckb_computador";
            this.ckb_computador.Size = new System.Drawing.Size(116, 24);
            this.ckb_computador.TabIndex = 4;
            this.ckb_computador.Text = "Computador";
            this.ckb_computador.UseVisualStyleBackColor = true;
            this.ckb_computador.CheckedChanged += new System.EventHandler(this.ckb_computador_CheckedChanged);
            // 
            // ckb_mesa
            // 
            this.ckb_mesa.AutoSize = true;
            this.ckb_mesa.Location = new System.Drawing.Point(410, 119);
            this.ckb_mesa.Name = "ckb_mesa";
            this.ckb_mesa.Size = new System.Drawing.Size(67, 24);
            this.ckb_mesa.TabIndex = 5;
            this.ckb_mesa.Text = "Mesa";
            this.ckb_mesa.UseVisualStyleBackColor = true;
            this.ckb_mesa.CheckedChanged += new System.EventHandler(this.ckb_mesa_CheckedChanged);
            // 
            // ckb_banana
            // 
            this.ckb_banana.AutoSize = true;
            this.ckb_banana.Location = new System.Drawing.Point(410, 149);
            this.ckb_banana.Name = "ckb_banana";
            this.ckb_banana.Size = new System.Drawing.Size(84, 24);
            this.ckb_banana.TabIndex = 6;
            this.ckb_banana.Text = "Banana";
            this.ckb_banana.UseVisualStyleBackColor = true;
            this.ckb_banana.CheckedChanged += new System.EventHandler(this.ckb_banana_CheckedChanged);
            // 
            // pcb_imagens
            // 
            this.pcb_imagens.Location = new System.Drawing.Point(405, 197);
            this.pcb_imagens.Name = "pcb_imagens";
            this.pcb_imagens.Size = new System.Drawing.Size(321, 128);
            this.pcb_imagens.TabIndex = 8;
            this.pcb_imagens.TabStop = false;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpb_lala);
            this.Controls.Add(this.pcb_gif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.Text = "Componentes";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_gif)).EndInit();
            this.gpb_lala.ResumeLayout(false);
            this.gpb_lala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_gif;
        private System.Windows.Forms.GroupBox gpb_lala;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cbb_listarnomes;
        private System.Windows.Forms.Label lbl_Listarnomes;
        private System.Windows.Forms.Label lbl_listarnome;
        private System.Windows.Forms.ListBox lbx_listarnomes;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.CheckBox ckb_mesa;
        private System.Windows.Forms.CheckBox ckb_computador;
        private System.Windows.Forms.CheckBox ckb_livros;
        private System.Windows.Forms.Label lbl_escolha;
        private System.Windows.Forms.CheckBox ckb_banana;
        private System.Windows.Forms.PictureBox pcb_imagens;
    }
}