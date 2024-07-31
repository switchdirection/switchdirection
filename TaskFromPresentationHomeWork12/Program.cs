namespace TaskFromPresentationHomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login, password, confirmPassword;
            Console.WriteLine("Введите логин: ");
            login = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            password = Console.ReadLine();
            Console.WriteLine("Подтвердите введённый пароль: ");
            confirmPassword = Console.ReadLine();
            Authorization.AuthorizationProcess(login, password, confirmPassword);
        }
    }
}
