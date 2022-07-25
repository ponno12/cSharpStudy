namespace Practice.Fundamentals
{

    public class LinqExample
    {
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
        // Program.cs
        public static void Linq()
        {
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            // 전부 출력 
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
            //한번 섴기
            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);

            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }
            // 한번 순환할때가지 섴기
            var times = 0;
            // We can re-use the shuffle variable from earlier, or you can make a new one
            //var shuffle = startingDeck;
            do
            {
                shuffle = shuffle.Take(26).InterleaveSequenceWith(shuffle.Skip(26));

                foreach (var card in shuffle)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine();
                times++;

            } while (!startingDeck.SequenceEquals(shuffle));

            Console.WriteLine(times);


            // Program.cs

            /*var startingDeck = (from s in Suits().LogQuery("Suit Generation")
                                from r in Ranks().LogQuery("Rank Generation")
                                select new { Suit = s, Rank = r }).LogQuery("Starting Deck");
*/
            foreach (var c in startingDeck)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
            //var times = 0;
            //var shuffle = startingDeck;

            do
            {
                // Out shuffle

                shuffle = shuffle.Take(26)
                    .LogQuery("Top Half")
                    .InterleaveSequenceWith(shuffle.Skip(26)
                    .LogQuery("Bottom Half"))
                    .LogQuery("Shuffle");


                // In shuffle
                shuffle = shuffle.Skip(26).LogQuery("Bottom Half")
                        .InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half"))
                        .LogQuery("Shuffle");

                foreach (var c in shuffle)
                {
                    Console.WriteLine(c);
                }

                times++;
                Console.WriteLine(times);
            } while (!startingDeck.SequenceEquals(shuffle));

            Console.WriteLine(times);

        }
    }

}
