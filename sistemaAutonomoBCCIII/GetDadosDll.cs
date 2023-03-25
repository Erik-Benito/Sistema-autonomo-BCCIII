﻿using CartagenaServer;
using sistemaAutonomoBCCIII.Properties;
using System;

namespace sistemaAutonomoBCCIII
{
    public class GetDadosDll
    {
        public Tratamentos tratamentos;
        public ContainerInicial containerInicial;
        public ControleCarta controleCarta;

        public GetDadosDll(ContainerInicial containerInicial)
        {
            this.containerInicial = containerInicial;
            this.tratamentos = new Tratamentos();
            this.controleCarta = new ControleCarta(containerInicial);
        }

        public void ListarPartidas()
        {
            this.containerInicial.listBoxPartidas.Items.Clear();

            string resposta = Jogo.ListarPartidas("T");
            string[] partidas = this.tratamentos.stringsForArray(resposta);

            foreach (string partida in partidas)
                this.containerInicial.listBoxPartidas.Items.Add(partida);
        }

        public void ListarPlayers()
        {
            this.containerInicial.listBoxPlayers.Items.Clear();

            string resposta = Jogo.ListarJogadores(this.containerInicial.idPartida);
            string[] jogadores = this.tratamentos.stringsForArray(resposta);

            foreach (string jogador in jogadores)
                this.containerInicial.listBoxPlayers.Items.Add(jogador);
        }

        public void ListarMao()
        {
            string cartas = Jogo.ConsultarMao(this.containerInicial.idJogador, this.containerInicial.senhaJogador);

            if (this.tratamentos.ehErro(cartas))
                return;

            this.controleCarta.setCartas(cartas);
        }
    }
}