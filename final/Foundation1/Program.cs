class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Funny Cats", "CatLover123", 120);
        v1.AddComment(new Comment("Alice", "So cute!"));
        v1.AddComment(new Comment("Bob", "LOL"));
        v1.AddComment(new Comment("Charlie", "I want one!"));
        videos.Add(v1);

        Video v2 = new Video("Travel Vlog", "WanderlustMike", 300);
        v2.AddComment(new Comment("Dave", "Nice views!"));
        v2.AddComment(new Comment("Emma", "Where is this?"));
        v2.AddComment(new Comment("Frank", "I want to go there!"));
        videos.Add(v2);

        Video v3 = new Video("DIY Project", "HandySam", 240);
        v3.AddComment(new Comment("Gina", "So helpful!"));
        v3.AddComment(new Comment("Harry", "Mine turned out great!"));
        v3.AddComment(new Comment("Isla", "Can you do another one?"));
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }
    }
}