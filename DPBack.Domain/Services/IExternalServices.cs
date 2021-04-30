namespace DPBack.Domain.Services
{
    public interface IExternalServices
    {
        void Execute();
        bool ServiceStatus(bool status, string message, string serviceName);
    }
}