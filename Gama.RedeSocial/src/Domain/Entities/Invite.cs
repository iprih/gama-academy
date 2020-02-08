using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Invite : BaseEntity
    {
        public User Sender { get; set; }

        public User Receiver { get; set; }

        public InviteStatus Status { get; set; }

    }
}
