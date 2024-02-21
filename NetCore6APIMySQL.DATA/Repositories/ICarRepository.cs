﻿using NetCore6APIMySQL.Data.Repositories;
using NetCore6APIMySQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6APIMySQL.Data.Repositories
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCars();

    }
}