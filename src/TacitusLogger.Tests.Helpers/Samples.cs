using System;
using System.Collections.Generic;

namespace TacitusLogger.Tests.Helpers
{
    public static class Samples
    {
        public static class LogModels
        {
            public static LogModel Standard(LogType logType = LogType.Error)
            {
                return new LogModel()
                {
                    Context = "Context1",
                    Description = "Description1",
                    Source = "Source1",
                    LogType = logType,
                    LogDate = DateTime.Now,
                    LogId = "logid",
                };
            }
            public static LogModel WithTagsAndItems(LogType logType = LogType.Error)
            {
                var standard = Standard(logType); 
                standard.Tags = new string[] { "Tag1", "Tag2", "Tag3" };
                standard.LogItems = new LogItem[]
                {
                    new LogItem("Name1", new { Property1 = "Value1" , Property2 = "Value2" }),
                    new LogItem("Name2", new { Property1 = "Value1" , Property2 = new { } })
                };
                return standard;
            }
        }
        public static class Logs
        {
            public static Log Standard(LogType logType = LogType.Error)
            {
                return new Log(logType, "description1").From("context1").Tagged("tag1", "tag2");
            }
        }
        public static class ColorSchemes
        {
            public static Dictionary<LogType, ConsoleColor> Custom()
            {
                return new Dictionary<LogType, ConsoleColor>()
                {
                    { LogType.Success, ConsoleColor.White },
                    { LogType.Info, ConsoleColor.White },
                    { LogType.Event, ConsoleColor.White },
                    { LogType.Warning, ConsoleColor.White},
                    { LogType.Failure, ConsoleColor.White},
                    { LogType.Error, ConsoleColor.White},
                    { LogType.Critical, ConsoleColor.White }
                };
            }
        }
        public static class Strings
        {
            public static string RandomGuidBased(int length = 10)
            {
                return Guid.NewGuid().ToString("n").Substring(0, 10);
            }
        }
    }
}
