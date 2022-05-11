/* Bölüm 1 Matematiksel Opartörler 
    Toplama +
    Çıkarma -
    Çarpma  *
    Bölme   /
    Kalan   %
 */

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

bool Sonuc = sayi1>sayi2;// false
bool Sonuc2 = sayi1+sayi2 == sayi3; // true
bool Sonuc3 = sayi1+sayi2 != sayi3; // false
bool Sonuc4 = sayi1+sayi2 > sayi4+sayi5; // true
bool Sonuc5 = sayi1+sayi2 > sayi3;// false
bool Sonuc6 = sayi1+sayi2 >= sayi3;// false

Console.WriteLine(Sonuc6);
 */

/* Bölüm 3 Mantıksal Opartörler 
    Ve    &&  shift + 6
    Veya  ||  alt gr + küçüktür
    Yada  ^ => shift + 3  

// bakkaldan  Cipsi ... Kola al
// ve => 2 seçeneğinde true olması durumu
// veya =>  en az 1 tanesi true olması durmu
// yada  => sadece 1 tane true 

int a = 5;
int b = 7;

bool Sonuc = (a == 5   &&   b == 6) || ( a+b >= 12 );

Console.WriteLine(Sonuc);
 */



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
++x;// bulunduğu satırda işlem yapar daha sonra 1 arttırır
++x; // önce bir arttırrır daha sonra satırdaki işlemi yapar

int x = 0; //   0
x++;// 1
++x;//  2
x = 5; // 5 
x++;  // 6

int y = 6;
x = y++ + 3;  // 9
// y=7  x=9
Console.WriteLine(y); */

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

int sayi1 = Convert.ToInt32(Console.ReadLine());
//int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sayi1 * sayi1);
/*

/*
 Çalıştırılacak Proje Ayarlama
 1. yöntem üst menünden ayarlıyoruz 
2. Yöntem projeye sağ tıklayıp  
Set as Startup project e tıklıyoruz
 */