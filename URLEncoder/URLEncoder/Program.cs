using System;
using System.Collections.Generic;

namespace URLEncoder
{
    class Program
    {
        static Dictionary<string, string> exchangeValue = new Dictionary<string, string>
        {
            {" ", "%20"}, {"<", "%3C"}, {">", "%3E"}, {"#", "%23"}, {"\"", "%22"},
            {";", "%3B"}, {"/", "%2F"}, {"?", "%3F"}, {":", "%3A"}, {"@", "%40"},
            {"&", "%26"}, {"=", "%3D"}, {"+", "%2B"}, {"$", "%24"}, {",", "%2C"},
            {"{", "%7B"}, {"}", "%7D"}, {"|", "%7C"}, {"\\", "%5C"}, {"^", "%5E"},
            {"[", "%5B"}, {"]", "%5D"}, {"`", "%60"}
        };

        static void Main(string[] args)
        {
            string projectName, activityName;
            Console.Write("Welcome to the URLEncoder Program!/nHere we will make a URL for you by asking you a few questions.\n");
            Console.Write("Please enter the name of the project: ");
            projectName = Console.ReadLine();

            Console.Write("Please enter the name of the activity of the project: ");
            activityName = Console.ReadLine();

            projectName = Encoding(projectName);
            activityName = Encoding(activityName);

            Console.Write("Here is your newly developed URL: ");
            Console.WriteLine("https://companyserver.com/content/" + projectName + "/files/" + activityName + "/" + activityName + "Report.pdf");
            Console.ReadLine();
        }


        static string Encoding(string name)
        {
            string encodedValue = "";
            foreach (char character in name.ToCharArray())
            {
                string strHolder = character.ToString();
                encodedValue += exchangeValue.GetValueOrDefault(strHolder, strHolder);
            }
            return encodedValue;
        }
    }
}
