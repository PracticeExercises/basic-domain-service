using System;

namespace BasicDomainService.BusinessLogic.Time
{
    public interface ISystemTime
    {
        DateTime Now { get; }
    }
}