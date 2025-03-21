
namespace LojahAbc
{
    partial class frmfuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfuncionarios));
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtOutro = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDatadeNascimento = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlbotao = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.bntNovo = new System.Windows.Forms.Button();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gpbGenero.SuspendLayout();
            this.pnlbotao.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbDadosPessoais.Controls.Add(this.pictureBox3);
            this.gpbDadosPessoais.Controls.Add(this.mskCelular);
            this.gpbDadosPessoais.Controls.Add(this.lblCelular);
            this.gpbDadosPessoais.Controls.Add(this.gpbGenero);
            this.gpbDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblDatadeNascimento);
            this.gpbDadosPessoais.Controls.Add(this.mskCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.txtCodigo);
            this.gpbDadosPessoais.Controls.Add(this.lblCodigo);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(5, 13);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(774, 264);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            this.gpbDadosPessoais.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(628, 129);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(526, 77);
            this.mskCelular.Mask = "99999-9999";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(96, 26);
            this.mskCelular.TabIndex = 6;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(451, 80);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(62, 20);
            this.lblCelular.TabIndex = 15;
            this.lblCelular.Text = "Celular:";
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.rbtFeminino);
            this.gpbGenero.Controls.Add(this.rbtOutro);
            this.gpbGenero.Controls.Add(this.rbtMasculino);
            this.gpbGenero.Location = new System.Drawing.Point(10, 120);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(130, 117);
            this.gpbGenero.TabIndex = 7;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Gênero:";
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(12, 25);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(92, 24);
            this.rbtFeminino.TabIndex = 8;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtOutro
            // 
            this.rbtOutro.AutoSize = true;
            this.rbtOutro.Location = new System.Drawing.Point(12, 85);
            this.rbtOutro.Name = "rbtOutro";
            this.rbtOutro.Size = new System.Drawing.Size(67, 24);
            this.rbtOutro.TabIndex = 10;
            this.rbtOutro.TabStop = true;
            this.rbtOutro.Text = "Outro";
            this.rbtOutro.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(12, 55);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbtMasculino.TabIndex = 9;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(333, 77);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(103, 26);
            this.dtpDataNascimento.TabIndex = 5;
            this.dtpDataNascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDatadeNascimento
            // 
            this.lblDatadeNascimento.AutoSize = true;
            this.lblDatadeNascimento.Location = new System.Drawing.Point(199, 80);
            this.lblDatadeNascimento.Name = "lblDatadeNascimento";
            this.lblDatadeNascimento.Size = new System.Drawing.Size(128, 20);
            this.lblDatadeNascimento.TabIndex = 8;
            this.lblDatadeNascimento.Text = "Data Nacimento:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(64, 77);
            this.mskCPF.Mask = "999,999,999-90";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(120, 26);
            this.mskCPF.TabIndex = 4;
            this.mskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 80);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 20);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(486, 32);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(423, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(207, 32);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(146, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(64, 32);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // pnlbotao
            // 
            this.pnlbotao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlbotao.Controls.Add(this.btnVoltar);
            this.pnlbotao.Controls.Add(this.btnPesquisar);
            this.pnlbotao.Controls.Add(this.btnLimpar);
            this.pnlbotao.Controls.Add(this.btnExcluir);
            this.pnlbotao.Controls.Add(this.btnAlterar);
            this.pnlbotao.Controls.Add(this.btnCadastrar);
            this.pnlbotao.Controls.Add(this.bntNovo);
            this.pnlbotao.Location = new System.Drawing.Point(5, 514);
            this.pnlbotao.Name = "pnlbotao";
            this.pnlbotao.Size = new System.Drawing.Size(774, 40);
            this.pnlbotao.TabIndex = 19;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(668, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 34);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(562, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 34);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "   &Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(451, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 34);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(340, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 34);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(229, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 34);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(118, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 34);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "  &Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // bntNovo
            // 
            this.bntNovo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntNovo.Image = ((System.Drawing.Image)(resources.GetObject("bntNovo.Image")));
            this.bntNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntNovo.Location = new System.Drawing.Point(7, 3);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(105, 34);
            this.bntNovo.TabIndex = 20;
            this.bntNovo.Text = "&Novo";
            this.bntNovo.UseVisualStyleBackColor = false;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbEndereco.Controls.Add(this.pictureBox2);
            this.gpbEndereco.Controls.Add(this.lblUF);
            this.gpbEndereco.Controls.Add(this.cbbUF);
            this.gpbEndereco.Controls.Add(this.txtEstado);
            this.gpbEndereco.Controls.Add(this.lblEstado);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.lblCidade);
            this.gpbEndereco.Controls.Add(this.txtComplemento);
            this.gpbEndereco.Controls.Add(this.lblComplemento);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.lblNumero);
            this.gpbEndereco.Controls.Add(this.mskCEP);
            this.gpbEndereco.Controls.Add(this.lblCEP);
            this.gpbEndereco.Controls.Add(this.txtLogradouro);
            this.gpbEndereco.Controls.Add(this.lblLogradouro);
            this.gpbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(8, 282);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(774, 234);
            this.gpbEndereco.TabIndex = 11;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            this.gpbEndereco.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(625, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(12, 109);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(35, 20);
            this.lblUF.TabIndex = 27;
            this.lblUF.Text = "UF:";
            // 
            // cbbUF
            // 
            this.cbbUF.FormattingEnabled = true;
            this.cbbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbUF.Location = new System.Drawing.Point(53, 106);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(84, 28);
            this.cbbUF.TabIndex = 18;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(218, 67);
            this.txtEstado.MaxLength = 10;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(124, 26);
            this.txtEstado.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(152, 70);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(424, 67);
            this.txtCidade.MaxLength = 10;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(124, 26);
            this.txtCidade.TabIndex = 16;
            this.txtCidade.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(358, 70);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 22;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(483, 32);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(263, 26);
            this.txtComplemento.TabIndex = 13;
            this.txtComplemento.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(366, 38);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 20);
            this.lblComplemento.TabIndex = 20;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(647, 67);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(99, 26);
            this.txtNumero.TabIndex = 17;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(555, 70);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(69, 20);
            this.lblNumero.TabIndex = 18;
            this.lblNumero.Text = "Número:";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(53, 67);
            this.mskCEP.Mask = "99999-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(84, 26);
            this.mskCEP.TabIndex = 14;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 70);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 20);
            this.lblCEP.TabIndex = 4;
            this.lblCEP.Text = "CEP:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(98, 35);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(263, 26);
            this.txtLogradouro.TabIndex = 12;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 38);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(95, 20);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // frmfuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.pnlbotao);
            this.Controls.Add(this.gpbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmfuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaABC - Funcionários";
            this.Load += new System.EventHandler(this.frmfuncionarios_Load);
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.pnlbotao.ResumeLayout(false);
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.Panel pnlbotao;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDatadeNascimento;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtOutro;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}