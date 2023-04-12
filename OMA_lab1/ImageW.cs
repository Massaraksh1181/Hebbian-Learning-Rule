using System;

public class ImagW
{
	public ImagW()
	{
	}

    public W(int ImHeight, int ImWidth)
    {
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

                // label2.Text = label2.Text + newClass1[i].ToString() + " " ;

            }
        }
    }
}
