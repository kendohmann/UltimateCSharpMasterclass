
List<string> todoList = new List<string>();

Console.WriteLine("Hello!");

var userAction = "";
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
        PrintTodoList();

    } else if( IsEqualCase(userAction, "a") ) 
    {
        Console.WriteLine("What todo do you want to add?");
        string toAdd = Console.ReadLine();
        while( !isDescriptionValid(toAdd) )
        {
            Console.WriteLine("Invalid input. Please enter a new todo");
            toAdd = Console.ReadLine();
        }

    } else if( IsEqualCase(userAction, "r") ) 
    {

        PrintTodoList();
         if(todoList.Count == 0) {
            continue;
        }       
        Console.WriteLine("Which number todo do you want to remove?");
         int index = GetValidIndex();
        
        todoList.RemoveAt(index-1);
        
    } else if(IsEqualCase(userAction, "e") ) 
    {
        continue_ = false;

    } else
    {
        Console.WriteLine("Incorrect input");
    }
}

Console.WriteLine("Goodbye!");

bool isDescriptionValid(string descript)
{
    if(descript == null || descript.Length == 0)
    {
        return false;
    }
    if(todoList.Contains(descript))
    {
        return false;
    }
    return true;
}
int GetValidIndex()
{
        int.TryParse( Console.ReadLine() , out int index );
        while(index < 0 || index > todoList.Count())
        {
            Console.WriteLine("Invalid Index, Please enter another:");
            int.TryParse( Console.ReadLine() , out index );
        }
        return index;
}

void PrintTodoList()
{
    if(todoList.Count == 0) {
        Console.WriteLine("Todo list is empty");
    }
    for(int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"{(i+1)}. " + todoList[i]);
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


/* Notes:
    multiple declaration:
        int one = 3, two = 2;
        int one, two;
    naming:
        letters digits _ @ but first char can't be a digit
        case sensitive
        keywords
        vars - lower camelcase
        methods - upper camelcase
        meaningful
            avoid abrevation
            precise firstname vs name1
        boolean
            yes or no / true or false quesion
            isBlonde

    operators
        precedence: pemdas
    implicitly defined variables (vs explicitly)
        var name = "string"
            - is a string in every way
            - must be declared inline
            - good practice
    short circuiting for time optimization
        - true || ---- ends when true is evaluated
        - false && ----- ends when false is evaluated
    methods
        - avoid repetitions
        void MethodName(type parameter) {}
        MethodName(arguement);
        type MethodName() {
            return varOftype;
        }
        can be used before declared in file'
    Statically typed
        - int stays an int
        - int.Parse(string);
    string extrapilation
        $"..."{int} ... {int} ... {}"
    do while loop
        do {
            
        } while ();
        - bad to set variables to a default random value bc of changing requirements
          instead use do while loops where you can
    performance
        - break early
        - put preformance-heavy code outside loops where possible
    continue;
        - skips the rest of the iteration and goes to the next iteration
    out
        - must be assigned within the method
        - passes a reference
        int var;
        MethodName( out var );
        MethodName( out int varName );
        void MethodName( out int var ) { }
    int.TryParse( string, out int number )
        - returns a boolean
        - number is now the string parsed


*/