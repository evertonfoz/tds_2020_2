using PetCare.Common.EntityClasses;
using PetCare.Common.ModelClasses;
using PetCare.Domain.Models;
using PetCare.Domain.ValueObjects;
using System;

namespace PetCare.Domain.Entities
{
    public class OwnerEntity : EntityClass
    {
        #region Properties
        public Guid OwnerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        #endregion

        #region Constructors
        protected OwnerEntity() { }
        public OwnerEntity(Guid ownerID, string firstName, string lastName, string email)
        {
            OwnerID = ownerID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        #endregion

        #region Override Methods
        public override OwnerModel ToModel()
        {
            return new OwnerModel(new Name(FirstName, LastName), Email, OwnerID);
        }
        #endregion
    }
}
