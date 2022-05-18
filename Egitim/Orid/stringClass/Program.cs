/* String sınıfı stringler üstünde işlem yapmamıza yarar 
 
1- indexer[] nedir. ardaşık  yapılarda kullanılmaya yarar
 indexer 0 dan başlar

string Kelime = "0123 56 89";
Console.WriteLine(Kelime[6]);

2- stringler null veya empty değer alabilir.
null nedir =>  ""
empty nedir => " "
int a = null;// hata
string b = null;

string test = "";
bool Sonuc1 = string.IsNullOrEmpty(test);// => verilen değer null true döner değilse false
bool Sonuc2 =string.IsNullOrWhiteSpace(test);// => null ve empty değerlerde true döner


// Soru kelime girilmişmi girilmemişmi
string kelime = Console.ReadLine();
bool sonuc = string.IsNullOrWhiteSpace(kelime);
// true dönüyorsa boşluk vardır

if (sonuc==false)
{
    Console.WriteLine("Evet Kelime Girmiş");
}
else
{
    Console.WriteLine("Hayır Kelime Girmemiş");
}

3- string Formatlama


 basit birleştirme de  dib dibe yazar
 boşluk bırakmak için  4 farklı yöntem vardır
 1- 1.cümlenin sonuna bir boşluk veririz
 2- 2.cümlenin başına bir boşluk veririz
 3- yeni bir empty değerli string oluşturup araya katarız
 4- yeni bir string oluşturmadan araya direk değer olarak boşluk katarız.
sadece 4.yöntem kullanılır.

string Cumle1 = "bu yoğurdu sarımsaklasaktamı saklasak";
string Cumle2 = " sarımsaklamasaktamı saklasak";
string bosluk = " ";

string sonuc1 = Cumle1+" "+Cumle2;
string sonuc2 = Cumle1+bosluk+Cumle2;

Console.WriteLine();

// 9 tane değişken kullanmış oluyorsun 
//string Anonymous1 = " ";
//string Anonymous2 = " ";
//string Anonymous3 = " yaşında ";
//string Anonymous4 = "de yaşıyor";
string ad = "hakan";
string soyad = "çakır";
string yas = "27";
string sehir = "mersin";

// hakan çakır 27 yaşında mersinde yaşıyor
string bilgi = ad + " " + soyad + " " + yas + " yaşında " + sehir + "de yaşıyor" ;
Console.WriteLine(bilgi);


yukardaki kullanım performans açısından rezalet bir  kullanımdır

$ işareti string içinde süslü parantezler ile değişken kullanımıza olanak sağlar.
@ işareti kaçış karakterlerini iptal eder
@$ işaretleri birlikte kullanılabilir.

// 5 tane değişken vardır
string ad = "hakan";
string soyad = "çakır";
string yas = "27";
string sehir = "mersin";
string bilgi = $"{ad} {soyad} {yas} yaşında {sehir}'de yaşıyor ";
Console.WriteLine(bilgi);

####  \ Kaçış karakteri demek ####
bazı işlemleri yapmamıza yarar
\n bir alt satıra girer
\a =>  windows açılış sesi çıkarmaya yarar
\t   tab 3-4 tane boşluk karakteri
\v cinsiyet işareti
\" çift tırnak işareti
\' tek tırnak işareti
\\  ters slaş işareti




// \r kullanımı
//string ad=Console.ReadLine();
//string SoyAd=Console.ReadLine();
//string AdSoyAd = "\r";
//if (string.IsNullOrWhiteSpace(ad)==false|| string.IsNullOrWhiteSpace(SoyAd)==false)
//{
//    AdSoyAd=$"{ad} {SoyAd} ";
//}
//string cumle = $"{AdSoyAd}Aramıza Hoş geldin    ";

//Console.WriteLine(cumle);
 */

/* Bazı STRİNG metotları
 
Contains
Bir metin içersinde verilen değeri aramaya yarar
Bool a = Metin.Contains(keyword); 
örnek : girilen mailin mail formatında olup olmadığını kontrol edelim
string mail = "baranc33@gmail.com";
bool sonuc = mail.Contains("@") && mail.Contains(".com");
Console.WriteLine(sonuc);


Startswith
Metinin Başlangıç değerini kontrol eder
containsin aynısı ama başı kontrol eder


Endswith
Metinin sonunu kontrol eder
containsin aynısı ama sonu kontrol eder



Equals
Metin ifadesiyle başka bir değerin bire bir eşit olup olmamasını kontrol eder
Bool a= metin.equals(metin2);
string ad = "hakan";
string ad2 = "yunus";

bool sonuc = ad==ad2; // bu kullanımın aynısı equal
bool sonuc2 = ad.Equals(ad2);
Console.WriteLine(sonuc2);


Comparre
Metinsel alfa numerik olarak karşılaştırma yapar
String.compare(metin,metin2);
Geriye int döner  
0 = eşit
1= soldaki büyük
-1= sağdaki büyük
Aşırı yükleyip belli karakterleride karşılaştırabiliriz
String.Compare(metin,index,metin2,index, kaç adat karakter karşılaştırılcak)


string ad = "mersin";
string ad2 = "adana";
int sonuc = string.Compare(ad,ad2);

Console.WriteLine(sonuc);



Compareto
Compare ile aynı görevi görüyor sadece kullanımı farklı
Metin.compareTo(metin2);
Seklinde görev yapıyor



Indexof
Verilen değerin eşleşen index numarasını verir
Metin.IndexOf(“x”);

string mail= Console.ReadLine();
int a = mail.IndexOf("@");
string mailUzantısı = mail.Substring(a+1);
Console.WriteLine(mailUzantısı);

İnsert
Stringe değer eklememizi sağlar
Metin.insert(başlkangıç index, eklenecek keyword);
Geriye string döner var olan metini değiştirmez.

string ad = "Hakan Çakır";
string yeniAd = ad.Insert(6, " Baran ");
Console.WriteLine(yeniAd);



Remove => insert ile aynı mantık
	Metin içinde index  verilerek değerler silinir
Metin.remove(5);  5 ten sonrasını sil
Metin.remove(5,2); 5 ten sonra 2 tane sil



Substring
Split gibi metni parçalama splitten farklı olarak indexlerden işlem yapar
   string metin2 = metin.Substring(başlangıç index);
    string metin2 = metin.Substring(başlangıç index, kaç karakter);


string cumle = "yunus can hakan baran çakır";

//string cumleparcasi = cumle.Substring(6);// bu  6. sıradan sonrasını komple al
//string cumleparcasi = cumle.Substring(6,3);// bu 6 . sırdan 3 tanesini al
Console.WriteLine(cumleparcasi);


ÖNEMLİ ÖRNEK 

// bir kadın ve bir adam evlendi kadının soyadını adamınki ile değiştircez
Console.WriteLine("Kocanın Ad ve soyadı");
string adam= Console.ReadLine();
Console.WriteLine("Eşinin Adı ve soyadı");
string kadın = Console.ReadLine();
// döngü kullanmak için kişilerin sadece 1 adı olduğunu farz ediyoruz
int adamSoyadSira = adam.IndexOf(" ");
string adamSoyad = adam.Substring(adamSoyadSira+1);
int kadinAdSira = kadın.IndexOf(" ");
//string kadinAd = kadın.Remove(kadinAdSira);// bu yöntemlede alabilirz
string kadinAd = kadın.Substring(0, kadinAdSira);
string kadinYeniAdveSoyad = $"{kadinAd} {adamSoyad}";

Console.WriteLine($"Kadının Yeni adı = {kadinYeniAdveSoyad}");
*/
