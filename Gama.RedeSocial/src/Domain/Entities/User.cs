using System;


namespace Gama.RedeSocial.Domain.Entities
{
    class User : BaseEntity
    {
        public User()
        {
            Gender = new Gender(); //acessando no construtor essa propriedade 
            
        }
        public string Name { get; set; }//get - ler e set - definir
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }   
        
    }
}
