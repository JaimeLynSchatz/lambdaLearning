using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningLamdas
{
    public class EmailSender
    {
        private int sendResult;
        public int SendEmail() // signature matches delegate, can be used
        {
            Console.WriteLine("Simulating sending email...");
            sendResult = 0;
            return sendResult;
        }
    }
}
