/*
 program.cs dosyasýnýn kopyasýný notlar kýsmýnda oluþturup notlarýmý aldým.
 */

/*
 ConfigurationManagere eriþip MiddleWare üstünde iþlem yapmak istersek aþþaðýdaki yolu takip etmelyiz
 
 */
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
//app.Configuration["jsonConfigismi"].  //Metotlar geliyor bu sekilde
// get section metodu üstündende kullanýlabilir
//app.Configuration.GetSection


app.MapGet("/", () => "Hello World!");





app.Run();
/*
 
 COnfigurationManager= Servis entegrasyonlarý sürecinde herhangi bir konfigrasyonel deðer ihtiyacýmýz varsa bu sýnýftan yararlanýrýz
yani (apppsetting.json.enviroment varable.) gibi yerlerden gelen deðerleri almak  için kullanýlýr
builder.Services üstünden eriþilir
 
 
 IConfiguration : Middleware'ler üzeründe konfigurasyonel deðere eriþim için kullanýlýr ConfigurationManager yerinede kullanýlabilir


* Eðer elimizde harici Json dosyalarý  vb. dosyalarý okumakk için farklý yöntemler  kullanýrken 
.net 6 da bunun için geliþtirilmiþ yöntemi inceliyelim bu yapý sadece program.cs için geçerli deðildir
Classlarýn içindede yapýlabilir Eskiden
Configuration Builder c=new();
c.AddJsonFile("Deneme.json");
IcConfugiration ýc=c.build();
var gelecekdeðer= ci["Key]; þeklinde eriþim yapýyorduk
kolay olsada build maliyetli bir iþlem bunu hem daha kolay hemde maliyetini azaltmaya yapýyoruz

Tabi bu iþlemi burda yapacaksak run etmeden  önce yapmalýyýz
*/
ConfigurationManager cm = new();
cm.AddJsonFile("conf.json");
string dger = cm["conf:Key"].ToString();
Console.WriteLine(dger);