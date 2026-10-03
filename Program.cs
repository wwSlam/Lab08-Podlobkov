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

// string answer;

// do {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранён");


// Console.WriteLine();
// Console.WriteLine("Первое задание A");

// Console.Write("Введите любое число: ");
// int num1 = int.Parse(Console.ReadLine());
// int i = 1;
// {
//       while (i <= 10)
//          {
//                System.Console.WriteLine($"{i} * {num1} = {i * num1}");
//                i++ ;
//          }
// }

// Console.WriteLine();
// Console.WriteLine("Задание В");

// int sum = 0;

// while (true)
// {
//     Console.Write("Введите количество страниц прочитанных за день  (чтобы выйти введите: -1) : ");
//     int book = int.Parse(Console.ReadLine());
//     if (book == -1)
//          {
//           break;
//            }
//     sum += book;
// }
// Console.WriteLine($"прочитано страниц {sum}");

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// Console.WriteLine();
// Console.WriteLine("Индивидуальное задание номер 2");

// int summ = 0;

// while (true)
// {
//     Console.Write("Введите число(чтобы остановить введите 0): ");
//     string str = Console.ReadLine();
//     if (str == "0")
//     {
//         break;
//     }
//     if (int.TryParse(str, out int num))
//     {
//         if (num < 0)
//         {
//             continue;
//         }
//         if (num > 0)
//         {
//             summ += num;
//         }
//     }
// }
// System.Console.WriteLine($"{summ}");

System.Console.WriteLine();
System.Console.WriteLine("Задание 9. Самостоятельная работа");

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int total = 0;
int i = 2;

while (i <= num) 
{
     total += i;
     i += 2;           
}

Console.WriteLine($"Сумма чётных чисел от 1 до {num} = {total}");