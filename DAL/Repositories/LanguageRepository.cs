using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class LanguageRepository : EFRepository<Language>
    {
        public LanguageRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
