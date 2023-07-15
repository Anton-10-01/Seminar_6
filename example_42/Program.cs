/* Задача 39: Напишите программу, которая юудет преобразовывать
десятичное число в двоичное.
46 -> 101110
13 -> 1101
2 -> 10
*/

Console.Write("Введи положитеьное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DecToBin(number));
Console.Write(DecToBinStr(number));

int DecToBin(int num) {
    int result = 0;
    int factor = 1;
    while (num > 0) {
        result += num % 2 * factor;
        num /= 2;
        factor *= 10;
    }
    return result;
}

 string DecToBinStr(int num) {
    string result = String.Empty;
    while (num > 0) {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}