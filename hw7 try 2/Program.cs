
using hw7_try_2;

Computer comp1 = new Computer("HP", 1000);
comp1.Info();

Computer comp2 = new Computer("Lenovo", 1000, new RAM("ramName", 8), new HDD("hddName", 512, HDDType.externalHDD));
comp2.Info();

