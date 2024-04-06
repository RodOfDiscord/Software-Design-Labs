using Logging;
string path = "test.txt";

Logger filelogger = new FileWriterAdapter(new FileWriter(), path);
Logger loger = new();

filelogger.Warn("warning message");
filelogger.Error("some error((");

loger.Warn("warning");
loger.Log("success logs");