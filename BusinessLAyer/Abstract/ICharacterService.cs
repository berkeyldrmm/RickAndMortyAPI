﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICharacterService : IGenericService<Character>
    {
        public Task<bool> DeleteAll();
    }
}
