# dotnet `VSCode` 常用命令

## dotnet 终端命令

- dotnet --list-sdks

列出已安装的 .net 版本

- dotnet new console 

在 选中目录中创建控制台应用

- dotnet

生成项目

- dotnet run 

运行项目

## api命令

- dotnet new webapi -controllers -f net8.0

使用 net8.0 框架创建 webapi 应用。

- dotnet tool install -g Microsoft.dotnet-httprepl

安装 .NET HTTP Read-Eval-Print Loop (REPL) 命令行工具

- httprepl https://localhost:{PORT}

连接到 webapi

- connect https://localhost:{PORT}

连接到 webapi


- ls

列出可用节点

- cd [WeatherForecast]

转到对应节点

- get

在 GET 中发出HttpRepl请求：

- exit

结束当前 HttpRepl

