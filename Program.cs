// int lessonNumber = 1;
// int totalLessons = 5;

// while (lessonNumber >= totalLessons)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// System.Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1: ");
// int grade = int.Parse(Console.ReadLine());
// int score = 0;

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
//     score++;
// }

// Console.WriteLine("Вводи завершён");
// Console.WriteLine($"Количество введёных оценок: {score}");

// using System.Runtime.Intrinsics.Arm;

// int sum = 0;
// int count = 0;
// int max = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1: ");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
//     if (grade > max)
//     {
//         max = grade;
//     }
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     System.Console.WriteLine("Оценок не было введено");
// }
// Console.WriteLine($"Максимальный балл: {max}");


// string correctPassword = "qwerty123";
// int count = 0;

// while (true)
// {
//     System.Console.WriteLine("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         System.Console.WriteLine("Доступ разрешён");
//         break;
//     }
//     System.Console.WriteLine("Неверный пароль, попробуйте снова");
//     count++;
// }
// Console.WriteLine($"неудачных попыток было: {count}");