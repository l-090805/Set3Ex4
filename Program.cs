
namespace Set3Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vector: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(' '),int.Parse);

            int Min = int.MaxValue;
            int Max = int.MinValue;
            int minCount = 0;
            int maxCount = 0;
            int n = v.Length;
      
            foreach(int num in v)
            {
                if(num < Min)
                {
                    Min = num;
                    minCount = 1;
                }
                else if(num == Min)
                {
                    minCount++;
                }
                if(num > Max)
                {
                    Max = num;
                    maxCount = 1;
                }
                else if(num == Max)
                {
                    maxCount++;
                }

            }

            Console.WriteLine($"Minim: {Min} ; Maxim: {Max}; Aparitii Minim: {minCount} ; Aparitii Maxim: {maxCount}");
        }
    }
}
