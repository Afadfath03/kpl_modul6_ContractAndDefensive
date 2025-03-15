class Program {
    static void Main(string[] args) {
        SayaTubeUser UserAfad = new SayaTubeUser("Afad");
        
        UserAfad.AddVideo(new SayaTubeVideo("Review Film 20th Century Boys oleh Afad"));
        UserAfad.AddVideo(new SayaTubeVideo("Review Film VHS oleh Afad"));
        UserAfad.AddVideo(new SayaTubeVideo("Review Film The Cabin in the Woods oleh Afad"));
        UserAfad.AddVideo(new SayaTubeVideo("Review Film 12 Angry Men oleh Afad"));
        UserAfad.AddVideo(new SayaTubeVideo("Review Film Predestination oleh Afad"));
        UserAfad.AddVideo(new SayaTubeVideo("Review Film Hereditary oleh Afad"));
        UserAfad.AddVideo(new SayaTubeVideo("Review Film Source Code oleh Afad"));
        UserAfad.AddVideo(new SayaTubeVideo("Review Film The Da Vinci Code oleh Afad"));
        UserAfad.AddVideo(new SayaTubeVideo("Review Film The Wandering Earth oleh Afad"));
        UserAfad.AddVideo(new SayaTubeVideo("Review Film Incantation oleh Afad"));


        UserAfad.PrintAllVideoPlaycounts();
    }
}