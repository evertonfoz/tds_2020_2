using Microsoft.EntityFrameworkCore;
using PetCare.Domain.Entities;
using PetCare.Domain.Models;
using PetCare.Domain.Repositories;
using PetCare.Persistence.Data;
using System;
using System.Linq;

namespace PetCare.Persistence.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private PetCareDataContext _context = new PetCareDataContext();

        public OwnerModel GetByID(Guid ownerID)
        {
            return _context.Owners.AsNoTracking().Where(x => x.OwnerID.Equals(ownerID)).FirstOrDefault()?.ToModel();
        }

        public OwnerModel GetByEMail(string email)
        {
            return _context.Owners.AsNoTracking().Where(x => x.Email.ToLower().Equals(email.ToLower())).FirstOrDefault()?.ToModel();
        }

        public void Create(OwnerModel ownerModel)
        {
            _context.Owners.Add(ownerModel.ToEntity());
            _context.SaveChanges();
        }

        public void Update(OwnerModel ownerModel)
        {
            _context.Entry<OwnerEntity>(ownerModel.ToEntity()).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(OwnerModel ownerModel)
        {
            _context.Owners.Remove(ownerModel.ToEntity());
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
