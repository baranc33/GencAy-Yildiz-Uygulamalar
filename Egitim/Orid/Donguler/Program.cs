/*
  Döngüler 

1- While
2- Do While
3- For
4- Foreach => döngü değil itere etmektir fakat döngü gibi davranır
5- Go to x => döngü değildir.

ek kullanılabilirk = break ,continue;

 */

/* 1 Goto x
 amacı belli bi yerden belli bi yere kodu geriye Sarmaya yarar

başlangıcı ve bitişi vardır 

x:       => başlangıç noktası 
goto x;   => gidicek noktası
 */
// kullanıcada 2 sayı gerekiyor
// hangi işlem 
// sonuc
int sayi1, sayi2;
string islem;// * => çarpma   / => bölme   + => toplama   - => çıkarma
int sonuc = 0;
x:
Console.WriteLine("Lütfen 1. sayıyı giriniz");
string girdi1 = Console.ReadLine();
bool result1 = int.TryParse(girdi1, out sayi1);

if (result1==false)
{
    Console.Clear();// consolu temizliyor
    Console.WriteLine("Hatalı Bir Giriş Yaptınız Lütfen Tekrar Deneyiniz !!!");
    Thread.Sleep(3000);// mili saniye cinsinden kodu beklet 
    Console.Clear();
    goto x;
}

Console.Clear();
Console.WriteLine("1. Sayının Değeri = "+ sayi1);

y:
Console.WriteLine("Lütfen 2. sayıyı giriniz");
string girdi2 = Console.ReadLine();
Console.Clear();
Console.WriteLine("1. Sayının Değeri = "+ sayi1+ "\n2. sayının değeri = " + girdi2);
bool result2 = int.TryParse(girdi2, out sayi2);

if (result2==false)
{
    Console.Clear();
    Console.WriteLine("Hatalı giriş yaptınız Lütfen Tekrar Deneyiniz!!!");
    Thread.Sleep(3000);// mili saniye cinsinden kodu beklet 
    Console.Clear();
    goto y;
}
z:
Console.WriteLine("Toplama için ( + ) tıklayınız.");
Console.WriteLine("Çıkarma için ( - ) tıklayınız.");
Console.WriteLine("Çarpma için ( * ) tıklayınız.");
Console.WriteLine("Bölme için ( / ) tıklayınız.");
Console.WriteLine("Kalan için ( % ) tıklayınız.");

islem = Console.ReadLine();

bool Dogrumu = Alayli.islemDogrumu(islem);

if (Dogrumu==false)
{
    Console.Clear();
    Console.WriteLine("İşlemini doğru seçiniz bay yavşak!");
    Thread.Sleep(1500);
    goto z;
}

string cümle = Alayli.Hesaplama(sayi1, sayi2, islem);

Console.WriteLine(cümle);

















//if (islem=="+")
//{
//    sonuc =sayi1+sayi2;
//}
//else if (islem=="-")
//{
//    sonuc =sayi1-sayi2;
//}
//else if (islem=="/")
//{
//    sonuc =sayi1/sayi2;
//}
//else if (islem=="*")
//{
//    sonuc =sayi1*sayi2;
//}
//else
//{
//    Console.Clear();
//    Console.WriteLine("İşlemini doğru seçiniz bay yavşak!");
//    Thread.Sleep(1500);
//    goto z;
//}
//Console.Clear();
//Console.WriteLine(sayi1 +"  "+islem+" "+sayi2 +" = "+sonuc.ToString());


// toplu yorum ctrl+k , ctrl+ c
// kaldırması  ctrl+k  , ctrl + u















// false bir metot=> yunus







































//if (islem== "+")
//{
//    int cevap = sayi1+sayi2;
//    Console.WriteLine("İşleminizin Sonucu" + cevap);
//}
//else if (islem== "-")
//{
//    int cevap2 = sayi1-sayi2;
//    Console.WriteLine("İşleminizin Sonucu" + cevap2);
//}
//else if (islem== "/")
//{
//    int cevap3 = sayi1/sayi2;
//    Console.WriteLine("İşleminizin Sonucu" + cevap3);
//}
//else if (islem== "*")
//{
//    int cevap3 = sayi1*sayi2;
//    Console.WriteLine("İşleminizin Sonucu" + cevap3);
//}
//else
//{
//    Console.Clear();
//    Console.WriteLine("İşlemini doğru seçiniz bay yavşak!");
//    Thread.Sleep(1500);
//    goto z;
//}



