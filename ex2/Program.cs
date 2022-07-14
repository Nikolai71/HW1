Console.WriteLine("Введите три числа : ");

int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());

int c = Convert.ToInt32(Console.ReadLine());

int max = a;
        
if (max < b) max = b;

if (max < c) max = c;

Console.WriteLine("{0} наибольшее число", max);
