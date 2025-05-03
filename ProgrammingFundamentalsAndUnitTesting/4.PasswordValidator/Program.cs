string password = Console.ReadLine();
string result = PasswordValidator(password);
Console.WriteLine(result);

static string PasswordValidator(string password)
{
    string result = "";

    // Rule 1: Length Check
    if (password.Length < 6 || password.Length > 10)
    {
        result += "Password must be between 6 and 10 characters" + Environment.NewLine;
    }

    // Rule 2: Only Letters and Digits
    if (!password.All(char.IsLetterOrDigit))
    {
        result += "Password must consist only of letters and digits" + Environment.NewLine;
    }

    // Rule 3: At Least 2 Digits
    int digitCount = password.Count(char.IsDigit);
    if (digitCount < 2)
    {
        result += "Password must have at least 2 digits" + Environment.NewLine;
    }

    // If result is still empty, password is valid
    if (result == "")
    {
        result = "Password is valid";
    }

    return result.Trim(); // Trim to remove any trailing newline
}