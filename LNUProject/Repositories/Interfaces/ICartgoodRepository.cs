﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;

namespace LNUProject.Repositories.Interfaces
{
    public interface ICartgoodRepository:IRepository<Cartgood>
    {
        Cartgood Get(int id);
        Cartgood GetByCartId(int cartid);
        Cartgood GetQuantity(int id);
    }
}
