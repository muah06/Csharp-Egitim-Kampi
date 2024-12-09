using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("**** Yemek Kategorileri ****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek Kategorileri ****");

            #endregion


            #region String Değişkenler

            // string
            //Değişken_türü değişken_adı

            //string name;
            //name = "ali";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Eda";
            //customerSurname = "Kiraz";
            //customerPhone = "+90 500 400 30 40";
            //customerEmail = "deneme@gmail.com";
            //district = "Karatay";
            //city = "Konya";
            //Console.WriteLine("**** Rezarvasyon Kartı ****");
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Müşteri:  " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/"+ city);
            //Console.WriteLine("------------------------------------------");

            //Console.WriteLine();

            //customerName = "Kerem";
            //customerSurname = "Demir";
            //customerPhone = "+90 500 250 25 25";
            //customerEmail = "test@gmail.com";
            //district = "Karaköy";
            //city = "İstanbul";
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Müşteri:  " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------");






            #endregion


            #region Int Değişkenler

            //hamburger pizza limonata cola su kızartma

            int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int lemonadePrice = 40;
            int cokePrice = 45;
            int waterPrice = 10;
            int friesPrice = 50;

            Console.WriteLine("**** Menü Fiyat Listesi ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " +hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " +pizzaPrice + " TL");
            Console.WriteLine("----Limonata : " +lemonadePrice + " TL");
            Console.WriteLine("----Kola : " +cokePrice + " TL");
            Console.WriteLine("----Su : " +waterPrice + " TL");
            Console.WriteLine("----Kızartma : " +friesPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Menü Fiyat Listesi ****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            int totalhamburgerPrice;
            int totalpizzaPrice;
            int totallemonadePrice;
            int totalcokePrice;
            int totalwaterPrice;
            int totalfriesPrice;
            int totalprice;

            int hamburgerCount;
            int pizzaCount;
            int lemonadeCount;
            int cokeCount;
            int waterCount;
            int friesCount;

            hamburgerCount = 4;
            pizzaCount = 1;
            lemonadeCount = 3;
            cokeCount= 1;
            waterCount = 0;
            friesCount = 1;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalpizzaPrice = pizzaCount * pizzaPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totalfriesPrice = friesCount * friesPrice;
            totalprice= totalhamburgerPrice + totalpizzaPrice + totallemonadePrice + totalcokePrice + totalwaterPrice + totalfriesPrice;

            Console.WriteLine("Hamburger Fiyatı: " + totalhamburgerPrice);
            Console.WriteLine("Pizza Fiyatı: " + totalpizzaPrice);
            Console.WriteLine("Limonata Fiyatı: " + totallemonadePrice);
            Console.WriteLine("Kola Fiyatı:" + totalcokePrice);
            Console.WriteLine("Su Fiyatı: " + totalwaterPrice);
            Console.WriteLine("Kızartma Fiyatı: " + totalfriesPrice);
            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Fiyat: " + totalprice);





            #endregion


            Console.Read();
        }
    }
}
