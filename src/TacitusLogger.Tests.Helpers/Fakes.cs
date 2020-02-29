using Moq;
using System;

namespace TacitusLogger.Tests.Helpers
{
    public static class Fakes
    {
        public static class LogGroups
        {
            public static Mock<LogGroupBase> Standard(LogGroupStatus status, bool isEligible)
            { 
                var logGroupMock = new Mock<LogGroupBase>();
                logGroupMock.SetupGet(x => x.Name).Returns(Guid.NewGuid().ToString("n"));
                logGroupMock.SetupGet(x => x.Status).Returns(Setting<LogGroupStatus>.From.Variable(status));
                logGroupMock.Setup(x => x.IsEligible(It.IsAny<LogModel>())).Returns(isEligible);
                return logGroupMock;
            }
        }
    }
}