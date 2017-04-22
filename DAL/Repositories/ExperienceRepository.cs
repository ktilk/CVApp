using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class ExperienceRepository : EFRepository<Experience>, IExperienceRepository
    {
        public ExperienceRepository(CVAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
