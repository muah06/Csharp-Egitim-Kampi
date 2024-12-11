using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 7.18;
            //Console.WriteLine(number);

            // Console.WriteLine("**** Fiyat Listesi ****");
            // Console.WriteLine();

            // double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            // applePrice = 24.95;
            // orangePrice = 34.75;
            // strawberryPrice = 45.50;
            // potatoPrice = 9.90;
            // tomatoPrice = 19.50;

            // Console.WriteLine("----Elma Kg Fiyatı: "+applePrice);
            // Console.WriteLine("----Portakal Kg Fiyatı: "+orangePrice);
            // Console.WriteLine("----Çilek Kg Fiyatı: "+strawberryPrice);
            // Console.WriteLine("----Patates Kg Fiyatı: "+potatoPrice);
            // Console.WriteLine("----Domates Kg Fiyatı: "+tomatoPrice);

            // double appleKgram, orangeKgram, strawberryKgram, potatoKgram, tomatoKgram;
            // appleKgram = 1.250;
            // orangeKgram = 2.450;
            // strawberryKgram = 1.750;
            // potatoKgram = 4.900; ;
            // tomatoKgram = 3.250;

            //double appleTotalPrice,orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            // appleTotalPrice = applePrice * appleKgram;
            // orangeTotalPrice = orangePrice * orangeKgram;
            // strawberryTotalPrice = strawberryPrice * strawberryKgram;
            // potatoTotalPrice = potatoPrice * potatoKgram;
            // tomatoTotalPrice = tomatoPrice * tomatoKgram;

            // Console.WriteLine();

            // Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı : " + applePrice + " - Gramaj: " + appleKgram + " Kg" + " - Toplam Tutar: " +appleTotalPrice +" TL");
            // Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı : " + orangePrice + " - Gramaj: " + orangeKgram + " Kg" + " - Toplam Tutar: " +orangeTotalPrice +" TL");
            // Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı : " + strawberryPrice + " - Gramaj: " + strawberryKgram + " Kg" + " - Toplam Tutar: " +strawberryTotalPrice +" TL");
            // Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı : " + potatoPrice + " - Gramaj: " + potatoKgram + " Kg" + " - Toplam Tutar: " +potatoTotalPrice +" TL");
            // Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı : " + tomatoPrice + " - Gramaj: " + tomatoKgram + " Kg" + " - Toplam Tutar: " +tomatoTotalPrice +" TL");

            // Console.WriteLine();

            // double shoppingTotalPrice;
            // shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + tomatoTotalPrice;
            // Console.WriteLine( "Toplam Ödencek Tutar: " + shoppingTotalPrice + "TL");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("İl: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Tc Kimlik No: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("Yolcu Tc Kimlik No: " + passangerIdentityNumber + " Yolcu Adı Soyadı: "+ passangerName + " " + passangerSurname +" "+ passangerAge +" " + passangerDistrict + "/" + passangerCity );


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, tvPrice, chairPrice, computerPrice;

            //shoesPrice = 1500;
            //tvPrice = 24000;
            //chairPrice = 4500;
            //computerPrice = 35000;

            //int shoesCount, tvCount, chairCount, computerCount;

            //Console.Write("Almak İstediğini Ayakkabı Adedini Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Almak İstediğini Televizyon Adedini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.Write("Almak İstediğini Sandalye Adedini Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Almak İstediğini Bilgisayar Adedini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int totalPrice;

            //totalPrice= shoesPrice * shoesCount + tvPrice * tvCount + chairPrice * chairCount + computerPrice * computerCount;
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri 

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Girinizi (%37.5) :");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz (%12.5) :");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz (%50) :");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 * 37.5 + exam2 * 12.5 + exam3 * 50) /100;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalmanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.WriteLine("Lütfen cinsiyet seçiniz: ");
            gender=char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();

        }
    }
}
