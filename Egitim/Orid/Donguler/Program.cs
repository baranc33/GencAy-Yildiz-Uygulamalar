/*
  Döngüler 

1- While
2- Do While
3- For
4- Foreach => döngü değil itere etmektir fakat döngü gibi davranır
5- Go to x => döngü değildir.

6 - break continue;

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
// kullanıcıdan veri girmesini istiyorsun
// istediğin veri int değilse tekrar girsin
// int ise sayıyı ekrana yazsın ve program bitsin

/*Kopya
 string Ssayi1 = Console.ReadLine();
bool Sonuc1 = int.TryParse(Ssayi1, out sayi); // false ise sayı değildir
 */


int i = 0;

while (i< 20)
{
    i++;
    Console.WriteLine(i);
}
