using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    public interface IBrandFactory
    {
        IMobileFactory getMobileBrandFactory(int budget);
        ILaptopFactory getLaptopBrandFactory(int budget);
    }

    public class BrandFactory : IBrandFactory
    {
        IMobileFactory mobileBrandFactory;
        ILaptopFactory laptopBrandFactory;

        ILaptopFactory IBrandFactory.getLaptopBrandFactory(int budget)
        {
            if (budget > 150000)
                laptopBrandFactory = new MSIFactory();
            else if (budget < 50000)
                laptopBrandFactory = new HPFactory();
            else
                laptopBrandFactory = new DellFactory();
            return laptopBrandFactory;
        }

        IMobileFactory IBrandFactory.getMobileBrandFactory(int budget)
        {
            if (budget > 50000)
                mobileBrandFactory = new SamsungFactory();
            else if (budget < 25000)
                mobileBrandFactory = new RedMiFactory();
            else
                mobileBrandFactory = new OnePlusFactory();
            return mobileBrandFactory;
        }

    }
    public interface IMobileFactory
    {
        void getMobileBrand();
    }

    public class SamsungFactory : IMobileFactory
    {
        public void getMobileBrand()
        {
            Console.WriteLine("Samsung phone");
        }
    }

    public class OnePlusFactory : IMobileFactory
    {
        public void getMobileBrand()
        {
            Console.WriteLine("OnePlus phone");
        }
    }

    public class RedMiFactory : IMobileFactory
    {
        public void getMobileBrand()
        {
            Console.WriteLine("RedMi phone");
        }
    }
    public interface ILaptopFactory
    {
        public void getLaptopBrand();
    }

    public class MSIFactory : ILaptopFactory
    {
        public void getLaptopBrand()
        {
            Console.WriteLine("MSI laptop");
        }
    }

    public class DellFactory : ILaptopFactory
    {
        public void getLaptopBrand()
        {
            Console.WriteLine("Dell laptop");
        }
    }

    public class HPFactory : ILaptopFactory
    {
        public void getLaptopBrand()
        {
            Console.WriteLine("HP laptop");
        }
    }
}
