using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10_delegate
{
    internal class SmartphoneApp : ISmartDevice
    {
        public string Name { get; } = "SmartphoneApp";

        public SmartphoneApp(SmartHomeHub hub)
        {
            //подписывается на события хаба в конструкторе
            hub.OnEvent += ReactToEvent;
        }

        public void ReactToEvent(HubEvent eventData)
        {
            switch (eventData.EventName)
            {
                case EventName.Doorbell:
                    Console.WriteLine($"{Name}: Doorbell");
                    break;
                case EventName.Fire:
                    Console.WriteLine($"{Name}: Fire! Calling 911.");
                    break;
                case EventName.PhoneCall:
                    Console.WriteLine($"{Name}: You have a phoneCall.");
                    break;
                default:
                    break;
            }

        }
    }
}
