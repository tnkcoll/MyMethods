namespace MyMethods
{
    internal class MyMethods
    {
       public void PrintArray(int[] ints)
        {
            foreach (int i in ints)
            {
                //Print the array passed into this method.
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
