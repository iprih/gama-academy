using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    class UserMapper : BaseMapper<User>
    {
        public UserMapper()
        {
            ToTable("TB_USER");
            Map(e => e.Name).ToColumn("NM_USER");
            Map(e => e.Email).ToColumn("DS_EMAIL");
            Map(e => e.Password).ToColumn("DS_PASSWORD");
            Map(e => e.Birthday).ToColumn("DT_BIRTHDAY");
            Map(e => e.Gender.Id).ToColumn("ID_GENDER");
            Map(e => e.Cover.Id).ToColumn("ID_COVER");
            Map(e => e.Avatar.Id).ToColumn("ID_AVATARS");
        }
    }
}
