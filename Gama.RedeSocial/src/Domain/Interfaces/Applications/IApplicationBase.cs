﻿using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces.Applications
{
    public interface IApplicationBase<T> : IBase<T> where T : BaseEntity
    {
    }
}
