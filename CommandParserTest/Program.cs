using CommandParserTest.Commands;
using CommandParserTest.Library;
using System;

namespace CommandParserTest.Core
{
    class Program
    {
        public static void Main(string[] args)
        {
            Item sword = new Item();

            Console.WriteLine("Hello");

            sword.CanPickUp = true;
            sword.CanDropItem = true;
            sword.PrimaryNoun = "sword";
            sword.Nouns.Add("weapon");
            sword.Nouns.Add("blade");
            sword.Adjectives.Add("sharp");
            sword.Adjectives.Add("short");

            sword.ShortName = "sharp shortsword";
            sword.Weight = 1f;

            while(true)
            {
                Console.Write("> ");
                string? input = Console.ReadLine();

                if (input == null || string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Unrecognized Command.");
                }
                else
                {
                    Parser.Instance.Parse(input);
                }
            }
        }
    }
}