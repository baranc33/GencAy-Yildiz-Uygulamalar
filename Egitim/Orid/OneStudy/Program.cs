
// Ram Nedir ?

// Bilgisayarın Kısa süreli Küçük Hafıza belleği ve hızlı işlem belleğidir

// Ram Bölümleri

// ctrl k + ctrl D  => kodlarını düzeltir.
/*
 int => Sayısal veri tipleri => Tam Sayılar 
double => ondalıklı sayılar için => nokta ile ondalıklı
string => kelimeler için  => çift tırnaklar içinde yazılmalı
bool => mantıksal işlemler için
0=> false
1=> true 

DateTime => Tarih için

 */

// oyuncu =>Ne sıklkla oynadığı / karakteri / lwli / oyuna para yatırmışmı /
/*Birinci Yöntem Değişken Oluşturma Daha sonra değer atama
DateTime oynamaSikligi;
string Karakteri;
int lwl;

bool ptw;
//string Karakteri= "Nodaçi";// yeni bir değişken oluşturma
Karakteri = "Nodaçi";
Karakteri = "Uzun Kılıç";
Karakteri ="Baltalı Kargı";

Console.WriteLine(Karakteri);*/
/*2. Yöntem Değişken oluştururken Değer Atama
string karakter = "nodaçi";*/

/*3. yöntem Toplu Oluşturma sonra değer atma 
int guc, ceviklik,saglik,zirh;
guc=5;
ceviklik=5;*/
/*4. yöntem Toplu Oluştururken Değer Atama
int guc=5, ceviklik, saglik, zirh;
ceviklik=10;*/



/*
Formül
Türü   DeğişkenAdi ;




1.Stack bölgesi

Değer(value) Tip dediğimiz nesneler burda kalır
stack pointer dediğimiz bölgeler sayesinde doğrudan erişilebilir
stack bölgesinde olan değişkenler  çalışma zamanı öncesi ramde ne kadar yer kapliyacağı bilinmesi gerekir
bazı referans tipli değişkenlerin yoluda bu bölgede bulunur


2.Heap bölgesi
stack ye göre farkı ne kadar yer kaplicağı bilinmesi gerekmemektedir
bu bölge programlamaya büyük esneklik katmaktadır
bu bölgede yeni bir nesne oluşturmak için
NEW  anahtar kelimesi kullanılmalıdır.
bu bölgedeki değişenler dinamik olarak oluşturula bilir
stack bölgesine göre daha yavaş çalışır



3.Static bölge
Bellekte herhangi bir bölgeyi temsil eder 
bu bölgedeki nesneler programın akışı boyunca kullanılacağı için hep tutulurlar 
bir static nesne oluşturmak için  
Static kelimesi kullanırız



Notlar 
1 - Yorum Satırları
2 - ; noktalı virgül
3 - stringlerde çift tırnak içinde değer veriyoruz
4 - Var olan Değişkeni Kullanırken Tipini/türünü  yazmayız
5 - Aynı blok içersinde aynı isimden 1 tane değişken olabilir.
6 - Kodlar Yukardan Aşşağıya Doğru okunur.
*/