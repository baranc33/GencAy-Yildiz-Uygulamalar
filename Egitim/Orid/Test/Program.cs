int sayi1;
int sayi2;
x:
Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
string Ssayi1 = Console.ReadLine();
bool Sonuc1 = int.TryParse(Ssayi1, out sayi1);

if (Sonuc1 ==false)
{
    Console.Clear();
    Console.WriteLine("Kardeşim Sayı Değeri Girsene");
    Thread.Sleep(3000);
    Console.Clear();
    goto x;
}
y:
Console.WriteLine("Lütfen 2. Sayıyı Giriniz");
string Ssayi2 = Console.ReadLine();
bool Sonuc2 = int.TryParse(Ssayi2, out sayi2);

if (Sonuc2==false)
{
    Console.Clear();
    Console.WriteLine("Kardeşim Sayı Değeri Girsene");
    Thread.Sleep(3000);
    Console.Clear();
    goto y;
}

Console.Clear();
z:
Console.WriteLine("Toplama işlemi için ( + )  ya tıklayınız ");
Console.WriteLine("Çıkarma işlemi için ( - )  ya tıklayınız ");
Console.WriteLine("Çarpma işlemi için ( * )  ya tıklayınız ");
Console.WriteLine("Bölme işlemi için ( / )  ye tıklayınız ");
int result;
string islem = Console.ReadLine();
Console.Clear();

if (islem == "+" || islem == "-" || islem == "*" || islem == "/")
{
    if (islem == "+")
    {
        result= sayi1+sayi2;
    }
    else if (islem == "-")
    {
        result= sayi1-sayi2;

    }
    else if (islem == "*")
    {
        result= sayi1*sayi2;
    }
    else
    {
        result= sayi1/sayi2;
    }


}
else
{
    Console.Clear();
    Console.WriteLine("Kardeşim işlem Değeri Girsene");
    Thread.Sleep(3000);
    Console.Clear();
    goto z;
}

string Cevap = sayi1 + " " + islem + " " + sayi2+ " = "+ result;

Console.WriteLine(Cevap);

Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("YENİDEN DENEMEK İSTERMİSİNİZ EVET YADA HAYIR Yazınız");

// Kullanıcıdan Bilgi alcaz ona göre devam ettircez
string Devam = Console.ReadLine();
if (Devam=="EVET")
{
    goto x;
}
else
{
    Console.Clear();
    Console.WriteLine("İyi günler Program Kapatılıyor...");
    Thread.Sleep(800);
    Console.Clear();
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("İyi günler Program Kapatılıyor.");
    Thread.Sleep(800);
    Console.Clear();
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("İyi günler Program Kapatılıyor...");
    Thread.Sleep(800);
    Console.Clear();
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("İyi günler Program Kapatılıyor.");
    Thread.Sleep(800);
    Console.Clear();
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("İyi günler Program Kapatılıyor...");
    Thread.Sleep(800);
    Console.Clear();
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("İyi günler Program Kapatılıyor.");
    Thread.Sleep(800);
    Console.Clear();
   
    //Console.WindowWidth=1;
    //Console.WindowHeight=1;
}
