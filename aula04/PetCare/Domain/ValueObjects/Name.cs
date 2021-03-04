using PetCare.Common.Contracts;
using PetCare.Common.Notifications;
using PetCare.Common.ValueObjects;

namespace PetCare.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        #region Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        #endregion

        #region Constructors
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            ApplyContracts();
        }
        #endregion

        #region Set Methods
        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
            ApplyContracts();
        }
        #endregion

        private void ApplyContracts()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNull(FirstName, "Name.FirstName", "O primeiro nome não pode ser nulo")
                .IsNotEmpty(FirstName, "Name.FirstName", "O primeiro nome não pode ser nulo")
                .MinAndMaxLength(FirstName, 3, 40, "Name.FirstName", 
                        "O primeiro nome precisa ter entre 3 e 40 caracteres"));
        }
    }
}
