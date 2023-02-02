//15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что ее нет (Вывести:NO).
System.Console.WriteLine("Введите число: ");
string a= System.Console.ReadLine();
if (a.Length>2)
    System.Console.WriteLine(a[2]);
else
{
    System.Console.WriteLine("NO");

}


