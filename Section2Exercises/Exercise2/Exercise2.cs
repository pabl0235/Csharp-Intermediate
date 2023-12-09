using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2Exercises.Exercise2
{
    class Exercise2
    {
        /*
             *Exercise 2: Design a StackOverflow Post
                Design a class called Post. This class models a StackOverflow post. It should have properties 
                for title, description and the date/time it was created. We should be able to up-vote or down-vote 
                a post. We should also be able to see the current vote value. In the main method, create a post, 
                up-vote and down-vote it a few times and then display the the current vote value. 
                In this exercise, you will learn that a StackOverflow post should provide methods for up-voting 
                and down-voting. You should not give the ability to set the Vote property from the outside, 
                because otherwise, you may accidentally change the votes of a class to 0 or to a random 
                number. And this is how we create bugs in our programs. The class should always protect its 
                state and hide its implementation detail. 
                Educational tip: The aim of this exercise is to help you understand that classes should 
                encapsulate data AND behaviour around that data. Many developers (even those with years of 
                experience) tend to create classes that are purely data containers, and other classes that are 
                purely behaviour (methods) providers. This is not object-oriented programming. This is 
                procedural programming. Such programs are very fragile. Making a change breaks many parts 
                of the code. 
        */
        public static void Execute()
        {
            var input = "";
            Console.WriteLine("Type 'Post' to create a post; 'title' to read title; 'description', to read the description;");
            Console.WriteLine("Type 'u' to up-vote; 'd', to down-vote; 'c', for displaying current value; 'exit' exit, lol.");
            var post = new Post();
            while (input != "exit")
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "Post":
                        Console.WriteLine("Create post.");
                        post = CreatePost();
                        break;
                    case "title":
                        Console.WriteLine("Post's title: {0}", post.Title);
                        break;
                    case "description":
                        Console.WriteLine("Post's description: {0}", post.Description);
                        break;
                    case "u":
                        Console.WriteLine("up-vote.");
                        post.UpVote();
                        break;
                    case "d":
                        Console.WriteLine("down-vote.");
                        post.DownVote();
                        break;
                    case "c":
                        Console.WriteLine("Current vote value: {0}", post.VoteValue);
                        break;
                    case "exit":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("Unrecognized command.");
                        break;
                }
            }
        }

        private static Post CreatePost()
        {
            Console.WriteLine("Write the title:");
            var title = Console.ReadLine();
            Console.WriteLine("Write the description:");
            var description = Console.ReadLine();
            return new Post(title, description);
        }
    }
}
