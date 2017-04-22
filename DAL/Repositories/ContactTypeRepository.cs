using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class ContactTypeRepository : EFRepository<ContactType>, IContactTypeRepository
    {
        public ContactTypeRepository(CVAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
