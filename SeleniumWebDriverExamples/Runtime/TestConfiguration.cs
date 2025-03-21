using Microsoft.Extensions.Configuration;
public class TestConfiguration
{
    public string BrowserType { get; set; }
    public bool Headless { get; set; }
    public bool SaveFailureScreenshots { get; set; }
    public string ScreenshotPath { get; set; } = string.Empty;

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
        BrowserType = GetRequiredConfiguration("BrowserType");

        try
        {
            Headless = ParseBoolConfig("Headless");
            SaveFailureScreenshots = ParseBoolConfig("SaveFailureScreenshots");
        }
        catch (FormatException ex)
        {
            throw new ArgumentException("One or more configuration values are invalid.", ex);
        }
    }

    private string GetRequiredConfiguration(string key)
    {
        var value = _configuration[key];
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"{key} is required in the configuration.");
        }
        return value;
    }

    private bool ParseBoolConfig(string key)
    {
        var value = GetRequiredConfiguration(key);
        return bool.Parse(value);
    }
}
