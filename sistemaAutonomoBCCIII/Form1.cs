﻿using CartagenaServer;
using sistemaAutonomoBCCIII.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.Design;

namespace sistemaAutonomoBCCIII
{
    public partial class ContainerInicial : Form
    {

        public GetDadosDll getDadosDll;
        public Tratamentos tratamentos;
        public ControleCarta controleCarta;
        public ControlePirata controlePirata;
        public int idPartida;
        public int idJogador;
        public string senhaJogador;
        public bool criouAdversario = false;

        public Adversario adversario1;
        public Adversario adversario2;
        public Adversario adversario3;
        public Adversario adversario4;

        public ContainerInicial()
        {
            InitializeComponent();
            this.getDadosDll = new GetDadosDll(this);
            this.controleCarta = new ControleCarta(this);
            this.tratamentos = new Tratamentos();
            this.controlePirata = new ControlePirata(this);
        }

        private void ContainerInicial_Load(object sender, EventArgs e)
        { this.getDadosDll.ListarPartidas(); }

        private void listBoxPartidas_Click(object sender, EventArgs e)
        {
            string idsPartidas = this.listBoxPartidas.Items[this.listBoxPartidas.SelectedIndex].ToString();
        
            this.idPartida = this.tratamentos.getIdString(idsPartidas);
            this.getDadosDll.ListarPlayers();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = this.txtNomePartida.Text;
            string senha = this.txtSenhaPartida.Text;

            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Deve ser preenchido com um nome valido a partida!");
                return;
            }

            if (String.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Deve ser preenchido com uma senha valido a partida!");
                return;
            }

            string resposta = "";

            try
            {
                resposta = Jogo.CriarPartida(nome, senha);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao tentar criar a partida, por favor tente novamente");
                return;
            }

            if (this.tratamentos.ehErro(resposta)) return;

            this.idPartida = Convert.ToInt32(resposta);
            this.getDadosDll.ListarPartidas();

            MessageBox.Show($"Partida Criada com sucesso {this.idPartida}");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtPirata.Text;
            string senha = this.txtSenhaPirata.Text;

            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Deve ser preenchido com um nome valido de pirata!");
                return;
            }

            if (String.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Deve ser preenchido com uma senha valido a senha!");
                return;
            }

            string resposta = "";

            try
            {
                resposta = Jogo.EntrarPartida(this.idPartida, nome, senha);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao tentar entrar na Partidas, por favor tente novamente");
                return;
            }
            
            if (this.tratamentos.ehErro(resposta))
                return;

            string[] dados = resposta.Split(',');
            this.idJogador = Convert.ToInt32(dados[0]);
            this.lblSenha.Text = "Senha:" + dados[1];
            this.senhaJogador = dados[1]; 
            this.splitterJogo.BackColor = this.tratamentos.setColor(dados[2]);

            MessageBox.Show($"Entrou com sucesso {this.idPartida}");
            this.getDadosDll.ListarPlayers();
            this.timer1.Enabled = true;
        }

        private void lblSenha_Click(object sender, EventArgs e) { }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string resposta = "";

            try
            {
                resposta = Jogo.IniciarPartida(this.idJogador, this.senhaJogador);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao tentar inciar a partida, por favor tente novamente");
                return;
            }

            if (this.tratamentos.ehErro(resposta))
                return;

            this.getDadosDll.ListarMao();
            this.getDadosDll.ListarPartidas();
            this.getDadosDll.GerarTabuleiro();

            this.timer1.Enabled= true;
        }

        private void cartaTricornio_Click(object sender, EventArgs e)
        { this.controleCarta.selecionarCarta("T"); }

        private void cartaFaca_Click(object sender, EventArgs e)
        { this.controleCarta.selecionarCarta("F"); }

        private void cartaPistola_Click(object sender, EventArgs e)
        { this.controleCarta.selecionarCarta("P"); }

        private void cartaChave_Click(object sender, EventArgs e)
        { this.controleCarta.selecionarCarta("C"); }

        private void cartaEsqueleto_Click(object sender, EventArgs e)
        { this.controleCarta.selecionarCarta("E"); }

        private void cartaGarrafa_Click(object sender, EventArgs e)
        { this.controleCarta.selecionarCarta("G"); }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string resposta = "";

            try
            { resposta = Jogo.Jogar(this.idJogador, this.senhaJogador, this.controlePirata.pirataSelecionado.posicao, this.controleCarta.cartaSelecionada); }
            catch (Exception)
            { 
                MessageBox.Show("Houve um erro ao tentar entrar na Partidas, por favor tente novamente");
                return;
            }

            if (this.tratamentos.ehErro(resposta))
                return;

            
            string historico = "";

            try
            { historico = Jogo.ExibirHistorico(this.idPartida); }
            catch (Exception)
            { 
                MessageBox.Show("Houve um erro ao tentar atualizar a partida, por favor tente novamente"); 
                return; 
            }

            int posicao = this.tratamentos.pegarPosicao(historico);
            int novaPosicao = posicao  == 0 ? this.controlePirata.pirataSelecionado.posicao : posicao;

            if (this.tratamentos.ehErro(historico))
                return;

            this.controlePirata.SetPosicao(this.controlePirata.pirataSelecionado.id, novaPosicao);
            this.getDadosDll.ListarMao();
        }

        private void imgPirata0_Click(object sender, EventArgs e)
        { this.controlePirata.SelecionarPirata(0); }

        private void imgPirata1_Click(object sender, EventArgs e)
        { this.controlePirata.SelecionarPirata(1); }

        private void imgPirata2_Click(object sender, EventArgs e)
        { this.controlePirata.SelecionarPirata(2); }

        private void imgPirata3_Click(object sender, EventArgs e)
        { this.controlePirata.SelecionarPirata(3); }

        private void imgPirata4_Click(object sender, EventArgs e)
        { this.controlePirata.SelecionarPirata(4); }
        
        private void imgPirata5_Click(object sender, EventArgs e)
        { this.controlePirata.SelecionarPirata(5); }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string statusPartida = "";

            try
            { statusPartida = Jogo.VerificarVez(this.idPartida); }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao tentar verificar vez");
                return;
            }
            
            if (this.tratamentos.ehErro(statusPartida)) return;

            string[] infosPartida = statusPartida.Split(',');

            if (infosPartida[0] != "J") this.criouAdversario = true;
            if (infosPartida[0] == "E") MessageBox.Show("A partida foi encerrada");
            this.btnVez.Text = infosPartida[1] == this.idJogador.ToString() ? "🫵" : "🤚";
            
            if (this.criouAdversario)
            {
                this.getDadosDll.GerarTabuleiro();
                this.getDadosDll.ListarMao();

                this.criouAdversario = false;

                string[] ids = this.tratamentos.stringsForArray(Jogo.ListarJogadores(this.idPartida));
                string idJogador = this.idJogador.ToString();

                foreach (string jogador in ids)
                {
                    if (jogador == "") return;

                    int jogadorAdversarioId = Convert.ToInt32(jogador.Substring(0, jogador.IndexOf(",")));
                    if (!jogador.Contains(idJogador) && adversario1 == null)
                    { 
                        adversario1 = new Adversario(this, 1, jogadorAdversarioId);
                        break;
                    }
                    if (!jogador.Contains(idJogador) && adversario2 == null)
                    {
                        adversario2 = new Adversario(this, 2, jogadorAdversarioId);
                        break;
                    }
                    if (!jogador.Contains(idJogador) && adversario3 == null)
                    {
                        adversario3 = new Adversario(this, 3, jogadorAdversarioId);
                        break;
                    }
                    if (!jogador.Contains(idJogador) && adversario4 == null)
                    {
                        adversario4 = new Adversario(this, 4, jogadorAdversarioId);
                        break;
                    }
                }

            }

            string resposta;
            try
            {
                resposta = Jogo.ExibirHistorico(this.idPartida);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao tentar atualizar a partida, por favor tente novamente");
                return;
            }

            if (adversario1 != null)
                adversario1.atualizarPosicao(resposta);
            if (adversario2 != null)
                adversario2.atualizarPosicao(resposta);
            if (adversario3 != null)
                adversario3.atualizarPosicao(resposta);
            if (adversario4 != null)
                adversario4.atualizarPosicao(resposta);


        }






        // Não usados
        private void lblCaveira_Click(object sender, EventArgs e) { }
        private void lblGarrafa_Click(object sender, EventArgs e) { }
        private void imgPirata0_Paint(object sender, PaintEventArgs e) { }
        private void imgPirata1_Paint(object sender, PaintEventArgs e) { }
        private void imgPirata2_Paint(object sender, PaintEventArgs e) { }
        private void imgPirata3_Paint(object sender, PaintEventArgs e) { }
        private void imgPirata4_Paint(object sender, PaintEventArgs e) { }
        private void imgPirata5_Paint(object sender, PaintEventArgs e) { }
        private void listBoxPartidas_SelectedIndexChanged(object sender, EventArgs e) { }

        private void attPts_Click(object sender, EventArgs e)
        {
            this.getDadosDll.ListarPartidas();
        }
    }
}
