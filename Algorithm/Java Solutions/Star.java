

import java.awt.Graphics;
import java.awt.Color;

public class Star
{
   private int points, size, x, y;


   //  Sets up this star using the specified information.

   public Star (int numPoints, int radius, int xPoint, int yPoint)
   {
      points = numPoints;
      size = radius;
      x = xPoint;
      y = yPoint;
   }

   //  Draws the star.
   
   public void draw (Graphics page)
   {
      page.setColor (Color.white);

      switch (points)
      {
         case 4:
            page.drawLine (x-size, y-size, x+size, y+size);
            page.drawLine (x-size, y+size, x+size, y-size);
            break;
         case 5:
            page.drawLine (x, y, x, y-size);
            page.drawLine (x, y, x-size, y-size);
            page.drawLine (x, y, x+size, y+size);
            page.drawLine (x, y, x-size, y+size);
            page.drawLine (x, y, x+size, y-size);
            break;
         default:
            int shift = size / 3;
            page.drawLine (x-size, y, x+size, y);
            page.drawLine (x-size+shift, y-size, x+size-shift, y+size);
            page.drawLine (x-size+shift, y+size, x+size-shift, y-size);
      }
   }
}
