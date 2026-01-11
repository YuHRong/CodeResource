using Newtonsoft.Json;
using System.IO;

namespace zdsr
{
 public class ApiConfig
 {
  public string BaseUrl { get; set; } = "http://www.zd.hk/";
  public string AppKey { get; set; } = "";
  public string SecretKey { get; set; } = "";
  public int TimeoutSeconds { get; set; } = 30;
  public UserInfo CurrentUser { get; set; }
 }

 public class UserInfo
 {
  public string Auth { get; set; }
  public string Username { get; set; }
  public string Email { get; set; }
  public int Uid { get; set; }
  public bool IsLoggedIn => !string.IsNullOrEmpty(Auth);
 }

 public static class ConfigManager
 {
  private static readonly string ConfigFile = "zdsr_config.json";

  public static ApiConfig LoadConfig()
  {
   try
   {
    if (File.Exists(ConfigFile))
    {
     string json = File.ReadAllText(ConfigFile);
     return JsonConvert.DeserializeObject<ApiConfig>(json) ?? new ApiConfig();
    }
   }
   catch { }

   return new ApiConfig();
  }

  public static void SaveConfig(ApiConfig config)
  {
   try
   {
    string json = JsonConvert.SerializeObject(config, Formatting.Indented);
    File.WriteAllText(ConfigFile, json);
   }
   catch { }
  }
 }
}