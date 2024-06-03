using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitidades
{
   public class CursosEntidade
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public string Turno { get; set; }
        public bool Ativo { get; set; }

    }
}