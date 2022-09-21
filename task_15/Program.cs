Console.WriteLine("Введите номер дня недели: ");
string? numDay = Console.ReadLine();
string? WeekEnd (string? week)
{
    if (numDay == "1")
{
    Console.WriteLine ("Рабочий день");
}
else if (numDay == "2")
{
    Console.WriteLine ("Рабочий день");
} 
else if (numDay == "3")
{
    Console.WriteLine ("Рабочий день");
} 
else if (numDay == "4")
{
    Console.WriteLine ("Рабочий день");
} 
else if (numDay == "5")
{
    Console.WriteLine ("Рабочий день");
} 
else if (numDay == "6")
{
    Console.WriteLine ("Это выходной Суббота");
} 
else if (numDay == "7")
{
    Console.WriteLine ("Это выходной Воскресение");
} 
else
{
    Console.WriteLine ("Вы ввели неверное значение");
}

return ("-1");

}

string? WE =  WeekEnd(numDay);