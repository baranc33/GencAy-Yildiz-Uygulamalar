
/*
 ConfigurationManagere erişip MiddleWare üstünde işlem yapmak istersek aşşağıdaki yolu takip etmelyiz
 
 */


public class AltıncıBolum
{

    static void Main()
    {

        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();
        //app.Configuration["jsonConfigismi"].  //Metotlar geliyor bu sekilde
        // get section metodu üstündende kullanılabilir
        //app.Configuration.GetSection


        app.MapGet("/", () => "Hello World!");





        app.Run();
        /*

         COnfigurationManager= Servis entegrasyonları sürecinde herhangi bir konfigrasyonel değer ihtiyacımız varsa bu sınıftan yararlanırız
        yani (apppsetting.json.enviroment varable.) gibi yerlerden gelen değerleri almak  için kullanılır
        builder.Services üstünden erişilir


         IConfiguration : Middleware'ler üzeründe konfigurasyonel değere erişim için kullanılır ConfigurationManager yerinede kullanılabilir


        * Eğer elimizde harici Json dosyaları  vb. dosyaları okumakk için farklı yöntemler  kullanırken 
        .net 6 da bunun için geliştirilmiş yöntemi inceliyelim bu yapı sadece program.cs için geçerli değildir
        Classların içindede yapılabilir Eskiden
        Configuration Builder c=new();
        c.AddJsonFile("Deneme.json");
        IcConfugiration ıc=c.build();
        var gelecekdeğer= ci["Key]; şeklinde erişim yapıyorduk
        kolay olsada build maliyetli bir işlem bunu hem daha kolay hemde maliyetini azaltmaya yapıyoruz

        Tabi bu işlemi burda yapacaksak run etmeden  önce yapmalıyız
        */
        ConfigurationManager cm = new();
        cm.AddJsonFile("conf.json");
        string dger = cm["conf:Key"].ToString();
        Console.WriteLine(dger);
    }

}
