using PetCare.Common.Contracts;
using PetCare.Common.Notifications;
using PetCare.Common.ValueObjects;


namespace PetCare.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        #region Properties
        public string OwnerEmail { get; private set; }
        #endregion

        #region Constructors
        public Email(string email)
        {
           OwnerEmail = email;
           ApplyContractsEmail();
        
        }
        #endregion

        #region Set Methods
        public void SetEmail(string email)
        {
            OwnerEmail = email;
            ApplyContractsEmail();

        }
        #endregion

        private void ApplyContractsEmail()
        {
            AddNotifications(new Contract<Notification>()
               .Requires()
               .IsValid(OwnerEmail, "Email.OwnerEmail", "Por favor, insira um email valido."));
               
        }

      
    }
}
