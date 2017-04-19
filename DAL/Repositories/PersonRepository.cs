using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace DAL.Repositories
{
    public class PersonRepository : EFRepository<Person>
    {
        public PersonRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
