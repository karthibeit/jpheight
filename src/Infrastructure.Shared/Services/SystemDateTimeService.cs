using JPBlazor.Application.Interfaces.Services;
using System;

namespace JPBlazor.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}