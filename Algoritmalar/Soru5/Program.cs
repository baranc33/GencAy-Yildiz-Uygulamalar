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

/* Çözüm 3*/

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

/* Çözüm 4*/