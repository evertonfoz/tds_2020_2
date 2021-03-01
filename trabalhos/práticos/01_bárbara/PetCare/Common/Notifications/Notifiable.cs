using System;
using System.Collections.Generic;

namespace PetCare.Common.Notifications
{
   public abstract class Notifiable<T> where T: Notification
    {
        #region Properties
        private readonly List<T> _notifications;

        //não será usado list normal pois não queremos que o user tenha acesso, por isso a utl de interfaces
        public IReadOnlyCollection<T> Notificantions => _notifications;
        #endregion

        #region Constructors
        protected Notifiable() => _notifications = new List<T>();
        private T GetNotificationInstance(string key, string message)
        {
            //instancia a classe notification
            return (T)Activator.CreateInstance(typeof(T), new object[] { key, message });
        }
        #endregion

        //implementação de um polimorfismo do tipo "overload" (mesmo métodos com diferentes assinaturas)

        #region Overloads AddNotification Methods 
        public void AddNotification(string key, string message)
        {
            _notifications.Add(GetNotificationInstance(key, message));
        }

        public void AddNotification(T notification)
        {
            _notifications.Add(notification);
        }
        #endregion

        #region Overloads AddNotifications Methods 

        public void AddNotifications(IReadOnlyCollection<T> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(Notifiable<T> item)
        {
            AddNotifications(item.Notificantions);
        }
        #endregion

        #region Clear Method
        public void Clear()
        {
            _notifications.Clear();
        }
        #endregion
    }
}
