using CleanArchitecture.Data;
using CleanArchitecture.Domain;

StreamerDbContext dbContext = new();

//Obj para insertar en t streamer
Streamer streamer = new()
{
    Nombre = "Amazon Prime",
    Url = "https://amazonprime.com"
};

dbContext!.Streamers!.Add(streamer);
await dbContext.SaveChangesAsync();

var movies = new List<Video>
{
    new Video
    {
        Nombre = "Mad Max",
        //StreamerId= 1,
        StreamerId= streamer.Id
    },
    new Video
    {
        Nombre = "Batman",
        StreamerId= streamer.Id
    },
    new Video
    {
        Nombre = "Crepusculo",
        StreamerId= streamer.Id
    },
    new Video
    {
        Nombre = "Citizen Kane",
        StreamerId= streamer.Id
    }
};

await dbContext.AddRangeAsync(movies);
await dbContext.SaveChangesAsync();