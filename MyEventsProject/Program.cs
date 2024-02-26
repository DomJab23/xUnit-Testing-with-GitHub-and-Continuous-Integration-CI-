using System;

namespace MyEvents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Event Management System");

            // Create an instance of EventManager
            EventManager manager = new EventManager();

            // Create some sample events
            Event codingWorkshop = new Event("Coding Workshop", "Workshop", 30);
            Event techTalk = new Event("Tech Talk", "Seminar", 100);

            // Add events to the manager
            manager.AddEvent(codingWorkshop);
            manager.AddEvent(techTalk);

            // Display all events
            Console.WriteLine("Upcoming Events:");
            DisplayEvent(codingWorkshop);
            DisplayEvent(techTalk);

            // Simulate attendee registration
            Console.WriteLine("\nRegistering 1 attendee for the Coding Workshop...");
            bool registrationResult = codingWorkshop.RegisterAttendee();
            Console.WriteLine($"Registration successful: {registrationResult}");
            DisplayEvent(codingWorkshop); // Show updated capacity

            // Simulate event cancellation
            Console.WriteLine("\nCancelling the Tech Talk...");
            bool cancellationResult = manager.CancelEvent("Tech Talk");
            Console.WriteLine($"Cancellation successful: {cancellationResult}");
            DisplayEvent(techTalk); // Show updated status

            // Keep the console window open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void DisplayEvent(Event evnt)
        {
            Console.WriteLine($"Event: {evnt.Name}, Type: {evnt.Type}, Capacity: {evnt.Capacity}, Active: {evnt.IsActive}");
        }
    }
}