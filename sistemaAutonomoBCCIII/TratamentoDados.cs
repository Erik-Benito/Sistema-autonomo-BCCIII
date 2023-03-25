using System;

using System.Windows.Forms;

namespace sistemaAutonomoBCCIII
{
    public class Tratamentos
    {

        public string[] stringsForArray(string resposta)
        {
            resposta.Replace("\r", "");
            return resposta.Split('\n');
        }

        public int getIdString(string resposta)
        {
            string identificador = ",";
            int posicaoIdentificador = resposta.IndexOf(identificador);

            return Convert.ToInt32(resposta.Substring(0, resposta.Length + posicaoIdentificador - resposta.Length));
        }

        public bool ehErro(string resposta)
        {
            string identificador = "ERRO";

            bool eherro = resposta.IndexOf(identificador) != -1 ? true : false;

            if (eherro)
                MessageBox.Show(resposta, "Error", MessageBoxButtons.OK);

            return eherro;
        }

    }

}