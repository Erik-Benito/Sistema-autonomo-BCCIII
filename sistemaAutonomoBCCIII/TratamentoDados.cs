using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sistemaAutonomoBCCIII
{
    public class Tratamentos
    {
        public string[] stringsForArrayVirgula(string resposta)
        {
            return Regex.Replace(resposta, "[\r\n]", "").Split(',');
        }

        public string[] stringsForArray(string resposta)
        {
            List<string> strings = new List<string>();
            resposta.Replace("\r", "");
            strings = resposta.Split('\n').ToList();
            
           strings.RemoveAt(strings.Count - 1);
            
            return strings.ToArray();
        }

        public int getIdString(string resposta)
        {
            string identificador = ",";
            int posicaoIdentificador = resposta.IndexOf(identificador);

            return Convert.ToInt32(resposta.Substring(0, resposta.Length + posicaoIdentificador - resposta.Length));
        }

        public bool ehErro(string resposta, bool exibirErro = true)
        {
            string identificador = "ERRO";

            bool eherro = resposta.IndexOf(identificador) != -1 ? true : false;

            if (eherro  && exibirErro)
                MessageBox.Show(resposta, "Error", MessageBoxButtons.OK);

            return eherro;
        }

        public System.Drawing.Color setColor(string cor)
        {
            cor = cor.Replace("\r\n", "");

            System.Drawing.Color cor1 = Color.Aquamarine;

            switch (cor) // cataloga as cor q falta
            {
                case "Vermelho":
                    cor1 = System.Drawing.Color.Red;
                    break;
                case "Verde":
                    cor1 = System.Drawing.Color.Green;
                    break;
                case "Azul":
                    cor1 = System.Drawing.Color.Blue;
                    break;
                case "Marrom":
                    cor1 = System.Drawing.Color.Brown;
                    break;
                case "Amarelo":
                    cor1 = System.Drawing.Color.Yellow;
                    break;
            }

            return cor1;
        }

        public int pegarPosicao (string historico)
        {
            historico = historico.Replace("\r\n", "");
            char test = historico[historico.Length - 1];
            if (test == ',') return 0;

            return int.Parse(historico.Substring(historico.LastIndexOf(',') + 1, historico.Length - historico.LastIndexOf(',') - 1));
        }

    }

}