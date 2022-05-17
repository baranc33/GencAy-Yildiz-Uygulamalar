/*  Bölüm 1 Matematiksel Opartörler 
    Toplama +
    Çıkarma -
    Çarpma  *
    Bölme   /
    Kalan   %
 */

//int sayi1;
//int sayi2;
//int sayi3;
//int sayi4;
//sayi1 = 10;
//sayi2 = 5;
//sayi3 =5;
//sayi4=2;

//int sayi6 = 10 % 3;




////double sayi7 = 2.2 + 2.4;
////Console.WriteLine(sayi7);

////string sayi7 = "32" + "23";
////Console.WriteLine(sayi7);


// yunus 4.6
// şafak  4.6
// 


//sayi3 = 3  * (sayi1 / sayi2);
//  2 ve 4 ü çarp  1 ve 3 çarp  2ve 4 ün sonucndan çıkanı 1 ve 3 ün çıkan sonucuna böl

// değişken isimleri Çift Tırnak içinde Yazılmaz
// Sadece String Değişkeninin Değeri çift Tırnak içinde Yazılır


// cw tap tap =>Parantezleirn içine ne yazarsan Console yazar
//Console.ReadLine(); // o anki Satırı Okumaya Yarar



//string Yazi = Console.ReadLine();


//Console.WriteLine(Yazi);


// sayi 1 =10 sayi2=5 sayi3=7  sayi4=2 sayi5=2  sayi6=3
// 1.soru  sayi1 ve sayi2 nin toplamından sayi 3 ü çıkar  
// 2.soru sayi1 ve sayi2 nin toplamı sayi6 ya böle
// 3.soru  sayi1 ve sayi2 toplamını sayi4 ile çarp
// 4.soru  sayi1 ve sayi2 toplamından sayı 3ü çıkar sonra sayi 4 le sayı 5i çarp önceki sonuçla çarp
//int sayi1, sayi2, sayi3,sayi4,sayi5,sayi6; // 8 4
//sayi1 = 10;
//sayi2 = 3;
//sayi3=sayi1 % sayi2;




//Console.WriteLine(sayi3);
/* Bölüm 2  Karşılaştırma işlemler
    Küçüktür  <
    Büyüktür  >
    Küçük Eşit   <=
    Büyük Eşit   >=
    Eşittir      ==
    Eşit Değildir.  !=

int sayi1 = 3, sayi2 = 4, sayi3 = 7, sayi4 = 2, sayi5 = 2, sayi6 = 11;
 */
// true false
//bool Sonuc = (3*5) +2  < (5-4)*4;

//Console.WriteLine(Sonuc);

//bool Sonuc = "Hakan" != "hakan";
//Console.WriteLine(Sonuc);

//bool Sonuc = 2.400000== 2.40;

//Console.WriteLine(Sonuc);






/* Bölüm 3 Mantıksal Opartörler 
    Ve    &&  shift + 6
    Veya  ||  alt gr + küçüktür
    Yada  ^ => shift + 3  

// bakkaldan  Cipsi ... Kola al
// ve => 2 seçeneğinde true olması durumu
// veya =>  en az 1 tanesi true olması durmu
// yada  => sadece 1 tane true 
 */
//int a = 5;
//int b = 6;
//  //           true     ^    false
//bool Sonuc = ((a*5)>10) ^ (b+a*2) > 20; 
//// şafak false
//// ibrahim True
//// yunus false

//Console.WriteLine(Sonuc);

/* 4. işlem Operatörleri 
   ++x;  işlemden önce 1 arttır
   x++;  işlemden sonra 1 arttır
   --x;  işlemden önce 1 azalt
   x--;  işlemden sonra 1 azalt
   x+=y;  ekleme 
   x-=y;  çıkarma 
   x*=y;  çarpma 
   x/=y; Bölme
   x %=y; kalan
x++;// bulunduğu satırdaki işlem yapar daha sonra 1 arttırır
++x; // önce bir arttırrır daha sonra satırdaki işlemi yapar



/// a=5  ise  a = a+ 5;  
int a = 5;
a += 5;
a += 3;
a--;
a *=2;
a+=100;
a-=50;
a/=2;

Console.WriteLine(--a); 
*/


//int a = 5;
//int b = 7;
/////           false                         true
//bool Sonuc = (a+5> 25  ||  a*b <=30) ^ (a+(++b)*2)> 20;
//Console.WriteLine(!Sonuc);

// yunus    
// ibrahim   true
// şafak  true
// hakan


/*

int x = 5;
// x = x + 5;
 x += 3; // 8
x -= 1;  // 7
x++; // 8
--x;// 7
x=3; // 3
Console.WriteLine(x+=3);// 6
Console.WriteLine(x--); // 6
Console.WriteLine(x);  // 5
*/

/* 5 diğer operatörler 
   tersi !
 */

//bool dogrumu = 5 > 6; // false
//Console.WriteLine(!dogrumu);

//int sayi1 = Convert.ToInt32(Console.ReadLine());
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(sayi1 * sayi1);
/*

/*
 Çalıştırılacak Proje Ayarlama
 1. yöntem üst menünden ayarlıyoruz 
2. Yöntem projeye sağ tıklayıp  
Set as Startup project e tıklıyoruz
 */


/* as ve is operatörü
As = Bildiğiniz gibi elimizdeki herhangi bir nesneyi T tipine çevirebiliyorsa,
çeviren, yok eğer çeviremiyorsa null dönen bir operatördür.

is = Eldeki nesnenin tipini tanımlamamızı sağlar. Yani hangi tipten(değişken)
bir nesne olduğunu is operatörü ile sorgulayabilmekteyiz.

*/