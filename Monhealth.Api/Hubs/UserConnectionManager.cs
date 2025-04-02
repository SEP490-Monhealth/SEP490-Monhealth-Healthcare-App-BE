using Monhealth.Application.Contracts.ChatBox;
using System.Collections.Concurrent;

namespace Monhealth.Api.Hubs
{
    public class UserConnectionManager : IUserConnectionManager
    {
        private readonly ConcurrentDictionary<Guid, List<string>> _userConnectionMap;
        public UserConnectionManager()
        {
            _userConnectionMap = new ConcurrentDictionary<Guid, List<string>>();

        }
        public void AddConnection(Guid userId, string connectionId)
        {
            _userConnectionMap.AddOrUpdate(
                           userId,
                           new List<string> { connectionId },
                           (key, connections) =>
                           {
                               connections.Add(connectionId);
                               return connections;
                           });
        }

        public List<string> GetConnections(Guid userId)
        {
            _userConnectionMap.TryGetValue(userId, out var connections);
            return connections ?? new List<string>();
        }

        public void RemoveConnection(Guid userId, string connectionId)
        {
            if (_userConnectionMap.TryGetValue(userId, out var connections))
            {
                connections.Remove(connectionId);

                if (!connections.Any())
                {
                    _userConnectionMap.TryRemove(userId, out _);
                }
            }
        }
    }
}
