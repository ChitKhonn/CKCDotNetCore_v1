using System.Data;
using System.Data.SqlClient;
using CKCDotNetCore.ConsoleApp.AdoDotNetExamples;
using CKCDotNetCore.ConsoleApp.DapperExamples;
using CKCDotNetCore.ConsoleApp.EFCoreExamples;
using CKCDotNetCore.ConsoleApp.HttpClientExample;
using CKCDotNetCore.ConsoleApp.RestClientExample;
using CKCDotNetCore.ConsoleApp.RestClientExamples;

Console.WriteLine("Hello, World!");


//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Run();

//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();

//EFCoreExample eFCoreExample = new EFCoreExample();
//eFCoreExample.Run();


//HttpClientExample httpClientExample = new HttpClientExample();
//await httpClientExample.Run();

RestClientExample restClientExample = new RestClientExample();
await restClientExample.Run();

Console.ReadKey();

