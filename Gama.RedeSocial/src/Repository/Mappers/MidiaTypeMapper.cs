using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class MidiaTypeMapper : BaseMapper<MidiaType>
    {
        public MidiaTypeMapper()
        {
            ToTable("TB_MIDIA_TYPE");
            Map(e => e.Description).ToColumn("DS_MIDIA_TYPE");
            Map(e => e.Extensions).ToColumn("DS_EXTENSIONS");
        }
    }
}
