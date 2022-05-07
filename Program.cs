using System;

namespace Stack_Overflow_Post
{
    class Program
    {
        

        static void Main(string[] args)
        {
            PostCreator.Interface();
            PostCreator post = new PostCreator();
            post.Implementation();

           
           
            Console.ReadKey();
        }
    }
}
