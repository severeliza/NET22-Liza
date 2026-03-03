using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10_delegate
{
    internal class SecuritySiren : ISmartDevice
    {
        public string Name { get; } = "SecuritySiren";

        public SecuritySiren(SmartHomeHub hub)
        {
            //подписывается на события хаба в конструкторе
            hub.OnEvent += ReactToEvent;
        }

        public void ReactToEvent(HubEvent eventData)
        {
            //анализирует тип события и его параметры, чтобы решить, включаться или выключаться.
            if (eventData.EventName == EventName.Fire)
            {
                Console.WriteLine($"{Name}: The siren is blaring.");
            }
        }
    }
}
