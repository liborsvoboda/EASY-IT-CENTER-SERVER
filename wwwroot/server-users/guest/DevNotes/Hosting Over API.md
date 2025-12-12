Klient LDAP

# udelat Spr8vu glob8ln9ch mudulů
dotnet i npm a tím se dají nabízet aplikace na dotnet new XXX



# Udelat napojeni na externi mail klienty
a prekladat texty
vyzobat emaily z githubu a nabidnout je oslovit
------------------------------------


# Website Over HTML API    

with template system can be create dynamic html API 

which provide full website without razor pages

----------------





SignalR API Dynamic Data Move ETC
https://github.com/aspnet/SignalR-samples/tree/main

ASPNETCORE FullDoc https://github.com/dotnet/aspnetcore/tree/3f1acb59718cadf111a0a796681e3d3509bb3381/src
Nuget Info/Dodwload https://github.com/NuGet/Samples/blob/main/CatalogReaderExample/CatalogReaderExample/Program.cs

udelat dynamickou stranku portalu kde budu cshtml plne nacitat a editovat z webu

API jako response přes klienty
https://learn.microsoft.com/en-us/aspnet/core/signalr/dotnet-client?view=aspnetcore-8.0&tabs=visual-studio

----------------------------------------------------------------------
Bussines PLAN 



500Kc   10 Tools 


----------------------------------------------------------------------
INSERT TO API 

----------------------
var builder = WebApplication.CreateSlimBuilder(args);


builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0,
                                 AppJsonSerializerContext.Default);
});

var app = builder.Build();

app.MapPut("/v1/todos/{id}", ([AsParameters] TodoRequest request)
    => Results.Ok(request.Todo));

app.Run();

---------------------

START API WITH SWAGGER

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<List<Book>>((sp) =>
{
    return new(){
    new Book(1, "Testing Dot", "Carson Alexander"),
    new Book(2, "Learn Linq", "Meredith Alonso"),
    new Book(3, "Generics", "Arturo Anand"),
    new Book(4, "Testing the Mic", "Gytis Barzdukas"),
    new Book(5, "Drop the Dot", "Van Li"),
};
});
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

// <snippet_multiple_result_types>
app.MapGet("/book{id}", Results<Ok<Book>, NotFound> (int id, List<Book> bookList) =>
{
    return bookList.FirstOrDefault((i) => i.Id == id) is Book book
     ? TypedResults.Ok(book)
     : TypedResults.NotFound();
});
// </snippet_multiple_result_types>

// <snippet_single_result_type>
app.MapGet("/books", (List<Book> bookList) => TypedResults.Ok(bookList));
// </snippet_single_result_type>

app.Run();


-------------------------------------------------------------------



