namespace HackaThon__1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一至少大於90的整數");
            int num = int.Parse(Console.ReadLine());
            while (num < 90)
            {
                Console.WriteLine("輸入值小於90，請重新輸入");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("結果如下:");
            for (int i = 1; i <= num; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }



    }
}
