// С клавиатуры вводятся два числа. Найти и вывести на экран их сумму 
//string s;
int a,b,sum;
System.Console.Write("Введите a:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
//1 Конкатенация (склеивание) строк
System.Console.Write(a+"+"+b+"="+Convert.ToString (sum));
//2 Форматированный вывод 
System.Console.WriteLine("{0}+{1}={2}",a,b,sum);
//3 Интерполяция строк
System.Console.WriteLine($"{a}+{b}={sum}");

// С клавиатуры вводятся два числа. Найти и вывести на экран максимальное из них
int max;
if (a>b)
{
  max=a;
}
else
{
  max=b;
}
System.Console.WriteLine($"max={max}");



