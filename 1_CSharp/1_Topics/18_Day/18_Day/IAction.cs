﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Day
{
    public interface IAction
    {
        int Minus(int num1, int num2);
        string UserName(int uid);
    }
}
