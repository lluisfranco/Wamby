namespace Wamby.Core.Model
{
    public enum LogLineTypeEnum
    {
        Info, ReadingFolder, Error
    }

    public class LogLine
    {
        public LogLineTypeEnum LogLineType { get; set; }
        public string Message { get; set; }
        public string Value { get; set; }
    }
}
