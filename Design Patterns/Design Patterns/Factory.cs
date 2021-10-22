using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    
    public interface IShipmentFactory
    {
        IPrintShipmentMethod getShippingMethod(string medium);   
    }

    public class ShipmentFactory : IShipmentFactory
    {
        public IPrintShipmentMethod getShippingMethod(string medium)
        {
            if (medium == "land")
                return new RoadTransport();
            else if (medium == "sea")
                return new ShipTransport();
            else
                return new AirTransport();
        }
    }

    public interface IPrintShipmentMethod
    {
        void printShipmentMethod();
    }
    public class RoadTransport : IPrintShipmentMethod
    {
        public void printShipmentMethod()
        {
            Console.WriteLine("Road Transport");
        }
    }
    public class AirTransport : IPrintShipmentMethod
    {
        public void printShipmentMethod()
        {
            Console.WriteLine("Air Transport");
        }
    }
    public class ShipTransport : IPrintShipmentMethod
    {
        public void printShipmentMethod()
        {
            Console.WriteLine("Sea Ship");
        }
    }
}
