var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Welcome to Uday coding...");
//});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hey Guys \n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Welcome to Uday coding... \n");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Let's go to machao........");
});

app.Run();
