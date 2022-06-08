﻿using System;
using System.Collections.Generic;
using System.Text;

using CaprichoHexagonal.Core.Domain.Interfaces;

namespace CaprichoHexagonal.Core.Infraestructure.Repository.Abstract
{
    public interface IBaseRepository<Entity, EntityId>: ICreate<Entity>,
        IRead<Entity, EntityId>, IUpdate<Entity>, IDelete<EntityId>, ITransaction
    {

    }
}
