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
        public Name(string firtsName, string lastName)
        {
            FirstName = firtsName;
            LastName = lastName;

            ApplyContractsFirstName();
            ApplyContractsLastName();
        }
        #endregion

        #region Set Methods
        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
            ApplyContractsFirstName();

        }
        public void SetLastName(string lastName)
        {
            LastName = lastName;
            ApplyContractsLastName();
         
        }

        #endregion

        private void ApplyContractsFirstName()
        {
            AddNotifications(new Contract<Notification>()
               .Requires()
               .IsNotNull(FirstName, "Name.FirstName", "O primeiro nome não pode ser nulo.")
               .IsNotEmpty(FirstName, "Name.FirstName", "O primeiro nome não pode ser nulo.")
               .MinAndMaxLength(FirstName, 40, 3, "Name.FirstName", "O primeiro nome precia ter entre 3 e 40 caracteres"));
        }

        private void ApplyContractsLastName()
        {
            AddNotifications(new Contract<Notification>()
               .Requires()
               .IsNotNull(LastName, "Name.LastName", "O sobrenome não pode ser nulo.")
               .IsNotEmpty(LastName, "Name.LastName", "O sobrenome não pode ser nulo.")
               .MinAndMaxLength(LastName, 40, 3, "Name.LastName", "O sobrenome precia ter entre 3 e 40 caracteres"));
        }
    }
}
