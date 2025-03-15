class SayaTubeVideo {
    public int id;
    public string title;
    public int playCount;

    public SayaTubeVideo(string title) {
        Random random = new Random();
        id = random.Next(00000, 100000);

        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount() {
        playCount++;
    }

    public void PrintVideoDetails() {
        Console.WriteLine("ID        : " + id);
        Console.WriteLine("Title     : " + title);
        Console.WriteLine("Play Count: " + playCount + "\n");
    }
}