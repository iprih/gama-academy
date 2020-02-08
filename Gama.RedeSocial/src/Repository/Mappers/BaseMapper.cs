using Dapper.FluentMap.Dommel.Mapping;
using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class BaseMapper<T> : DommelEntityMap<T> where T : BaseEntity
    {
        public BaseMapper()
        {
            Map(e => e.Id).ToColumn("ID").IsKey();
            Map(e => e.DateCreated).ToColumn("DT_CREATED");
            Map(e => e.DateUpdated).ToColumn("DT_UPDATED");
            Map(e => e.Active).ToColumn("ST.ACTIVE");
        }

    }
}
