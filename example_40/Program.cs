/* Задача 39: Напишите программу, которая принимает
на вход три чила и проверяет, может ли существовать
треугольник со сторонами такой длины.
Теорема о неравенстве треуголника: каждая сторона
треуголтника меньше суммы двух других сторон
*/

Console.Write("Введи длину 1 стороны: ");
int side1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи длину 2 стороны: ");
int side2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи длину 3 стороны: ");
int side3 = Convert.ToInt32(Console.ReadLine());

bool existsTriangle = IsExistsTriangle(side1, side2, side3);
Console.Write(existsTriangle ? "Треугольник существует" : "Треугольник не существует");

bool IsExistsTriangle(int a, int b, int c) {
    return a < b + c && b < a + c && c < b + a;
}