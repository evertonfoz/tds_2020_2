using PetCare.Common.Notifications;

namespace PetCare.Common.Contracts
{
    public partial class Contract<T> : Notifiable<Notification>
    {
        public Contract<T> MinAndMaxLengthNumber(string value, int minLength, int maxLength, string property, string message)
        {
            var valueLength = value.Trim().Length;
            if (valueLength > maxLength || valueLength < minLength)
            {
                AddNotification(property, message);
            }

            return this;
        }

    }
}
