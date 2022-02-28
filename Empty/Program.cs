using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Program>());// controller ve view kullan�lacak
//builder.Services.AddControllers();//sadece kontroller

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();// Gelen isteklerin Rotas�n� bu middleware belirler. 

app.UseEndpoints(endpoints =>
{ 
// �imdilik defaulta ayarlad�k

    // ilk parametre route ismi verilir daha sonra standrt controler ve action gelir
    // istersek bunlara default de�er verebiliriz ard�ndan gelen parametreler ? null olabilir diyebiliriz
    // route mekanizmas�nda her parametre {} s�sl�ler i�ersinde yer al�r
    //endpoints.MapControllerRoute("MyRoute", "{controller=product}/{action=GetProduct}/{id?}/{name?}");

    // e�er yukardaki tan�ma uymazsa bu �al���r  e�er bunada uymazsa  alttakine ge�er o y�zden
    // default tan�mlama herzaman en altta kalmal�d�r
    endpoints.MapDefaultControllerRoute();
});


//app.MapGet("/", () => "Hello World!");


app.Run();
