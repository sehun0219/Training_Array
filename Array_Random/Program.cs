
class IndexValue
{
    public void PutInValue(int[] arr)
    {
        Random NewRandom = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            int randomValue = NewRandom.Next(5);
            arr[i] = randomValue;
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];

        IndexValue indexValue = new IndexValue();
        indexValue.PutInValue(arr);
        Console.WriteLine("Outputs random numbers entered in the array.");
        Console.WriteLine(string.Join(" ", arr));

        Console.WriteLine("Sort and re-output duplicate values.");
        int[] distArray = arr.Distinct().ToArray();
        Console.WriteLine(string.Join(" ", distArray));

    }
}