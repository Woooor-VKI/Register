using static Register.LoginPassword;

Console.WriteLine("Login");
string input1 = Console.ReadLine();
Console.WriteLine("Password");
string input2 = Console.ReadLine();
Console.WriteLine("Password");
string input3 = Console.ReadLine();
(string result, string result1) = new Register.LoginPassword().CheckRegister(input1, input2, input3);
Console.WriteLine(result);
Console.WriteLine(result1);


