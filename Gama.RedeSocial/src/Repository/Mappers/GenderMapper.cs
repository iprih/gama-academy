﻿using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class GenderMapper : BaseMapper<Gender>
    {
        public GenderMapper()
        {
            ToTable("TB_GENDER");
            Map(entity => entity.Description).ToColumn("DS_GENDER");
        }
    }
}
