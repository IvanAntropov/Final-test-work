
string[] arr = { "adf", "asdf", "13fdf", "adkook", "4okko", "fhgd" };

//CreatArray();

int flag = 0;
Console.WriteLine(Print(SolveEx(arr, flag), flag));

/*
string[] CreatArray()
{

}
*/

string[] SolveEx(string[] array, int flag)
{

   string help = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            help += array[i] + " ";
        }
    }
    help = help.TrimEnd(' ');
    string[] result = help.Split(" ");
    return result;
}

string Print(string[] array, int flag)
{
    string forPrint = string.Empty;
    forPrint += "[";
    if (array[0] == "")
    {
        forPrint += " Array is empty ";
        
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            forPrint += array[i] + ", ";
        }
        forPrint = forPrint.TrimEnd(',',' ');
    }
    forPrint += "]";
    return forPrint;

}
