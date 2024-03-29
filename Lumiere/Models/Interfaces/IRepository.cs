﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lumiere.Models.Tables;

namespace Lumiere.Models.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<UserTable> UserTables { get; }
    }
}