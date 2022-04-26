// girilen sayının faktöriyelini hesaplayan uygulama yazınız


/* Çözüm 1 


Console.WriteLine("Lütfen Bir Sayı Giriniz");
int sayi = int.Parse(Console.ReadLine());
int sonuc = 1;

for (int i = sayi; i>0; i--)
{
    sonuc *=i;
}

Console.WriteLine(sonuc);
*/
/* Çözüm 2

Console.WriteLine("Lütfen Bir Sayı Giriniz");
int sayi = int.Parse(Console.ReadLine());
int sonuc = 1;

while (sayi >0)
{
    sonuc*=sayi;
    sayi--;
}
Console.WriteLine(sonuc);
*/

/* Çözüm 3/

Console.WriteLine("Lütfen Bir Sayı Giriniz");
int sayi = int.Parse(Console.ReadLine());
int sonuc = 1;


do
{
    sonuc*=sayi;
    sayi--;
}
while (sayi>0);
Console.WriteLine(sonuc);
*/

/* Çözüm 4

Console.WriteLine("Lütfen Bir Sayı Giriniz");
int sayi = int.Parse(Console.ReadLine());
int toplam = 1;
string sonuc = "";
for (int i = sayi; i > 0; i--)
{
    if (i > 1)
    {
        sonuc += $"{i} X ";
        toplam*=i;
    }
    else
    {
        toplam*=i;
        sonuc += $"{i} = {toplam} ";
    }
}

Console.WriteLine(sonuc);
*/
/* Çözüm 5 */
Console.WriteLine("Lütfen Bir Sayı Giriniz");
int sayi = int.Parse(Console.ReadLine());
int sonuc = 1;
string _sonuc = "";

while (sayi>0)
{
    sonuc*=sayi;
    if (sayi !=1)
    {
        _sonuc+=$"{sayi} X ";
    }
    else
    {
        _sonuc+=$"{sayi} = {sonuc}";

    }
    sayi--;
}


Console.WriteLine(_sonuc);
