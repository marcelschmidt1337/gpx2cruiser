using GPX2Cruiser.Shared.Utils;
using Newtonsoft.Json;

namespace GPX2Cruiser.Shared.Model
{
    [JsonConverter(typeof(WaypointJsonConverter))]
    public class Waypoint
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
