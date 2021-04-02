using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilaria_Verifica4
{
    class Immatricolazione
    {
        
        //PROPRIETA'
        public Corso_di_Laurea CorsoDiLaurea { get; }
        public int Matricola { get; }
        private static int _matricola = 0;
        public DateTime DataInizio { get; }
        public bool FuoriCorso { get; set; }
        public int CfuAccumulati { get; set; }

        public Immatricolazione(Corso_di_Laurea corsoDiLaurea, DateTime dataInizio, bool fuoriCorso, int cfuAccumulati)
        {
            CorsoDiLaurea = corsoDiLaurea;
            Matricola = ++_matricola;
            DataInizio = dataInizio;
            FuoriCorso = fuoriCorso;
            CfuAccumulati = cfuAccumulati;


        }
    }
}
