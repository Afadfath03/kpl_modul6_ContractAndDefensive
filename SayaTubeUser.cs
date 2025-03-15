class SayaTubeUser{
    int id;
    List<SayaTubeVideo> uploadedVideos;
    string Username;

    public SayaTubeUser(string Username) {
        Random random = new Random();
        id = random.Next(00000, 100000);

        this.Username = Username;
        uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount() {
        int totalPlayCount = 0;
        for (int i = 0; i < uploadedVideos.Count; i++) {
            totalPlayCount += uploadedVideos[i].playCount;
        }
        return totalPlayCount;
    }

    public void AddVideo(SayaTubeVideo video) {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycounts() {
        Console.WriteLine($"User  : {Username} \n");
        for(int i = 0; i < uploadedVideos.Count; i++) {
            Console.WriteLine($"Video {i + 1} judul : {uploadedVideos[i].title}");
        }
    }
}
