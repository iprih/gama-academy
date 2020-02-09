﻿using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;

using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Services
{
    public class GenderService : ServiceBase<Gender>, IGenderService
    {
        private readonly IGenderRepository _repository;
        public GenderService(IGenderRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
