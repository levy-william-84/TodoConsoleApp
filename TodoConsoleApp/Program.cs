string userInput;
List<string> todoList = new List<string>();

MainView();

do
{
    userInput = Console.ReadLine().ToUpper();

    ValidateUserInput(userInput);

    if (userInput == "A")
    {
        AddTodoItem();
        //testingUserInput(userInput);
    }
    if (userInput == "U")
    {
        UpdateTodoItem();
        //testingUserInput(userInput);
    }
    if (userInput == "R") 
    {
        RemoveTodoItem();
        //testingUserInput(userInput);
    }

}
while (userInput != "E");

Console.WriteLine("Work completed. Press any key to close the app.");
Console.ReadKey();

#region View
void Header()
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?\n");
}

void ShowAllTodos()
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

void UserOptionMenu()
{
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[U]pdate a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit\n");

    Console.Write("Select an option: ");
}

void MainView()
{
    Console.Clear();
    Header();
    ShowAllTodos();
    UserOptionMenu();
}

#endregion

void AddTodoItem()
{
    Console.Clear();
    string userTodoInput;
    Console.WriteLine("Please enter a task to add to your TODO list");
    userTodoInput = ValidateStringIsNotEmpty(Console.ReadLine());
    todoList.Add(userTodoInput);
    MainView();
}

void UpdateTodoItem()
{
    
    Console.WriteLine("Please enter the task number you wish to update");
    
    int updateInput = ValidateIndexInput(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("You have selected the following to update.");
    Console.WriteLine("{0}: {1}", updateInput, todoList[updateInput - 1]);
    Console.WriteLine("What would you like it to be updated to?");
    userInput = Console.ReadLine();
    todoList[updateInput - 1] = userInput;
    MainView();
}

void RemoveTodoItem()
{
    
    Console.Write("Please enter the task number you wish to remove ");
    int removeInput = ValidateIndexInput(Console.ReadLine());
    todoList.Remove(todoList[removeInput - 1]);
    MainView();
}

#region Validation
void ValidateUserInput(string userInput)
{
    if (userInput != "A" && userInput != "U"
        && userInput != "R" && userInput != "E")
    {
        Console.Write("Please enter a valid choice: ");
    }
}
string ValidateStringIsNotEmpty(string input)
{
    string userInput = input;
    bool isEmpty = true;

    do
    {
        if (userInput == "")
        {
            Console.Write("Please enter a task: ");
            userInput = Console.ReadLine();
        }
        else
        {
            isEmpty = false;
        }

    }
    while (isEmpty != false);

    return userInput;
}

int ValidateIndexInput(string userInput)
{
    int result = 0;
    int indexNumber = ConvertFromString(userInput);
    bool isValid = false;

    do
    {
        if (indexNumber > todoList.Count || indexNumber <= 0)
        {
            Console.Write("You selected an invalid number. Please select the task number: ");
            indexNumber = ConvertFromString(Console.ReadLine());
        }
        else
        {
            isValid = true;
        }

    }
    while (isValid != true);

    result = indexNumber;

    return result;
}

int ConvertFromString(string input)
{
    int result;
    string userInput = input;

    while (!int.TryParse(userInput, out result))
    {
        Console.Write("Please enter a valid task number: ");
        userInput = Console.ReadLine();
    }

    return result;
} 
#endregion


//void testingUserInput(string userInput)
//{
//    Console.WriteLine("User Entered: " + userInput);
//}
