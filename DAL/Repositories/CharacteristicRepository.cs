using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace DAL.Repositories
{
    public class CharacteristicRepository : EFRepository<Characteristic>
    {
        public CharacteristicRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
