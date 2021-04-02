using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilaria_Verifica4
{
    class Studente
    {
        //PROPRIETA' DELLA CLASSE
        public string Nome { get; } 
        public string Cognome { get; } 
        public int AnnoDiNascita { get; }

        private Immatricolazione _immatricolazione;// immatricolazione è un oggetto da passare da classe immatricolazione

        public bool RichiestaLaurea { get; }

        //COSTRUTTORE
        public Studente(string nome, string cognome, int annodinascita, bool richiestalaurea)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annodinascita;
            RichiestaLaurea = richiestalaurea;
            
        }

        //LISTA ESAMI
        private List<Esame> _esami = new List<Esame>();

        public List<Esame> Esami
        {
            get
            {
                return _esami;
            }
        }

    }
}
