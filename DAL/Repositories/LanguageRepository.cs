using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class LanguageRepository : EFRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(CVAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
