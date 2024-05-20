using Api_Rest_1.Entities;

namespace Api_Rest_1.Persistence
{
    public class DevEventsDbContext
    {
        public List<DevEvent> DevEvents { get; set; }

        public DevEventsDbContext()

        { 
            DevEvents = new List<DevEvent>();
        }
    }
}
