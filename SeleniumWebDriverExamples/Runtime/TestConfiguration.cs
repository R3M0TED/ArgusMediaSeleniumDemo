using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.IO;

public class TestConfiguration
{
    public string BrowserType { get; set; }
    public bool Headless { get; set; }
    public bool SaveFailureScreenshots { get; set; }
    public string ScreenshotPath { get; set; } = string.Empty;

    private static IConfiguration _configuration;

    static TestConfiguration()
    {
        try
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("testsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();
        }
        catch
        {
            throw new ConfigurationErrorsException("Failed to load 'testsettings.json' file.");
        }
    }

    public TestConfiguration()
    {
        BrowserType = GetRequiredConfiguration("BrowserType");
        Headless = bool.Parse(GetRequiredConfiguration("Headless"));
        SaveFailureScreenshots = bool.Parse(GetRequiredConfiguration("SaveFailureScreenshots"));
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
}
