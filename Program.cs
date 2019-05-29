using System;

namespace question
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who is lil' p-tag?");
            Console.WriteLine("Choose: 1. Kendra, 2. Keith, 3. Delo");
            string answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "1":
                    myAnsw("You are correct my friend!");
                    break;
                case "2":
                    string line = myAnsw2("haha he thinks ", "...but no!");
                    Console.WriteLine(line);
                    break;
                case "3":
                    name();
                    break;
                case "4":
                    Console.WriteLine("You are Yung doodoo butter!!!");
                    break;

            }
        }

        private static void name()
        {
            Console.WriteLine("You picked Delo. You are wrong.");
            Console.WriteLine("But here are a couple of names that we can choose from");

            string[] rapName = { "lil skid marks", "yung rational", "master hershey kisses" };

            int likes = 0;

            for (int i = 0; i < rapName.Length; i++)
            {
                Console.WriteLine("Do you like {0}?", rapName[i]);
                Console.WriteLine("yes or no");
                string nod = Console.ReadLine().ToLower();

                if (nod == "yes")
                {
                    likes++;
                } else
                {
                    Console.WriteLine("Me either");
                }
            }
            Console.WriteLine(likes);
        }

        private static void myAnsw(string rightOn)
        {
            Console.WriteLine(rightOn);
        }

        private static string myAnsw2(string words1, string words2)
        {
            string haha = words1 + words2;
            return haha;
        }
    }
}

        
