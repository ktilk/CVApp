using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class ContactRepository : EFRepository<Contact>, IContactRepository
    {
        public ContactRepository(CVAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
