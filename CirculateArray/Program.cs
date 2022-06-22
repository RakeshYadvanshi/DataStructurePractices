


Console.WriteLine(string.Join("->", Circlulate.CirculateArray(new int[] { 1, 2, 3, 5, 6 })));

Console.WriteLine(string.Join("->", Circlulate.CirculateArray(new int[] { 5, 6 })));

Console.WriteLine(string.Join("->", Circlulate.CirculateArray(new int[] { 6 })));


public class Circlulate
{

    // assumption array wouldn't be null
    public static int[] CirculateArray(int[] array)
    {
        if (array.Length < 2)
        {
            return array;
        }
        var tempFirstItem = array[0];

        for (int i = 0; i < array.Length-1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = tempFirstItem;
        return array;


    }

}




