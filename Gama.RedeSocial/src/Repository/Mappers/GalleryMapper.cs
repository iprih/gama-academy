﻿using Gama.RedeSocial.Domain.Entities;

namespace Repository.Mappers
{
    public class GalleryMapper : BaseMapper<Gallery>
    {
        public GalleryMapper()
        {
            ToTable("TB_GALLERY");
            Map(e => e.Author.Id).ToColumn("ID_AUTHOR");
            Map(e => e.Name).ToColumn("NM_GALLERY");            
        }
    }
}
