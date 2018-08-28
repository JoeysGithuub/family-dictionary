using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

                 myFamily.Add("Sister", new Dictionary<string, string>(){ 
                {"name", "Sasha"},
                {"age", "30"}
            });
                 myFamily.Add("Mother", new Dictionary<string, string>(){ 
                {"name", "Shawna"},
                {"age", "47"}
            });
                 myFamily.Add("Father", new Dictionary<string, string>(){ 
                {"name", "Allan"},
                {"age", "52"}
            });
                 myFamily.Add("Dog", new Dictionary<string, string>(){ 
                {"name", "Oliver"},
                {"age", "4"}
            });
             foreach (var familyMember in myFamily)
            {
                Console.WriteLine($"My {familyMember.Key}'s name is {familyMember.Value["name"]} and is {familyMember.Value["age"]}");
            }
        }
    }
}
