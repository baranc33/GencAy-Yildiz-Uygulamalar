// iki sayının toplamını veren uygulamayı yazınız
// dizileri tek satırda tanımlayıp kod maliyetini azaltırız
decimal sayi1, sayi2;
// kullanıcıya gerekli bilgiyi vermeliyiz
try
{// hata alabileceğimiz kısmı kontrol etmeliyiz

    Console.WriteLine("Lütfen bir sayı giriniz");
    sayi1 = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Lütfen bir sayı giriniz");
    sayi2 = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine(sayi1 + sayi2);
}
catch 
{
    Console.WriteLine("Lütfen Geçerli bir değer giriniz");

}
