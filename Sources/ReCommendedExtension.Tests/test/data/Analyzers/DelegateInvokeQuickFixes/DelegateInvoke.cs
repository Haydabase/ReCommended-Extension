﻿using System;

namespace Test
{
    public class DelegateInvoke
    {
        void Method(Action action)
        {
            action.{caret}Invoke();
        }
    }
}