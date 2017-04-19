using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class SkillRepository : EFRepository<Skill>
    {
        public SkillRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
