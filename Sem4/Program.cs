static int[] CreateArray(int[] num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}
static void WriteArray(int[] array)
{
        foreach(int num in array)
        
    {
        Console.Write(num + " ");
    }
    static void Main(string[] args)
    {
        WriteArray(Createarray(20));
    }
    
}
