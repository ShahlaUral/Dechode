﻿using Dechode.Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Application.Repositories
{
    public interface IGenericRepository<T> where T : class,  IBaseEntity, new()
    {
    }
}
