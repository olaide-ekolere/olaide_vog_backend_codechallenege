using System;
using System.Collections.Generic;
namespace VogCodeChallenge.API.ConsoleApp
{
    public class QuestionClass
    {
        static List<string> NamesList = new List<string>() {
            "Jimmy",
            "Jeff"
        };

        public static void TestQuestion()
        {
            foreach(string Name in NamesList)
            {
                Console.WriteLine(Name);
            }
            /*
            using(var enumator = NamesList.GetEnumerator())
            {
                while (enumator.MoveNext())
                {
                    Console.WriteLine(enumator.Current);
                }
            }
            */
        }
    }
}
