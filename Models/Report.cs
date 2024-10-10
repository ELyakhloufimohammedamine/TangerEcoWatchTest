namespace TangerEcoWatchTest.Models
{
    public class Report
    {
            public int Id { get; set; }
            public required string UserName { get; set; }
            public required string Location { get; set; }
            public required string PollutionDescription { get; set; }
            public string PollutionType { get; set; }
            public string ImagePath { get; internal set; }
    }
}
