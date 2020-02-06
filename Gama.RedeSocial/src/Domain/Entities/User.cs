using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Entities
{//atalho prop - ou ctor 
    class User
    {
        public string Name { get; set; }//get - ler e set - definir
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

        

    }
}
