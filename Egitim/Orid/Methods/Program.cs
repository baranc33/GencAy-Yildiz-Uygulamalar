﻿/* Bilgiler
  1- Nesne içersinde Adı metot Nesne Dışında Adı fonksiyon
  2- C#  işlem yapan Herşey Metot içersinde yazılmalıdır
  3- Metotlar  Nesne(class) lar içinde yazılması zorunludur.
  4- return Ettikten Sonraki Metot Kodları Çalışmaz

 işlem nedir ? => bilgisayar verdiğimiz emirler


Notlar 
1- metot içinde metot
2- Recursive metot
*/



//Console.WriteLine("Hakan"); // =>  bu bir işlemdir
// =>  hani bunun metodu
// =>  hani c# %100  programlamaydı nesnemiz nerde metodumuz nerde ?



/*
 Metot oluşturma sırası
1- Erişim Belirteci => Metoda nerden erişilebileceğini belirler // public
2- Metotdun Tipi => Statik Veya Dynamic                 // dynamic
3- Geri Dönüş Değeri => Metot Geriye Ne dönecek
(değişkenler ör:int,string,bool)

// bir sayı vercem sayının tekmi çiftmi olduğunu
parametre =>giren => 1 tane int
metot => makina    => bla bla
geri dönüş değeri => çıktı  bool


4- Metodun ismi  => isimlendirme kuralları
5- Parantezler içinde  metoda Gelen Değerler(parametre )
6- scope kullanırız {}
7- Geriye dönülecek Değerin önüne return kelimesi getirilir

 */
// sayının çiftmi tekmi olduğunu bulan Metot yazalım



// 2 taraflı code vardır
// 1. Codu Kullanan
//// 2. Codu Yazan


//Console.WriteLine("Lütfen bir sayı giriniz");
//string Sayi = Console.ReadLine();

//bool Sonuc = Alayli.Ciftmi(2);

//if (Sonuc== true)
//{
//    Console.WriteLine("Sayı Çifttir");
//}
//else
//{
//    Console.WriteLine("Sayı Tektir");
//}













//double sayi = Alayli.AussuB(2);

Console.WriteLine("Lütfen Bir Sayı Giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());

int Sonuc = Alayli.Karesi(sayi);

Console.WriteLine(Sonuc);



public static class Alayli
{
    public static bool Ciftmi(int sayi)
    {
        bool Sonuc = sayi %2 ==0;// true yada false
        return Sonuc;
    }

    // Karesini Hesaplayan Bir Metot yazcaz
    public static int Karesi(int Sayi)
    {
        int Sonuc;
        Sonuc = Sayi* Sayi;
        return Sonuc;
    }

    public static int BuyukSayi(int sayi1,int sayi2)
    {
        if (sayi1 > sayi2)
            return sayi1;
        else
            return sayi2;
    }

  

}
