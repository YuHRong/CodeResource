# 语义化 HTML 复习

## 语义化 HTML 的重要性

- `标题元素的结构层次`：使用正确的标题元素对于保持内容的结构层次非常重要。 `h1 元素`是`最高级别的标题`， `h6元素`是`最低级别的标题`。

- `表示性 HTML 元素`：定义内容外观的元素。 `例如`：已荒废的 `center`、 `big`和 `font 元素。`

- `语义化超文本标记语言元素`：具有意义和结构的元素。例如 `header`、 `nav`、 `figure`。

## 语义化 HTML 元素

### header 元素

用于定义文档或某些部分的头部内容。 

`<`header`>`

  `<`h1`>`CatPhotoApp`<`/h1`>`

  `<`p`>`Welcome to our cat gallery.`<`/p`>`


`<`/header`>`


### main 元素

用于包含网页的主要内容。 

`<`main`>`

  `<`section`>`

<`h2`>`Cat Photos`<`/h2`>

`<`p`>`Browse adorable cat pictures.`<`/p`>`

`<`/section`>`


`<`/main`>`


### 部分元素

用于将内容划分为较小的部分。 

`<`section`>`

`<`h2`>`About Me`<`/h2`>`

`<`p`>`Hi, I am Jane Doe and I am a web developer.`<`/p`>`


`<`/section`>`


### 导航（ nav）元素

代表带有导航链接的部分。 

`<`nav``>

`<`ul`>`

`<`li`>`<`a href`=`"`#photos`"`>`Photos`<`/a`>`<`/li`>`

`<`li`>`<`a href`=`"`#videos"`>`Videos`<`/a`>`<`/li`>

`<`/ul`>`


`<`/nav`>`


### 图元素

用于包含插图和图表。 

`<`figure`>`

`<`img

`src`=`"`https://cdn.freecodecamp.org/curriculum/cat-photo-app/cats.jpg`"

`alt`=`"`Two tabby kittens sleeping together on a couch.`"`
`/>`

  <`figcaption`>`Cats` <`strong`>`hate`<`/strong`> `other cats.`<`/figcaption`>


`<`/figure`>`


### 强调（ `em`）元素：

用于标记需要强调的文本。 

`<`p`>`

  Never give up on `<`em`>`your</em> dreams.

`<`/p`>`


### 惯用文本显示元素（ `i`） 

用于突出另一种语调或语境下的词汇，比如`外语术语`、`技术术语`和`思想`。 

`<`p`>`

  There is a certain `<`i `lang`=`"`fr`"`>`je ne sais quoi`<`/i`> `in the air.`

<`/p`>

 `i`开始标签中的 `lang`属性用于指定内容的语言。本例中，`语言就是`je ne sais quoi`。` i 元素`并不表示文本是否重要`，它只是表示文本与周围的文本有某种不同。

### 强烈强调（ `strong）`元素：

用于标记非常重要的文本。 

`<`p`>`

  `<`strong`>`Warning:`<`/strong`>` This product may cause allergic reactions.

`<`/p`>`


### 引起注意（ `b`）元素 ：

用于突出显示对内容`意义不重要`但需要`引起注意的文本`。它通常用于`总结中的关键词`或`评论中的产品名称`。 

`<`p`>`

  We tested several products, including the `<`b`>`SuperSound 3000`<`/b`>` for audio quality, the `<`b`>`QuickCharge Pro`<`/b`>` for fast charging, and the `<`b`>`Ecoclean Vacuum`<`/b`>` for cleaning. The first two performed well, but the `<`b`>`Ecoclean Vacuum`<`/b`>` did not meet expectations.

`<`/p`>`


### 描述列表（ `dl`）元素

用于表示术语-描述的装备列表。

### 描述术语（ `dt`）元素

表示要定义的术语。

### 描述细节（ `dd`）元素：

表示该术语的解释。 `<`dl`>`

`<`dt`>`HTML`<`/dt`>`
  `<`dd`>`HyperText Markup Language`<`/dd`>`

  `<`dt`>`CSS`<`/dt`>`

  `<`dd`>`Cascading Style Sheets`<`/dd`>`


`<`/dl`>`


### 块级引用（ `blockquote`）元素

用于表示引用自其他来源的内容。该元素有一个 `cite`属性。 `cite`属性的值为源文件的 `URL`。 `<`blockquote cite`=`"`https://www.freecodecamp.org/news/learn-to-code-book/`"`>`

  "`Can you imagine what it would be like to be a successful developer? To have built software systems that people rely upon?`"


`<`/blockquote`>`


### 引用（ `cite`）元素

用于可视化地标记引用来源。通常用于`标记`作品的`标题`。 

`<`div`>`

`<`blockquote cite`=`"`https://www.freecodecamp.org/news/learn-to-code-book/`"`>`

`"`Can you imagine what it would be like to be a successful developer? To have built software systems that people rely upon?`"`

`<`/blockquote`>`

`<`p`>`

-Quincy Larson, `<`cite`>`How to learn to Code and Get a Developer Job [Full Book].`<`/cite`>`

`<`/p`>`


`<`/div`>`


### 内联引用（ `q`）元素

用于表示短的内联引用。 

`<`p`>`

As Quincy Larson said,

`<`q cite`=`"`https://www.freecodecamp.org/news/learn-to-code-book/`"`>

Momentum is everything.

`<`/q`>`


`<`/p`>`


### 缩写（ `abbr`）元素 

用于表示缩写或首字母缩略词。为帮助用户理解缩写或首字母缩略词的含义，可以利用 `title`属性显示其完整形式，即人类可预见的描述。 

`<`p`>`

`<`abbr `title`=`"`HyperText Markup Language`"`>`HTML`<`/abbr`> `is the foundation of the web.`

`<`/p`>`


### 联系地址（ `address`）元素

用于表示联系信息。

### （日期）时间（ `time`）元素

用于表示日期或时间。 `datetime` 属性用于将日期和时间转换为机器格式。 

`<`p`>`

The reservations are for the `<`time `datetime`=`"`20:00`"`>`20:00` <`/time`>


`<`/p`>`


### ISO `8601` 日期（ `datetime`）属性

用于以`机器`区别格式表示`日期`和`时间`。标准格式是 `YYYY`-`MM`-`DD`T`hh`:`mm`:`ss`，其中大写 `T`用于分隔日期和时间。

### 上标（ sup）元素

用于表示上标文本。 `sup` 元素的常见示例包括`指数`、`上位字母`和`序数词`。 

`<`p`>`

2`<`sup`>`2`<`/sup`>` (`2` squared`)` is `4`.

`<`/p`>`


### 下标（ `sub`）元素 

用于表示下标文本。下标元素的常见示例包括`化学式`、`脚注`和`标记下标`。 

`<`p`>`

CO`<`sub`>`2`<`/sub`>`


`<`/p`>`


### 内联代码（ `code`）元素

用于表示一段代码。

### 预重建文本（ `pre`）元素

用于表示预先重建的文本。 

`<`pre`>`

`<`code`>`

`body` {

`color:` red`;`

`}`

`<`/code`>`


`<`/pre`>`


### 文本非注释（ `u`）元素 

用于表示一段内联文本，该文本以表明其具有非文本注释的方式呈现。 

`<`p`>`

  You can use the unarticulated annotation element to highlight

`<`u`>`inccccort`<`/u`>` <`u`>`spling`<`/u`> `<`u`>`issses`<`/u`>.`

`<`/p`>`


### Ruby 注释（ `ruby`）元素 

用于注释标注发音或说明解释的文本。示例示例是东亚文字注音排版。

### Ruby 回退（ `rp`）元素

仪表不支持显示 `ruby`​​ 注释的浏览器的回退显示。

### Ruby 文本（ `rt`）元素 

用于表示 `ruby`​​ 注释的文本。通常用于东亚排版中的发音或翻译细节。 

`<`ruby`>`

明日 `<`rp`>`(`<`rp`>`<`rt`>`Ashita`<`/rt`>`<`rp`>`)`<`/rp`>`


</ruby>


### 删除线（ `s`）要素

用于表示不再准确或相关的内容。 

`<`p`>`

`<`s`>`Tomorrow's hike will be meeting at noon.`<`/s`>`


`<`/p`>`


`<`p`>`

  Due to unforeseen weather conditions, the hike has been canceled.


</p>


### 内部链接

用于通过在 `a`元素上使用 `href`=`"`#id`"`并为目标元素提供相同的 `id` 链接页面的另一个部分。这通常用于`跳过链接`、`目录`或`具有多个部分`的`长页面`。 

`<`a `href`=`"`#about-section`"`>`Go to About Section`<`/a`>




`<`section `id`=`"`about-section`"`>

`<`h2`>`About`<`/h2`>`

`<`p`>`This is the about section of the page.`<`/p`>`


`<`/section`>`