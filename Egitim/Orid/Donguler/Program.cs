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

Console.WriteLine("Lütfen Bir Sayı Giriniz.");
a:
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi < 0)
{
    Console.Clear();
    Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz");
    goto a;
}


Console.WriteLine("Sayınız :"+ sayi);




