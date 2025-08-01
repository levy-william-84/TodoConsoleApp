string userInput;
List<string> todoList = new List<string>();

header();
showAllTodos();
userOptionMenu();



void header()
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?\n");
}

void showAllTodos()
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("TODO List is empty.\n");
    }
    else
    {
        Console.WriteLine("This will display all todos");
    }

}

void userOptionMenu()
{
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[U]pdate a TODOs");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

Console.ReadKey();
