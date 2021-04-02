using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilaria_Verifica4
{
    class Esame
    {
       public Corso Corso { get; }

       public bool Passato { get; set; }

       public Esame(Corso corso, bool passato) //COSTRUTTORE
       {
                Corso = corso;
                Passato = passato;
       }

       


}
