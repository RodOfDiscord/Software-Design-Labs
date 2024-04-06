using TextReader;

string filePath = "test.txt";
SmartTextReader smartTextReader = new SmartTextReader();
var arr = smartTextReader.ConvertTo2DArray(filePath);

SmartTextChecker textChecker = new(smartTextReader);
textChecker.ConvertTo2DArray(filePath);

SmartTextReaderLocker textReaderLocker = new SmartTextReaderLocker(smartTextReader, @"\.txt");
textReaderLocker.ConvertTo2DArray(filePath);
textReaderLocker.ChangePattern(@"\.doc");
textReaderLocker.ConvertTo2DArray(filePath);