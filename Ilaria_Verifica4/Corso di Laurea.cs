using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilaria_Verifica4
{
    
    public enum NomeCorsoDiLaurea
    {
        Matematica,
        Fisica,
        Informatica,
        Ingegneria,
        Lettere
    }

    class Corso_di_Laurea
    {
        public bool PresenzaCorso(Corso corso)
        {
            if (_corsi.Contains(corso))
                return true;

            return false;
        }

        public NomeCorsoDiLaurea Nome { get; set; }
         
        
        //LISTA DI CORSI ASSOCIATI
        private List<Corso> _corsi = new List<Corso>();

        public List<Corso> Corsi //_corsi è campo privato, Corsi è proprietà pubblica
        {
            get
            {
                return _corsi;
            }
        }

        //PROPRIETA' DELLA CLASSE
        public int AnniDiCorso { get; set; }
        public int CfuTotali { get; set; }

        //COSTRUTTORE
        public Corso_di_Laurea(List<Corso> corso, NomeCorsoDiLaurea nome, int annidicorso, int cfutotali) 
        {
            _corsi = corso;
            Nome = nome;
            AnniDiCorso = annidicorso;
            CfuTotali = cfutotali;
            

        }


    }
}
