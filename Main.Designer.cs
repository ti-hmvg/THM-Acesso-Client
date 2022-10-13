namespace THM_Acesso
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureFotoPerfil = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblOcupacoes = new System.Windows.Forms.Label();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.TimerVerifyFinger = new System.Windows.Forms.Timer(this.components);
            this.lbl_msg = new System.Windows.Forms.Label();
            this.PrintEtiqueta = new System.Drawing.Printing.PrintDocument();
            this.dataGridHistorico = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnPrestador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFotoPerfil
            // 
            this.pictureFotoPerfil.Location = new System.Drawing.Point(127, 92);
            this.pictureFotoPerfil.Name = "pictureFotoPerfil";
            this.pictureFotoPerfil.Size = new System.Drawing.Size(231, 248);
            this.pictureFotoPerfil.TabIndex = 2;
            this.pictureFotoPerfil.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Nascimento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ocupações:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Observações:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(145, 449);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(327, 24);
            this.lblObservacoes.TabIndex = 16;
            this.lblObservacoes.Text = "teste nome";
            this.lblObservacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOcupacoes
            // 
            this.lblOcupacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacoes.Location = new System.Drawing.Point(131, 425);
            this.lblOcupacoes.Name = "lblOcupacoes";
            this.lblOcupacoes.Size = new System.Drawing.Size(341, 24);
            this.lblOcupacoes.TabIndex = 17;
            this.lblOcupacoes.Text = "teste nome";
            this.lblOcupacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNascimento.Location = new System.Drawing.Point(202, 401);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(270, 24);
            this.lblDtNascimento.TabIndex = 18;
            this.lblDtNascimento.Text = "teste nome";
            this.lblDtNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCPF
            // 
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(70, 377);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(402, 24);
            this.lblCPF.TabIndex = 19;
            this.lblCPF.Text = "teste nome";
            this.lblCPF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(85, 353);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(387, 24);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "teste nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerVerifyFinger
            // 
            this.TimerVerifyFinger.Enabled = true;
            this.TimerVerifyFinger.Interval = 300;
            this.TimerVerifyFinger.Tick += new System.EventHandler(this.TimerVerifyFinger_Tick);
            // 
            // lbl_msg
            // 
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.Location = new System.Drawing.Point(12, 9);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(460, 80);
            this.lbl_msg.TabIndex = 21;
            this.lbl_msg.Text = "label7aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaa";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_msg.TextChanged += new System.EventHandler(this.lbl_msg_TextChanged);
            // 
            // dataGridHistorico
            // 
            this.dataGridHistorico.AllowUserToAddRows = false;
            this.dataGridHistorico.AllowUserToDeleteRows = false;
            this.dataGridHistorico.AllowUserToResizeColumns = false;
            this.dataGridHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnCPF,
            this.ColumnAcao,
            this.ColumnImprimir,
            this.ColumnPrestador});
            this.dataGridHistorico.Location = new System.Drawing.Point(12, 476);
            this.dataGridHistorico.MultiSelect = false;
            this.dataGridHistorico.Name = "dataGridHistorico";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridHistorico.Size = new System.Drawing.Size(460, 134);
            this.dataGridHistorico.TabIndex = 23;
            this.dataGridHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistorico_CellClick);
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.Name = "ColumnCPF";
            // 
            // ColumnAcao
            // 
            this.ColumnAcao.HeaderText = "Ação";
            this.ColumnAcao.Name = "ColumnAcao";
            this.ColumnAcao.ReadOnly = true;
            // 
            // ColumnImprimir
            // 
            this.ColumnImprimir.HeaderText = "Imprimir";
            this.ColumnImprimir.Name = "ColumnImprimir";
            this.ColumnImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnImprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnPrestador
            // 
            this.ColumnPrestador.HeaderText = "Prestador";
            this.ColumnPrestador.Name = "ColumnPrestador";
            this.ColumnPrestador.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.dataGridHistorico);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblDtNascimento);
            this.Controls.Add(this.lblOcupacoes);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureFotoPerfil);
            this.Name = "Main";
            this.Text = "THM-Acesso";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureFotoPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblOcupacoes;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbl_msg;
        public System.Windows.Forms.Timer TimerVerifyFinger;
        private System.Drawing.Printing.PrintDocument PrintEtiqueta;
        private System.Windows.Forms.DataGridView dataGridHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAcao;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnImprimir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPrestador;
    }
}

