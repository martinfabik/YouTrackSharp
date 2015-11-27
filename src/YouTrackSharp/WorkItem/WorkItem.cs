using System;
using System.Collections.Generic;
using JsonFx.Json;

namespace YouTrackSharp.WorkItem
{
    public class WorkItem
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        [JsonName("author")]
        public object AuthorObject { get; set; }

        [JsonName("date")]
        public long EpochDate { get; set; }

        public DateTime Date
        {
            get
            {
                var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                return epoch.AddMilliseconds(EpochDate);
            }
        }

        public string AuthorName
        {
            get
            {
                return (string)((IDictionary<string, object>)AuthorObject)["login"];
            }
        }
    }
}