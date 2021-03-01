using PetCare.Common.ModelClasses;
using PetCare.Domain.ValueObjects;

namespace PetCare.Domain.Models
{
   public class OwnerModel : ModelClass
    {
        #region Properties
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public Telephone Telephone { get; private set; }
        #endregion

        #region Constructors
        public OwnerModel(Name name, Email email, Address address, Telephone telephone)
        {
            Name = name;
            Email = email;
            Address = address;
            Telephone = telephone;
        }
        #endregion


    }
}
