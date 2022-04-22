/*
 program.cs dosyas�n�n kopyas�n� notlar k�sm�nda olu�turup notlar�m� ald�m.
 */

/*
 ConfigurationManagere eri�ip MiddleWare �st�nde i�lem yapmak istersek a��a��daki yolu takip etmelyiz
 
 */
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
//app.Configuration["jsonConfigismi"].  //Metotlar geliyor bu sekilde
// get section metodu �st�ndende kullan�labilir
//app.Configuration.GetSection


app.MapGet("/", () => "Hello World!");





app.Run();
/*
 
 COnfigurationManager= Servis entegrasyonlar� s�recinde herhangi bir konfigrasyonel de�er ihtiyac�m�z varsa bu s�n�ftan yararlan�r�z
yani (apppsetting.json.enviroment varable.) gibi yerlerden gelen de�erleri almak  i�in kullan�l�r
builder.Services �st�nden eri�ilir
 
 
 IConfiguration : Middleware'ler �zer�nde konfigurasyonel de�ere eri�im i�in kullan�l�r ConfigurationManager yerinede kullan�labilir


* E�er elimizde harici Json dosyalar�  vb. dosyalar� okumakk i�in farkl� y�ntemler  kullan�rken 
.net 6 da bunun i�in geli�tirilmi� y�ntemi inceliyelim bu yap� sadece program.cs i�in ge�erli de�ildir
Classlar�n i�indede yap�labilir Eskiden
Configuration Builder c=new();
c.AddJsonFile("Deneme.json");
IcConfugiration �c=c.build();
var gelecekde�er= ci["Key]; �eklinde eri�im yap�yorduk
kolay olsada build maliyetli bir i�lem bunu hem daha kolay hemde maliyetini azaltmaya yap�yoruz

Tabi bu i�lemi burda yapacaksak run etmeden  �nce yapmal�y�z
*/
ConfigurationManager cm = new();
cm.AddJsonFile("conf.json");
string dger = cm["conf:Key"].ToString();
Console.WriteLine(dger);