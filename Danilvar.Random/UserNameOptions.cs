using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danilvar.Random;

public class UserNameOptions
{
    public string Prefix { get; set; } = "user";
    public int PostfixLength { get; set; } = 6;

    public UserNameOptions()
    {
        
    }

    public UserNameOptions(string prefix = "user", int postfixLength = 6)
    {
        Prefix = prefix;
        PostfixLength = postfixLength;
    }
}