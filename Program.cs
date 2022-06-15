// Домашка №2
//1

/*
Console.Write("input num: ");
int num = Convert.ToInt32(Console.ReadLine());
int thirdnum = num / 10;
int secondnum = thirdnum % 10;
Console.WriteLine(secondnum);
*/

//2
/*
Console.WriteLine("Input num: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 99 && N < 1000)
{
    int n = N % 10;
    Console.WriteLine("Third number is: " + n);
}
else if(N > 0 && N < 100)
{
    int n = N % 10;
    Console.WriteLine("Third number off");
}
else 
{
    if (N > 1000 && N < 10000)
    {
        int n = (N / 10) % 10;
        Console.WriteLine("Third number is: " + n);
    }
    else if (N > 1000 && N < 10000);
    {
        int n = (N / 100) % 10;
        Console.WriteLine("Third number is: " + n);
    }

}
*/

//3

Console.WriteLine("Input num day: ");
string[] Days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
string writeDay = Console.ReadLine();
bool result = int.TryParse(writeDay, out int dayNumber);
if(0 < dayNumber && dayNumber < 6)
{
Console.WriteLine($"{dayNumber}-рабочий день недели - {Days[dayNumber - 1]}");
}
else if(5 < dayNumber && dayNumber < 8)
{
Console.WriteLine($"{dayNumber}-выходной день недели - {Days[dayNumber - 1]}");
}
else Console.WriteLine("Дня недели с таким номером не существует");



