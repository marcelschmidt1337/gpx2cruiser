using Newtonsoft.Json;
using GPX2Cruiser.Shared.Model;
using System.IO;
using System.Collections.Generic;
using System;

namespace GPX2Cruiser.Shared.Utils
{
    public class CruiserExporter
    {
        private const int MAX_WPS = 100;

        public static void SaveRoute(string path, Route route, List<Waypoint> waypoints)
        {
            int fileAmount = (int)Math.Ceiling(waypoints.Count / (decimal)MAX_WPS);

            var wps = new List<Waypoint>(MAX_WPS);

            for (int i = 0; i < fileAmount; i++)
            {
                wps.Clear();

                for (int j = 0; j + i * MAX_WPS < waypoints.Count && j < MAX_WPS; j++)
				{
                    wps.Add(waypoints[j + i * MAX_WPS]);
				}

                route.Waypoints = wps;

				var wrapper = new { route = route };
				var content = JsonConvert.SerializeObject(wrapper);

                var filePath = path;
                if (fileAmount > 1)
                {
                    var fileName = Path.GetFileNameWithoutExtension(filePath);
                    filePath = filePath.Replace(fileName, fileName + string.Format("-{0}-{1}", i + 1, fileAmount));
                }

                File.WriteAllText(filePath, content);
			}
        }
    }
}
