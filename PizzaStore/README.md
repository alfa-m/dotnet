# Minimal API of Pizza Store

## Description

A minimal API example using ASP.NET Core and .NET.
The original course Microsoft Learn can be seen [here](https://learn.microsoft.com/pt-br/training/modules/build-web-api-minimal-api/).

## Requirements

This example requires:

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (v.6 and onwards)
- [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-pack) in your
  [Visual Studio Code](https://code.visualstudio.com/Download)

## Step-by-step

### Creating the Minimal API

1. Choose a folder to save your project and open it in VS Code
2. Open the PowerShell terminal inside VS Code and type:

```
dotnet new web -o PizzaStore
```

This tells the terminal to create a new ASP.NET Core template (`new web`) and to output it to the PizzaStore directory (`-o PizzaStore`). Since the PizzaStore directory doesn't exist yet, this will also create this folder.

3. Change to the new directory

```
cd PizzaStore
```

You'll see that the ASP.NET Core template already includes the following four lines of code.

```
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
```

Breaking down the code:

`var builder = WebApplication.CreateBuilder(args);` -> Informs that the builder will be a WebApplicationBuilder

`var app = builder.Build();` -> Builds the Web Application

`app.MapGet("/", () => "Hello World!");` -> Shows "Hello World!" when the route is "/"

`app.Run();` -> Runs the application

4. Run the application

```
dotnet run
```

When the building finishes, the terminal will show the localhost ports for the application.

5. Access the port

In the browser, go to the indicated `http://localhost:{PORT}`, where you'll see the message "Hello World!".

### Creating the data
