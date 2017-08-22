using System;
using System.Text;
using GPX2Cruiser.Shared.Model;
using Newtonsoft.Json;

namespace GPX2Cruiser.Shared.Utils
{
	public class WaypointJsonConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Waypoint);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var wp = reader.Value.ToString();
			var split = wp.Split(',');

			return new Waypoint
			{
				Latitude = split.Length > 0 ? split[0] : "0",
				Longitude = split.Length > 1 ? split[1] : "1"
			};
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var wp = value as Waypoint;
			if (wp == null)
			{
				writer.WriteNull();
				return;
			}

			var sb = new StringBuilder();
			sb.Append(wp.Latitude);
			sb.Append(",");
			sb.Append(wp.Longitude);

			writer.WriteValue(sb.ToString());
		}
	}
}
