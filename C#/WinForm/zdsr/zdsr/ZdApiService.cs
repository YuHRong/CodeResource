using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;

namespace zdsr
{
 public class ZdApiService
 {
  private readonly HttpClient _httpClient;
  private ApiConfig _config;

  public ZdApiService(ApiConfig config)
  {
   _config = config ?? throw new ArgumentNullException(nameof(config));
   _httpClient = new HttpClient
   {
    BaseAddress = new Uri(config.BaseUrl),
    Timeout = TimeSpan.FromSeconds(config.TimeoutSeconds)
   };

   // 设置默认请求头
   _httpClient.DefaultRequestHeaders.Add("User-Agent", "zdsr-client/1.0");
  }

  public void UpdateConfig(ApiConfig config)
  {
   _config = config ?? throw new ArgumentNullException(nameof(config));
  }

  #region 用户相关API

  /// <summary>
  /// 用户登录
  /// </summary>
  public async Task<ApiResult> LoginAsync(string email, string password)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["email"] = email,
    ["password"] = password
   };

   return await PostAsync("user-login.htm", parameters);
  }

  /// <summary>
  /// 用户注册（跳转到浏览器）
  /// </summary>
  public void RegisterInBrowser()
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey
   };

   string url = BuildUrl("user-create.htm", parameters);
   System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
   {
    FileName = url,
    UseShellExecute = true
   });
  }

  /// <summary>
  /// 获取用户个人资料
  /// </summary>
  public async Task<ApiResult> GetUserProfileAsync(int uid)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["uid"] = uid.ToString()
   };

   return await GetAsync("user-index.htm", parameters);
  }

  /// <summary>
  /// 获取用户发表的主题
  /// </summary>
  public async Task<ApiResult> GetUserThreadsAsync(int uid, int page = 1)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["uid"] = uid.ToString(),
    ["page"] = page.ToString()
   };

   return await GetAsync("user-thread.htm", parameters);
  }

  #endregion

  #region 内容相关API

  /// <summary>
  /// 获取首页内容
  /// </summary>
  public async Task<ApiResult> GetIndexAsync(string orderBy = "tid", int page = 1)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["orderby"] = orderBy,
    ["page"] = page.ToString()
   };

   return await GetAsync("index-index.htm", parameters);
  }

  /// <summary>
  /// 获取板块列表
  /// </summary>
  public async Task<ApiResult> GetForumListAsync()
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey
   };

   return await GetAsync("index-forumlist.htm", parameters);
  }

  /// <summary>
  /// 获取主题列表
  /// </summary>
  public async Task<ApiResult> GetThreadListAsync(int fid, int page = 1)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["fid"] = fid.ToString(),
    ["page"] = page.ToString()
   };

   return await GetAsync("forum-index.htm", parameters);
  }

  /// <summary>
  /// 查看主题详情
  /// </summary>
  public async Task<ApiResult> GetThreadDetailAsync(int tid, int uid = 0, int page = 1)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["tid"] = tid.ToString(),
    ["page"] = page.ToString()
   };

   if (uid > 0)
    parameters["uid"] = uid.ToString();

   return await GetAsync("thread-index.htm", parameters);
  }

  #endregion

  #region 发帖相关API

  /// <summary>
  /// 发新主题
  /// </summary>
  public async Task<ApiResult> CreateThreadAsync(string auth, int fid, string subject, string message,
  int typeid1 = 0, int typeid2 = 0, int typeid3 = 0, int typeid4 = 0)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["auth"] = auth,
    ["fid"] = fid.ToString(),
    ["subject"] = subject,
    ["message"] = message
   };

   if (typeid1 > 0) parameters["typeid1"] = typeid1.ToString();
   if (typeid2 > 0) parameters["typeid2"] = typeid2.ToString();
   if (typeid3 > 0) parameters["typeid3"] = typeid3.ToString();
   if (typeid4 > 0) parameters["typeid4"] = typeid4.ToString();

   return await PostAsync("post-thread.htm", parameters);
  }

  /// <summary>
  /// 回复主题
  /// </summary>
  public async Task<ApiResult> ReplyThreadAsync(string auth, int fid, int tid, string message, int pid = 0)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["auth"] = auth,
    ["fid"] = fid.ToString(),
    ["tid"] = tid.ToString(),
    ["message"] = message
   };

   if (pid > 0)
    parameters["pid"] = pid.ToString();

   return await PostAsync("post-post.htm", parameters);
  }

  /// <summary>
  /// 编辑帖子
  /// </summary>
  public async Task<ApiResult> EditPostAsync(string auth, int fid, int pid, string message,
  string subject = "", int typeid1 = 0, int typeid2 = 0, int typeid3 = 0, int typeid4 = 0)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["auth"] = auth,
    ["fid"] = fid.ToString(),
    ["pid"] = pid.ToString(),
    ["message"] = message
   };

   if (!string.IsNullOrEmpty(subject))
    parameters["subject"] = subject;
   if (typeid1 > 0) parameters["typeid1"] = typeid1.ToString();
   if (typeid2 > 0) parameters["typeid2"] = typeid2.ToString();
   if (typeid3 > 0) parameters["typeid3"] = typeid3.ToString();
   if (typeid4 > 0) parameters["typeid4"] = typeid4.ToString();

   return await PostAsync("post-update.htm", parameters);
  }

  #endregion

  #region 搜索和社交API

  /// <summary>
  /// 搜索
  /// </summary>
  public async Task<ApiResult> SearchAsync(string keyword, int page = 1)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["keyword"] = HttpUtility.UrlEncode(keyword),
    ["page"] = page.ToString()
   };

   return await GetAsync("search-index.htm", parameters);
  }

  /// <summary>
  /// 关注用户
  /// </summary>
  public async Task<ApiResult> FollowUserAsync(int uid)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["uid"] = uid.ToString()
   };

   return await GetAsync("follow-create.htm", parameters);
  }

  /// <summary>
  /// 取消关注用户
  /// </summary>
  public async Task<ApiResult> UnfollowUserAsync(int uid)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["uid"] = uid.ToString()
   };

   return await GetAsync("follow-delete.htm", parameters);
  }

  /// <summary>
  /// 每日签到
  /// </summary>
  public async Task<ApiResult> SignInAsync(string auth)
  {
   var parameters = new Dictionary<string, string>
   {
    ["format"] = "json",
    ["appkey"] = _config.AppKey,
    ["seckey"] = _config.SecretKey,
    ["auth"] = auth,
    ["version"] = "2.0"
   };

   return await PostAsync("attendance-post.htm", parameters);
  }

  #endregion

  #region 私有方法

  private async Task<ApiResult> GetAsync(string endpoint, Dictionary<string, string> parameters)
  {
   try
   {
    string url = BuildUrl(endpoint, parameters);
    HttpResponseMessage response = await _httpClient.GetAsync(url);
    return await ProcessResponse(response);
   }
   catch (Exception ex)
   {
    return new ApiResult { Success = false, Message = $"请求失败: {ex.Message}" };
   }
  }

  private async Task<ApiResult> PostAsync(string endpoint, Dictionary<string, string> parameters)
  {
   try
   {
    var content = new FormUrlEncodedContent(parameters);
    HttpResponseMessage response = await _httpClient.PostAsync(endpoint, content);
    return await ProcessResponse(response);
   }
   catch (Exception ex)
   {
    return new ApiResult { Success = false, Message = $"请求失败: {ex.Message}" };
   }
  }

  private async Task<ApiResult> ProcessResponse(HttpResponseMessage response)
  {
   string content = await response.Content.ReadAsStringAsync();

   if (!response.IsSuccessStatusCode)
   {
    return new ApiResult
    {
     Success = false,
     Message = $"HTTP错误: {response.StatusCode}",
     Data = content
    };
   }

   try
   {
    JObject result = JObject.Parse(content);
    bool success = result["status"]?.ToString() == "1";
    string message = result["message"]?.ToString() ?? "";
    string serverError = result["servererror"]?.ToString() ?? "";

    return new ApiResult
    {
     Success = success,
     Message = success ? message : (string.IsNullOrEmpty(serverError) ? "未知错误" : serverError),
     Data = result["message"] ?? result,
     RawData = content
    };
   }
   catch (Exception ex)
   {
    return new ApiResult
    {
     Success = false,
     Message = $"解析响应失败: {ex.Message}",
     RawData = content
    };
   }
  }

  private string BuildUrl(string endpoint, Dictionary<string, string> parameters)
  {
   var query = new List<string>();
   foreach (var param in parameters)
   {
    query.Add($"{HttpUtility.UrlEncode(param.Key)}={HttpUtility.UrlEncode(param.Value)}");
   }
   return $"{endpoint}?{string.Join("&", query)}";
  }

  public void Dispose()
  {
   _httpClient?.Dispose();
  }

  #endregion
 }

 /// <summary>
 /// API返回结果
 /// </summary>
 public class ApiResult
 {
  public bool Success { get; set; }
  public string Message { get; set; }
  public JToken Data { get; set; }
  public string RawData { get; set; }
 }
}
