using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace sistemaAutonomoBCCIII
{
    public class Tratamentos
    {

        public string[] stringsForArray(string resposta)
        {
            resposta.Replace("\r", "");
            return resposta.Split('\n');
        }

    }

}