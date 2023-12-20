namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null
                logger.LogWarning("Error Warning !!! Length is less than 3");
                return null; 
            }

            // TODO: Grab the latitude from your array at index 0
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            double latitude = 0;

            if (double.TryParse(cells[0], out latitude) == false)
            {
                logger.LogError($" {cells[0]} Something went wrong, Latitude must be parsed as double only!");

            }

            // TODO: Grab the longitude from your array at index 1
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            double longitude = 0;

            if (double.TryParse(cells[1], out longitude) == false)
            {
                logger.LogError("Something went wrong, Longitude must be parsed as double only!");

            }

            // TODO: Grab the name from your array at index 2
            var name = cells[2];

            if (cells[2] == null || cells[2].Length == 0)
            {
                logger.LogError("Location name was not found !");
            }

            // TODO: Create a TacoBell class
            // that conforms to ITrackable

            // TODO: Create an instance of the Point Struct
            // TODO: Set the values of the point correctly (Latitude and Longitude) 
            var pointStruct = new Point
            {
                Latitude = latitude,
                Longitude = longitude
            };
            // TODO: Create an instance of the TacoBell class
            // TODO: Set the values of the class correctly (Name and Location)
            var tacoBell = new TacoBell();

            tacoBell.Location = pointStruct;
            tacoBell.Name = name;
            // TODO: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable

            return tacoBell;
        }
    }
}
