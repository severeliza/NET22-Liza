using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10_delegate
{
    internal interface ISmartDevice
    {
        public string Name { get; }

        public void ReactToEvent(HubEvent eventData);
    }
}
