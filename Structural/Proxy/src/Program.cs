using System;
using System.Collections.Generic;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ISubject> subjects = new Dictionary<string, ISubject>();
            String[] subjectsKeys = { "a", "b", "c" };
            foreach(var value in subjectsKeys) 
            {
                subjects.Add(value, new Proxy(value));
            }
            subjects["a"].Request();
            subjects["b"].Request();
        }
    }
}
