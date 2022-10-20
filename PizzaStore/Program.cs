using PizzaStore.DB;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc(
        "v1",
        new OpenApiInfo
        {
            Title = "Cardápio de Pizzas - API",
            Description = "Lista de pizzas da semana",
            Version = "v1"
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pizza API");
});

app.MapGet("/pizzas/{id}", (int id) => PizzaDB.GetPizza(id));
app.MapGet("/pizzas", () => PizzaDB.GetPizzas());

app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));

app.MapPut("/pizzas", (Pizza pizza) => PizzaDB.UpdatePizza(pizza));

app.MapDelete("/pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));


app.Run();
