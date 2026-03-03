// See https://aka.ms/new-console-template for more information
using hw10_delegate;


SmartHomeHub smartHomeHub = new SmartHomeHub();

SmartLamp smartLamp1 = new SmartLamp(smartHomeHub);
SmartLamp smartLamp2 = new SmartLamp(smartHomeHub);
SecuritySiren SecuritySiren = new SecuritySiren(smartHomeHub);
SmartphoneApp SmartphoneApp = new SmartphoneApp(smartHomeHub);

smartHomeHub.TriggerFireAlarm();
smartHomeHub.TriggerMotion();
smartHomeHub.TriggerDoorbell();
smartHomeHub.TriggerPhoneCall();