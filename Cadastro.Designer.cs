﻿namespace THM_Acesso
{
    partial class Cadastro
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.btnCadastraImg = new System.Windows.Forms.Button();
            this.btnCadastraDigital = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbObs = new System.Windows.Forms.TextBox();
            this.lblStatusDigital = new System.Windows.Forms.Label();
            this.selectEmpresa = new System.Windows.Forms.ComboBox();
            this.selectOcupacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectMotivo = new System.Windows.Forms.ComboBox();
            this.checkDigital = new System.Windows.Forms.CheckBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fdImagem = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecionaImagem = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Observações:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Empresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome:";
            // 
            // imgPerfil
            // 
            this.imgPerfil.Location = new System.Drawing.Point(522, 12);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(150, 200);
            this.imgPerfil.TabIndex = 26;
            this.imgPerfil.TabStop = false;
            // 
            // btnCadastraImg
            // 
            this.btnCadastraImg.Location = new System.Drawing.Point(522, 218);
            this.btnCadastraImg.Name = "btnCadastraImg";
            this.btnCadastraImg.Size = new System.Drawing.Size(150, 29);
            this.btnCadastraImg.TabIndex = 27;
            this.btnCadastraImg.Text = "Cadastrar Foto";
            this.btnCadastraImg.UseVisualStyleBackColor = true;
            this.btnCadastraImg.Click += new System.EventHandler(this.btnCadastraImg_Click);
            // 
            // btnCadastraDigital
            // 
            this.btnCadastraDigital.Location = new System.Drawing.Point(12, 420);
            this.btnCadastraDigital.Name = "btnCadastraDigital";
            this.btnCadastraDigital.Size = new System.Drawing.Size(150, 29);
            this.btnCadastraDigital.TabIndex = 29;
            this.btnCadastraDigital.Text = "Cadastrar Digital";
            this.btnCadastraDigital.UseVisualStyleBackColor = true;
            this.btnCadastraDigital.Click += new System.EventHandler(this.btnCadastraDigital_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Status da Digital:";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(202, 60);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(252, 20);
            this.dtNascimento.TabIndex = 31;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(70, 10);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(384, 20);
            this.txbCPF.TabIndex = 32;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(85, 35);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(369, 20);
            this.txbNome.TabIndex = 33;
            // 
            // txbObs
            // 
            this.txbObs.Location = new System.Drawing.Point(145, 139);
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(309, 20);
            this.txbObs.TabIndex = 34;
            // 
            // lblStatusDigital
            // 
            this.lblStatusDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDigital.Location = new System.Drawing.Point(159, 393);
            this.lblStatusDigital.Name = "lblStatusDigital";
            this.lblStatusDigital.Size = new System.Drawing.Size(290, 24);
            this.lblStatusDigital.TabIndex = 35;
            this.lblStatusDigital.Text = "Não Registrada";
            // 
            // selectEmpresa
            // 
            this.selectEmpresa.FormattingEnabled = true;
            this.selectEmpresa.Location = new System.Drawing.Point(117, 168);
            this.selectEmpresa.Name = "selectEmpresa";
            this.selectEmpresa.Size = new System.Drawing.Size(337, 21);
            this.selectEmpresa.TabIndex = 36;
            // 
            // selectOcupacao
            // 
            this.selectOcupacao.FormattingEnabled = true;
            this.selectOcupacao.Location = new System.Drawing.Point(117, 194);
            this.selectOcupacao.Name = "selectOcupacao";
            this.selectOcupacao.Size = new System.Drawing.Size(337, 21);
            this.selectOcupacao.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ocupação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Motivo:";
            // 
            // selectMotivo
            // 
            this.selectMotivo.FormattingEnabled = true;
            this.selectMotivo.Location = new System.Drawing.Point(93, 220);
            this.selectMotivo.Name = "selectMotivo";
            this.selectMotivo.Size = new System.Drawing.Size(361, 21);
            this.selectMotivo.TabIndex = 40;
            // 
            // checkDigital
            // 
            this.checkDigital.AutoSize = true;
            this.checkDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkDigital.Location = new System.Drawing.Point(21, 242);
            this.checkDigital.Name = "checkDigital";
            this.checkDigital.Size = new System.Drawing.Size(180, 28);
            this.checkDigital.TabIndex = 41;
            this.checkDigital.Text = "Não Possui Digital";
            this.checkDigital.UseVisualStyleBackColor = true;
            this.checkDigital.CheckedChanged += new System.EventHandler(this.checkDigital_CheckedChanged);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(522, 420);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(149, 28);
            this.btnCadastro.TabIndex = 42;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(85, 113);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(369, 20);
            this.txbEmail.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Email:";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(113, 87);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(341, 20);
            this.txbTelefone.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Telefone:";
            // 
            // fdImagem
            // 
            this.fdImagem.FileName = "fdImagem";
            // 
            // btnSelecionaImagem
            // 
            this.btnSelecionaImagem.Location = new System.Drawing.Point(522, 254);
            this.btnSelecionaImagem.Name = "btnSelecionaImagem";
            this.btnSelecionaImagem.Size = new System.Drawing.Size(150, 29);
            this.btnSelecionaImagem.TabIndex = 47;
            this.btnSelecionaImagem.Text = "Selecionar Foto";
            this.btnSelecionaImagem.UseVisualStyleBackColor = true;
            this.btnSelecionaImagem.Click += new System.EventHandler(this.btnSelecionaImagem_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(85, 276);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(364, 20);
            this.txbSenha.TabIndex = 49;
            this.txbSenha.Visible = false;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(17, 272);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 24);
            this.lblSenha.TabIndex = 48;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Visible = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnSelecionaImagem);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.checkDigital);
            this.Controls.Add(this.selectMotivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectOcupacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectEmpresa);
            this.Controls.Add(this.lblStatusDigital);
            this.Controls.Add(this.txbObs);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastraDigital);
            this.Controls.Add(this.btnCadastraImg);
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Cadastro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Button btnCadastraImg;
        private System.Windows.Forms.Button btnCadastraDigital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbObs;
        private System.Windows.Forms.Label lblStatusDigital;
        private System.Windows.Forms.ComboBox selectEmpresa;
        private System.Windows.Forms.ComboBox selectOcupacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox selectMotivo;
        private System.Windows.Forms.CheckBox checkDigital;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog fdImagem;
        private System.Windows.Forms.Button btnSelecionaImagem;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
    }
}