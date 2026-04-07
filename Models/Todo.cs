public class Todo
{
    public string Id { get; set; }

    public string Description { get; set; }

    public bool Done { get; set; }


    public Todo(string id, string description)
    {
        Id = id;
        Description = description;
        Done = false;
    }
}