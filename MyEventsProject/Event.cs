namespace MyEvents
{
    public class Event
    {
        public string Name { get; }
        public string Type { get; }
        public int Capacity { get; private set; }
        public bool IsActive { get; private set; }

        public Event(string name, string type, int capacity)
        {
            Name = name;
            Type = type;
            Capacity = capacity;
            IsActive = true;
        }

        public void Cancel()
        {
            IsActive = false;
        }

        public bool RegisterAttendee()
        {
            if (IsActive && Capacity > 0)
            {
                Capacity--;
                return true;
            }
            return false;
        }
    }
}