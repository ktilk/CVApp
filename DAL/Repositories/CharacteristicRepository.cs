using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class CharacteristicRepository : EFRepository<Characteristic>, ICharacteristicRepository
    {
        public CharacteristicRepository(CVAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
