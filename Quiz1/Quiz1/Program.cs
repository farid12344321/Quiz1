using System;

namespace Quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Farid", "Elmar", "Kamil" };
            //int index = 1;

            //DelteNameIndex(ref names, ref index);

            //Console.WriteLine(names);

            //DeleteFirstSpace("   salam necesen    ");

            //FindText("salam necesen", "salam");


            //FindText("ala","ala");
        }


        //Verilmiş sözün tərsdən oxunuşunun özü ilə eyni olub olmadığnı tapan metod(misalçün
        //“ala” sözü tərsdən yazıldıqda da “ala” olur)

        static void FindText(string text1,string text2)
        {
            for (int i = text1.Length; i >=0; i--)
            {
                if (text2[i] == text1[i])
                {
                    Console.WriteLine("Eynidir");
                }
                else
                {
                    Console.WriteLine("deyil");
                }
            }
        }


        //Verilmiş array-dən verilmiş indexli elementi silən metod.

        static void DelteNameIndex(ref string[] text,ref int index) 
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (index != i)
                {
                    count++;
                }
            }
            string[] newArr = new string[count];
            int index2 = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (index != i)
                {
                    newArr[index2] = text[i];
                    index2++;
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }



        //Verilmiş yazının əvvəlindəki boşluqları silən metod
        static void DeleteFirstSpace(string text)
        {
            string nn = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    nn += text[i];
                }
            }
            Console.WriteLine(nn);
        }



       
        
    }
}
