# JSON 笔记

## JSON 语法

### JSON 的基本结构

JSON 的基本结构包括:

- 对象

对象 是在大括号`{}`中的键值对的集合。

每个键都是一个字符串，后跟一个冒号和相应的值。

多个键值对用逗号分隔。

- 数组

数组是在 `[]`中的值的有序列表。

值可以是任何类型的，包括对象和其他数组。

数组中的元素用逗号分隔。

- 值

值可以是`字符串`、`数字`、`布尔值`、`数组`或`对象`。 字符串用`双引号`括起来，数字不带引号写入，布尔值表示为 `true` 或 `false`。 null 值由关键字 `null` 表示。

- 空格

：JSON 允许空格（空格、制表符和换行符）用于可读性。 但是，空格在 JSON 中并不重要，分析器可以忽略。

- 注释

：JSON 不支持注释。

- 编码

：JSON 在 UTF-8 中编码，这意味着它可以表示任何 Unicode 字符。 这允许在 JSON 数据中包含特殊字符和符号。

### JSON 的数据类型

JSON 的基本数据类型包括：

- 数字

可以包含小数部分的带符号十进制数，并且可能使用指数 `E` 表示法，但不能包含非数字。 该格式不区分整数和浮点。

- 字符串

零个或多个 `Unicode` 字符的序列。 字符串用`双引号`分隔，并支持反斜杠`\`转义语法。

- 布尔值

值`true`之一或`false`

- 数组

零个或多个元素的有序列表，每个元素可能属于任何类型的元素。 数组使用带`逗号`分隔元素的方括号表示法`[]`

- 对象

名称为字符串的`name:value`对集合。 对象用大括号`{}`分隔，并使用逗号分隔每对，而在每对中，冒号
`:`字符将`name`分隔其`value`。
值可以是任何受支持的类型，包括其他对象或数组。

- null

使用单词`null`的空值。

## JSON 示例

### JSON 数据语法

下面示例显示了一个具有多个键值对的对象，包括地址的嵌套对象。 键是字符串，值包括字符串、数字、布尔值和其他对象。


    {
  "name": "John Doe",
  "age": 30,
  "isEmployed": true,
  "address": {
    "street": "123 Main St",
    "city": "New York",
    "state": "NY"
  }
}

### JSON 数组语法

    [
  "apple",
  "banana",
  "cherry"
]

## JSON 序列化

在 C# 应用程序的上下文中，序列化用于将 C# 对象转换为 JSON 字符串。 这对于将数据保存到文件、通过网络发送数据或将数据存储在数据库中非常有用。


- 序列化对于不同系统或应用程序之间的数据交换至关重要，尤其是在它们使用不同的编程语言或平台时。 它允许以标准化格式轻松共享数据，这些格式可由各种系统理解。

- Web API 中还使用序列化在客户端和服务器之间发送和接收数据。 当客户端向服务器发出请求时，服务器可以将响应数据序列化为 JSON 格式，然后客户端可以将该格式反序列化回对象。

- 序列化用于数据存储方案，例如保存应用程序状态或用户首选项。 通过将对象序列化为 JSON，开发人员可以轻松存储和检索复杂的数据结构，而无需手动分析或格式化数据。

- 序列化通常用于缓存机制，其中数据存储在序列化格式以提高性能并减少重复数据库查询或计算的需求。

- 反序列化是序列化的反向过程，其中 JSON 字符串将转换回 C# 对象。 反序列化允许开发人员使用 C# 对象和属性以更结构化的方式处理 JSON 数据。 在使用返回 JSON 响应的 API 或外部数据源时，或者处理存储在 JSON 文件中的信息时，这特别有用。

### JsonSerializer 类

`JsonSerializer`类提供以下方法来序列化和反序列化 JSON：

- Serialize

：将 C# 对象转换为 JSON 字符串。

- Deserialize

：将 JSON 字符串转换回 C# 对象。

### 默认序列话行为

序列化 JSON 时，将应用以下默认行为：

- 默认编码器将转义非 ASCII 字符、ASCII 范围内的 HTML 敏感字符和必须根据 RFC 8259 JSON 规范转义的字符。

- 默认情况下，JSON 已缩小。 可以漂亮地打印 JSON。

- 默认情况下，JSON 名称的大小写与 .NET 名称匹配。 可以自定义 JSON 名称大小写。

- 默认情况下，检测到循环引用并引发异常。 可以保留引用并处理循环引用。

- 默认情况下，将忽略字段。 可以包含字段。


### 使用 JsonSerializerOptions 自定义序列化行为

`JsonSerializerOptions`类允许自定义方法的`JsonSerializer.Serialize`序列化行为。 例如，可以指定选项，例如是否忽略 null 值、包括字段和控制 JSON 输出的格式。

- DefaultIgnoreCondition：此属性指定序列化期间忽略具有默认值的属性的条件。 它可以通过排除具有默认值的属性来帮助减小序列化 JSON 的大小。

- WriteIndented：此属性允许对 JSON 输出进行漂亮的打印，从而通过添加缩进和换行符使其更具可读性。

- IncludeFields：此属性指定是否应在序列化过程中包括字段。 默认情况下，仅序列化属性。


#### 其他常用属性

- PropertyNameCaseInsensitive：此属性在反序列化期间启用属性名称不区分大小写的匹配。 当 JSON 数据具有与类定义不同的大小写的属性名称时，它很有用。

- AllowTrailingCommas：此属性允许 JSON 数组和对象中的尾随逗号，这在处理可能具有尾随逗号的 JSON 数据时非常有用。

- IgnoreNullValues：此属性指定是否应在序列化期间忽略 null 值。 它可以通过排除具有 null 值的属性来帮助减小序列化 JSON 的大小。

- 编码器：此属性允许指定用于转义 JSON 字符串中的字符的自定义编码器。 处理属性名称或值中的特殊字符时，它很有用。


#### 忽略单个属性

若要忽略单个属性，请使用 [JsonIgnore] 属性。

示例: 

    public class WeatherForecastWithIgnoreAttribute
    {
      public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    [JsonIgnore]
        public string? Summary { get; set; }
    }

    class Program
    {
        static void Main()
        {
                var forecast = new WeatherForecastWithIgnoreAttribute
            {
            Date = DateTimeOffset.Now,
            TemperatureCelsius = 25,
            Summary = "Warm"
            };

        string jsonString = JsonSerializer.Serialize(forecast);
        Console.WriteLine(jsonString);
        }
    }

// Output: {"Date":"2023-10-01T12:00:00Z","TemperatureCelsius":25}

可以通过设置 `[JsonIgnore]`属性`Condition`的属性来指定条件排除。

`JsonIgnoreCondition`枚举提供以下选项：

- 始终
始终忽略该属性。 如果未指定条件，则假定此选项。

 - Never
无论 DefaultIgnoreCondition、IgnoreReadOnlyProperties 和 IgnoreReadOnlyFields 全局设置如何，属性始终序列化和反序列化。

- WhenWritingDefault
 如果属性是引用类型 null、可以为 null 的值类型为 null 或值类型默认值，则会在序列化时忽略该属性。

- WhenWritingNull
如果属性是引用类型为 null，则序列化时将忽略该属性，或可为 null 的值类型为 null。

下面示例演示如何使用 `[JsonIgnore]` 属性的 `Condition` 属性

    using System.Text.Json;
    using System.Text.Json.Serialization;

    namespace JsonIgnoreAttributeExample
    {
    public class Forecast
        {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime Date { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public int TemperatureC { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Summary { get; set; }
        };

    public class Program
    {
        public static void Main()
        {
            Forecast forecast = new()
            {
                Date = default,
                Summary = null,
                TemperatureC = default
            };

            JsonSerializerOptions options = new()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
            };

            string forecastJson =
                JsonSerializer.Serialize<Forecast>(forecast,options);

            Console.WriteLine(forecastJson);
        }
    }
    }

// Produces output like the following example:
//{"TemperatureC":0}

#### 忽略所有只读属性

如果属性包含公共 `getter` 但不包含公共 `setter，`则属性为只读。 若要在序列化时忽略所有只读属性，请将其设置为`JsonSerializerOptions.IgnoreReadOnlyProperties`true

如例: 

    var options = new JsonSerializerOptions
    {
        IgnoreReadOnlyProperties = true,
        WriteIndented = true
    };

    jsonString = JsonSerializer.Serialize(weatherForecast, options);

以下示例演示要序列化的类型。 它还显示 JSON 输出：

    public class WeatherForecastWithROProperty
    {
      public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
        public int WindSpeedReadOnly { get; private set; } = 35;
    }

// {
//   "Date": "2019-08-01T00:00:00-07:00",
//   "TemperatureCelsius": 25,
//   "Summary": "Hot",
// }

`注意`此选项仅适用于属性。 若要在序列化字段时忽略只读字段，请使用`JsonSerializerOptions.IgnoreReadOnlyFields`全局设置。

#### 忽略所有 null 值属性

若要忽略所有 null 值属性，请将`DefaultIgnoreCondition`该属性设置为`WhenWritingNull`

    using System.Text.Json;
    using System.Text.Json.Serialization;

    namespace IgnoreNullOnSerialize
    {
        public class Forecast
        {
            public DateTime Date { get; set; }
            public int TemperatureC { get; set; }
            public string? Summary { get; set; }
        };

    public class Program
        {
            public static void Main()
            {
                Forecast forecast = new()
                {
                    Date = DateTime.Now,
                    Summary = null,
                    TemperatureC = default
                };

                JsonSerializerOptions options = new()
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                };

                string forecastJson =
                    JsonSerializer.Serialize<Forecast>(forecast, options);
            
                Console.WriteLine(forecastJson);
            }
        }
    }

// Produces output like the following example:
//
//{"Date":"2020-10-30T10:11:40.2359135-07:00","TemperatureC":0}

#### 忽略所有默认值属性

若要防止对值类型属性中的默认值进行序列化，请将`DefaultIgnoreCondition`该属性设置为`WhenWritingDefault`

    using System.Text.Json;
    using System.Text.Json.Serialization;

    namespace IgnoreValueDefaultOnSerialize
    {
        public class Forecast
        {
            public DateTime Date { get; set; }
            public int TemperatureC { get; set; }
            public string? Summary { get; set; }
        };

        public class Program
        {
            public static void Main()
            {
                Forecast forecast = new()
                {
                    Date = DateTime.Now,
                    Summary = null,
                    TemperatureC = default
                };

                JsonSerializerOptions options = new()
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
                };

                string forecastJson =
                    JsonSerializer.Serialize<Forecast>(forecast, options);

                Console.WriteLine(forecastJson);
            }
        }
    }

// Produces output like the following example:
//
//{ "Date":"2020-10-21T15:40:06.8920138-07:00"}


### 在序列化过程中包括字段

默认情况下，仅序列化属性，但也可以将序列化程序配置为包含字段。 使用`JsonSerializerOptions.IncludeFields`全局设置或`[JsonInclude]`属性在序列化或反序列化时包括字段，涂如栗所示
默认情况下，仅序列化属性，但也可以将序列化程序配置为包含字段。 使用`JsonSerializerOptions.IncludeFields`全局设置或[JsonInclude]```属性在序列化或反序列化时包括字段，以例所示：

    using System.Text.Json;
    using System.Text.Json.Serialization;

    namespace Fields
    {
        public class Forecast
        {
            public DateTime Date;
            public int TemperatureC;
            public string? Summary;
        }

        public class Forecast2
        {
            [JsonInclude]
            public DateTime Date;
            [JsonInclude]
            public int TemperatureC;
            [JsonInclude]
            public string? Summary;
        }

        public class Program
        {
            public static void Main()
            {
                string json = """
                    {
                        "Date":"2020-09-06T11:31:01.923395",
                        "TemperatureC":-1,
                        "Summary":"Cold"
                    }
                    """;
                Console.WriteLine($"Input JSON: {json}");

                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                };
                Forecast forecast = JsonSerializer.Deserialize<Forecast>(json, options)!;

                Console.WriteLine($"forecast.Date: {forecast.Date}");
                Console.WriteLine($"forecast.TemperatureC: {forecast.TemperatureC}");
                Console.WriteLine($"forecast.Summary: {forecast.Summary}");

                string roundTrippedJson =
                    JsonSerializer.Serialize<Forecast>(forecast, options);

                Console.WriteLine($"Output JSON: {roundTrippedJson}");

                Forecast2 forecast2 = JsonSerializer.Deserialize<Forecast2>(json)!;

                Console.WriteLine($"forecast2.Date: {forecast2.Date}");
                Console.WriteLine($"forecast2.TemperatureC: {forecast2.TemperatureC}");
                Console.WriteLine($"forecast2.Summary: {forecast2.Summary}");

                roundTrippedJson = JsonSerializer.Serialize<Forecast2>(forecast2);
                
                Console.WriteLine($"Output JSON: {roundTrippedJson}");
            }
        }
    }

// Produces output like the following example:
//
//Input JSON: { "Date":"2020-09-06T11:31:01.923395","TemperatureC":-1,"Summary":"Cold"}
//forecast.Date: 9/6/2020 11:31:01 AM
//forecast.TemperatureC: -1
    //forecast.Summary: Cold
//Output JSON: { "Date":"2020-09-06T11:31:01.923395","TemperatureC":-1,"Summary":"Cold"}
  //forecast2.Date: 9/6/2020 11:31:01 AM
//forecast2.TemperatureC: -1
//forecast2.Summary: Cold
//Output JSON: { "Date":"2020-09-06T11:31:01.923395","TemperatureC":-1,"Summary":"Cold"}

若要忽略只读字段，请使用 `JsonSerializerOptions.IgnoreReadOnlyFields` 全局设置。


## 写入 JSON 文件

使用 JSON 数据时，编写 JSON 文件是一项常见任务。 该`JsonSerializer`类提供了将对象序列化为 JSON 字符串的方法，这些字符串随后可以保存到文件中。 `File.WriteAllText`方法可用于将 JSON 字符串写入文件。
下面示例演示如何将对象序列化为 JSON 并将其保存到文件中：

    using System;
    using System.IO;
    using System.Text.Json;

    class Program
    {
          static void Main()
          {
              var customer = new BankCustomer {  };
              string jsonString = JsonSerializer.Serialize(customer);
              File.WriteAllText("customer.json", jsonString);
              Console.WriteLine("JSON file created and saved.");
          }
    }

## 自定义返序列话行为

`JsonSerializer.Deserialize`方法用于将 JavaScript 对象表示法（JSON）字符串转换回 C# 对象。
读取 JSON 文件、从 API 接收 JSON 数据或对 JSON 数据的一般处理时，将使用反序列化。``Deserialize``方法采用 JSON 字符串和要创建为输入的对象的类型，并返回该对象的实例。

    string jsonString = """{"Name":"Anette Thomsen","Age":30,"Address":"123 Main St"}""";
    var customer = JsonSerializer.Deserialize<Employee>(jsonString);

## 反序列化行为

与序列化一样，反序列化遵循一些默认行为。 反序列化 JSON 时，将应用以下行为：

- 默认情况下，属性名称匹配区分大小写。 可以指定不区分大小写。
- 序列化程序忽略非公共构造函数。
- 不支持对不可变对象或没有公共集访问器的属性进行反序列化，但默认情况下不支持。 请参阅不可变类型和记录。
- 默认情况下，枚举支持为数字。 可以反序列化字符串枚举字段。
- 默认情况下，将忽略字段。 可以包含字段。
- 默认情况下，JSON 中的注释或尾随逗号会引发异常。 可以允许注释和尾随逗号。
- 默认的最大深度为 64。

## 使用 `JsonSerializerOptions` 自定义反序列化行为

`JsonSerializerOptions`类，允许自定义方法的·JsonSerializer.Deerialize·反序列化行为。

他包含下面属性： 

- RespectRequiredConstructorParameters
：此属性指定 JSON 反序列化是否需要所有非可选构造函数参数。

- PreferredObjectCreationHandling
：此属性指定反序列化期间的首选对象创建处理行为。

通常用于自定义反序列化的其他属性包括：

- DefaultBufferSize
：此属性设置默认缓冲区大小（以字节为单位），这可以提高反序列化大型 JSON 字符串或 UTF-8 字节数组时的性能。

- AllowTrailingCommas
：此属性允许 JSON 数组和对象中的尾随逗号，这在处理可能具有尾随逗号的 JSON 数据时非常有用。

- AllowOutOfOrderMetadataProperties
：此属性消除了在反序列化 JSON 对象的开头指定 JSON 元数据属性（如`$id`和`$type`）的要求。

- NumberHandling
：此属性指定序列化或反序列化时应如何处理数字类型，这对于确保数值的准确表示非常有用。

## 反序列化所需属性

可以标记某些属性，以表示它们必须存在于 JSON 有效负载中才能成功反序列化。 同样，可以设置一个选项来指定 JSON 有效负载中存在所有非可选构造函数参数。 如果其中一个或多个必需属性不存在，则`JsonSerializer.Deserialize`方法将引发一个`JsonException`。

对于 JSON 反序列化，可通过三种方法将属性或字段标记为必须：

- 通过添加`required`修饰符。
- 通过批注它`JsonRequiredAttribute`。
- 通过修改`JsonPropertyInfo.IsRequired`协定模型的属性。

若要指定 JSON 反序列化所需的所有非可选构造函数参数，请将`JsonSerializerOptions.RespectRequiredConstructorParameters`选项设置为`true`。

从序列化程序的角度来看，C#`required`修饰符和`[JsonRequired]`属性是等效的，两者都映射到相同的元数据片段，即`JsonPropertyInfo.IsRequired`。 在大多数情况下，将使用内置的 C# 关键字。 但是，在以下情况下，应改用`JsonRequiredAttribute`:

- 如果使用 C# 以外的编程语言或 C# 的下层版本。
- 如果只想将要求应用于 JSON 反序列化。
- 如果在源生成模式下使用`System.Text.Json`序列化。 在这种情况下，如果使用所需的修饰符，则代码不会编译，因为源生成在编译时发生。

下面代码片段显示了使用`required`关键字修改的属性的示例。 此属性必须存在于 JSON 有效负载中，才能成功反序列化。

    public static void RunIt()
    {
        // The following line throws a JsonException at run time.
        Console.WriteLine(JsonSerializer.Deserialize<Person>("""{"Age": 42}"""));
    }

    public class Person
    {
        public required string Name { get; set; }
        public int Age { get; set; }
    }

也可使用`JsonRequiredAttribute`:

    public static void RunIt()
    {
        // The following line throws a JsonException at run time.
        Console.WriteLine(JsonSerializer.Deserialize<Person>("""{"Age": 42}"""));
    }

    public class Person
    {
        [JsonRequired]
        public string Name { get; set; }
        public int Age { get; set; }
    }

还可以使用`JsonPropertyInfo.IsRequired`该属性通过协定模型控制属性是否必需：

    public static void RunIt()
    {
        var options = new JsonSerializerOptions
        {
            TypeInfoResolver = new DefaultJsonTypeInfoResolver
            {
                Modifiers =
                {
                    static typeInfo =>
                    {
                        if (typeInfo.Kind != JsonTypeInfoKind.Object)
                            return;

                        foreach (JsonPropertyInfo propertyInfo in typeInfo.Properties)
                        {
                            // Strip IsRequired constraint from every property.
                            propertyInfo.IsRequired = false;
                        }
                    }
                }
            }
        };

        // Deserialization succeeds even though
        // the Name property isn't in the JSON payload.
        JsonSerializer.Deserialize<Person>("""{"Age": 42}""", options);
    }

    public class Person
    {
        public required string Name { get; set; }
        public int Age { get; set; }
    }


## 反序列化和填充初始化的属性

将 JSON 字符串反序列化为对象时，可以指定是否初始化某些属性。 这可用于确保反序列化对象具有所有必要的数据，然后才能使用它。
.NET 8 开始，可以指定在反序列化 JSON 时替换或填充 .NET 属性的首选项。
`JsonObjectCreationHandling`枚举提供对象创建处理选项：

- JsonObjectCreationHandling.Replace
：默认行为。 属性将替换为 JSON 有效负载中的值。 这与在早期版本的 .NET 中的行为相同。

- JsonObjectCreationHandling.Populate
：属性使用 JSON 有效负载中的值填充。 这意味着，如果属性已初始化，则会使用 JSON 有效负载中的值更新其值。

### 默认替换行为

System.Text.Json
反序列化程序始终创建目标类型的新实例。 但是，即使创建了一个新实例，某些属性和字段也可能已初始化为对象的构造的一部分。 请考虑以下类型：

    class A
    {
        public List<int> Numbers1 { get; } = [1, 2, 3];
        public List<int> Numbers2 { get; set; } = [1, 2, 3];
    }

创建此类的实例时，`List`两个类型属性使用三个元素（1、2 和 3）进行初始化。 如果将 JSON 反序列化为此类型，则默认行为是将属性值替换为 JSON 有效负载中的数据。

- 因此`Numbers1`，由于它是只读的（没有 setter），因此它仍然在其列表中具有值 1、2 和 3。
- 对于`Numbers2`，这是读写的，将分配一个新列表，并添加 JSON 中的值。
- 
例如，如果执行以下反序列化代码，`Numbers1`则包含值 1、2 和 3，并`Numbers2`包含值 4、5 和 6。

    var json = """{"Numbers1": [4, 5, 6], "Numbers2": [4, 5, 6]}""";
    var a = JsonSerializer.Deserialize<A>(json);

    Console.WriteLine(string.Join(", ", a.Numbers1));
    Console.WriteLine(string.Join(", ", a.Numbers2));

    // Output: 1, 2, 3
    // Output: 4, 5, 6

### 填充行为

可以更改反序列化行为来修改（填充）属性和字段，而不是替换它们：

- 对于集合类型属性，该对象将重复使用而不清除。 如果集合预填充了元素，则它们将显示在最终反序列化结果中，以及 JSON 中的值。
- 对于作为具有属性的对象的属性，其可变属性将更新为 JSON 值，但对象引用本身不会更改。
- 对于结构类型属性，有效行为是，对于其可变属性，将保留任何现有值，并添加 JSON 中的新值。 但是，与引用属性不同，对象本身不会重复使用，因为它是值类型。 而是修改结构的副本，然后重新分配给该属性。

`struct`属性。必须具有 setter;否则，在运行时引发一个`InvalidOperationException`属性。

### 如何指定

可通过多种方式指定首选项`replace`或`populate`:

- 使用`JsonObjectCreationHandlingAttribute`特性在类型或属性级别批注。 如果在类型级别设置属性并将其属性`Handling`设置为`Populate`，则行为仅适用于可能填充的属性（例如，值类型必须具有 setter）。如果希望类型范围的首选项，`Populate`但想要从该行为中排除一个或多个属性，则可以在类型级别添加属性，并在属性级别再次添加属性以替代继承的行为。 此模式显示在以下代码中。

    `// Type-level preference is Populate.
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    class B
    {
        // For this property only, use Replace behavior.
        [JsonObjectCreationHandling(JsonObjectCreationHandling.Replace)]
        public List<int> Numbers1 { get; } = [1, 2, 3];
        public List<int> Numbers2 { get; set; } = [1, 2, 3];
    }`

- 设置为`JsonSerializerOptions.PreferredObjectCreationHandling`指定全局首选项。

    var options = new JsonSerializerOptions
    {
        PreferredObjectCreationHandling = JsonObjectCreationHandling.Populate
    };

## 读取 JSON 文件

    using System;
    using System.IO;
    using System.Text.Json;

    class Program
    {
        static void Main()
        {
            string jsonString = File.ReadAllText("customer.json");
            var customer = JsonSerializer.Deserialize<BankCustomer>(jsonString);
            Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}, Address: {customer.Address}");
        }
    }

## 管理复杂对象的序列化和反序列化

使用复杂对象时，`JsonSerializerOptions`可以使用类和数据传输对象（DTO）来避免处理问题。 复杂对象通常包含嵌套结构、特殊数据类型，或需要特定配置才能有效处理序列化和反序列化。 该`JsonSerializerOptions`类提供可以自定义的各种属性来解决这些挑战。 例如，属性可用于添加自定义转换器、启用不区分大小写的属性匹配或处理 null 值。
另一方面，DTO 充当中介对象，用于简化应用程序不同层之间的数据传输，确保数据的结构和类型一致且易于管理。
通过利用`JsonSerializerOptions`和 DTO，开发人员可以实现更复杂的 JavaScript 对象表示法（JSON）数据的更可靠、更高效的序列化和反序列化，从而更轻松地处理和集成到其应用程序中。

### 使用 JsonSerializerOptions 类帮助序列化复杂对象

该`JsonSerializerOptions`是命名空间`System.Text.Json`的一部分，提供配置 JSON 序列化和反序列化行为的方法。 它允许自定义序列化过程的各个方面，例如如何处理属性、如何管理引用以及处理特殊数据类型的方式。

`JsonSerializerOptions`类在处理复杂对象时非常有用，因为它提供了处理嵌套结构、循环引用和其他序列化挑战的选项。
他包含以下属性： 

- MaxDepth：此属性设置读取或写入 JSON 时允许的最大深度。 它可以帮助防止深层嵌套对象出现问题，这些对象可能会导致堆栈溢出或性能问题。
- ReferenceHandler：此属性允许指定在序列化和反序列化期间如何处理对对象的引用。 处理循环引用或复杂对象图时，它很有用。

帮助序列化和反序列化复杂对象的另一个属性是
`Converters`。 此属性允许添加自定义转换器来处理特定类型或复杂对象。 例如，可以为包含嵌套对象或复杂属性的类创建自定义转换器。

### 使用 JsonSerializerOptions.ReferenceHandler 属性

该`ReferenceHandler`属性用于指定在序列化和反序列化期间如何处理对对象的引用。 处理可能包含循环引用或共享引用的复杂对象图时，这特别有用。

当两个或多个对象相互引用时，将发生循环引用。最后会导致堆栈溢出错误。`示例：`

    public class Person
    {
        public string Name { get; set; }
        public List<Pet> Pets { get; set; }
    }

    public class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
    }

在此示例中，  `Person`  类具有对象列表  `Pet`  ，每个  `Pet`  对象都有对其所有者（`the Person`）的引用。在序列化或反序列化对象时，这会创建循环引用。

使用默认设置序列化 `Person` 对象会导致 `JsonExceptio`n 循环引用。 若要处理此问题，可以使用 `ReferenceHandler` 类的属性`JsonSerializerOptions`。

    var options = new JsonSerializerOptions
    {
        ReferenceHandler = ReferenceHandler.Preserve,
        WriteIndented = true
    };

    var person = new Person
    {
        Name = "John",
        Pets = new List<Pet>
        {
            new Pet { Name = "Fido", Owner = null },
            new Pet { Name = "Whiskers", Owner = null }
        }
    };

    person.Pets[0].Owner = person;
    person.Pets[1].Owner = person;

    var json = JsonSerializer.Serialize(person, options);
    Console.WriteLine(json);

    /*

    OUTPUT (with WriteIndented = true):
     
    {
      "$id": "1",
      "Name": "John",
      "Pets": {
        "$id": "2",
        "$values": [
          {
            "$id": "3",
            "Name": "Fido",
            "Owner": {
              "$ref": "1"
            }
          },
          {
            "$id": "4",
            "Name": "Whiskers",
            "Owner": {
              "$ref": "1"
            }
          }
        ]
      }
    }

    */

在此示例中，该`ReferenceHandler.Preserve`选项用于处理循环引用。 序列化程序在 JSON 输出中包含一个`$id`属性来表示引用，允许它正确反序列化。
反序列化时，`ReferenceHandler.Preserve`该选项还可确保正确还原引用，从而防止创建重复的对象。

    var deserializedPerson = JsonSerializer.Deserialize<Person>(json, options);
    Console.WriteLine($"Name: {deserializedPerson.Name}");

    foreach (var pet in deserializedPerson.Pets)
    {
        Console.WriteLine($"Pet Name: {pet.Name}, Owner: {pet.Owner.Name}");
    }

    /*

    OUTPUT:
     
    Name: John
    Pet Name: Fido, Owner: John
    Pet Name: Whiskers, Owner: John

    */

在此示例中，反`Person`序列化对象与原始对象具有相同的引用，从而保留与`Person`对象之间的关系`Pet`。

### 使用数据传输对象来帮助序列化和反序列化复杂对象

在需要序列化和反序列化复杂对象的方案中，通常使用数据传输对象。
DTO 具有以下优势：

- 简化的数据结构：DTO 可以通过平展嵌套对象或删除不必要的属性来简化数据结构。 这样就可以更轻松地序列化和反序列化数据，而无需处理复杂的对象图。
- 选择性序列化：DTO 允许控制序列化输出中包含的属性。 这有助于减小序列化数据的大小并提高性能。
- 分离：DTO 将数据结构与业务逻辑分离，以便更轻松地管理和维护代码。 这种关注点的分离还使更改序列化格式更容易，而不会影响应用程序的其余部分。
- 数据协定：DTO 充当数据协定，定义序列化和反序列化的数据的结构。 这样，可以更轻松地确保应用程序的不同部分或不同应用程序之间的一致性和兼容性。
- 互作性：DTO 可以帮助确保数据结构与其他系统或服务兼容，从而更轻松地与外部 API 或服务集成。
- 版本控制：DTO 可以帮助管理数据结构的版本控制，从而能够改进数据模型，而无需中断现有客户端或服务。
- 安全性：DTO 可以通过限制内部数据结构的公开来帮助提高安全性。 通过使用 DTO，可以控制序列化和反序列化哪些属性，从而减少公开敏感信息的风险。
- 性能：DTO 可以通过减少通过网络传输的数据量来提高性能。 通过使用 DTO，只能序列化所需的属性，减少序列化数据的大小并提高性能。

#### 创建和使用 DTO 进行序列化

下面是有关如何在 C# 中创建和使用 DTO 进行序列化的分步指南：

- 定义 DTO：创建仅包含要序列化的属性和方法结果的类。
- 将原始对象映射到 DTO：创建将原始对象映射到 DTO 的方法。 此方法从原始对象中提取必要的数据并填充 DTO。
- 序列化 DTO：使用`JsonSerializer`类将 DTO 序列化为 JSON 字符串。
- 反序列化 DTO：使用`JsonSerializer`类将 JSON 字符串反序列化回 DTO。
- 将 DTO 映射回原始对象：创建将 DTO 映射回原始对象的方法。 此方法从 DTO 中提取数据并填充原始对象。

下面示例演示如何创建和使用 DTO 对复杂对象的序列化和反序列化：

    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        // Constructor to initialize the Employees list
        public Company(Employee employee)
        {
            Name = "Contoso Ltd";
            Employees = new List<Employee> { employee };
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int EmployeeId { get; set; }
        public double Salary { get; set; }
        public List<Person> Dependents { get; set; }
        public List<Person> EmergencyContacts { get; set; }

        // Constructor to initialize the lists
        public Employee()
        {
            Dependents = new List<Person>();
            EmergencyContacts = new List<Person>();
        }
    }

    public class EmployeeDTO
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }

    }

    class Program
    {
        static void Main()
        {
            // Create an Employee object
            Employee employee = new Employee
            {
                Name = "Elize Harmsen",
                Age = 35,
                Gender = "Female",
                Address = "123 Main St",
                Email = "elize@example.com",
                EmployeeId = 101,
                Salary = 75000,
                Dependents = new List<Person>
                {
                    new Person { Name = "Peter Zammit", Age = 35 }
                },
                EmergencyContacts = new List<Person>
                {
                    new Person { Name = "Anette Thomsen", Age = 40 }
                }
            };

            // Create a Company object with the Employee
            Company company = new Company(employee);

            // Map Employee to EmployeeDTO
            EmployeeDTO employeeDTO = new EmployeeDTO
            {
                Name = employee.Name,
                EmployeeId = employee.EmployeeId
            };

            // Serialize EmployeeDTO to JSON
            string json = JsonSerializer.Serialize(employeeDTO);
            Console.WriteLine("Serialized EmployeeDTO:");
            Console.WriteLine(json);

            // Deserialize JSON back to EmployeeDTO
            EmployeeDTO deserializedEmployeeDTO = JsonSerializer.Deserialize<EmployeeDTO>(json);

            // Use the deserialized object to create a new Employee object
            Employee newEmployee = new Employee
            {
                Name = deserializedEmployeeDTO.Name,
                EmployeeId = deserializedEmployeeDTO.EmployeeId
            };

            // Use the newEmployee.EmployeeId to find the original Employee object in the Company
            Employee foundEmployee = company.Employees.Find(e => e.EmployeeId == newEmployee.EmployeeId);
            if (foundEmployee != null)
            {
                Console.WriteLine("Found Employee:");
                Console.WriteLine($"Name: {foundEmployee.Name}");
                Console.WriteLine($"Age: {foundEmployee.Age}");
                Console.WriteLine($"Gender: {foundEmployee.Gender}");
                Console.WriteLine($"Email: {foundEmployee.Email}");
                Console.WriteLine($"EmployeeId: {foundEmployee.EmployeeId}");
                Console.WriteLine($"Salary: {foundEmployee.Salary}");
                Console.WriteLine($"Dependents: {string.Join(", ", foundEmployee.Dependents.Select(d => d.Name))}");
                Console.WriteLine($"Emergency Contacts: {string.Join(", ", foundEmployee.EmergencyContacts.Select(ec => ec.Name))}");
            }
            else
            {
                Console.WriteLine("Employee not found in the company.");
            }
        }
    }

在此示例中，将`EmployeeDTO`创建类来表示类的`Employee`简化版本。 该`EmployeeDTO`类仅包含序列化所需的属性。 该`Employee`类包含 DTO 中不包含的其他属性。 该`Company`类包含对象列表`Employee`。 `Main`方法演示如何创建对象`Employee`，将其`EmployeeDTO`映射到 DTO，将 DTO 序列化为 JSON，然后将其反序列化回 DTO。 最后，它演示如何使用反序列化的 DTO 查找`Employee`原始`Company`对象。
此方法允许你控制序列化过程，并避免复杂的对象图出现问题。 通过使用 DTO，可以简化数据结构，并确保序列化输出中仅包含必要的属性。

