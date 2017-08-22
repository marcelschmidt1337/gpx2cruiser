using Newtonsoft.Json;
namespace GPX2Cruiser.Shared.Model
{
    public class Settings
    {
        private enum Value
        {
            Allow = 0,
            Forbid = 2
        }

        // TR = Toll Road
        // FR = Ferry
        [JsonProperty] private const int VT = 1;
        [JsonProperty] private const int BE = 0;
        [JsonProperty] private int FR = 0;
        [JsonProperty] private const int ROUND = 0;
        [JsonProperty] private const int RT = 3;
        [JsonProperty] private const int SR = 0;
        [JsonProperty] private const int HOV = 0;
        [JsonProperty] private const int HW = 0;
        [JsonProperty] private int TR = 0;
        [JsonProperty] private const int CU = 1;

        [JsonIgnore]
        public bool ForbidFerries
        {
            get { return FR == (int)Value.Forbid; }
            set { FR = value == true ? (int)Value.Forbid : (int)Value.Allow; }
        }

		[JsonIgnore]
		public bool ForbidTollRoads 
        {
            get { return TR == (int)Value.Forbid; }
            set { TR = value == true ? (int)Value.Forbid : (int)Value.Allow; }
        }
	}
}
