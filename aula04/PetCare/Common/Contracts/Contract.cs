using PetCare.Common.Notifications;

namespace PetCare.Common.Contracts
{
    public partial class Contract<T> : Notifiable<Notification>
    {
        #region Fluent method invocation
        public Contract<T> Requires() => this;
        #endregion
    }
}
