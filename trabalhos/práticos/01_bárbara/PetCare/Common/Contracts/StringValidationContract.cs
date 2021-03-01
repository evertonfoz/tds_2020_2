using PetCare.Common.Notifications;


namespace PetCare.Common.Contracts
{
    public partial class Contract<T> : Notifiable<Notification>
    {
        public Contract<T> IsNotNull(string value, string property, string message)
        {
            if (value == null)
            {
                AddNotification(property, message);
            }

            return this;
        }
        public Contract<T> IsNotEmpty(string value, string property, string message)
        {
            if (value.Trim().Length == 0)
            {
                AddNotification(property, message);
            }

            return this;
        }
        public Contract<T> MinLength(string value, int minLength, string property, string message)
        {
            if (value.Trim().Length < minLength)
            {
                AddNotification(property, message);
            }

            return this;
        }
        public Contract<T> MaxLength(string value, int maxLength, string property, string message)
        {
            if (value.Trim().Length > maxLength)
            {
                AddNotification(property, message);
            }

            return this;
        }
        public Contract<T> MinAndMaxLength(string value, int minLength, int maxLength, string property, string message)
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
