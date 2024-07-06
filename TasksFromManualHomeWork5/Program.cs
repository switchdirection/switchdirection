using System.Text;

namespace TasksFromManualHomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string argument = "1234-abc-5678-def-9g0h";
            ManualTasks.EightFirstDigit(argument);
            ManualTasks.ReplaceLetters(argument);
            ManualTasks.LowerCaseLettersInFormat(argument);
            ManualTasks.UpperCaseLettersInFormat(argument);
            ManualTasks.CheckIfAStringStartingWithASequence(argument);
        }

        
    }
}
