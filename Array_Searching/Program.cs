class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int[] arr = new int[10];
        Console.WriteLine("Array with index of 10. Please enter values");
        for (int i = 0; i < arr.Length; i++)
        {
            string? input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            arr[i] = value;
        }
        Console.WriteLine("Enter a number to find if it is in the array");
        string? input2 = Console.ReadLine();
        int addValue = Convert.ToInt32(input2);
        for (int i = 0; i < arr.Length; i++)
        {
            if (addValue == arr[i])
            {
                count++;
            }
        }
        if (count != 0)
        {
            Console.WriteLine("The Array has "+ addValue + " and the number of it is " + count );
        }
        else
        {
            Console.WriteLine("No exiest "+ addValue );
        }
    }
}