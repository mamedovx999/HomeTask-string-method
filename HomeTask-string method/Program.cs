using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

namespace HomeTask_string_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //while (true)
            //{
            //takenumber:
            //    Console.WriteLine("ilk reqem daxil edin");
            //    bool isnumber = int.TryParse(Console.ReadLine(), out int num);
            //    if (!isnumber)
            //    {
            //        Console.WriteLine("duzgun daxil edin");
            //        goto takenumber;
            //    }
            //    Console.WriteLine("ikinci eded daxil edin");
            //    bool isnumber1 = int.TryParse(Console.ReadLine(), out int num2);
            //    if (!isnumber1)
            //    {
            //        Console.WriteLine("duzgun daxil edin");
            //        goto takenumber;
            //    }
            //    Console.WriteLine("simvol daxil edin");
            //    char symbol = Convert.ToChar(Console.ReadLine());
            //    calculator(num, num2, symbol);
            //}
            #endregion
            #region Task2
            //CharOfSum("Memmedeli!!", '!');
            #endregion
            #region Task3
            //CountOfWords("Salam Memmedeli Necesen");
            #endregion
            #region Task4
             
           // SumOfNumbers(Convert.ToInt32(343));

            #endregion
            #region Task5
           // Console.WriteLine(Math.Pow(2,6));
            #endregion
            #region Task6
            //int[] arr;
            //Convert(out arr);

            //foreach (int num in arr)
            //{
            //    Console.WriteLine(num + "");
            //}

            #endregion
            #region Task7 void
            //string word = "Memmedeli";
            //reversestring(word);
            #endregion
        }

        #region task 1 void
        //static void calculator(int num, int num2, char symbol)
        //{
        //    switch (symbol)
        //    {
        //        case '+':
        //            Console.WriteLine($"Cavab:{num + num2}");
        //            break;
        //        case '-':
        //            Console.WriteLine($"Cavab:{num - num2}");
        //            break;
        //        case '/':
        //            if (num2 != 0)
        //            {
        //                Console.WriteLine($"Cavab:{num / (double)num2}");
        //            }
        //            else Console.WriteLine("0 bolunmur");
        //            break;
        //        case '*':
        //            Console.WriteLine($"Cavab:{num * num2}");
        //            break;
        //        default:
        //            Console.WriteLine("duzgun simvol daxil ed");
        //            break;
        //    }
        //}
        #endregion
        #region Task2 void
        //static void CharOfSum(string word,char c)
        //{
        //    int count = 0;
        //    foreach (var a in word)
        //    {
        //        if (a == c)
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(count);
        //}
        #endregion
        #region Task3 void
        //static void CountOfWords(string word)
        //{
        //    int count = default;
        //    string[] words = word.Split(' ');
        //    foreach (var a in words)
        //    {
        //        count++;
        //    }
        //    Console.WriteLine(count);

        //}
        #endregion
        #region Task4
        static void SumOfNumbers(int num)
        {
            int sum = 0;
            string numbers = num.ToString();
            foreach (var i in numbers)
            {
                sum += int.Parse(i.ToString());
            }
            Console.WriteLine(sum);
        }

        #endregion
        #region TAsk6 void       
        //static void Convert(out int[] arr)
        //{
        //    arr = new int[] { -23, -43, -32, 34, 32 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < 0)
        //        {
        //            arr[i] *= -1;
        //        }
        //    }
        //}
        #endregion
        #region Task 7 void
        //static void reversestring(string word)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        sb.Append(word[i]);
        //    }
        //    Console.WriteLine(sb);
        //}
        #endregion










    }

}











