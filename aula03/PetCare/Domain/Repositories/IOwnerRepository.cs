using PetCare.Domain.Models;
using System;

namespace PetCare.Domain.Repositories
{
    public interface IOwnerRepository : IDisposable
    {
        OwnerModel GetByID(Guid ownerID);
        OwnerModel GetByEMail(string email);
        void Create(OwnerModel ownerModel);
        void Update(OwnerModel ownerModel);
        void Delete(OwnerModel ownerModel);
    }
}
