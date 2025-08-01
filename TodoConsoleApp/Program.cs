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
        //addTodoItem();
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

void validateUserInput(string userInput)
{
    if (userInput != "A" && userInput != "U"
        && userInput != "R" && userInput != "E")
    {
        Console.WriteLine("Please enter a valid choice");
    }
}

//void testingUserInput(string userInput)
//{
//    Console.WriteLine("User Entered: " + userInput);
//}
