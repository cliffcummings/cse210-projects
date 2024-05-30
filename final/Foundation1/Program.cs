using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        StoreVideos();
        StoreComments();
        DisplayVideos();

        void AddVideo (string title, string author, int length)
        {
            Video vid = new Video(title, author, length);
            _videos.Add(vid);
        }

        void AddComment (int videoNumber, string name, string text)
        {
            Comment cmt = new Comment(name, text);
            _videos[videoNumber].AddComment(name, text);
        }

        void StoreVideos()
        {
            AddVideo("Talented Cat", "Cliff Cummings", 35);
            AddVideo("Web cute kitten", "Joe Smith", 45);
            AddVideo("Dog treats", "Jamie Cummings", 25);
            AddVideo("New kitten", "Lindsay Passmore", 60);
        }

        void StoreComments()
        {
            AddComment(0, "Dude1", "Wow-zers!");
            AddComment(0, "CatLover", "How pretty!");
            AddComment(0, "Athlete", "Love the way the cat jumps!");
            AddComment(0, "Dudette", "Look at that fur-ball jump!");

            AddComment(1, "CatLover", "I'm back!");
            AddComment(1, "CatLover", "Aww! I want that kitten!");
            AddComment(1, "Jane", "She is such a cute kitten!");
            AddComment(1, "Johnny", "Kittens sure are cute!");

            AddComment(2, "Dogger1", "Did your dog snatch the treat from its nose??");
            AddComment(2, "Phil", "I want to see that again in slow motion!");
            AddComment(2, "Betty", "Was the other dog trying to get the treat from dog #1's nose?");
            AddComment(2, "Goofy-Haws", "I want those dogs!");
            AddComment(2, "Michele", "Kara says Pawpy!");
            
            AddComment(3, "Gail", "That is one cute kitten!");
            AddComment(3, "Brittany", "Kind of looks like my cat, Midge!");
            AddComment(3, "Cliff", "Why is it named Cali?");
            AddComment(3, "Kara", "Kitty-Cali!");
        }

        void DisplayVideos()
        {
            foreach (Video vid in _videos)
            {
                vid.DisplayVideoInfo();
            }
            Console.WriteLine("\n");
        }
    }
}