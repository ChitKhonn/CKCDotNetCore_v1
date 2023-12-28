using System.Data;
using System.Data.SqlClient;
using CKCDotNetCore.ConsoleApp.AdoDotNetExamples;
using CKCDotNetCore.ConsoleApp.DapperExamples;
using CKCDotNetCore.ConsoleApp.EFCoreExamples;

Console.WriteLine("Hello, World!");


//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Run();

//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();

EFCoreExample eFCoreExample = new EFCoreExample();
eFCoreExample.Run();

Console.ReadKey();

