using System.Reflection;
using Microsoft.AspNetCore.Mvc;

var assembly = Assembly.Load("Events.API"); // ← nome do assembly, geralmente igual ao nome do projeto

var controllers = assembly.GetTypes()
    .Where(type => typeof(ControllerBase).IsAssignableFrom(type) && !type.IsAbstract);

int totalEndpoints = 0;

foreach (var controller in controllers)
{
    var methods = controller.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
        .Where(m => m.GetCustomAttributes().Any(attr =>
            attr.GetType().Name.StartsWith("Http")));

    Console.WriteLine($"📁 {controller.Name}: {methods.Count()} endpoints");

    totalEndpoints += methods.Count();
}

Console.WriteLine($"\n🔢 Total de endpoints encontrados: {totalEndpoints}");
