# 什么是 ASP.NET Core？

<div>

ASP.NET Core 是一个用于生成新式 Web 应用程序的跨平台高性能框架。 这个开放源代码框架允许开发人员创建可以在 Windows、macOS 和 Linux 上运行的 Web 应用程序、服务和 API。 它专为大规模应用开发而生成，可以处理任何大小的工作负荷，是企业级应用程序的可靠选择。

</div>

<div>

## 全堆栈 Web 开发

ASP.NET Core 是一个全堆栈 Web 框架，可在单个一致的框架内无缝集成前端和后端开发需求：  
- 用于前端开发的 ASP.NET Core 包括 Blazor，这是一个以 C# 为基础的基于组件的 Web UI 框架，支持服务器端呈现和通过 WebAssembly 进行的客户端呈现。
- 也可将 ASP.NET Core 与 JavaScript 前端框架（如 Angular、React 和 Vue）集成。

</div>

<div>

## API 开发

ASP.NET Core 是一个强大的 API 开发框架：
- 它支持使用 SignalR 创建基于 JSON 的 API、gRPC 服务和实时服务。
- 借助内置的 OpenAPI 支持，开发人员可以轻松生成和可视化 API 文档，简化 API 的设计和使用。
- 可以使用 ASP.NET Core 为各种应用（包括 Web 应用和本机移动应用）生成后端 API。

</div>

<div>

## 模块化体系结构

ASP.NET Core 的模块化体系结构为新式 Web 开发提供了灵活的方法：
- 该体系结构包含对依赖项注入、中间件、配置和记录的支持。
- 可以配置中间件组件来处理请求和响应，其中包括用于身份验证、路由、会话管理和静态文件服务的内置中间件。
- 依赖项注入设计模式增强了可测试性和可维护性。

</div>

<div>

## 内置安全性

ASP.NET Core 凭借其强大的用于身份验证和授权的内置安全功能帮助你生成安全的应用程序。 这些功能可帮助应用程序有效地管理用户标识和保护敏感数据。

</div>

<div>

## 提高工作效率
总体而言，ASP.NET Core 提供高效的开发体验，使开发人员能够有效且高效地生成高质量的全堆栈 Web 应用。

</div>

---

<div>

## ASP.NET Core 的工作原理

ASP.NET Core 应用本质上是一个 .NET 应用，其中包含一个 Program.cs 文件，用于设置所需的 Web 应用组件功能并使其运行。

最基本的 ASP.NET Core 应用的 Program.cs 文件：

```
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
```

上面的示例：
- 设置基本的 ASP.NET Core Web 应用程序，用于侦听根 URL（“/”）中的 HTTP GET 请求并使用“Hello World!”进行响应。
- 初始化应用、配置单个路由并启动 Web 服务器。

</div>

<div>

## Blazor

可以使用 Blazor 通过 ASP.NET Core 生成交互式 Web UI。 Blazor 是一个基于组件的 Web UI 框架，与 ASP.NET Core 集成，用于使用 HTML、CSS 和 C# 生成交互式 Web UI。

Counter.razor 文件中定义了可重复使用的 Blazor 组件，例如以下`Counter`组件

razor  
```
@page "/counter"
@rendermode InteractiveServer

<PageTitle>Counter</PageTitle>

<h1>Counter</h1>

<p role="status">Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
```

上面的示例：
- 创建了一个显示计数器的组件。
- @code 块包含使用 C# 的组件逻辑，其中包括递增计数器的方法。
- 每次点击按钮时，都会显示并更新计数器值。
- 组件方法允许在应用程序的不同部分中重复使用代码，并且可以灵活地在浏览器中或在 Blazor 应用中的服务器上运行。

可以通过添加`<Counter />`元素将`Counter`组件添加到应用中的任何网页。

razor  
```
@page "/"

<PageTitle>Home</PageTitle>

<h1>Hello, world!</h1>

<Counter />
```

</div>

<div>

## API

ASP.NET Core 提供了用于使用 SignalR 生成 API、gRPC 服务和实时应用的框架，以便将数据更新即时推送到客户端。  
基本精简 API：

```
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => "Hello, World!");

app.Run();
```

上面的示例：
- 设置精简 API，用于侦听 /hello URL 中的 HTTP GET 请求并使用“Hello World!”进行响应。
- 使用`WebApplicationBuilder`配置应用。
- `MapGet`方法定义 GET 请求的路由和处理程序。

</div>

<div>

## 中间件

ASP.NET Core 使用中间件组件的管道来处理 HTTP 请求和响应。 这种模块化方法使你可以灵活地根据需要添加或删除中间件组件来自定义和扩展应用程序的功能。

中间件管道按顺序处理 HTTP 请求，确保在将请求传递到管道中的下一个组件之前，每个组件都可以执行其指定任务。

在 Program.cs 文件中添加内置中间件:

```
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.UseRouting();

app.MapStaticAssets();

app.UseAuthentication();

app.UseAuthorization();

app.MapGet("/", () => "Hello World!");

app.Run();
```

在前面的代码中，添加了几个常用的中间件组件：
- `UseHttpsRedirection`：将 HTTP 请求重定向到 HTTPS。
- `UseRouting`：启用路由以将请求映射到终结点。
- `MapStaticAssets`：优化静态文件的发送，例如 HTML、CSS、JavaScript、图像和其他资产。
- `UseAuthentication`：添加身份验证功能。
- `UseAuthorization`：添加授权功能。
- `app.MapGet`：这是一个简单的终结点，用于证明应用程序正在运行。

</div>

<div>

## 依赖项注入

ASP.NET Core 具有对依赖项注入 (`DI`) 的内置支持，用于配置应用及其各种框架组件使用的服务。  
例如，你可能希望使用 EntityFramework Core 之类的框架集中配置服务，而应用的其他部分则依赖于该框架来访问数据库。 可以使用依赖项注入将 EntityFramework Core 中的数据库上下文配置为服务，如下所示：

```
public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    
    public DbSet<Product> Products { get; set; } = default!;
}

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.Run();
```

上面的示例：
- 将`DbContext`配置为使用依赖项注入的服务。
- 使用`WebApplicationBuilder`配置应用。
- `AddDbContext`方法向依赖项注入容器注册
- `DbContext`从配置中检索连接字符串并用于设置数据库上下文。

</div>

<div>

## 配置

ASP.NET Core 支持从各种源（例如 JSON 文件、环境变量和命令行参数）访问配置数据。  
在 appsetting.json 文件中配置连接字符串

JSON
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;"
  }
}
```

在 Program.cs 文件中：

```
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.Run();
```

在前面的代码示例中：
- 在 appsettings.json 文件中配置了连接字符串
- 使用`WebApplicationBuilder`配置应用。
- `AddDbContext`方法向依赖项注入容器注册`DbContext`。
- 从配置中检索连接字符串并用于设置数据库上下文。

</div>

<div>

## 监控和诊断

ASP.NET Core 提供了一套全面的工具来监视和维护应用程序的运行状况和性能。 可以轻松地将这些功能作为中间件组件添加到应用程序，并将特定功能集成到项目中：
- `内置指标`：ASP.NET Core 包含内置指标，用于跟踪应用程序性能的各个方面，例如请求率、响应时间和错误率。
- `灵活记录框架`：内置了灵活的记录框架，并支持各种记录提供程序，包括控制台、调试和事件源。  
这有助于捕获诊断和监视的详细日志。
- `跟踪`：ASP.NET Core 支持分布式跟踪，这有助于跟踪跨不同服务和组件的请求流。  
这对于诊断性能问题和了解应用程序不同部分之间的交互很有用。
- `OpenTelemetry`：`ASP.NET Core` 与 `OpenTelemetry` 集成，后者是云原生软件的开源可观测性框架。  
`OpenTelemetry` 提供标准化 API 和检测来收集指标、日志和跟踪，使你能够更有效地监视和诊断应用程序。
- `运行状况检查`：通过运行状况检查 `API`，可以监视应用程序的运行状况及其依赖项。  
可以配置运行状况检查来报告各种组件（例如数据库、外部服务等）的状态。
- `诊断工具`：ASP.NET Core 提供了各种诊断工具，例如 `dotnet-trace`、`dotnet-dump` 和 `dotnet-gcdump`，可帮助从应用程序收集和分析诊断数据。

</div>

---

<div>

## 何时使用 ASP.NET Core

当 Web 应用具有以下任何要求时，用于 Web 开发的 ASP.NET Core 是理想选择：
- `丰富的用户界面`：你想要生成交互式和动态 Web 应用程序。 通过支持 Blazor 和常用的前端 JavaScript 框架，ASP.NET Core 允许你创建丰富的用户界面。
- `API 开发`：需要开发可靠的 API 服务。 ASP.NET Core 同时支持 RESTful API 和 gRPC，为不同的通信需求提供了灵活性。
- `微服务体系结构`：你正在构建基于微服务的体系结构。 ASP.NET Core 的轻型模块化设计非常适合微服务。
- `高性能`：应用程序需要高性能和可伸缩性。 ASP.NET Core 设计用于高效地处理高流量和大规模应用程序。
- 新式开发实践`：你更喜欢新式开发做法，例如依赖项注入、异步编程和模块化体系结构。 ASP.NET Core 现成支持这些做法。
- `跨平台要求`：需要开发在 `Windows`、`macOS`、`Linux` 和 `Docker` 上运行的应用程序。 ASP.NET Core 的跨平台功能使其成为适合各种环境的绝佳选择。
- `云集成`：计划将应用程序部署到云。 `ASP.NET Core` 与 `Azure` 和其他云平台无缝集成，简化了部署和管理。
- `安全性和符合性`：需要强大的安全功能，并符合行业标准。 `ASP.NET Core` 为 `HTTPS`、`数据保护`和其他安全最佳做法提供了内置支持。

</div>

<div>

## 什么时候不适合使用 ASP.NET Core

当 `Web 应用`具有以下任何要求时，`ASP.NET Core` 可能不适合用来满足 `Web` 开发需求：
- `最低要求`：应用程序是一个简单的静态页面网站。
- `特定语言首选项`：你的团队更喜欢使用 C# 以外的语言。 虽然 ASP.NET Core 支持多种语言，但它主要是为 C# 开发而设计的。

</div>

---

