﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAuth.BasicAuth
{
    public class BasicAuthAccount : Account
    {
		public string Key { get; set; }

	    public override bool IsValid()
	    {
		    return !string.IsNullOrWhiteSpace(Key);
	    }
    }
}