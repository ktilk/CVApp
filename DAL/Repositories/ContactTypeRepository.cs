using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ContactTypeRepository : EFRepository<ContactType>
    {
        public ContactTypeRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
