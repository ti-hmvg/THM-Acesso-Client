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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureFotoPerfil = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.TimerVerifyFinger = new System.Windows.Forms.Timer(this.components);
            this.lbl_msg = new System.Windows.Forms.Label();
            this.PrintEtiqueta = new System.Drawing.Printing.PrintDocument();
            this.dataGridHistorico = new System.Windows.Forms.DataGridView();
            this.ColumnHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnPrestador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImprime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkBoxPrestador = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // 
            // dataGridHistorico
            // 
            this.dataGridHistorico.AllowUserToAddRows = false;
            this.dataGridHistorico.AllowUserToDeleteRows = false;
            this.dataGridHistorico.AllowUserToResizeColumns = false;
            this.dataGridHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHorario,
            this.ColumnNome,
            this.ColumnCPF,
            this.ColumnAcao,
            this.ColumnImprimir,
            this.ColumnPrestador,
            this.DataNascimento,
            this.ColumnImprime});
            this.dataGridHistorico.Location = new System.Drawing.Point(12, 476);
            this.dataGridHistorico.MultiSelect = false;
            this.dataGridHistorico.Name = "dataGridHistorico";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridHistorico.RowHeadersVisible = false;
            this.dataGridHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridHistorico.Size = new System.Drawing.Size(460, 134);
            this.dataGridHistorico.TabIndex = 23;
            this.dataGridHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistorico_CellClick);
            // 
            // ColumnHorario
            // 
            this.ColumnHorario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnHorario.FillWeight = 233.7662F;
            this.ColumnHorario.HeaderText = "Horário";
            this.ColumnHorario.Name = "ColumnHorario";
            this.ColumnHorario.Width = 60;
            // 
            // ColumnNome
            // 
            this.ColumnNome.FillWeight = 33.11688F;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.Width = 75;
            // 
            // ColumnAcao
            // 
            this.ColumnAcao.FillWeight = 33.11688F;
            this.ColumnAcao.HeaderText = "Ação";
            this.ColumnAcao.Name = "ColumnAcao";
            this.ColumnAcao.ReadOnly = true;
            // 
            // ColumnImprimir
            // 
            this.ColumnImprimir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnImprimir.HeaderText = "Imprimir";
            this.ColumnImprimir.Image = global::THM_Acesso.Properties.Resources.printer;
            this.ColumnImprimir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnImprimir.Name = "ColumnImprimir";
            this.ColumnImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnImprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnImprimir.Width = 45;
            // 
            // ColumnPrestador
            // 
            this.ColumnPrestador.HeaderText = "Prestador";
            this.ColumnPrestador.Name = "ColumnPrestador";
            this.ColumnPrestador.Visible = false;
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            this.DataNascimento.Visible = false;
            // 
            // ColumnImprime
            // 
            this.ColumnImprime.HeaderText = "Imprime";
            this.ColumnImprime.Name = "ColumnImprime";
            this.ColumnImprime.ReadOnly = true;
            this.ColumnImprime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnImprime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnImprime.Visible = false;
            // 
            // checkBoxPrestador
            // 
            this.checkBoxPrestador.AutoSize = true;
            this.checkBoxPrestador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrestador.Location = new System.Drawing.Point(17, 428);
            this.checkBoxPrestador.Name = "checkBoxPrestador";
            this.checkBoxPrestador.Size = new System.Drawing.Size(219, 28);
            this.checkBoxPrestador.TabIndex = 24;
            this.checkBoxPrestador.Text = "É Prestador Visitando?";
            this.checkBoxPrestador.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Atualizar Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxPrestador);
            this.Controls.Add(this.dataGridHistorico);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblDtNascimento);
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
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbl_msg;
        public System.Windows.Forms.Timer TimerVerifyFinger;
        private System.Drawing.Printing.PrintDocument PrintEtiqueta;
        private System.Windows.Forms.DataGridView dataGridHistorico;
        private System.Windows.Forms.CheckBox checkBoxPrestador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAcao;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImprimir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPrestador;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnImprime;
        private System.Windows.Forms.Button button1;
    }
}
