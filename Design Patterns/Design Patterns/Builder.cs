using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{

    public interface ICDBuilder
    {
        IBrand getCDDetails(int budget);
    }
    public class CDBuilder : ICDBuilder
    {
        public IBrand getCDDetails(int budget)
        {
            if(budget > 400)
            {
                return new Sony();    
            }
            else
            {
                return new Sega();
            }
        }
    }
    public interface IBrand
    {
        string getBrandName();

        int getPrice();
    }
    public class Sony: IBrand, ICD
    {
        ICD CD;
        public Sony() { }
        public Sony(ICD _ICD)
        {
            CD = _ICD;
        }
        public string getBrandName()
        {
            return "Sony";
        }
        public int getPrice()
        {
            return 500;
        }
        public void getCDType(string brand, int price)
        {
            CD.getCDType(brand, price);
        }
    }
    public class Sega : IBrand, ICD
    {
        ICD CD;
        public Sega() { }
        public Sega(ICD _ICD)
        {
            CD = _ICD;
        }
        public string getBrandName()
        {
            return "Sega";
        }

        public int getPrice()
        {
            return 400;
        }
        public void getCDType(string brand, int price)
        {
            CD.getCDType(brand, price);
        }
    }
    public interface ICD
    {
        void getCDType(string brand, int price);
    }
    public class MusicCD : ICD
    {
        public void getCDType(string brand, int price)
        {
            Console.WriteLine(brand + "-Music CD, price: " + price.ToString());
        }
    }
    public class RemixCD : ICD
    {
        public void getCDType(string brand, int price)
        {
            Console.WriteLine(brand + "-Remix CD, price: " + price.ToString());
        }
    }
    public class MovieCD : ICD
    {
        public void getCDType(string brand, int price)
        {
            Console.WriteLine(brand + "-Movie CD, price: " + price.ToString());
        }
    }
}
