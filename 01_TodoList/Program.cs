var todos = new List<string>();

Console.WriteLine("Hello!");

bool shallExit = false;
while (!shallExit)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        Console.WriteLine("What todo do you want to add?");
        todoList.Add(Console.ReadLine());
        break;

Console.ReadKey();

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter the TODO description:");
        description = Console.ReadLine();
    }
}

bool IsEqualCase(string a, string b)
{
    if( a== null && b == null ) 
    {
        return true;
    }
    if( a == null || b == null ) 
    {
        return false;
    }
    return true;
}


    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        SeeAllTodos();
    } while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty");
        return false;
    }
    if (int.TryParse(userInput, out index) &&
        index >= 1 &&
        index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid.");
    return false;
}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}

void ShowNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}