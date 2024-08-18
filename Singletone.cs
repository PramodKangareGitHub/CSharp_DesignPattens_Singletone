using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singletone
    {
        private static int Counter = 0;

        private static Singletone Instance = null;

        private Singletone(){
            Counter++;
            Console.WriteLine("Counter value : "+ Counter);
        }

        public static Singletone GetInstance(){
            if(Instance == null){
                Instance = new Singletone();
            }
            return Instance;
        }

        public void PrintDetails(string Message){
            Console.WriteLine("Message from {0}", Message);
        }
    }
}