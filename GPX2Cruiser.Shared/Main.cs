using System.Collections.Generic;
using GPX2Cruiser.Shared.Model;
using GPX2Cruiser.Shared.Utils;

namespace GPX2Cruiser.Shared
{
    public class Main
    {
        public string LoadedFileName { get; private set; }
        public bool HasLoadedValidRoute { get { return waypoints != null && waypoints.Count >= 2; }}
        public int LoadedWayPoints { get { return HasLoadedValidRoute ? waypoints.Count : 0; } }

		public Settings Settings = new Settings();

        private List<Waypoint> waypoints;

        public void OpenFile(string path)
        {
            waypoints = GpxLoader.LoadWaypoints(path);

            if(HasLoadedValidRoute)
            {
                LoadedFileName = System.IO.Path.GetFileNameWithoutExtension(path);
            }
        }

        public void Export(string path)
        {
            if (HasLoadedValidRoute)
            {
                Route route = new Route
                {
                    Settings = Settings
                };
                CruiserExporter.SaveRoute(path, route, waypoints);
            }
        }
	}
}
