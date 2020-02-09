using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Gallery : BaseEntity
    {
        public string Name { get; set; }
        public List<Midia> Midias { get; set; }

        public User Author { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrWhiteSpace(Name)) throw new ArgumentNullException("O nome deve ser preenchido!");
        }
    }
}
