
public static class Extensions
{
    public static T[] Append<T>(this T[] array, T NewValue)
    {
        if (array == null)
        {
            return new T[] { NewValue };
        }

        T[] result = new T[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[i];
        }

        result[array.Length] = NewValue;
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[6];

        Console.WriteLine("An array of six indexes was created. Enter a number for each index: ");

        for (int i = 0; i < arr.Length; i++)
        {
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            arr[i] = num;
        }

        Console.WriteLine(" ");
        Console.Write("Enter a number to add: ");
        int NewInput = Convert.ToInt32(Console.ReadLine());

        int[] result = arr.Append(NewInput);
        Array.Sort(result);
        Console.WriteLine(String.Join(" ", result));
    }
}