using System.Collections.Generic;
using System.Xml.Linq;
using GPX2Cruiser.Shared.Model;

namespace GPX2Cruiser.Shared.Utils
{
    public class GpxLoader
    {
        public static List<Waypoint> LoadWaypoints(string path) 
        {
            var waypoints = new List<Waypoint>();
            var xml = XDocument.Load(path);

            var routeData = xml.Root.Element(xml.Root.Name.Namespace + "rte");

            foreach (var wp in routeData.Elements(xml.Root.Name.Namespace + "rtept"))
			{
                var waypoint = new Waypoint
                {
                    Latitude = wp.FirstAttribute.Value,
                    Longitude = wp.LastAttribute.Value
                };

                waypoints.Add(waypoint);
            }

            return waypoints;
        }
    }
}
