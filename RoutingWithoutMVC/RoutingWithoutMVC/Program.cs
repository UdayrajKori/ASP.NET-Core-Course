
// To create the custome middleware you need to:

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // add this line of code
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


// this is the convetional based routing...

//app.MapDefaultControllerRoute();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}"
//    );


// now from here we start attribute routing.....

// and also this line of code for attribute routing.

app.MapControllers();


app.Run();
