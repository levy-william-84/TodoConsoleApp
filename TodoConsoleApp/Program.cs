string userInput;
List<string> todoList = new List<string>();

header();
showAllTodos();
userOptionMenu();

do
{
    userInput = Console.ReadLine().ToUpper();

    validateUserInput(userInput);

    if (userInput == "A")
    {
        addTodoItem();
        //testingUserInput(userInput);
    }
    if (userInput == "U")
    {
        //UpdateTodoItem();
        //testingUserInput(userInput);
    }
    if (userInput == "R") 
    {
        //RemoveTodoItem();
        //testingUserInput(userInput);
    }

}
while (userInput != "E");

Console.WriteLine("Work completed. Press any key to close the app.");
Console.ReadKey();

void header()
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?\n");
}

void showAllTodos()
{
    int count = 1;

    if (todoList.Count == 0)
    {
        Console.WriteLine("TODO List is empty.\n");
    }
    else
    {
        foreach (var item in todoList)
        {
            Console.WriteLine($"{count}: " + item);
            count++;
        }
    }
    Console.WriteLine("\n");
}

void userOptionMenu()
{
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[U]pdate a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

void validateUserInput(string userInput)
{
    if (userInput != "A" && userInput != "U"
        && userInput != "R" && userInput != "E")
    {
        Console.WriteLine("Please enter a valid choice");
    }
}

void addTodoItem()
{
    Console.Clear();
    string userTodoInput;
    Console.WriteLine("Please enter a task to add to your TODO list");
    userTodoInput = Console.ReadLine();
    todoList.Add(userTodoInput);
    Console.WriteLine("Press any key to return to the main window");
    Console.ReadKey();
    Console.Clear();
    header();
    showAllTodos();
    userOptionMenu();
}

//void testingUserInput(string userInput)
//{
//    Console.WriteLine("User Entered: " + userInput);
//}
