
// Ram Nedir ?

// Bilgisayarın Kısa süreli Küçük Hafıza belleği ve hızlı işlem belleğidir

// Ram Bölümleri



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



3.Register bölgesi
stack ve heap a göre hızlıdır sınırlı sayıdaki yapı olduğu için çok sık kullanılan yapıları bu bölgede tutar
bu bölgeye doğrudan erişimimiz yoktur bu erişimi jit derleyici otomatik olarak yapar



4.Static bölge
Bellekte herhangi bir bölgeyi temsil eder 
bu bölgedeki nesneler programın akışı boyunca kullanılacağı için hep tutulurlar 
bir static nesne oluşturmak için  
Static kelimesi kullanırız



5.sabit bölge
sabit(constant) bu bölgede programın kodları tutulur sadece okumak amaçlı oldukları için hızlılık açısından bazı durumlarda 
ROM (read only memory )' de tutulurlar 




6.ram olmayan bölge
program kapatıldığında verilerin kaybolmasını istemiyorsak buraya yazılır hard disk gibi.


