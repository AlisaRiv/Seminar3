//Напишите программу, которая принимает на вход
 //число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("Ведите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
int i = 1;
bool isFirst = true;
while (i <= number) {
    string prefix = isFirst ? "" : ", ";
    double cube = Math.Pow(i, 3);
    Console.Write($"{prefix}{cube}");
    if (isFirst) {
        isFirst = false;
    }
    i++;
}
