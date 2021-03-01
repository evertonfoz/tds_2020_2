using PetCare.Common.Notifications;

namespace PetCare.Common.Contracts
{
    public partial class Contract<T> : Notifiable<Notification>
    {
        public Contract<T> IsValid(string value, string property, string message)
        {

            string model = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(value, model))
            {

            }
            else
            {
                AddNotification(property, message);
            }

            return this;
        }
    }
}
