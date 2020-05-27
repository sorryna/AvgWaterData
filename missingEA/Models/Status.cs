namespace missingEA.Models
{
    public class Status
    {
        public string EA { get; set; }
        public string REG { get; set; }
        public string CWT { get; set; }
        public string CWT_NAME { get; set; }
        public string AMP { get; set; }
        public string AMP_NAME { get; set; }
        public string TAM { get; set; }
        public string TAM_NAME { get; set; }
        public int DISTRICT { get; set; }
        public int BuildingDoneAll { get; set; }
        public int BuildingComplete { get; set; }
        public int BuildingPause { get; set; }
        public int BuildingRefresh { get; set; }
        public int BuildingSad { get; set; }
        public int BuildingMicOff { get; set; }
        public int BuildingEyeOff { get; set; }
        public int BuildingCheckMark { get; set; }
        public int HouseholdComplete { get; set; }
        public int HouseholdMicOff { get; set; }
        public int HouseholdEyeOff { get; set; }
        public int HouseholdSad { get; set; }
        public int HouseholdPause { get; set; }
        public int HouseholdRefresh { get; set; }
        public int HouseholdNull { get; set; }
        public int ComunityComplete { get; set; }
        public int ComunityPause { get; set; }
    }
}