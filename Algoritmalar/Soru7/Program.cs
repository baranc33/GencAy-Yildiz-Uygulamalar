// pozitif sayılarda bölme işlemini çıkarma kullanarak yapan uygulama yazınız.

/*Çözüm  1*/
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
/*Çözüm  2*/
/*Çözüm  3*/
/*Çözüm  4*/
/*Çözüm  5*/
