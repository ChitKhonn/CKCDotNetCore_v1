﻿using System.Data;
using System.Data.SqlClient;
using TestingDotNetCore.ConsoleApp.AdoDotNetExamples;
using TestingDotNetCore.ConsoleApp.DapperExamples;
using TestingDotNetCore.ConsoleApp.EFCoreExamples;

Console.WriteLine("Hello, World!");


//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Run();

//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();

EFCoreExample eFCoreExample = new EFCoreExample();
eFCoreExample.Run();

Console.ReadKey();

