// kullanıcının girdiği iki sayının karelerinin toplamını veren uygulama yazınız

int sayi1, sayi2;
/* Çözüm 1 
 Console.WriteLine("Lütfen bir sayı giriniz");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen bir sayı giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((sayi1*sayi1) + (sayi2*sayi2));
 */

/* Çözüm 2
Console.WriteLine("Lütfen bir sayı giriniz");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen bir sayı giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());

// Powe Metodu 1. parametre taban 2. parametre üssü ifade eder
double Sonuc = Math.Pow(sayi1, 2)+ Math.Pow(sayi2, 2);
Console.WriteLine(Sonuc);
*/

/* Çözüm 3  Tek satırda işlem yapma*/
Console.WriteLine("Lütfen birinci ve ikinci sayılarını giriniz");
Console.WriteLine(Math.Pow(Convert.ToInt32(Console.ReadLine()),2)+Math.Pow(Convert.ToInt32(Console.ReadLine()), 2));
