using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    public interface IModesOfTransport
    {
        void getVehicle();
    }
    public class ModesOfTransport: IModesOfTransport
    {
        public IModesOfTransport Modes;

        public ModesOfTransport(IModesOfTransport _IModesOfTransport)
        {
            Modes = _IModesOfTransport;
        }

        public void getVehicle()
        {
            Modes.getVehicle();
        }
    }
    
    public class Taxi : IModesOfTransport
    {
        void IModesOfTransport.getVehicle()
        {
            Console.WriteLine("Getting Taxi");
        }
    }
    public class Bus : IModesOfTransport
    {
        void IModesOfTransport.getVehicle()
        {
            Console.WriteLine("Getting Bus");
        }
    }
    public class Auto : IModesOfTransport
    {
        void IModesOfTransport.getVehicle()
        {
            Console.WriteLine("Getting Auto");
        }
    }
}
