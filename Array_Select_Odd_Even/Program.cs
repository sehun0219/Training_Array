
class Array
{
    public int[]? arr;

    public void Starting()
    {
        Console.WriteLine("How many indexes do you want to create?");
    }
    public int GetIndexNum()
    {
        int indexNum = Convert.ToInt32(Console.ReadLine());
        return indexNum;
    }
    public void AddIndexValue()
    {
        Console.WriteLine("=== Please enter a value ===");
        for (int i = 0; i < arr?.Length; i++)
        {
            string inputValue = Console.ReadLine();
            int inputvalue = Convert.ToInt32(inputValue);
            arr[i] = inputvalue;
        }
    }
    public void PrintEvenNum(int[] arr)
    {
        int even = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                even = arr[i];
                Console.Write(even + " ");
            }
        }
        Console.ReadLine();
    }

    public void PrintOddNum(int[] arr)
    {
        int Odd = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                Odd = arr[i];
                Console.Write(Odd + " ");
            }
        }
        Console.ReadLine();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Array NewArr = new Array();
        NewArr.Starting();
        NewArr.arr = new int[NewArr.GetIndexNum()];
        Console.WriteLine("Array created successfully.");
        Console.WriteLine("Enter values to be placed in the array.");
        NewArr.AddIndexValue();
        Console.Write("Only even numbers : ");
        NewArr.PrintEvenNum(NewArr.arr);
        Console.Write("Only odd numbers : ");
        NewArr.PrintOddNum(NewArr.arr);
    }
}