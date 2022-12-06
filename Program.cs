// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int SecondNumber() {
    Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int second_number = num / 10;
    return second_number % 10; 
}

int result = SecondNumber();
Console.WriteLine (result);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void Weekend(int num){
//     if (num >0 && num <= 5)
//         Console.WriteLine("Это не выходной день");
//     else if (num == 6 || num == 7)
//         Console.WriteLine("Ура! Это выходной день!");
//     else
//         Console.WriteLine("Введите число от 1 до 7");
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Weekend(num);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void ThirdNumber (int num) {
//     if (num > 100 && num < 1000){
//         int third = num % 10;
//         Console.WriteLine(third);
//     }
//     else if (num < 100)
//         Console.WriteLine("Третьей цифры нет.");
//     else 
//         while (num >= 1000)
//         num = num / 10;
//         Console.WriteLine(num % 10);
// }
//  Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
//  ThirdNumber (num);