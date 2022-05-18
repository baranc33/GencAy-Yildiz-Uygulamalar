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
