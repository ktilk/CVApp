using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ExperienceRepository : EFRepository<Experience>
    {
        public ExperienceRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
