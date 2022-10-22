//Метод, ничего не принимает и не отдает
//Можно использовать например для вывода сообщения в конце программы

void Method1()
{
    Console.WriteLine ("Программа выполнена");
}
Method1();
// Method1 указывать без скобок нельзя, программа не поймет что это метод


// Метод принимает аргументы, но не возвращает

void Method2 (string msg)
{
    Console.WriteLine(msg);
}
Method2("Неявный способ задать переменную");
Method2(msg: "Явный способ задать переменную");


void Method2_5(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2_5("сообщение 1", 2);
Method2_5(msg:"сообщение 2", count: 3);
Method2_5( count: 2, msg: "сообщение 3"); //можно таким образом 
                                          //изменить порядок внесения переменных


//Метод, ничего не получает, но выводит

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);



//метод принимает значения и возвращает 1 значение

string Method4(int count,string Text)
{
    int i = 0;
    string result = String.Empty; //обозначает что строка пустая

    while (i < count)
    {
        result = result + Text;
        i++;
    }
    return result;
}

//string res = Method4(count: 10, Text: "Oz");
string res = Method4(5,"Ri");
Console.WriteLine(res);


