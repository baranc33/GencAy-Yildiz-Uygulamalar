/*
  Döngüler 

1- While
2- Do While
3- For
4- Foreach => döngü değil itere etmektir fakat döngü gibi davranır
5- Go to x => döngü değildir.

break => döngüyü bitirir
continue => o anki döngüyü atlar;
 */



/* 1 Goto x
 amacı belli bi yerden belli bi yere kodu geriye Sarmaya yarar

başlangıcı ve bitişi vardır 

x:       => başlangıç noktası 
goto x;   => gidicek noktası

while
en basit döngüdür.
sadece if gibi yazılır if gibi hareket eder
if yerine while yazarız.
 
 */
int i = 1;
// 12345-12345-12345
// 3 kere yazsın
int counter = 0;


while (i < 4)
{
    if (i==2)
    {
        i++;// 3 3 3 
        continue;
    }
    Console.WriteLine(i);// 1 3 1 3 1 3
    i++;//  2 4 2 4 2 4

    if (i==4 && counter < 2)
    {

        counter++;// 1 2
        i=1;
    }

}



// yunus
// şafak  1 2 1 2 
// ibo
// memoş
// hako

Console.WriteLine("işlem bitti");






































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



