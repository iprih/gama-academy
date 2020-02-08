using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class MidiaMapper : BaseMapper<Midia>
    {
        public MidiaMapper()
        {
            ToTable("TD_MIDIA");
            Map(e => e.MidiaType.Id).ToColumn("ID_MIDIA_TYPO");
            Map(e => e.Path).ToColumn("DS_PATH");
        }
    }
}
