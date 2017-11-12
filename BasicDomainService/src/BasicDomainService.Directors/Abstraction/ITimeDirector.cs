using BasicDomainService.Directors.Models;

namespace BasicDomainService.Directors.Abstraction
{
    public interface ITimeDirector
    {
        TimeViewModel GetLocalTimeView();
    }
}