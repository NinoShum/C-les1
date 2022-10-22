// For
string Method4(int count,string Text)
{
    string result = String.Empty; //обозначает что строка пустая

    for(int i = 0; i < count; i++)
    {
        result = result + Text;
    }
    return result;
}

//string res = Method4(count: 10, Text: "Oz");
string res = Method4(5,"Ri");
Console.WriteLine(res);
