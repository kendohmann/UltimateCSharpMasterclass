using System.Data.Common;

Console.WriteLine("Hello!\nInput the first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do with those numbers?\n[A]dd\n[S]ubtract\n[M]ultiply");
string choice = Console.ReadLine();

// if(IsEqualCase(choice, "a")) {
//     PrintEquation(num1, num2, num1+num2, "+");
// } else if (IsEqualCase(choice, "s")) {
//     PrintEquation(num1, num2, num1-num2, "-");
// } else if (IsEqualCase(choice, "m")) {
//     PrintEquation(num1, num2, num1*num2, "*");
// } else {
//     Console.WriteLine("Invalid option");
// }
switch(choice)
{
    case "a":
    case "A":
        PrintEquation(num1, num2, num1+num2, "+");
        break;
    case "s":
    case "S":
        PrintEquation(num1, num2, num1-num2, "-");
        break;
    case "m":
    case "M":
        PrintEquation(num1, num2, num1*num2, "*");
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;
        
}
void PrintEquation(int num1, int num2, int result, string _operator){
    Console.WriteLine(num1 + _operator + num2 + "=" + result);
}
bool IsEqualCase(string a, string b){
    return a.ToLower() == b.ToLower();
}