﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danilvar.Random;

public class EmailOptions
{
    public string Prefix { get; set; } = "user";
    public string[] Domains { get; set; } = { "@mail.com" };
    public int RandomCharLength { get; set; } = 6;

    public EmailOptions()
    {
    }

    public EmailOptions(string[] domains, string prefix = "user", int randomCharLength = 6)
    {
        Domains = domains;
        Prefix = prefix;
        RandomCharLength = randomCharLength;
    }
}