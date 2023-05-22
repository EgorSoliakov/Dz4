// Задача 27: Напишите программу, которая 
//принимает на вход число и выдаёт сумму цифр 
//в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt()
{
Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine());
return limit;
}

int Res(int a)
{
    int res = 0;
    while (a>0)
    {
        
      int b=a%10;
      res = res+b;
      a/=10;
    }
    return res;
}

int A = Prompt();
Console.WriteLine($"->{Res(A)}");

