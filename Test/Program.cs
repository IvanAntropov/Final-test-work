
string[] arr = { "asdf", "asdf", "13fdf", "adkook", "4okko", "fhgd" };

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

    string help = null;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            help += array[i] + " ";
        }
    }

    string[] result = new string[] { };
    if (help == null)
    {
        flag++;
        return result;
    }
    else
    {
        help = help.TrimEnd(' ');
        result = help.Split(" ");
        return result;
    }
}

string Print(string[] array, int flag)
{
    string forPrint = string.Empty;
    forPrint += "[";
    if (flag == 1)
    {
        forPrint += " Array is empty ";

    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            forPrint += array[i] + ", ";
        }
        forPrint = forPrint.TrimEnd(',', ' ');
    }
    forPrint += "]";
    return forPrint;
}
