using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilaria_Verifica4
{
    class Corso
    {
        

            //PROPRIETA' DELLA CLASSE
            public string NomeEsame { get; }
        public int Cfu { get; }

        //COSTRUTTORE
        public Corso(string nomeesame, int cfu)
        {
            NomeEsame = nomeesame;
            Cfu = cfu;

        }
    }
}
