

public class Flight
{
   private String airline, origin, destination;
   private int flightNumber;

   //-----------------------------------------------------------------
   //  Sets up this Flight object with the specified data.
   //-----------------------------------------------------------------
   public Flight (String airlineInit, String originInit,
                  String destinationInit, int flightNumberInit)
   {
      airline = airlineInit;
      origin = originInit;
      destination = destinationInit;
      flightNumber = flightNumberInit;
   }


   //  Accessors.

   public String getAirline ()
   {
	   return airline;
   }

   public String getOrigin ()
   {
	   return origin;
   }

   public String getDestination ()
   {
	   return destination;
   }

   public int getFlightNumber ()
   {
	   return flightNumber;
   }


   //  Mutators.

   public void setAirline (String airlineUpdate)
   {
	   airline = airlineUpdate;
   }

   public void setOrigin (String originUpdate)
   {
	   origin = originUpdate;
   }

   public void setDestination (String destinationUpdate)
   {
	   destination = destinationUpdate;
   }

   public void setFlightNumber (int flightNumberUpdate)
   {
	   flightNumber = flightNumberUpdate;
   }

   
   //  Returns a string representation of this flight.

   public String toString ()
   {
      return airline + " " + flightNumber + " --  From: " + origin +
             ", To: " + destination;
   }
}
