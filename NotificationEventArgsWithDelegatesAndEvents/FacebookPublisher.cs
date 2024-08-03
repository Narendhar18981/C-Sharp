namespace NotificationEventArgsWithDelegatesAndEvents
{
    public class FacebookPublisher
    {
        // Declare the event using EventHandler<T>
        public event EventHandler<NotificationEventArgs> Notification;

        private readonly object _eventLock = new object();

        // Method to trigger the event
        public void PublishNotification(string message)
        {
            // Create the event args
            var eventArgs = new NotificationEventArgs(message);

            // Trigger the event in a thread-safe manner
            EventHandler<NotificationEventArgs> handler;
            lock (_eventLock)
            {
                handler = Notification;
            }

            if (handler != null)
            {
                foreach (EventHandler<NotificationEventArgs> subscriber in handler.GetInvocationList())
                {
                    try
                    {
                        subscriber(this, eventArgs);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error notifying subscriber: {ex.Message}");
                    }
                }
            }
        }

        // Method to subscribe to the event
        public void Subscribe(EventHandler<NotificationEventArgs> handler)
        {
            lock (_eventLock)
            {
                Notification += handler;
            }
        }

        // Method to unsubscribe from the event
        public void Unsubscribe(EventHandler<NotificationEventArgs> handler)
        {
            lock (_eventLock)
            {
                Notification -= handler;
            }
        }
    }

}
