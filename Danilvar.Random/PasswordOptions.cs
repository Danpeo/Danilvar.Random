using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danilvar.Random;

public class PasswordOptions
{
    public int Length { get; set; } = 8;

    public bool RequireLowercase { get; set; } = true;

    public bool RequierUppercase { get; set; } = true;

    public bool RequireNonAlphanumeric { get; set; } = true;

    public PasswordOptions()
    {
    }

    public PasswordOptions(int length = 6, bool requireLowercase = true, bool requierUppercase = true,
        bool requireNonAlphanumeric = true)
    {
        if (length < 6)
            Length = 6;

        Length = length;
        RequireLowercase = requireLowercase;
        RequierUppercase = requierUppercase;
        RequireNonAlphanumeric = requireNonAlphanumeric;
    }
}