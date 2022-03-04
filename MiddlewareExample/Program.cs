var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.Use(async (context, next) =>
{
    Console.WriteLine("Start");
    await next.Invoke();
    Console.WriteLine("Finish");
});

app.Run(async context =>{
    global::System.Console.WriteLine("Run");
});







app.UseAuthorization();

app.MapControllers();

app.Run();
