using hw12_exception;

try
{
    MyAuthorization.ValidateAuthorization("Login1", "Pass1", "Pass1");

    Console.WriteLine("Valid credentials.");
}
catch (WrongLoginException)
{
    Console.WriteLine("WrongLoginException exception.");
}
finally
{
    Console.WriteLine("Finally!");
}

// WrongLoginException expected
try
{
    MyAuthorization.ValidateAuthorization("Login 1", "Pass1", "Pass1");

    Console.WriteLine("Valid credentials.");
}
catch (WrongLoginException)
{
    Console.WriteLine("WrongLoginException exception.");
}

// WrongPasswordException expected
try
{
    MyAuthorization.ValidateAuthorization("Login1", "Pass1", "Pass2");

    Console.WriteLine("Valid credentials.");
}
catch (WrongPasswordException)
{
    Console.WriteLine("WrongPasswordException exception.");
}

// WrongLoginException expected
try
{
    MyAuthorization.ValidateAuthorization("Login111111111111111111111111111111111111111111111111111", "Pass1", "Pass2");

    Console.WriteLine("Valid credentials.");
}
catch (WrongLoginException)
{
    Console.WriteLine("WrongLoginException exception.");
}

// WrongPasswordException expected
try
{
    MyAuthorization.ValidateAuthorization("Login1", "Pass", "Pass");

    Console.WriteLine("Valid credentials.");
}
catch (WrongPasswordException)
{
    Console.WriteLine("WrongPasswordException exception.");
}
