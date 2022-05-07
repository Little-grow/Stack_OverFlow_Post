using System;
namespace Stack_Overflow_Post
{
    class PostCreator
    {

        private int i = 0;
        Post _newPost = new Post();

        public static void Interface()
        {
            Console.WriteLine("*******  Hello to StackOverFlow  ********");
            Console.WriteLine("\n ");
            Console.WriteLine("create post ...");
            Console.WriteLine("press 1 to add title ");
            Console.WriteLine("press 2 to add description ");
            Console.WriteLine("press 3 to display the post");
            Console.WriteLine("\nto give your imprssion about the post press 4 \nenter up for upvoting down for downvoting");
            Console.WriteLine("press 5 to create another post");
          
        }


        private string PostTitle()
        {
            Console.WriteLine("Enter the title");
            string title = Console.ReadLine();
            _newPost.Title = title;
            return title;
        }

        private string PostDescription()
        {
            Console.WriteLine("Enter the description ");
            string description = Console.ReadLine();
            _newPost.Description = description;
            return description;
        }


        private void UpVote() => ++_newPost.UpVote;
        private void DownVote() => ++_newPost.DownVote;
            


        private void Display()
        {
            Console.WriteLine($"The post \n Title :  { _newPost.Title} \n Descrption : {_newPost.Description} \n \n Creation date : {_newPost.CreationTime} .....");
            Console.WriteLine($"\n The Upvotes :{_newPost.UpVote} .......... The DownVotes : {_newPost.DownVote}");
        }

        private void Voting()
        {
            Console.WriteLine("Enter your vote");
            string vote = Console.ReadLine();

            switch (vote)
            {
                case "up":
                    UpVote();
                    break;
                case "UP":
                    UpVote();
                    break;
                case "Up":
                    UpVote();
                    break;
                case "down":
                    DownVote();
                    break;
                case "Down":
                    DownVote();
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Input . Try again");
                        vote = Console.ReadLine();   
                    }

                    break;
            }
            Console.WriteLine("Thanks for your voting ");
            Console.WriteLine("you have now 2 choices either voting again (4) ,  creating another post (5)");

        }
        private void InvalidInput()
        {
            Console.WriteLine("Invalid input.Try again");
            i = 0;
        }

        private void CreatingAnotherPost()
        {
            i = 0;
            Console.WriteLine("You are about to  creat a new post");
            _newPost.UpVote = 0;
            _newPost.DownVote = 0;
        }

        public void Implementation()
        {
            while (true)
            {
                if (i == 0)
                {
                    i = int.Parse(Console.ReadLine());
                    if (!(i == 1))
                    {
                        InvalidInput();
                        i = 0;
                    }
                    else
                     PostTitle();

                }

                if (i == 1)
                { 
                    i = int.Parse(Console.ReadLine());
                    if (!(i == 2))
                    {
                        InvalidInput();
                        i = 1;
                    }
                    else
                        PostDescription();
                }

                if (i == 2)
                {
                    i = int.Parse(Console.ReadLine());
                    if (!(i == 3 || i == 5))
                    {
                        InvalidInput();
                        i = 2;
                    }
                    else if (i == 3)
                        Display();
                    else if (i == 5)
                        CreatingAnotherPost();

                }

                if (i == 3)
                {
                    i = int.Parse(Console.ReadLine());
                    if (!(i == 5 || i == 4 || i==3))
                    {
                        InvalidInput();
                        i = 3;
                    }
                    else if (i == 3)
                    {
                        Display();   // display again
                    }
                    else if (i == 5)
                        CreatingAnotherPost();
                    else if (i == 4)
                    {
                        Voting();
                         i = 3;    //no voting before display
                    }
                    
                }

            }

        }



        }
    }
