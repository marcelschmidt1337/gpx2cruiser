using System.Collections.Generic;
using Newtonsoft.Json;

namespace GPX2Cruiser.Shared.Model
{
    public class Route
    {
        [JsonIgnore]
        public const int MIN_WAYPOINTS = 2;

        [JsonProperty("coords")]
        public List<Waypoint> Waypoints;

        [JsonProperty("v")]
        public const int Version = 1;

        [JsonProperty("settings")]
        public Settings Settings;
    }
}
