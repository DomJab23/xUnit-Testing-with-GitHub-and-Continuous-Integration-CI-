using Xunit;
using MyEvents;

namespace MyEvents.Tests
{
    public class EventManagerTests
    {
        [Fact]
        public void AddEvent_IncreasesEventsCount()
        {
            var manager = new EventManager();
            var evnt = new Event("Networking Event", "Meetup", 100);
            manager.AddEvent(evnt);

            Assert.NotNull(manager.GetEvent("Networking Event"));
        }

        [Fact]
        public void CancelEvent_MakesEventInactive()
        {
            var manager = new EventManager();
            var evnt = new Event("Networking Event", "Meetup", 100);
            manager.AddEvent(evnt);
            manager.CancelEvent("Networking Event");

            Assert.False(manager.GetEvent("Networking Event").IsActive);
        }
    }
}