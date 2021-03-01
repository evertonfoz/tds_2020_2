namespace PetCare.Common.Notifications
{
   public class Notification
    {
        #region Properties
        public string Key { get; set; }
        public string Message { get; set; }
        #endregion

        #region Constructors
        public Notification(string key, string message)
       {
           Key = key;
           Message = message;
       }
        #endregion
    }
}
