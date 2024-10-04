using System.ComponentModel.Design;
using System.Text;

class Program
{
    
    public static void Main()
    {
        Console.Write("Enter the words: ");
        StringBuilder sb = new StringBuilder(Console.ReadLine());

        int menu = 0;

        while(menu != 4)
        {
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|1. Matn qoshish:          |");
            Console.WriteLine("|2. Matn oz'gartirish:     |");
            Console.WriteLine("|3. Matnni o'chirish:      |");
            Console.WriteLine("|4. Chiqish:               |");
            Console.WriteLine("+--------------------------+");
            Console.Write("Tanlang: ");
            menu = int.Parse(Console.ReadLine()!);

            switch(menu)
            {
                case 1:
                Console.Write("Qoshmoqchi b'olgan s'ozni kiriting: ");
                string word = Console.ReadLine()!;
                sb.Append(word);
                Console.WriteLine("Matn: " + sb);
                break;

                case 2:
                Console.WriteLine("Matn: " + sb);
                Console.Write("Eski matnni kritign: ");
                string oldWord = Console.ReadLine()!;
                Console.Write("Yangi matnni kritign: ");
                string newWord = Console.ReadLine()!;
                sb.Replace(oldWord, newWord);
                Console.WriteLine("Matn: " + sb);
                break;

                case 3:
                Console.Write("Qaysi indexdan boshlab o'chirmoqshisiz: ");
                int index1 = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Qaysi indexgacha: ");
                int index2 = int.Parse(Console.ReadLine()!);
                sb.Remove(index1, index2);
                Console.WriteLine("Matn: " + sb);
                break;

                case 4:
                    Console.WriteLine("Chiqish...");
                break;

                default:
                Console.WriteLine("Xatolik");
                break;

            }
        }      
    }
}