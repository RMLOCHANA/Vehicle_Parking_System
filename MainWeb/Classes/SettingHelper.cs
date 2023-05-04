using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MainWeb;
using MainWeb.Models;
using Microsoft.Extensions.Configuration;

// Helping class to read appSettings.json data

public class SettingHelper
{
    private static SettingHelper _appSettings;

    public string appSettingValue { get; set; }

    public static string AppSetting(string Key)
    {
        _appSettings = GetCurrentSettings(Key);
        return _appSettings.appSettingValue;
    }

    public SettingHelper(IConfiguration config, string Key)
    {
        this.appSettingValue = config.GetValue<string>(Key);
    }

    public static SettingHelper GetCurrentSettings(string Key)
    {
        var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddEnvironmentVariables();

        IConfigurationRoot configuration = builder.Build();

        var settings = new SettingHelper(configuration.GetSection("ApplicationSettings"), Key);

        return settings;
    }
}