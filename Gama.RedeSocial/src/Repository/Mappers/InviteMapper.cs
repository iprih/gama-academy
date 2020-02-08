using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class InviteMapper : BaseMapper<Invite>
    {
        public InviteMapper()
        {
            ToTable("TB_INVITE");
            Map(e => e.Sender.Id).ToColumn("ID_SENDER");
            Map(e => e.Receiver.Id).ToColumn("ID_RECEIVER");
            Map(e => e.Status.Id).ToColumn("ID_STATUS");
        }
    }
}
