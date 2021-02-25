using PetCare.Common.EntityClasses;
using PetCare.Common.ModelClasses;
using PetCare.Domain.Entities;
using PetCare.Domain.ValueObjects;
using System;

namespace PetCare.Domain.Models
{
    public class OwnerModel : ModelClass
    {
        #region Properties
        public Guid OwnerID { get; private set; }
        public Name Name { get; private set; }
        public string Email { get; private set; }
        #endregion

        #region Constructors
        public OwnerModel(Name name, string email, Guid? ownerID = null)
        {
            Name = name;
            Email = email;
            OwnerID = ownerID ?? Guid.NewGuid();
        }
        #endregion

        #region Access Methods
        public void ChangeEmail(string email)
        {
            Email = email;
        }
        #endregion

        #region Override Methods
        public override OwnerEntity ToEntity()
        {
            return new OwnerEntity(OwnerID, Name.FirstName, Name.LastName, Email);
        }
        #endregion
    }
}
