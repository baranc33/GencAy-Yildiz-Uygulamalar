
// Ram Nedir ?

// Bilgisayarın Kısa süreli Küçük Hafıza belleği ve hızlı işlem belleğidir

// Ram Bölümleri

// ctrl k + ctrl D  => kodlarını düzeltir.
int sayi1 = 5;
int sayi2 = 6;
int sayi3=sayi1 + sayi2;
//Console.WriteLine(sayi3);
string Adi1 = "Yunus";
string Adi2 = " idi";

string bas = Adi1.Substring(0, 2).ToUpper();
string Adi3 = bas+Adi1.Substring(2)+Adi2;
Console.WriteLine(Adi3);



/*
Değişken Nedir 
Programlama yapılırken verilen bir değeri bilgisayarın hafızasında tutan ve 
istediğimiz yerde kullanmamızı sağlayan verilere değişken adı verilmektedir

Formül
Türü   DeğişkenAdi ;



Her Satır Kod Bittiğinde  Noktalı virgül Kullanılır(;).

Derslerde kullanacağımız Veri tipleri
int => Sayısal veri tipleri => Tam Sayılar 
double => ondalıklı sayılar için => nokta ile ondalıklı
string => kelimeler için  => çift tırnaklar içinde yazılmalı
bool => mantıksal işlemler için
DateTime => Tarih için

 
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
*/