using PetCare.Common.ModelClasses;
using PetCare.Domain.ValueObjects;

namespace PetCare.Domain.Models
{
    public class OwnerModel : ModelClass
    {
        #region Properties
        public Name Name { get; private set; }
        public string Email { get; private set; }
        #endregion

        #region Constructors
        public OwnerModel(Name name, string email)
        {
            Name = name;
            Email = email;
        }
        #endregion
    }
}
