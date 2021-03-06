﻿using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;


namespace Gama.RedeSocial.Domain.Services
{
    public class InviteService : ServiceBase<Invite>, IInviteService
    {
        private readonly IInviteRepository _repository;
        public InviteService(IInviteRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
