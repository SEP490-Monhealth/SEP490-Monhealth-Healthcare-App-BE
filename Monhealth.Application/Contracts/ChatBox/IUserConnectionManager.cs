namespace Monhealth.Application.Contracts.ChatBox
{
    public interface IUserConnectionManager
    {
        void AddConnection(Guid userId, string connectionId);
        void RemoveConnection(Guid userId, string connectionId);
        List<string> GetConnections(Guid userId);
    }
}
