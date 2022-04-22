// doğum tarihini giren kişinin yaşını yazınız

/* Çözüm 1
 
 Console.WriteLine("Lütfen Doğum tarihini yazınız");
DateTime dogumTarihi=Convert.ToDateTime(Console.ReadLine());
DateTime now = DateTime.Now;
TimeSpan sonuc=now - dogumTarihi;
Console.WriteLine(sonuc.Days/365);
 */



/* Çözüm  2
Console.WriteLine("Lütfen Doğum tarihini yazınız");
DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
DateTime bugun = DateTime.Now;

int yas=bugun.Year-dogumTarihi.Year;
// eyer ay  hesabı yappmazsak  01.12.1995 doğumlu biri ölçünü 01.01.2020 yılında deneme yaparsa 25 yaşında çıkar
// fakat 12. ay da 25 yaşında olur bu yüzden hesabımız yanlış olur bununda kontrolünü yapmalıyız
//bugun.AddYears(-yas);// - diyerek  çıkarma işlemi yapıyoruz 

if (dogumTarihi>bugun.AddYears(-yas))// doğum tarihibüyük olursa  gün olarak  daha dolmamış demek
    yas--;

Console.WriteLine(yas);
*/


/* Çözüm  3*/
Console.WriteLine("Lütfen Doğum tarihini yazınız");
DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
DateTime bugun = DateTime.Now;

int gunFarki = (bugun-dogumTarihi).Days;
int yas = gunFarki/365;
int kalan = gunFarki%365;
Console.WriteLine(yas); Console.WriteLine("Kalan gün " +(365+(yas* 1/4)- kalan));// şubat ayı ve kalan zamanı düzgün hesaplıyoruz