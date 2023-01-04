namespace Post
{

    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();

            post.Description = "Description";
            post.Title = "Title";
            post.DatetimeCreation = new DateTime(2022, 1, 1);

            post.Upvote();
            post.Upvote();
            post.DownVote();

            Console.WriteLine("Title: " + post.Title);
            Console.WriteLine("Description: " + post.Description);
            Console.WriteLine("Date of creation: " + post.DatetimeCreation);
            Console.WriteLine("Number of votes: " + post.ShowVotes());  

        }
    }
}