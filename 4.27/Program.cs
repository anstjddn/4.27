using System.Security.Cryptography.X509Certificates;

namespace _4._27
{

    //하노이탑
    internal class Program
    {
        public static void Move(int Count,int start, int end)
        {
   
                if (Count == 1)
                {
                    int node = stick[start].Pop();
                    stick[end].Push(node);
                    Console.WriteLine($"{start} {end}");
                    return ;
                }
                int Middle = 6 - start - end;
                Move(Count - 1, start, Middle);
                Move(1, start, end);
                Move(Count - 1, Middle, end);
           

        }

    
        public static Stack<int>[] stick;

        static void Main(string[] args)
        {
            Console.Write("숫자입력:");
            int Num = int.Parse(Console.ReadLine());
             stick = new Stack<int>[4];              // 맨 왼쪽부터 0 1 2번 스틱        
             for(int i=1;i<stick.Length; i++)
             {
                 stick[i] = new Stack<int>();
             }
             for(int i = Num; i>0; i--)
             {
                 stick[1].Push(i);           // 가장 왼쪽에 54321 원판 집어넣는거
             }
            Console.WriteLine();            // 횟수구현
            Move(Num,1,3);
        }
    }
}