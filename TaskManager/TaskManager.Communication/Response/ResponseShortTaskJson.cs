namespace TaskManager.Communication.Response
{
    public class ResponseShortTaskJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime LimitDate { get; set; }

    }
}
