// See https://aka.ms/new-console-template for more information
Console.WriteLine("Мы попали в игру угадай число");
int secret_number = new Random().Next(1,11);
int attempt = 3;
bool Win = false;
while (attempt > 0)
{
    System.Console.WriteLine("Введите число от 1 до 10");
    int user_number = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine(user_number);
    if(user_number > secret_number)
    {
        System.Console.WriteLine("Секретное число меньше");
        attempt--;
    }
    else if(user_number < secret_number)
    {
        System.Console.WriteLine("Секретное число больше");
                attempt--;
    }
    else if (user_number == secret_number)
    {
        System.Console.WriteLine("Вы угадали");
        Win = true;
        break;
    }
    System.Console.WriteLine("Попробуй еще раз, попыток осталось " + attempt);
}
if(Win)
{
    System.Console.WriteLine("Вы победили, маладис увидимся позже");
    System.Console.WriteLine("Осталось попыток " + (attempt-1));
}else 
{
    System.Console.WriteLine("Вы проиграли, секретное число было " + secret_number);
    System.Console.WriteLine("Попробуйте еще раз");
}


