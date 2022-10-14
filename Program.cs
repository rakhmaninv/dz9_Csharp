while (true)
{
    Console.Write("select task number(64, 66 or 68): ");
    string task = Console.ReadLine() ?? "0";
    if (task == "64") 
    {
        Task64();
        break;
    }
    else if (task == "66") 
    {
        Task66();
        break;
    }
    else if (task == "68") 
    {
        Task68();
        break;
    }
    else Console.WriteLine("Incorrect task number");
}
void Task64() //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
{
    int numberN = UserNumberInput("enter a number: ");
    PrintNumbersFromNToOne(numberN);
}
void Task66() //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
{
    int numberM = UserNumberInput("enter number M: ");
    int numberN = UserNumberInput("enter number N: ");
    int sum = 0;
    if (numberN < 0 && numberM < 0) Console.WriteLine($"There are no natural numbers between {numberM} and {numberN}");
    else if (numberM > numberN)
        Console.WriteLine($"sum of natural elements between {numberN} and {numberM} is: {SumOfNumbersFromMtoN(numberN, numberM, sum)}");
    else 
        Console.WriteLine($"sum of natural elements between {numberM} and {numberN} is: {SumOfNumbersFromMtoN(numberM, numberN, sum)}");
}
void Task68() //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
{
    int numberM = UserNonNegativeNumberInput("enter non-negative(>=0) number M: ");
    int numberN = UserNonNegativeNumberInput("enter non-negative(>=0) number N: ");
    Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {Ackermann(numberM, numberN)}");
}
int UserNumberInput(string msg)
{
    int userNumber;
    while (true)
    {
        try
        {
            Console.Write(msg);
            userNumber = int.Parse(Console.ReadLine()!);
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
    return userNumber;
}
void PrintNumbersFromNToOne(int n)
{
    Console.Write(n + " ");
    if (n == 1) Console.Write('\b');
    else PrintNumbersFromNToOne(n-1);
}
int SumOfNumbersFromMtoN(int m, int n, int sum)
{
    if (m < 0) m = 1;
    if (m == n +1) return sum;
    else
    {
        sum += m;
        return SumOfNumbersFromMtoN(m+1, n, sum);
    }
}
int UserNonNegativeNumberInput(string msg)
{
    int userNumber;
    while (true)
    {
        try
        {
            Console.Write(msg);
            userNumber = int.Parse(Console.ReadLine()!);
            if (userNumber >= 0) break;
            else Console.WriteLine("You entered negative number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
    return userNumber;
}
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m-1, 1);
    else return Ackermann(m-1, Ackermann(m, n-1));
}