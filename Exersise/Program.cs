Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());

// Пользователь вводит 2 числа необходимо найти максимум
// n > m
// n < m
// n == m
// = - оператор присвоения 
// == - проверка на равенство 
if (n > m )
    Console.WriteLine(n);
else if (n < m)
    Console.WriteLine(m);
else 
    Console.WriteLine("=");