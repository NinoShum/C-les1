int [] array = { 15,451,451,41,21,-1,51,195};

int n = array.Length;
int find = 451;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
