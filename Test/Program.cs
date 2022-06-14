
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

string Print(string[] array)
{
    string forPrint = string.Empty;
    if (array.Length == 0)
    {
        return forPrint += " Array is empty ";
    }
    else
    {
        forPrint += "[";
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                forPrint += array[i];
            }
            else
            {
                forPrint += array[i] + ", ";
            }

        }
        forPrint += "]";
        return forPrint;

    }


}
