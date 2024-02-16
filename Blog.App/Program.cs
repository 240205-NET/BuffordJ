﻿using System;
using System.Xml.Serialization;

namespace Blog.App
{
    class Program
    {
        static void Main()
        {
            try
            {
                Blog MyBlog = new Blog();
                Console.WriteLine("Journal Buddy Starting...");
                //Console.WriteLine(MyBlog.GetAuthorsInfo());
                MyBlog.Menu();
                Console.WriteLine("\nJournal Buddy Closing...");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

/*
- Present on Friday 2/16.
- Your project must be written in C#.
- Your project must be a .NET 7 console application.
- Your project must have multiple classes, including at least one abstract class.
- Your project must read and write from and to a file.
- Your project must serialize an object.

Requirement Update - 2/8
- Your project must have at least ten unit tests. 
- Your unit tests should check at least 4 different methods from your application project.
*/