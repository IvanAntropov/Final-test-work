
//string[] arr = { "adf", "asdf", "13fdf", "adkook", "4okko", "fhgd" };

Console.WriteLine(Print(SolveEx(CreatArray("Введите слова в массив через пробел"))));

string[] creatArray(string description)
{
    
    Console.WriteLine(description);
    string help = string.Empty; 
    help = Console.ReadLine();
    string[] array = help.Split(" ");
    return array;
}


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
