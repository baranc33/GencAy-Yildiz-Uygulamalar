//  pozitif sayılarda çarpma işlemini toplama kulanarak bulan uygulamayı yazınız.

/* Çözüm 1 
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi2  = Convert.ToInt32(Console.ReadLine());

int toplam = 0;
for (int i = 0; i < sayi2; i++)
{
    toplam+=sayi1;
}


Console.WriteLine($"{sayi1} x {sayi2} = {toplam}");
/* Çözüm 2

Console.WriteLine("Lütfen bir sayı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int sayac = sayi2;
int sonuc = 0;
while (sayac>0)
{
    sonuc+=sayi1;
    sayac--;
}
Console.WriteLine($"{sayi1} x {sayi2} = {sonuc}");
*/

/* Çözüm 3

Console.WriteLine("Lütfen bir sayı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int sayac = sayi2;
int sonuc = 0;

do
{
    sonuc+=sayi1;
    sayac--;
}
while (sayac>0);

Console.WriteLine($"{sayi1} x {sayi2} = {sonuc}");
*/
/* Çözüm 4 recursive*/
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int sonuc = Topla(sayi1, sayi2);

Console.WriteLine($"recursive : {sayi1} x {sayi2} = {sonuc}");
/* Çözüm 5 */
/* Çözüm 6*/













static int Topla(int sayi1,int sayi2)
{
    if (sayi2 >1)
    {
        return sayi1+Topla(sayi1, --sayi2);
    }
    return sayi1;
}