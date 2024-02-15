// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    HttpClient httpClient = new()
    {
        BaseAddress = new Uri("http://localhost:50798/"),
    };

    using HttpResponseMessage response = await httpClient.GetAsync("WeatherForecast");

    var jsonResponse = await response.Content.ReadAsStringAsync();
    Console.WriteLine($"{jsonResponse}\n");
}
catch (Exception ex)
{
    Console.WriteLine($"Exception message : {ex.Message}");
}
finally
{
    Console.ReadKey(); ;
}