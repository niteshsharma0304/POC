using System;


namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------Builder Design Pattern----------------
            //ICDBuilder cdBuilder = new CDBuilder();
            //IBrand brand = cdBuilder.getCDDetails(600);
            //ICD CD = new MovieCD();
            //CD.getCDType(brand.getBrandName(), brand.getPrice());


            //------------Template Design Pattern----------------
            //IWorkRoutine labor = new Labor();
            //WorkRoutine workRoutine = new WorkRoutine(labor);
            //workRoutine.getJobStartTime();
            //workRoutine.getBreakDuration();
            //workRoutine.getJobEndTime();

            //------------Strategy Design Pattern----------------
            //IModesOfTransport modesOfTransport = new Taxi();
            //ModesOfTransport modes = new ModesOfTransport(modesOfTransport);
            //modes.getVehicle();

            //------------Abstract Factory Design Pattern----------------
            //IBrandFactory brandFactory = new BrandFactory();
            //IMobileFactory mobileFactory = brandFactory.getMobileBrandFactory(30000);
            //ILaptopFactory laptopFactory = brandFactory.getLaptopBrandFactory(100000);
            //mobileFactory.getMobileBrand();
            //laptopFactory.getLaptopBrand();

            //------------Factory Design Pattern----------------
            //IShipmentFactory factory = new ShipmentFactory();
            //IPrintShipmentMethod printShipmentMethod = factory.getShippingMethod("land");
            //printShipmentMethod.printShipmentMethod();

            //------------Singleton Design Pattern----------------
            //Singleton _Singleton1 = Singleton.getInstance();
            //Singleton _Singleton2 = Singleton.getInstance();
            //Console.WriteLine("_Singleton1 counter: " + _Singleton1.getGuid().ToString());
            //Console.WriteLine("_Singleton2 counter: " + _Singleton2.getGuid().ToString());
        }
    }
}
