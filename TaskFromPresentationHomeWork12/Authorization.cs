using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromPresentationHomeWork12
{
    sealed class Authorization
    {
        public static bool AuthorizationProcess(string login, string password, string confirmPassword)
        {
            try
            {
                if(login.Length >20 || login.Contains(' '))
                {
                    throw new WrongLoginException("Какое-то кастомное сообщение для исключения");
                }
                if(password.Length > 20)
                {
                    throw new WrongPasswordException();
                }
                if (password!=confirmPassword)
                {
                    throw new WrongPasswordException();
                }
                if (CheckPassword(password))
                {
                    throw new WrongPasswordException();
                }
            }
            catch(WrongLoginException ex)
            {
                if(ex.CustomMessage != null) 
                {
                    Console.WriteLine("Ошибка: " + ex.CustomMessage);
                    return false;
                }
                else
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            catch(WrongPasswordException ex)
            {
                if (ex.CustomMessage != null)
                {
                    Console.WriteLine("Ошибка: " + ex.CustomMessage);
                    return false;
                }
                else
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка: Произошла какая-то другая ошибка...");
                return false;
            }
            Console.WriteLine("Регистрация прошла успешно :)");
            return true;
        }

        private static bool CheckPassword(string pas)
        {
            int count = 0;
            if(pas.Contains(' '))
            {
                return true;
            }
            foreach(char c in pas)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            if(count >= 1)
            {
                return false;   
            }
            else
            {
                return true;
            }
        }
    }
}
