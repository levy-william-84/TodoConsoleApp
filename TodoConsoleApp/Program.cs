string userInput;
List<string> todoList = new List<string>();

mainView();

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
        updateTodoItem();
        //testingUserInput(userInput);
    }
    if (userInput == "R") 
    {
        removeTodoItem();
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
        Console.WriteLine("TODO List is currently empty.\n");
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
    Console.WriteLine("[E]xit\n");

    Console.Write("Select an option: ");
}

void validateUserInput(string userInput)
{
    if (userInput != "A" && userInput != "U"
        && userInput != "R" && userInput != "E")
    {
        Console.Write("Please enter a valid choice: ");
    }
}

void addTodoItem()
{
    Console.Clear();
    string userTodoInput;
    Console.WriteLine("Please enter a task to add to your TODO list");
    userTodoInput = Console.ReadLine();
    todoList.Add(userTodoInput);
    mainView();
}

void updateTodoItem()
{
    int updateInput;
    Console.WriteLine("Please enter the task number you wish to update");
    updateInput = int.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("You have selected the following to update.");
    Console.WriteLine("{0}: {1}", updateInput, todoList[updateInput - 1]);
    Console.WriteLine("What would you like it to be updated to?");
    userInput = Console.ReadLine();
    todoList[updateInput - 1] = userInput;
    mainView();
}

void removeTodoItem()
{
    int removeInput;
    Console.WriteLine("Please enter the task number you wish to remove");
    removeInput = int.Parse(Console.ReadLine());
    todoList.Remove(todoList[removeInput - 1]);
    mainView();
}

void mainView()
{
    Console.Clear();
    header();
    showAllTodos();
    userOptionMenu();
}

//void testingUserInput(string userInput)
//{
//    Console.WriteLine("User Entered: " + userInput);
//}
