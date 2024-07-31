using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromPresentationHomeWork12
{
    class WrongPasswordException : Exception
    {
        private string _customMessage;
        public string CustomMessage { get { return _customMessage; } private set { _customMessage = value; } }
        public WrongPasswordException()
        {
            CustomMessage = "Проверьте корректность введённого пароля.";
        }
        public WrongPasswordException(string message) : base(message)
        {
        }
    }
}
