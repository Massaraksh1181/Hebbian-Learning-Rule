using System;

public class ImagW
{

   public int W(string name)
    {
        Bitmap image1 = new Bitmap(@name, true);

        for (y = 0, i = 1; y < ImHeight; y++)
        {
            for (x = 0; x < ImWidth; x++, i++)
            {
                Color pixelColor = image1.GetPixel(x, y);
                image1.SetPixel(x, y, pixelColor);

                if (pixelColor.R == 0 && pixelColor.G == 0 && pixelColor.B == 0)
                {
                    newClass1[i] = 1;
                }
                else newClass1[i] = -1;

            }
        }
        return 
    }
}
