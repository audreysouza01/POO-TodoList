using Microsoft.AspNetCore.Mvc;

public class TodoController : Controller
{
    // http://localhost:5177/todo/getnome
    public string GetNome()
    {
        return "Audrey Souza";
    }
}