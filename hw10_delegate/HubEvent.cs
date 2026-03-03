using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10_delegate
{
    enum EventName
    {
        Motion,
        Fire,
        Doorbell,
        PhoneCall
    }

    enum Priority
    {
        Info = 1,
        Low = 2,
        Medium = 3,
        High = 4,
        Urgent = 5
    }

    internal class HubEvent
    {
        public EventName EventName {  get; }
        public DateTime StartTime { get; set; }

        public Priority Priority { get; set; }

        public HubEvent(EventName eventName, Priority priority, DateTime startTime =  default(DateTime))
        {
            EventName = eventName;
            StartTime = startTime;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"HubEvent: {EventName} with priority {Priority} emerged at {StartTime}";
        }

    }
}
