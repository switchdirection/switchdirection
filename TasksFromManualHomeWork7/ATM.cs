using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork7
{
    internal class ATM
    {
        private int _twenty;
        private int _fifty;
        private int _oneHundred;

        public int Twenty { get { return _twenty; } set { _twenty = value; } }
        public int Fifty { get { return _fifty; } set { _fifty = value; } }
        public int OneHundred { get { return _oneHundred; } set { _oneHundred = value; } }

        public ATM() 
        {
            Twenty = 10;
            Fifty = 10;
            OneHundred = 10;
        }

        public ATM(int t, int f, int h)
        {
            Twenty = t;
            Fifty = f;
            OneHundred = h;
        }

        public bool AddMoneyToATM(int twenty, int fifty, int hundred)
        {
            if (twenty < 0 || fifty < 0 || hundred < 0)
            {
                return false;
            }
            else
            {
                Twenty += twenty;
                Fifty += fifty;
                OneHundred += hundred;
                return true;
            }
        }
        
        public bool WithdrawMoneyFromAnATM(int amount)
        {
            int t = 0;
            int f = 0;
            int h = 0;
            if (amount < 0)
            {
                return false;
            }
            else
            {
                if (((Twenty*20) + (Fifty*50) + (OneHundred*100)) - amount > 0)
                {

                    while (amount > 0)
                    {
                        if (amount - 100 >= 0)
                        {
                            h++;
                            OneHundred--;
                            amount -= 100;
                            continue;
                        }
                        else if (amount - 50 >= 0)
                        {
                            f++;
                            Fifty--;
                            amount -= 50;
                            continue;
                        }
                        else if (amount - 20 >= 0)
                        {
                            t++;
                            Twenty--;
                            amount -= 20;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Оставшиеся деньги которые не были выдра т.к. нет нужного номинала: " + amount);
                            break;  
                        }
                    }
                    Console.WriteLine($"Деньги были выданы купюрами:\n20-рублёвые купюры: {t}\n50-рублёвые купюры: {f}\n100-рублёвые купюры: {h}");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Купюр оставших в банкомате:" +
                $"\n20-рублёвые купюры: {Twenty}" +
                $"\n50-рублёвые купюры: {Fifty}" +
                $"\n100-рублёвые купюры: {OneHundred}");
        }
    }
}
