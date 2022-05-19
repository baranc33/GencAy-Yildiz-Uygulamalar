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

Console.WriteLine("Lütfen bir sayı giriniz");
string Deger = Console.ReadLine();
int sayi;
//kardeşim degeri intager çevir sonra çıkan sonucu sayi değişkinine aktar
bool Sonuc = int.TryParse(Deger, out sayi); // bool değer dönüşüp dönüşmediği ifade eder

Console.WriteLine(Sonuc);
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


//int i = 0;

//while (i< 20)
//{
//    i++;
//    Console.WriteLine(i);
//}
