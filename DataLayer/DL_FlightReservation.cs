namespace DataLayer
{
    public class DL_FlightReservation
    {
        public static DL_FlightReservation _instance = null;

        private DL_FlightReservation()
        {

        }

        public static DL_FlightReservation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DL_FlightReservation();
                }
                return _instance;
            }
        }
    }
}
