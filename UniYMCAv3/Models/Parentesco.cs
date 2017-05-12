using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Parentesco
    {
        public Parentesco()
        {
            PersonaAutorizada = new HashSet<PersonaAutorizada>();
        }

        public int ParentescoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PersonaAutorizada> PersonaAutorizada { get; set; }
    }
}
