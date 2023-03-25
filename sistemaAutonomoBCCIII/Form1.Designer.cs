namespace sistemaAutonomoBCCIII
{
    partial class ContainerInicial
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
            this.txtCartagena = new System.Windows.Forms.Label();
            this.listBoxPartidas = new System.Windows.Forms.ListBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtPirata = new System.Windows.Forms.TextBox();
            this.txtSenhaPirata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitterJogo = new System.Windows.Forms.Splitter();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGarrafa = new System.Windows.Forms.Label();
            this.lblCaveira = new System.Windows.Forms.Label();
            this.lblChave = new System.Windows.Forms.Label();
            this.lblPistola = new System.Windows.Forms.Label();
            this.lblFaca = new System.Windows.Forms.Label();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblTricornio = new System.Windows.Forms.Label();
            this.cartaTricornio = new System.Windows.Forms.PictureBox();
            this.cartaFaca = new System.Windows.Forms.PictureBox();
            this.cartaPistola = new System.Windows.Forms.PictureBox();
            this.cartaChave = new System.Windows.Forms.PictureBox();
            this.cartaEsqueleto = new System.Windows.Forms.PictureBox();
            this.cartaGarrafa = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartaTricornio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaFaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaPistola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaChave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaEsqueleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaGarrafa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCartagena
            // 
            this.txtCartagena.AutoSize = true;
            this.txtCartagena.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartagena.Location = new System.Drawing.Point(108, 9);
            this.txtCartagena.Name = "txtCartagena";
            this.txtCartagena.Size = new System.Drawing.Size(167, 45);
            this.txtCartagena.TabIndex = 0;
            this.txtCartagena.Text = "Cartagena";
            // 
            // listBoxPartidas
            // 
            this.listBoxPartidas.FormattingEnabled = true;
            this.listBoxPartidas.Location = new System.Drawing.Point(28, 94);
            this.listBoxPartidas.Name = "listBoxPartidas";
            this.listBoxPartidas.Size = new System.Drawing.Size(159, 199);
            this.listBoxPartidas.TabIndex = 1;
            this.listBoxPartidas.Click += new System.EventHandler(this.listBoxPartidas_Click);
            this.listBoxPartidas.SelectedIndexChanged += new System.EventHandler(this.listBoxPartidas_SelectedIndexChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.Location = new System.Drawing.Point(202, 191);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(194, 102);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtPirata
            // 
            this.txtPirata.Location = new System.Drawing.Point(202, 94);
            this.txtPirata.Multiline = true;
            this.txtPirata.Name = "txtPirata";
            this.txtPirata.Size = new System.Drawing.Size(194, 29);
            this.txtPirata.TabIndex = 3;
            // 
            // txtSenhaPirata
            // 
            this.txtSenhaPirata.Location = new System.Drawing.Point(202, 156);
            this.txtSenhaPirata.Multiline = true;
            this.txtSenhaPirata.Name = "txtSenhaPirata";
            this.txtSenhaPirata.Size = new System.Drawing.Size(194, 29);
            this.txtSenhaPirata.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Partidas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(198, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pirata :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(198, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha :";
            // 
            // splitterJogo
            // 
            this.splitterJogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitterJogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterJogo.Location = new System.Drawing.Point(589, 0);
            this.splitterJogo.Name = "splitterJogo";
            this.splitterJogo.Size = new System.Drawing.Size(570, 515);
            this.splitterJogo.TabIndex = 8;
            this.splitterJogo.TabStop = false;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.btnCriarPartida.Location = new System.Drawing.Point(202, 364);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(194, 115);
            this.btnCriarPartida.TabIndex = 9;
            this.btnCriarPartida.Text = "Criar";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha :";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(28, 447);
            this.txtSenhaPartida.Multiline = true;
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(159, 29);
            this.txtSenhaPartida.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome :";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(28, 388);
            this.txtNomePartida.Multiline = true;
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(159, 29);
            this.txtNomePartida.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 23.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(21, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 39);
            this.label6.TabIndex = 14;
            this.label6.Text = "Novo jogo :";
            // 
            // lblGarrafa
            // 
            this.lblGarrafa.AutoEllipsis = true;
            this.lblGarrafa.AutoSize = true;
            this.lblGarrafa.Location = new System.Drawing.Point(673, 382);
            this.lblGarrafa.Name = "lblGarrafa";
            this.lblGarrafa.Padding = new System.Windows.Forms.Padding(5);
            this.lblGarrafa.Size = new System.Drawing.Size(23, 23);
            this.lblGarrafa.TabIndex = 21;
            this.lblGarrafa.Text = "0";
            // 
            // lblCaveira
            // 
            this.lblCaveira.AutoEllipsis = true;
            this.lblCaveira.AutoSize = true;
            this.lblCaveira.Location = new System.Drawing.Point(760, 382);
            this.lblCaveira.Name = "lblCaveira";
            this.lblCaveira.Padding = new System.Windows.Forms.Padding(5);
            this.lblCaveira.Size = new System.Drawing.Size(23, 23);
            this.lblCaveira.TabIndex = 22;
            this.lblCaveira.Text = "0";
            // 
            // lblChave
            // 
            this.lblChave.AutoEllipsis = true;
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(850, 382);
            this.lblChave.Name = "lblChave";
            this.lblChave.Padding = new System.Windows.Forms.Padding(5);
            this.lblChave.Size = new System.Drawing.Size(23, 23);
            this.lblChave.TabIndex = 23;
            this.lblChave.Text = "0";
            // 
            // lblPistola
            // 
            this.lblPistola.AutoEllipsis = true;
            this.lblPistola.AutoSize = true;
            this.lblPistola.Location = new System.Drawing.Point(940, 382);
            this.lblPistola.Name = "lblPistola";
            this.lblPistola.Padding = new System.Windows.Forms.Padding(5);
            this.lblPistola.Size = new System.Drawing.Size(23, 23);
            this.lblPistola.TabIndex = 24;
            this.lblPistola.Text = "0";
            // 
            // lblFaca
            // 
            this.lblFaca.AutoEllipsis = true;
            this.lblFaca.AutoSize = true;
            this.lblFaca.Location = new System.Drawing.Point(1029, 382);
            this.lblFaca.Name = "lblFaca";
            this.lblFaca.Padding = new System.Windows.Forms.Padding(5);
            this.lblFaca.Size = new System.Drawing.Size(23, 23);
            this.lblFaca.TabIndex = 25;
            this.lblFaca.Text = "0";
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(414, 94);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(144, 199);
            this.listBoxPlayers.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 17F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(409, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 28);
            this.label13.TabIndex = 27;
            this.label13.Text = "Piratas Online :";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.lblSenha.Location = new System.Drawing.Point(281, 67);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(0, 24);
            this.lblSenha.TabIndex = 28;
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.btnIniciar.Location = new System.Drawing.Point(415, 364);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(143, 112);
            this.btnIniciar.TabIndex = 29;
            this.btnIniciar.Text = "Inciar";
            this.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(411, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Iniciar partida :";
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold);
            this.btnJogar.Location = new System.Drawing.Point(797, 331);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(330, 39);
            this.btnJogar.TabIndex = 31;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblTricornio
            // 
            this.lblTricornio.AutoEllipsis = true;
            this.lblTricornio.AutoSize = true;
            this.lblTricornio.Location = new System.Drawing.Point(1118, 382);
            this.lblTricornio.Name = "lblTricornio";
            this.lblTricornio.Padding = new System.Windows.Forms.Padding(5);
            this.lblTricornio.Size = new System.Drawing.Size(23, 23);
            this.lblTricornio.TabIndex = 33;
            this.lblTricornio.Text = "0";
            // 
            // cartaTricornio
            // 
            this.cartaTricornio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartaTricornio.ErrorImage = global::sistemaAutonomoBCCIII.Properties.Resources.cg_cardl__1_;
            this.cartaTricornio.Image = global::sistemaAutonomoBCCIII.Properties.Resources.cg_cardl__1_;
            this.cartaTricornio.Location = new System.Drawing.Point(1055, 388);
            this.cartaTricornio.Name = "cartaTricornio";
            this.cartaTricornio.Size = new System.Drawing.Size(72, 112);
            this.cartaTricornio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartaTricornio.TabIndex = 32;
            this.cartaTricornio.TabStop = false;
            this.cartaTricornio.Click += new System.EventHandler(this.cartaTricornio_Click);
            // 
            // cartaFaca
            // 
            this.cartaFaca.Image = global::sistemaAutonomoBCCIII.Properties.Resources.faca;
            this.cartaFaca.Location = new System.Drawing.Point(969, 388);
            this.cartaFaca.Name = "cartaFaca";
            this.cartaFaca.Size = new System.Drawing.Size(72, 112);
            this.cartaFaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaFaca.TabIndex = 20;
            this.cartaFaca.TabStop = false;
            this.cartaFaca.Click += new System.EventHandler(this.cartaFaca_Click);
            // 
            // cartaPistola
            // 
            this.cartaPistola.Image = global::sistemaAutonomoBCCIII.Properties.Resources.pistola;
            this.cartaPistola.Location = new System.Drawing.Point(882, 388);
            this.cartaPistola.Name = "cartaPistola";
            this.cartaPistola.Size = new System.Drawing.Size(72, 112);
            this.cartaPistola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaPistola.TabIndex = 19;
            this.cartaPistola.TabStop = false;
            this.cartaPistola.Click += new System.EventHandler(this.cartaPistola_Click);
            // 
            // cartaChave
            // 
            this.cartaChave.Image = global::sistemaAutonomoBCCIII.Properties.Resources.chave;
            this.cartaChave.Location = new System.Drawing.Point(792, 388);
            this.cartaChave.Name = "cartaChave";
            this.cartaChave.Size = new System.Drawing.Size(72, 112);
            this.cartaChave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaChave.TabIndex = 18;
            this.cartaChave.TabStop = false;
            this.cartaChave.Click += new System.EventHandler(this.cartaChave_Click);
            // 
            // cartaEsqueleto
            // 
            this.cartaEsqueleto.Image = global::sistemaAutonomoBCCIII.Properties.Resources.caverira;
            this.cartaEsqueleto.Location = new System.Drawing.Point(702, 388);
            this.cartaEsqueleto.Name = "cartaEsqueleto";
            this.cartaEsqueleto.Size = new System.Drawing.Size(72, 112);
            this.cartaEsqueleto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaEsqueleto.TabIndex = 17;
            this.cartaEsqueleto.TabStop = false;
            this.cartaEsqueleto.Click += new System.EventHandler(this.cartaEsqueleto_Click);
            // 
            // cartaGarrafa
            // 
            this.cartaGarrafa.Image = global::sistemaAutonomoBCCIII.Properties.Resources.garrafa;
            this.cartaGarrafa.Location = new System.Drawing.Point(614, 388);
            this.cartaGarrafa.Name = "cartaGarrafa";
            this.cartaGarrafa.Size = new System.Drawing.Size(72, 112);
            this.cartaGarrafa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaGarrafa.TabIndex = 16;
            this.cartaGarrafa.TabStop = false;
            this.cartaGarrafa.Click += new System.EventHandler(this.cartaGarrafa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 23.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(607, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 39);
            this.label7.TabIndex = 34;
            this.label7.Text = "Suas cartas :";
            // 
            // ContainerInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 515);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFaca);
            this.Controls.Add(this.lblTricornio);
            this.Controls.Add(this.cartaTricornio);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.lblPistola);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.lblCaveira);
            this.Controls.Add(this.lblGarrafa);
            this.Controls.Add(this.cartaFaca);
            this.Controls.Add(this.cartaPistola);
            this.Controls.Add(this.cartaChave);
            this.Controls.Add(this.cartaEsqueleto);
            this.Controls.Add(this.cartaGarrafa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.splitterJogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaPirata);
            this.Controls.Add(this.txtPirata);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.listBoxPartidas);
            this.Controls.Add(this.txtCartagena);
            this.Name = "ContainerInicial";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.ContainerInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartaTricornio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaFaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaPistola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaChave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaEsqueleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaGarrafa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCartagena;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtPirata;
        private System.Windows.Forms.TextBox txtSenhaPirata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitterJogo;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox cartaGarrafa;
        private System.Windows.Forms.PictureBox cartaEsqueleto;
        private System.Windows.Forms.PictureBox cartaChave;
        private System.Windows.Forms.PictureBox cartaPistola;
        private System.Windows.Forms.PictureBox cartaFaca;
        public System.Windows.Forms.ListBox listBoxPartidas;
        public System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblGarrafa;
        public System.Windows.Forms.Label lblCaveira;
        public System.Windows.Forms.Label lblChave;
        public System.Windows.Forms.Label lblPistola;
        public System.Windows.Forms.Label lblFaca;
        private System.Windows.Forms.Button btnJogar;
        public System.Windows.Forms.Label lblTricornio;
        private System.Windows.Forms.PictureBox cartaTricornio;
        private System.Windows.Forms.Label label7;
    }
}

