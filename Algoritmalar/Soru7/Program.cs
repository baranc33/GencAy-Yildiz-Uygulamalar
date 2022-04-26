// pozitif sayılarda bölme işlemini çıkarma kullanarak yapan uygulama yazınız.

/*Çözüm  0
Console.WriteLine("Lütfen Bölmek istediğiniz Sayıyı giriniz");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen Bölen Sayıyı giriniz");
int sayi2 = int.Parse(Console.ReadLine());
int sonuc = 0;

for (int i = 0; sayi2 <= sayi1; i++)// i bölünenden küçük olması gerekiyor bölme işlemini yapabilmek için
{
    sayi1-=sayi2;
    sonuc++;
}

Console.WriteLine(sonuc);

*/
/*Çözüm  1*/
Console.WriteLine("Lütfen Bölmek istediğiniz Sayıyı giriniz");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen Bölen Sayıyı giriniz");
int sayi2 = int.Parse(Console.ReadLine());
int _sayi1 = sayi1;
int sonuc = 0;
int kalan = 0;

for (int i = 0; i < _sayi1; i++)// i bölünenden küçük olması gerekiyor bölme işlemini yapabilmek için
{
    sayi1-=sayi2;
    sonuc++;

    if (sayi1<sayi2)
    {
        kalan=sayi1;
        break;
    }
}
Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc}");
Console.WriteLine($"Kalan = {kalan}");
/*Çözüm  2*/
/*Çözüm  3*/
/*Çözüm  4*/
/*Çözüm  5*/
