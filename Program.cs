namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = {1,2,3,4,5,6,7,8,9};
            int L = 0;
            int R = myarray.Length - 1;
            int temp = L;

            while (L < R) 
            {
                temp = myarray[L];
                myarray[L] = myarray[R];
                myarray[R] = temp;
                L++;
                R--;
            }
            foreach (int i in myarray) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
