using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromPresentationHomeWork12
{
    class WrongLoginException : Exception
    {
        private string _customMessage;
        public string CustomMessage { get { return _customMessage; } private set { _customMessage = value; } }
        public WrongLoginException() 
        {
            CustomMessage = "Проверьте корректность введённого логина.";
        }
        public WrongLoginException(string message) : base(message)
        {
        }
    }
}
