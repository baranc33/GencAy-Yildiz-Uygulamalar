/*
  Döngüler 
1- While
2- Do While
3- For
4- Foreach => döngü değil itere etmektir fakat döngü gibi davranır
5- Go to x => döngü değildir.

 */

/* 1 Goto x
 amacı belli bi yerden belli bi yere kodu geriye Sarmaya yarar

başlangıcı ve bitişi vardır 

x:       => başlangıç noktası 
goto x;   => gidicek noktası
 */


// ///  1. parametere çevrilecek değer
// ///  2. paramtere değeri hangi değişkene atacağımız
// ///  2. parametrenin önüne out keyword ü gelecek
//int sayi2 = 5;
//string sayi = Console.ReadLine();
//bool a= int.TryParse(sayi, out sayi2);
//Console.WriteLine(sayi2);

/* Toplama işlemi yapcaz
2 tane tam sayı
*/
int sayi1;
int sayi2;
x:
Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
string Ssayi1 = Console.ReadLine();
bool Sonuc1 = int.TryParse(Ssayi1, out sayi1);

if(Sonuc1 ==false)
{
    Console.Clear();
    Console.WriteLine("Kardeşim Sayı Değeri Girsene");
    Thread.Sleep(4000);
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
    Thread.Sleep(4000);
    Console.Clear();

    goto y;
}

int Toplam = sayi1+sayi2;
string Cevap=sayi1 + " + " + sayi2 + " = " + Toplam;
Console.WriteLine(Cevap);





