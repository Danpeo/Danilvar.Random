using Danilvar.Random;

string randPassword = RandomGenerator.Password();

Console.WriteLine($"Random password: {randPassword}");

string randPassword2 = RandomGenerator.Password(new PasswordOptions(12));

Console.WriteLine($"Random password 2: {randPassword2}");

string userName = RandomGenerator.Username();

Console.WriteLine($"User Name: {userName}");

string email = RandomGenerator.Email();

Console.WriteLine(email);
