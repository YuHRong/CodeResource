HTML 复习
复习以下概念，为即将到来的预备考试做好准备。
重试    错误原因
HTML基础
•  HTML 的作用：HTML（超文本标记）是网页结构的基础，用于定义网页的元素。
•  超文本标记语言元素 ：用于表现页面上的内容。大多数由一个起始标签和一个结束标签组成（例如， <h1></h1>、 <p></p>）。
•  HTML结构：HTML由 head和 body组成，分别用于组织元数据、样式和内容。
•  常见的超文本标记语言元素：标题（ <h1>-  <h6>）、段落（ <p> ）和 div 容器（ <div>）。
•  div元素： div 元素是一个通用的 HTML 元素，没有语义意义。它被用来容纳其他 HTML 元素的通用容器。
•  空元素：没有闭合标签（例如， <img>）。
•  属性：用于为元素添加元数据和行为。
来源和分组
•  ID：元素的唯一标识符。
•  Class：用于将物品分组，以便进行样式或行为控制。
特殊字符和链接
•  超文本标记语言实体：使用特殊字符如 &amp;和 &lt;。
•  link元素：用于链接外部样式表。
•  script元素：用于嵌入外部JavaScript文件。
模板和编码
•  HTML 模板：网页的基本结构，包括 DOCTYPE、 html、 head和 body 元素。它应该作为 HTML 文档的起点。
•  UTF-8显示字符编码：确保通用字符。
SEO 和社交分享
•  元标签（ description）：为网页提供简短描述并影响SEO。
•  Open Graph标签：增强社交媒体分享效果。
媒体元素和优化
•  替换元素：嵌入式内容（例如：图片、iframe）。
•  媒体优化：提升媒体性能的技术。
•  图像格式与许可：理解使用权限和图像类型。
•  SVG：可缩放矢量形，保证清晰的视觉效果。
多媒体集成
•  HTML音频与视频元素：用于多媒体多媒体内容。
•  使用 <iframe>进行嵌入：集成外部视频内容。
路径和链接行为
•  target属性类型：控制链接行为。
•  绝对路径 vs 相对路径：目录导航。
•  路径语法：理解用于文件导航的 /、 ./、 ../。
•  链接状态：管理不同的链接交互（悬浮、触发）。
•  内部链接：通过在 a元素上使用 href="#id"并为目标元素配备相同的 id ，链接到页面的另一个部分。
语义化 HTML 的重要性
•  标题元素的结构层次：使用正确的标题元素对于保持内容的结构层次非常重要。 h1 元素是最高级别的标题， h6元素是最低级别的标题。
•  表现型超文本标记语言元素：定义内容外观的元素，例如废弃的 center、 big和 font元素。
•  语义化 HTML 元素：为内容结构提供有意义的元素。 例如：
•  <header>：表现介绍性内容。
•  <nav>：包含导航 链接。
•  <article>：表现独立内容。
•  <aside>：用于侧边栏或相关内容。
•  <section>：在文档中包相关内容。
•  <footer>：定义一个部分或文档的页脚。
语义化 HTML 元素
•  强调（ em）元素：用于标记需要强调的文本。
•  惯用文本显示元素（ i） ：用于突出另一种语调或语境下的词汇，比如外语术语、技术术语和思想。
•  强烈强调（ strong）元素：用于标记非常重要的文本。
•  引起注意（ b）要素：用于突出显示对内容意义不重要但需要引起注意的文本。
•  描述列表（ dl）元素：用于表示术语-描述的装备列表。
•  描述术语（ dt）元素：表示要定义的术语。
•  描述细节（ dd）元素：表示该术语的解释。
•  块级引用（ blockquote）元素：用于表示引用自其他来源的内容。
•  内联引用（ q）元素：用于表示短的内联引用。
•  缩写（ abbr）元素：用于表示缩写或首字母缩略词。
•  联系地址（ address）元素：用于表示联系信息。
•  （日期）时间（ time）元素：用于表示日期或时间。
•  上标（ sup）元素：用于表示上标文本。
•  下标（ sub）元素：用于表示下标文本。
•  内联代码（ code）元素：用于表示一段代码。
•  文本非注释（ u）元素 ：用于表示一段内联文本，该文本以表明其具有非文本注释的方式呈现。
•  Ruby 注释（ ruby）元素：表示 ruby​​ 注释文本。
•  删除线（ s）元素：用于表示不再准确或相关的内容。
HTML 表单元素和属性
表单
•  form 元素：用于创建供用户输入的 HTML 表单。
•  常见输入类型：
•  text、 email、 password、 radio、 checkbox、 number、 date。
•  action 属性：用于指定发送表单数据的 URL。
•  method 属性：用于指定发送表单数据时使用的 HTTP 方法。 最常见的方法是  GET 和  POST。 <form method="value-goes-here" action="url-goes-here">

  <!-- inputs go inside here -->


</form>


•  input 元素：用于创建用户输入字段。
•  type 属性：用于指定输入字段的类型，例如  text、 email、 number、 radio、 checkbox。
•  placeholder 属性：用于向用户显示提示，告诉他们在输入框中输入什么内容。
•  value 属性：用于指定输入值。 如果输入具有  button 类型， value  属性可用于设置按钮文本。
•  name 属性 ：用于为输入字段指定名称，在提交表单数据时作为键。 对于单选按钮，赋予它们相同的  name可将它们组合在一起，因此一次只能选择组中的一个选项。
•  size 属性：用于定义用户在输入时应显示的字符数。
•  min 属性：可与  number 等输入类型一起使用，指定输入字段中允许的最小值。
•  max 属性：可与  number 等输入类型一起使用，指定输入字段中允许的最大值。
•  minlength 属性：用于指定输入字段所需的最少字符数。
•  maxlength 属性：用于指定输入字段中允许的最大字符数。
•  required 属性：用于指定在提交表单前必须填写输入字段。
•  disabled 属性：用于指定禁用某个输入框。
•  readonly 属性：用于指定输入字段为只读。 <!-- Text input -->


<input  
  
type="text"

  id="name"

  name="name"

  placeholder="e.g. Quincy Larson"

  size="20"

  minlength="5"

  maxlength="30"

  required


/>




<!-- Number input -->


<input  
  
type="number"

  id="quantity"

  name="quantity"

  min="2"

  max="10"

  disabled


/>




<!-- Button -->


<input type="button" value="Show Alert" />


•  label 属性：用于为输入字段创建标签。
•  for 属性：用于指定标签所针对的输入字段。
•  隐式关联：通过将输入字段包装在  label 元素内，可以将输入与标签关联起来。 <form action="">

  <label>

    Full Name:

    <input type="text" />

  </label>


</form>


•  显示关联：输入可通过使用  label 元素上的  for 属性与标签关联。 <form action="">

  <label for="email">Email Address: </label>

  <input type="email" id="email" />


</form>


•  button 元素：用于创建可点击的按钮。按钮还可以有一个  type  属性，用于控件按钮激活时的行为，例如  submit、 reset、 button。 <button type="button">Show Form</button>


<button type="submit">Submit Form</button>


<button type="reset">Reset Form</button>


•  fieldset 元素：用于将相关输入归类在一起。
•  legend 元素：用于添加说明输入组的标题。 <!-- Radio group -->


<fieldset>

  <legend>Was this your first time at our hotel?</legend>



  <input id="yes-option" type="radio" name="hotel-stay" value="yes" />

  <label for="yes-option">Yes</label>



  <input id="no-option" type="radio" name="hotel-stay" value="no" />

  <label for="no-option">No</label>


</fieldset>




<!-- Checkbox group -->


<fieldset>

  <legend>

    Why did you choose to stay at our hotel? (Check all that apply)

  </legend>



  <input type="checkbox" id="location" name="location" value="location" />

  <label for="location">Location</label>



  <input type="checkbox" id="price" name="price" value="price" />

  <label for="price">Price</label>


</fieldset>


•  焦点状态：指用户点击或选中输入字段后，字段处于激活状态。
使用 HTML 表格元素和属性
•  表格元素：用于创建 HTML 表格。
•  表头 ( thead) 元素: 用来分组HTML表中的标题内容。
•  表格行（ tr）元素：用于在 HTML 表格中创建一行。
•  表头单元格（ th）元素：用于在 HTML 表格中创建表头单元格。
•  表体（ tbody）元素：用于在 HTML 表格中对正文内容进行分组。
•  表格数据单元格（ td）元素：用于在 HTML 表格中创建数据单元格。
•  表脚（ tfoot）元素：用于在 HTML 表格中对表脚内容进行分组。
•  caption 元素：用于为 HTML 表格添加标题。
•  colspan元素：用于指定表格单元格跨列数。 <table>

  <caption>Exam Grades</caption>



  <thead>

    <tr>

      <th>Last Name</th>

      <th>First Name</th>

      <th>Grade</th>

    </tr>

  </thead>



  <tbody>

    <tr>

      <td>Davis</td>

      <td>Alex</td>

      <td>54</td>

    </tr>



    <tr>

      <td>Doe</td>

      <td>Samantha</td>

      <td>92</td>

    </tr>



    <tr>

      <td>Rodriguez</td>

      <td>Marcus</td>

      <td>88</td>

    </tr>

  </tbody>



  <tfoot>

    <tr>

      <td colspan="2">Average Grade</td>

      <td>78</td>

    </tr>

  </tfoot>


</table>


HTML 工具
•  HTML 校验器：一种检查 HTML 代码语法以确保其有效性的工具。
•  DOM 检查器：一种可以检查和修改网页 HTML 结构的工具。
•  开发者工具 ：一套直接内置在浏览器中的网络开发工具，可帮助你调试、配置和分析网页。
无障碍简介
•  网页内容无障碍指南 ：网页内容无障碍指南（WCAG）是一组用于使网页内容对残障人士更加可访问的指南。
WCAG 的四大原则是 POUR，即可感知 (Perceivable)、可操作 (Operable)、可理解 (Understandable) 和健壮性 (Robust)。
无障碍辅助技术
•  屏幕阅读器 ：能朗读计算机屏幕内容的软件程序。 盲人或视力障碍者可通过它来访问网页。
•  大号文本或盲文键盘：供视力障碍者使用，以便访问网页。
•  屏幕放大器：放大计算机屏幕内容的软件程序。 低视力用户可借助它来访问网页。
•  替代指向设备：供行动障碍用户访问网页的设备。 这包括操纵杆、轨迹球和触控板。
•  语音识别：供行动障碍用户使用。 允许用户通过语音来控制计算机。
无障碍审计工具
•  常见的无障碍工具 ：Google Lighthouse、Wave、IBM Equal Accessibility Checker，以及 axe DevTools 是一些常见的网页无障碍审计工具。
无障碍最佳实践
•  正确的标题层级结构 ：你应使用正确的标题层级来创建内容的逻辑结构。 这有助于辅助技术理解网页内容。
•  表格无法：使用表格时，你应该使用 th元素定义表头单元格，使用 td 元素定义数据单元格。这有助于辅助技术理解表格的结构。
•  输入与标签关联的重要性：您应使用 label 元素将标签与表单输入相关联。这有助于辅助技术理解输入的用途。
•  良好的 alt文本重要性：您应该使用 alt 属性为图像提供文本替代内容。这有助于辅助技术理解图像内容。
•  良好的链接文本的重要性 ：你应该使用描述性的链接文本，以帮助用户理解链接的用途。
•  音频视频内容的最佳实践 ：您应该为音频和视频内容提供说明和注释，以便听力障碍用户访问。您还应该为视频内容提供音频描述，以便视力障碍用户访问。
•  tabindex属性 ：用于使元素可聚焦，并定义使用键盘导航时的相对顺序。重要的是界面要使用大于 0 的 tabindex值。相反，你应该使用值 0 或 -1。
•  accesskey属性 ：用于为元素定义键盘快捷键。这可以帮助操作障碍用户更轻松地导航网站。
WAI-ARIA、角色与属性
•  WAI-ARIA ：代表网络无障碍倡议 - 无障碍互联网应用。它是一组可以添加到 HTML 元素上的属性，用于改进无障碍性。它向辅助技术提供了关于内容用途和结构的附加信息。
•  ARIA角色 ：一组预定义的角色，可以添加到HTML元素上来定义其用途。这有助于辅助技术理解网页内容。例如 role="tab"、 role="menu"和 role="alert"。
•  aria-label和 aria-labelledby属性 ：这些属性用于定义一个程序化（或可访问的）名称，帮助辅助技术（例如屏幕阅读器）理解该元素的用途。当元素的视觉标签经常是图像或符号文本时，它们被使用。 aria-label 允许您直接在属性中定义名称，并 aria-labelledby允许您在页面上引用现有的文本。
•  aria-hidden属性 ：用于向屏幕阅读器等辅助技术元素。例如，这可用于隐藏不提供任何有意义内容的装饰图片。
•  aria-describedby属性 ：通过关联另一个包含附加信息的元素，为元素提供更多信息。这有助于辅助技术理解元素的目的