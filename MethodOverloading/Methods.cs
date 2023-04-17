using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int a, int b) 
        {
            return a + b;       
        }

        public static decimal Add(decimal a, decimal b)
        { 
            return a + b;
        }

        public static string Add(int a, int b, bool withDollars) 
        {
            if (withDollars && (a + b) != 1) 
            {
                 return (a + b).ToString() + " dollars";          
            }   
            else if (withDollars && (a +b) ==  1)
            { 
                return (a + b).ToString() + " dollar"; 
            }
            else
            {
                return (a + b).ToString();
            }            
        }
    }


}
