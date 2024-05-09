namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = {1,2,3,4,5,6,7,8,9};
            int left = 0;
            int right = myarray.Length - 1;
            int temp = left;

            while (left < right) 
            {
                temp = myarray[left];
                myarray[left] = myarray[right];
                myarray[right] = temp;
                left++;
                right--;
            }
            foreach (int i in myarray) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
