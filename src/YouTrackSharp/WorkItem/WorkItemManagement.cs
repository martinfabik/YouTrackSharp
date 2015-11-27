using System.Collections.Generic;
using YouTrackSharp.Infrastructure;

namespace YouTrackSharp.WorkItem
{
    public class WorkItemManagement
    {
        private readonly IConnection _connection;

        public WorkItemManagement(IConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<WorkItem> GetWorkItems(string issueId)
        {
            return _connection.Get<IEnumerable<WorkItem>>(string.Format("issue/{0}/timetracking/workitem", issueId));
        } 
    }
}