namespace Controle_fluxo
{
    partial class frmFluxoCaixa
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
            this.lbl_data = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.ckb_planodesaude = new System.Windows.Forms.CheckBox();
            this.lbl_lazer = new System.Windows.Forms.Label();
            this.txt_salariofolha = new System.Windows.Forms.TextBox();
            this.txt_impostoderenda = new System.Windows.Forms.TextBox();
            this.txt_salarioliquido = new System.Windows.Forms.TextBox();
            this.lblsalariofolha = new System.Windows.Forms.Label();
            this.lbl_impostoderenda = new System.Windows.Forms.Label();
            this.lbl_salarioliquido = new System.Windows.Forms.Label();
            this.cbb_clubedelazer = new System.Windows.Forms.ComboBox();
            this.btt_calcular = new System.Windows.Forms.Button();
            this.btt_limpar = new System.Windows.Forms.Button();
            this.btt_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(62, 66);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(85, 16);
            this.lbl_data.TabIndex = 0;
            this.lbl_data.Text = "data da folha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario.Location = new System.Drawing.Point(62, 141);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(85, 16);
            this.lbl_salario.TabIndex = 2;
            this.lbl_salario.Text = "data da folha";
            // 
            // txt_salario
            // 
            this.txt_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salario.Location = new System.Drawing.Point(62, 171);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(209, 22);
            this.txt_salario.TabIndex = 3;
            this.txt_salario.TextChanged += new System.EventHandler(this.txt_dotadafolha_TextChanged);
            // 
            // ckb_planodesaude
            // 
            this.ckb_planodesaude.AutoSize = true;
            this.ckb_planodesaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_planodesaude.Location = new System.Drawing.Point(65, 216);
            this.ckb_planodesaude.Name = "ckb_planodesaude";
            this.ckb_planodesaude.Size = new System.Drawing.Size(121, 20);
            this.ckb_planodesaude.TabIndex = 4;
            this.ckb_planodesaude.Text = "Plano de saúde";
            this.ckb_planodesaude.UseVisualStyleBackColor = true;
            this.ckb_planodesaude.CheckedChanged += new System.EventHandler(this.ckb_planodesaude_CheckedChanged);
            // 
            // lbl_lazer
            // 
            this.lbl_lazer.AutoSize = true;
            this.lbl_lazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lazer.Location = new System.Drawing.Point(62, 283);
            this.lbl_lazer.Name = "lbl_lazer";
            this.lbl_lazer.Size = new System.Drawing.Size(93, 16);
            this.lbl_lazer.TabIndex = 5;
            this.lbl_lazer.Text = "Clube de lazer";
            this.lbl_lazer.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_salariofolha
            // 
            this.txt_salariofolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salariofolha.Location = new System.Drawing.Point(541, 92);
            this.txt_salariofolha.Name = "txt_salariofolha";
            this.txt_salariofolha.Size = new System.Drawing.Size(163, 22);
            this.txt_salariofolha.TabIndex = 6;
            // 
            // txt_impostoderenda
            // 
            this.txt_impostoderenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_impostoderenda.Location = new System.Drawing.Point(541, 158);
            this.txt_impostoderenda.Name = "txt_impostoderenda";
            this.txt_impostoderenda.Size = new System.Drawing.Size(163, 22);
            this.txt_impostoderenda.TabIndex = 7;
            // 
            // txt_salarioliquido
            // 
            this.txt_salarioliquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salarioliquido.Location = new System.Drawing.Point(541, 253);
            this.txt_salarioliquido.Name = "txt_salarioliquido";
            this.txt_salarioliquido.Size = new System.Drawing.Size(163, 22);
            this.txt_salarioliquido.TabIndex = 8;
            // 
            // lblsalariofolha
            // 
            this.lblsalariofolha.AutoSize = true;
            this.lblsalariofolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalariofolha.Location = new System.Drawing.Point(429, 95);
            this.lblsalariofolha.Name = "lblsalariofolha";
            this.lblsalariofolha.Size = new System.Drawing.Size(82, 16);
            this.lblsalariofolha.TabIndex = 9;
            this.lblsalariofolha.Text = "Salário folha";
            // 
            // lbl_impostoderenda
            // 
            this.lbl_impostoderenda.AutoSize = true;
            this.lbl_impostoderenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_impostoderenda.Location = new System.Drawing.Point(429, 165);
            this.lbl_impostoderenda.Name = "lbl_impostoderenda";
            this.lbl_impostoderenda.Size = new System.Drawing.Size(112, 16);
            this.lbl_impostoderenda.TabIndex = 10;
            this.lbl_impostoderenda.Text = "Imposto de renda";
            // 
            // lbl_salarioliquido
            // 
            this.lbl_salarioliquido.AutoSize = true;
            this.lbl_salarioliquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salarioliquido.Location = new System.Drawing.Point(446, 260);
            this.lbl_salarioliquido.Name = "lbl_salarioliquido";
            this.lbl_salarioliquido.Size = new System.Drawing.Size(93, 16);
            this.lbl_salarioliquido.TabIndex = 11;
            this.lbl_salarioliquido.Text = "Salário liquido";
            // 
            // cbb_clubedelazer
            // 
            this.cbb_clubedelazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_clubedelazer.FormattingEnabled = true;
            this.cbb_clubedelazer.Location = new System.Drawing.Point(62, 331);
            this.cbb_clubedelazer.Name = "cbb_clubedelazer";
            this.cbb_clubedelazer.Size = new System.Drawing.Size(149, 24);
            this.cbb_clubedelazer.TabIndex = 12;
            // 
            // btt_calcular
            // 
            this.btt_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_calcular.Location = new System.Drawing.Point(495, 305);
            this.btt_calcular.Name = "btt_calcular";
            this.btt_calcular.Size = new System.Drawing.Size(175, 29);
            this.btt_calcular.TabIndex = 13;
            this.btt_calcular.Text = "Calcular";
            this.btt_calcular.UseVisualStyleBackColor = true;
            this.btt_calcular.Click += new System.EventHandler(this.btt_calcular_Click);
            // 
            // btt_limpar
            // 
            this.btt_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_limpar.Location = new System.Drawing.Point(495, 340);
            this.btt_limpar.Name = "btt_limpar";
            this.btt_limpar.Size = new System.Drawing.Size(175, 29);
            this.btt_limpar.TabIndex = 14;
            this.btt_limpar.Text = "Limpar";
            this.btt_limpar.UseVisualStyleBackColor = true;
            this.btt_limpar.Click += new System.EventHandler(this.btt_limpar_Click);
            // 
            // btt_sair
            // 
            this.btt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_sair.Location = new System.Drawing.Point(495, 375);
            this.btt_sair.Name = "btt_sair";
            this.btt_sair.Size = new System.Drawing.Size(175, 29);
            this.btt_sair.TabIndex = 15;
            this.btt_sair.Text = "Sair";
            this.btt_sair.UseVisualStyleBackColor = true;
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btt_sair);
            this.Controls.Add(this.btt_limpar);
            this.Controls.Add(this.btt_calcular);
            this.Controls.Add(this.cbb_clubedelazer);
            this.Controls.Add(this.lbl_salarioliquido);
            this.Controls.Add(this.lbl_impostoderenda);
            this.Controls.Add(this.lblsalariofolha);
            this.Controls.Add(this.txt_salarioliquido);
            this.Controls.Add(this.txt_impostoderenda);
            this.Controls.Add(this.txt_salariofolha);
            this.Controls.Add(this.lbl_lazer);
            this.Controls.Add(this.ckb_planodesaude);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_data);
            this.Name = "frmFluxoCaixa";
            this.Text = "Fluxo de caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.CheckBox ckb_planodesaude;
        private System.Windows.Forms.Label lbl_lazer;
        private System.Windows.Forms.TextBox txt_salariofolha;
        private System.Windows.Forms.TextBox txt_impostoderenda;
        private System.Windows.Forms.TextBox txt_salarioliquido;
        private System.Windows.Forms.Label lblsalariofolha;
        private System.Windows.Forms.Label lbl_impostoderenda;
        private System.Windows.Forms.Label lbl_salarioliquido;
        private System.Windows.Forms.ComboBox cbb_clubedelazer;
        private System.Windows.Forms.Button btt_calcular;
        private System.Windows.Forms.Button btt_limpar;
        private System.Windows.Forms.Button btt_sair;
    }
}

