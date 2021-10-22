using System;
using System.Collections.Generic;
using System.Text;


namespace Design_Patterns
{
    public class Singleton
    {
        private static Singleton _Singleton;
        private static Guid guidID { get; set; }
        private static object lockable = new Object();
        private Singleton(){}
        
        public static Singleton getInstance()
        {
            lock (lockable)
            {
                if (_Singleton == null)
                {
                    _Singleton = new Singleton();
                    Singleton.guidID = Guid.NewGuid();
                }
            }
            return _Singleton;
        }
        public Guid getGuid()
        {
            return guidID;
        }
    }
}
