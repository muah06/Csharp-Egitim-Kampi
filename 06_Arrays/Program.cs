using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //2,4,6,8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa
            //Değişken türü [] Diziadı=new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];

            //cities[0] = "Berlin";
            //cities[1] = "Moskova";
            //cities[2] = "Illinois";
            //cities[3] = "Lyon";
            //cities[4] = "Barcelona";

            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[4] = 342;
            //numbers[6] = 76;
            //numbers[9] = 563;

            //Console.WriteLine(numbers[9]);

            //string[] cities = { "Antalya","Madrid","Atina","Mersin","Venedik" };

            //Console.WriteLine(cities[4]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 6, 233, 334, 434, 645, 6643, 3463, 2324, };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 11, 22, 321, 143, 145, 555, 217, 821};

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "alperen", "Damla", "semih", "musa" };

            //Console.WriteLine(persons.Length);

            //int[] numbers = { 18, 232, 321, 24, 75, 95 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 18, 232, 321, 24, 75, 95 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Eray", "Ayşegül", "Merve", "Çınar", "İbrahim" };

            //int index = Array.IndexOf(customers,"Eray");
            //Console.WriteLine(index);

            //int[] numbers = { 231, 652, 351, 143, 552, 264, 647, 832, };
            //Console.WriteLine("Dizinin En Küçük Elamanı: " + numbers.Min() +" "+ "Dizinin En Büyük Elamanı: " + numbers.Max());



            #endregion

            #region Kullanıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);

            //}

            //int[] number = { 10, 20, 30,40,50 };
            //int sum = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum+= number[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 13, 42, 35, 46, 57, 68, 79, 88, 90, 107 };

            //Console.WriteLine("Dizideki Çift Sayılar");
         
            //for (int i = 0; i < numbers.Length; i++)
            //{
                
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Dizideki Tek Sayılar");
            

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
            Console.Read();
        }
    }
}
