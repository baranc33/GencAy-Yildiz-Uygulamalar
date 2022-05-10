
// Ram Nedir ?

// Bilgisayarın Kısa süreli Küçük Hafıza belleği ve hızlı işlem belleğidir

// Ram Bölümleri


int sayi1 = 15;
int sayi2 = 10;

int sayi3 = sayi1 + sayi2;

Console.WriteLine(sayi3);

/*
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