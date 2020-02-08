using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Post : BaseEntity
    {
        public Guid ParentId { get; set; } // respondendo
        public string Text { get; set; }
        public List<Midia> Midias { get; set; }
        public List<Like> Likes { get; set; }
        public List<Post> Comments { get; set; }
        public User Author { get; set; }


    }
}
