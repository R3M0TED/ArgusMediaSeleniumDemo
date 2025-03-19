using Microsoft.Extensions.Configuration;
public class TestConfiguration
{
    public string BrowserType { get; set; }
    public bool RunMaximised { get; set; }
    public bool Headless { get; set; }

    private static IConfiguration _configuration;

    static TestConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("testsettings.json", optional: false, reloadOnChange: true);

        _configuration = builder.Build();
    }

    public TestConfiguration()
    {
        BrowserType = _configuration["BrowserType"] ?? "Chrome";
        RunMaximised = bool.TryParse(_configuration["RunMaximised"], out bool runMaximised) && runMaximised;
        Headless = bool.TryParse(_configuration["Headless"], out bool headless) && headless; 
    }
}
