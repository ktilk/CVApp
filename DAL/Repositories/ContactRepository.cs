using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ContactRepository : EFRepository<Contact>
    {
        public ContactRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
