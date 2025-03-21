namespace Calculadora
{
    partial class calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.gpb_operacoes = new System.Windows.Forms.GroupBox();
            this.rbd_dividir = new System.Windows.Forms.RadioButton();
            this.rdb_multiplicar = new System.Windows.Forms.RadioButton();
            this.rdb_subtrair = new System.Windows.Forms.RadioButton();
            this.rdb_somar = new System.Windows.Forms.RadioButton();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_saor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.gpb_operacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num1.Location = new System.Drawing.Point(34, 39);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(76, 20);
            this.lbl_num1.TabIndex = 0;
            this.lbl_num1.Text = "numero 1";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num2.Location = new System.Drawing.Point(33, 140);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(76, 20);
            this.lbl_num2.TabIndex = 1;
            this.lbl_num2.Text = "numero 2";
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num1.Location = new System.Drawing.Point(37, 89);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(97, 26);
            this.txt_num1.TabIndex = 2;
            this.txt_num1.TextChanged += new System.EventHandler(this.txt__TextChanged);
            // 
            // txt_num2
            // 
            this.txt_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num2.Location = new System.Drawing.Point(37, 188);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(97, 26);
            this.txt_num2.TabIndex = 3;
            this.txt_num2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gpb_operacoes
            // 
            this.gpb_operacoes.Controls.Add(this.rbd_dividir);
            this.gpb_operacoes.Controls.Add(this.rdb_multiplicar);
            this.gpb_operacoes.Controls.Add(this.rdb_subtrair);
            this.gpb_operacoes.Controls.Add(this.rdb_somar);
            this.gpb_operacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_operacoes.Location = new System.Drawing.Point(191, 35);
            this.gpb_operacoes.Name = "gpb_operacoes";
            this.gpb_operacoes.Size = new System.Drawing.Size(192, 276);
            this.gpb_operacoes.TabIndex = 4;
            this.gpb_operacoes.TabStop = false;
            this.gpb_operacoes.Text = "Operações";
            // 
            // rbd_dividir
            // 
            this.rbd_dividir.AutoSize = true;
            this.rbd_dividir.Location = new System.Drawing.Point(24, 227);
            this.rbd_dividir.Name = "rbd_dividir";
            this.rbd_dividir.Size = new System.Drawing.Size(69, 24);
            this.rbd_dividir.TabIndex = 3;
            this.rbd_dividir.TabStop = true;
            this.rbd_dividir.Text = "Dividir";
            this.rbd_dividir.UseVisualStyleBackColor = true;
            // 
            // rdb_multiplicar
            // 
            this.rdb_multiplicar.AutoSize = true;
            this.rdb_multiplicar.Location = new System.Drawing.Point(24, 169);
            this.rdb_multiplicar.Name = "rdb_multiplicar";
            this.rdb_multiplicar.Size = new System.Drawing.Size(97, 24);
            this.rdb_multiplicar.TabIndex = 2;
            this.rdb_multiplicar.TabStop = true;
            this.rdb_multiplicar.Text = "Multiplicar";
            this.rdb_multiplicar.UseVisualStyleBackColor = true;
            // 
            // rdb_subtrair
            // 
            this.rdb_subtrair.AutoSize = true;
            this.rdb_subtrair.Location = new System.Drawing.Point(24, 103);
            this.rdb_subtrair.Name = "rdb_subtrair";
            this.rdb_subtrair.Size = new System.Drawing.Size(83, 24);
            this.rdb_subtrair.TabIndex = 1;
            this.rdb_subtrair.TabStop = true;
            this.rdb_subtrair.Text = "Subtrair";
            this.rdb_subtrair.UseVisualStyleBackColor = true;
            // 
            // rdb_somar
            // 
            this.rdb_somar.AutoSize = true;
            this.rdb_somar.Location = new System.Drawing.Point(24, 45);
            this.rdb_somar.Name = "rdb_somar";
            this.rdb_somar.Size = new System.Drawing.Size(74, 24);
            this.rdb_somar.TabIndex = 0;
            this.rdb_somar.TabStop = true;
            this.rdb_somar.Text = "Somar";
            this.rdb_somar.UseVisualStyleBackColor = true;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Image = ((System.Drawing.Image)(resources.GetObject("btn_calcular.Image")));
            this.btn_calcular.Location = new System.Drawing.Point(456, 32);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(89, 72);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.Image")));
            this.btn_Limpar.Location = new System.Drawing.Point(456, 138);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(89, 66);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_saor
            // 
            this.btn_saor.Image = ((System.Drawing.Image)(resources.GetObject("btn_saor.Image")));
            this.btn_saor.Location = new System.Drawing.Point(456, 238);
            this.btn_saor.Name = "btn_saor";
            this.btn_saor.Size = new System.Drawing.Size(89, 73);
            this.btn_saor.TabIndex = 7;
            this.btn_saor.UseVisualStyleBackColor = true;
            this.btn_saor.Click += new System.EventHandler(this.btn_saor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(34, 244);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(82, 20);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.Text = "Resultado";
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 358);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_saor);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.gpb_operacoes);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.MaximizeBox = false;
            this.Name = "calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpb_operacoes.ResumeLayout(false);
            this.gpb_operacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.GroupBox gpb_operacoes;
        private System.Windows.Forms.RadioButton rbd_dividir;
        private System.Windows.Forms.RadioButton rdb_multiplicar;
        private System.Windows.Forms.RadioButton rdb_subtrair;
        private System.Windows.Forms.RadioButton rdb_somar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_saor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

