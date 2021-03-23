using System;
using System.Collections.Generic;
using System.Text;

namespace Airport_Baggage
{
    /// <summary>
    /// BaggageInfo class provides information about arriving flights and the carousels where baggage from each flight is available for pickup
    /// </summary>
    public class BaggageInfo
    {
        private int flightNo;
        private string origin;
        private int location;

        /// <summary>
        /// internal constructor
        /// </summary>
        /// <param name="flight">represent the flight number</param>
        /// <param name="from">represent the flight came from any country</param>
        /// <param name="carousel">represent the flight location</param>
        internal BaggageInfo(int flight, string from, int carousel)
        {
            this.flightNo = flight;
            this.origin = from;
            this.location = carousel;
        }

        /// <summary>
        /// represent the flight number
        /// </summary>
        public int FlightNumber { get { return this.flightNo; } }

        /// <summary>
        /// represent the flight came from any country
        /// </summary>
        public string From { get { return this.origin ; } }

        /// <summary>
        /// represent the flight location
        /// </summary>
        public int Carousel { get { return this.location; }  }

    }
}
