using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10_delegate
{
    delegate void EventHandler<HubEvent>(HubEvent hubEvent);

    internal class SmartHomeHub
    {
        public event EventHandler<HubEvent>? OnEvent;

        
        protected void RaiseEvent(HubEvent hubEvent)
        {
            OnEvent?.Invoke(hubEvent);
        }

        public void TriggerMotion()
        {
            HubEvent motionEvent = new HubEvent(EventName.Motion, Priority.High);

            Console.WriteLine("MotionEvent was genereted.");

            RaiseEvent(motionEvent);
        }

        public void TriggerFireAlarm()
        {
            HubEvent fireAlarmEvent = new HubEvent(EventName.Fire, Priority.Urgent);

            Console.WriteLine("FireAlarm was genereted.");

            RaiseEvent(fireAlarmEvent);
        }

        public void TriggerPhoneCall()
        {
            HubEvent phoneCallEvent = new HubEvent(EventName.PhoneCall, Priority.Info);

            Console.WriteLine("PhoneCallEvent was genereted.");

            RaiseEvent(phoneCallEvent);
        }

        public void TriggerDoorbell()
        {
            HubEvent doorbellEvent = new HubEvent(EventName.PhoneCall, Priority.Medium);

            Console.WriteLine("Doorbell was genereted.");

            RaiseEvent(doorbellEvent);
        }


    }
}
