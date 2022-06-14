
string[] arr = { "as", "as", "13f", "adkook", "4okko", "fhg" };

//CreatArray();


Console.WriteLine(Print(SolveEx(arr)));

/*
string[] CreatArray()
{

}
*/

string[] SolveEx(string[] array)
{

    string help = null;
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

string Print(string[] array)
{
   string forPrint = string.Empty;
    forPrint += "[";
    if (array == null)
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
