using LinqFaroShuffle;

/* 
var startingDeck = from s in Suits()
                   from r in Ranks()
                   select (Suit: s, Rank: r);
 
 
 // var stardingDeck = Suits().SelectMany(suit => Ranks().Select(rank => (Suit: suit, Rank: rank)));

// 显示生成并放入 StardingDeck 的每张卡
foreach (var card in startingDeck)
{
 Console.WriteLine(card);
}

var top = startingDeck.Take(26);
var bottom = startingDeck.Skip(26);

var shuffledDeck = top.InterleaveSequenceWith(bottom);

var times = 0;
// Re-use the shuffle variable from earlier, or you can make a new one
shuffledDeck = startingDeck;
do
{
 // Out shuffle
 
 shuffle = shuffle.Take(26)
         .LogQuery("Top Half")
        .InterleaveSequenceWith(shuffle.Skip(26)
                .LogQuery("Bottom Half"))
                        .LogQuery("Shuffle");


 // shuffledDeck = shuffledDeck.Take(26).InterleaveSequenceWith(shuffledDeck.Skip(26));
 // shuffledDeck = shuffledDeck.Skip(26).InterleaveSequenceWith(shuffledDeck.Take(26));

 // In shuffle
shuffledDeck  = shuffledDeck.Skip(26).LogQuery("Bottom Half")
             .InterleaveSequenceWith(shuffledDeck.Take(26).LogQuery("Top Half"))
                         .LogQuery("Shuffle");

 foreach (var card in shuffledDeck)
 {
  Console.WriteLine(card);
 }
 Console.WriteLine();
 times++;
} while (!startingDeck.SequenceEquals(shuffledDeck));

Console.WriteLine(times);
 


foreach (var c in shuffledDeck)
{
Console.WriteLine(c);
}
*/

var startingDeck = (from s in Suits().LogQuery("Suit Generation")
                    from r in Ranks().LogQuery("Value Generation")
                    select new { Suit = s, Rank = r })
                    .LogQuery("Starting Deck")
                    .ToArray();

foreach (var c in startingDeck)
{
 Console.WriteLine(c);
}

Console.WriteLine();

var times = 0;
var shuffle = startingDeck;

do
{
 /*
 shuffle = shuffle.Take(26)
     .LogQuery("Top Half")
     .InterleaveSequenceWith(shuffle.Skip(26).LogQuery("Bottom Half"))
     .LogQuery("Shuffle")
     .ToArray();
 */

 shuffle = shuffle.Skip(26)
     .LogQuery("Bottom Half")
     .InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half"))
     .LogQuery("Shuffle")
     .ToArray();

 foreach (var c in shuffle)
 {
  Console.WriteLine(c);
 }

 times++;
 Console.WriteLine(times);
} while (!startingDeck.SequenceEquals(shuffle));

Console.WriteLine(times);

static IEnumerable<string> Suits()
{
 yield return "clubs";
 yield return "diamonds";
 yield return "hearts";
 yield return "spades";
}

static IEnumerable<string> Ranks()
{
 yield return "two";
 yield return "three";
 yield return "four";
 yield return "five";
 yield return "six";
 yield return "seven";
 yield return "eight";
 yield return "nine";
 yield return "ten";
 yield return "jack";
 yield return "queen";
 yield return "king";
 yield return "ace";
}

