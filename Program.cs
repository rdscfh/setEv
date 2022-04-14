// See https://aka.ms/new-console-template for more information
var p= args.First();
var path = "sss";


Environment.SetEnvironmentVariable("DIYHOMERUNTIME1", $"{path}", EnvironmentVariableTarget.Machine);
Console.WriteLine(Environment.GetEnvironmentVariable("DIYHOMERUNTIME1"));
