namespace Commerce.Website.Settings {

    public class AppSettings 
    {
        public ConnectionStrings ConnectionStrings {get; set;}
    }

    public class ConnectionStrings 
    {
        public string MongoDb {get; set;}
    }
}