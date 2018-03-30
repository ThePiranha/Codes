using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        private static Dictionary<string, CharacterTitleRating> _ratings = new Dictionary<string, CharacterTitleRating>();
        public string NumberOneInRatings;
        public string NumberTwoInRatings;
        public string NumberThreeInRatings;
        public int NumberOneInRatingsPoints;
        public int NumberTwoInRatingsPoints;
        public int NumberThreeInRatingsPoints;

        static void Main(string[] args)
        {

            _ratings.Add("ABC", new CharacterTitleRating
            {
                CharacterName = "ABC",
                TotalPoints = 100
            });

            _ratings.Add("DEF", new CharacterTitleRating
            {
                CharacterName = "DEF",
                TotalPoints = 200
            });

            _ratings.Add("J", new CharacterTitleRating
            {
                CharacterName = "J",
                TotalPoints = 600
            });

            _ratings.Add("K", new CharacterTitleRating
            {
                CharacterName = "K",
                TotalPoints = 700
            });

            _ratings.Add("L", new CharacterTitleRating
            {
                CharacterName = "L",
                TotalPoints = 800
            });

            _ratings.Add("O", new CharacterTitleRating
          {
              CharacterName = "O",
              TotalPoints = 900
          });

            var ratings = _ratings.Values.ToList().OrderByDescending(r => r.TotalPoints).ToList();
            foreach (var key in ratings.Take(4))
            {
                Console.WriteLine("{0}: {1}", key.TotalPoints, key.CharacterName);
            }

            Console.ReadLine();


        }
    }

    internal class CharacterTitleRating
    {
        public string CharacterName { get; set; }
        public int TotalPoints { get; set; }
    }
}