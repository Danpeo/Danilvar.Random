using System.Security.Cryptography;

namespace Danilvar.Random;

public class RandomGenerator
{
    private const string LowerChars = "abcdefghijklmnopqrstuvwxyz";
    private const string UpperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string NumericChars = "0123456789";
    private const string SpecialChars = "!@#$%^&*()_-+=<>?";
    private const string AllChars = LowerChars + UpperChars + NumericChars + SpecialChars;
    private const string NoSpecialChars = LowerChars + UpperChars + NumericChars;

    public static string Password(PasswordOptions? options = null)
    {

        options ??= new PasswordOptions();
        
        var password = new char[options.Length];
        var random = new System.Random();

        for (int i = 0; i < options.Length; i++)
        {
            string currentChars = i switch
            {
                0 when options.RequireLowercase => LowerChars,
                1 when options.RequierUppercase => UpperChars,
                2 when options.RequireNonAlphanumeric => SpecialChars,
                _ => AllChars
            };

            password[i] = currentChars[random.Next(currentChars.Length)];
        }


        password = password.OrderBy(c => random.Next()).ToArray();

        return new string(password);
    }


    public static string Username(UserNameOptions? options = null)
    {
        options ??= new UserNameOptions();
        var postfix = new char[options.PostfixLength];

        for (int i = 0; i < options.PostfixLength; i++)
        {
            postfix[i] = NoSpecialChars[RandomNumberGenerator.GetInt32(NoSpecialChars.Length)];
        }

        return options.Prefix + new string(postfix);
    }

    public static string Email(EmailOptions? options = null)
    {
        options ??= new EmailOptions();

        string postfix = options.Domains[RandomNumberGenerator.GetInt32(options.Domains.Length)];
        var middleChars = new char[options.RandomCharLength];

        for (int i = 0; i < options.RandomCharLength; i++)
        {
            middleChars[i] = NoSpecialChars[RandomNumberGenerator.GetInt32(NoSpecialChars.Length)];
        }

        return options.Prefix + new string(middleChars) + postfix;
    }
}