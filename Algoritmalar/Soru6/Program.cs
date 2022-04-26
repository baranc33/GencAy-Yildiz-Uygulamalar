//  pozitif sayılarda çarpma işlemini toplama kulanarak bulan uygulamayı yazınız.

/* Çözüm 1 */
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi2  = Convert.ToInt32(Console.ReadLine());

int toplam = 0;
for (int i = 0; i < sayi2; i++)
{
    toplam+=sayi1;
}


Console.WriteLine(toplam);
