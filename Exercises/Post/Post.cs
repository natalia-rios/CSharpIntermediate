namespace Post;

public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DatetimeCreation { get; set; }
    private int _votes;
    
    public void Upvote()
    {
        _votes++;
    }

    public void DownVote()
    {
        _votes--;
    }

    public int ShowVotes()
    {
        return _votes;
    }
}