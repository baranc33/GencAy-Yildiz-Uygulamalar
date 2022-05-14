// Console.ReadLine() Metodu ile Konsoldan Yazılan Yazıyı Alabiliriz 
// Gelen Veri String Tipindedir
string Girdi = Console.ReadLine();

int Sayi = Convert.ToInt32(Girdi);

// girilen Sayının 25 tek küçük olup olmadığını Kontrol etcem

if (Sayi >25)
{
    Console.WriteLine("Girilen Sayı 25 den büyüktür");
}
else
{
    Console.WriteLine("Girilen Sayı 25 den Küçüktür");
}


//if ( sayi1 > 20)
//{
//    Console.WriteLine("Girilen Sayı 20 den büyüktür");
//}
//else
//{
//    Console.WriteLine("Girilen Sayı 20 den Küçüktür");

//}


/* Karar Mekanizması
  
 if ( Şartımızı)
{
    // yapılacak işlemi
}

 */
