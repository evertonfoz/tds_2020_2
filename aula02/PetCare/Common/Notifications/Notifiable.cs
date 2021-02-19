using System;
using System.Collections.Generic;

namespace PetCare.Common.Notifications
{
    public abstract class Notifiable<T> where T: Notification
    {
        #region Properties
        private readonly List<T> _notifications;
        public IReadOnlyCollection<T> Notifications => _notifications;
        #endregion

        #region Constructors
        protected Notifiable() => _notifications = new List<T>();
        private T GetNotificationInstance(string key, string message)
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { key, message });
        }
        #endregion

        #region Overload AddNotification Methods
        public void AddNotification(string key, string message)
        {
            //var notification = GetNotificationInstance(key,message);
            _notifications.Add(GetNotificationInstance(key, message));
        }
        public void AddNotification(T notification)
        {
            _notifications.Add(notification);
        }
        #endregion

        #region Overload AddNotifications Methods
        public void AddNotifications(IReadOnlyCollection<T> notifications)
        {
            _notifications.AddRange(notifications);
        }
        public void AddNotifications(Notifiable<T> item)
        {
            AddNotifications(item.Notifications);
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
