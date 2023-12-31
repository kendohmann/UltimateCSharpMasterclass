
List<string> todoList = new List<string>();

Console.WriteLine("Hello!");

var userAction = Console.ReadLine();
bool continue_ = true;
while(continue_)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    userAction = Console.ReadLine();
    if( IsEqualCase(userAction, "s")) 
    {
        PrintTodoList(todoList);
        break;

    } else if( IsEqualCase(userAction, "a") ) 
    {
        Console.WriteLine("What todo do you want to add?");
        todoList.Add(Console.ReadLine());
        break;

    } else if( IsEqualCase(userAction, "r") ) 
    {
        PrintTodoList(todoList);
        Console.WriteLine("Which number todo do you want to add?");
        int.TryParse( Console.ReadLine() , out int index );
        while(index < 0 || index > todoList.Count())
        {
            Console.WriteLine("Invalid Index, Please enter another:");
            int.TryParse( Console.ReadLine() , out index );
        }
        todoList.RemoveAt(index);
        break;
        
    } else if(IsEqualCase(userAction, "e") ) 
    {
        continue_ = false;
        break;

    } else
    {
        Console.WriteLine("Incorrect input");
    }
}
Console.WriteLine("Goodbye!");

void PrintTodoList(List<string> todoList)
{
    for(int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"{i}. " + todoList[i]);
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
    return a.ToLower() == b.ToLower();
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