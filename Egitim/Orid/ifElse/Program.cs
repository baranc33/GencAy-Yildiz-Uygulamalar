
// girilen sayının
// 0-20 arasındamı
// 21-40
// 41-50
// 51 den büyük
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi > 0)
{
    if (sayi < 20)
    {
        Console.WriteLine("Sayı 0 ile 20 arasındadır");
    }
}

if (sayi > 0 && sayi < 20)
    Console.WriteLine("Sayı 0 ile 20 arasındadır");
else
    Console.WriteLine("ifin dışında");





Console.WriteLine("Cod Sonu");

// şafak Negafi algılamicak =>  0 ile 20 arasındadır der
// yunus bişi yazmicak  
// ibrahim hata verebilir   



//Console.WriteLine("lütfen bir değer giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());




int x = 2;

Console.WriteLine(x++);


/*
 Notlar 
if => Karar Verme Mekanizması
bir veya birden fazla şartın Kontrol Edilmesi durumlarında Kullanılır.

* if başlangıç bloğu /   olması zorunludur  / şartı Vardır.
* else if ler Orta bloklardır / olması zorunlu değildir / şartı  vardır.
* Else bloğu Bitiş Bloğudur  / olması zorunulu değildir / şartı yoktur


Madde 1 
her if bloğu sadece kendini temsil eder.

Madde 2 
if bloğuna Ek olarak Else if  veya else  Kullanıla bilir.

Madde 3 
Sıralama if - Else if ler - else.

Madde 4 
sınırsız Sayıda Else if kullanabiliriz.


Madde 5 
Üst bloktaki şart sağlanmadığı zaman Alt Bloğu kontrol eder
üst bloktaki Sağlanır ise Alt bloklara bakmadan bütün blokları es geçer.
 
Madde 6 
Üst bloklar Çalışmadığında Eğer Else Bloğu varsa 
Else Bloğunda şart a bakmaksızın çalışır.

 */










/*
 
 
 if (sayi >= 0)
{
    if (sayi> 20)
    {
        if (sayi>40)
        {
            if (sayi>50)
            {
                Console.WriteLine("50 den büyüktür");
            }
            else
            {
                Console.WriteLine("Sayı 41 ile 50 arasındadır");
            }
        }
        else
        {
            Console.WriteLine("Sayı 21 ile 40 arasındadır");
        }

    }
    else
    {
        Console.WriteLine("Sayı 0 ile 20 arasındadır");
    }
}
 */