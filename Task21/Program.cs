//Напишите программу, которая принимает на вход координаты
 //двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
string prefStr = "Введите координату ";
Console.Write(prefStr + "Ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write(prefStr + "Ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write(prefStr + "Az: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write(prefStr + "Bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write(prefStr + "By: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write(prefStr + "Bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

int xba = bx - ax;
int yba = by - ay;
int zba = bz - az;

double ab = Math.Sqrt(Math.Pow(xba,2)+Math.Pow(yba,2)+ Math.Pow(zba,2));
Console.WriteLine(Math.Round(ab, 2));