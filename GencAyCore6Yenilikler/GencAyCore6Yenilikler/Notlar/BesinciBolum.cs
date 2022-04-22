
public class BesinciBolum
{
    static void Main(string[] args)
    {
        /*
appsettings.development.json dosyasının içinden configrasyonel değer çekmek
sorumuz şu  .json dosyasnın içinde
"conf": { "A": "B" }
conf ismidneki configrasynun içindeki A nın Değeri nedir?
*/
        var builder = WebApplication.CreateBuilder(args);
        // eskiden IConfigrtion dönerken artık Configuration Manager Dönüyor
        string keyowrd = builder.Configuration["conf:A"];// bu şekilde string  olarakta alabiliriz.


        var app = builder.Build();

        app.MapGet("/", () => keyowrd);// burdad gördüğümüz gibi kullanabiliriz 
                                       // tabi istersek stringe atamdan direk olduğu gibide kullanabiliriz


        app.Run();

    }
}
