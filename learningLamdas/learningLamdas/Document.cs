using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningLambdas
{
    public class Document
    {
        // public delegate int FindResult(object obj1);
        // Once the delegate is created, you can excapsulate anymember method that meets the signature and return type
        // no method body needed
        // decouple the class that declares the delegate from the class that uses the delegate

        public string Text { get; set; }
        public delegate int SendDoc();

        public void ReportSendingResult(SendDoc sendingDelegate)
        {
            if (sendingDelegate() == 0)
            { 
                Console.WriteLine("Success");
            }
            else
            { 
                Console.WriteLine("Unable to send!");
            }
        }


    }
}
