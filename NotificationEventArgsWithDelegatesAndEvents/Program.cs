using NotificationEventArgsWithDelegatesAndEvents;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the publisher
        var facebookPublisher = new FacebookPublisher();

        // Subscribe to the event
        facebookPublisher.Subscribe(OnNotificationReceived);

        // Publish a notification
        facebookPublisher.PublishNotification("Hello, subscribers!");

        // Unsubscribe from the event
        facebookPublisher.Unsubscribe(OnNotificationReceived);

        // Try to publish another notification (no subscribers should be notified)
        facebookPublisher.PublishNotification("This should not be received.");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Event handler method
    static void OnNotificationReceived(object sender, NotificationEventArgs e)
    {
        Console.WriteLine($"Notification received: {e.Message} at {e.Timestamp}");
    }
}
