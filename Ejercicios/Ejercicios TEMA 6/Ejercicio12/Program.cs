using SkiaSharp;

namespace Ejercicio12;

internal class Program
{
    private const int LINE_WIDTH = 10;
    private static readonly SKColor LINE_COLOR = new SKColor(255, 0, 0); 

    static void Main(string[] args)
    {
        using SKBitmap originalImage = SKBitmap.Decode("nft-golem.jpg");

        Ejercicio1(originalImage);
        Ejercicio2(originalImage);
        Ejercicio3(originalImage);
        Ejercicio4(originalImage);
        Ejercicio5(originalImage);
    }

    static void Save(SKBitmap image, string path, SKEncodedImageFormat format = SKEncodedImageFormat.Jpeg)
    {
        using SKFileWStream file = new SKFileWStream(path);
        image.Encode(file, format, 100);
    }

    static void Ejercicio1(SKBitmap original)
    {
        using SKBitmap image = original.Copy();

        for (int i = 0; i < image.Width; i++)
            for (int j = 0; j < image.Height; j++)
            {
                SKColor color = image.GetPixel(i, j);
                color = color.WithAlpha(127);
                image.SetPixel(i, j, color);
            }

        Save(image, "nft-golem1.png", SKEncodedImageFormat.Png);
    }

    static void Ejercicio2(SKBitmap original)
    {
        using SKBitmap image = original.Copy();

        for (int i = 0; i < image.Width; i++)
            for (int j = 0; j < image.Height; j++)
            {
                SKColor color = image.GetPixel(i, j);
                byte gray = (byte)(0.299 * color.Red + 0.587 * color.Green + 0.114 * color.Blue);
                color = new SKColor(gray, gray, gray);
                image.SetPixel(i, j, color);
            }

        Save(image, "nft-golem2.jpg");
    }

    static void Ejercicio3(SKBitmap original)
    {
        using SKBitmap image = original.Copy();

        int radiusSquare = (int)(Math.Min(image.Width, image.Height) * 0.9);

        for (int i = 0; i < image.Width; i++)
            for (int j = 0; j < image.Height; j++)
            {
                if (Math.Abs(i - j) <= LINE_WIDTH || Math.Abs(image.Width - i - j) <= LINE_WIDTH)
                {
                    image.SetPixel(i, j, LINE_COLOR);
                }
            }

        Save(image, "nft-golem3.jpg");
    }

    static void Ejercicio4(SKBitmap original)
    {
        using SKBitmap image = original.Copy();

        int maxRadius = (int)(Math.Min(image.Width, image.Height) / 2 * 0.9);
        int maxRadiusSquare = maxRadius * maxRadius;
        int minRadiusSquare = (int)Math.Pow(maxRadius - LINE_WIDTH, 2);

        for (int i = 0; i < image.Width; i++)
            for (int j = 0; j < image.Height; j++)
            {
                int x = i - image.Width / 2;
                int y = j - image.Height / 2;
                int radiusSquare = x * x + y * y;

                if (radiusSquare <= maxRadiusSquare)
                {
                    if (minRadiusSquare <= radiusSquare || Math.Abs(i - j) < LINE_WIDTH)
                        image.SetPixel(i, j, LINE_COLOR);
                }
            }

        Save(image, "nft-golem4.jpg");
    }

    static void Ejercicio5(SKBitmap original)
    {
        using SKBitmap image = original.Copy();

        int maxRadius = (int)(Math.Min(image.Width, image.Height) / 2 * 0.9);
        int maxRadiusSquare = maxRadius * maxRadius;
        int minRadiusSquare = (int)Math.Pow(maxRadius - LINE_WIDTH, 2);

        int rectangleWidth = (int)(image.Width * 0.4);
        int rectangleHeight = rectangleWidth / 3;
        int rectangleWidthHalf = rectangleWidth / 2;
        int rectangleHeightHalf = rectangleHeight / 2;

        // He cambiado el orden del bucle, ahora por cada fila va recorriendo las columnas
        // No tiene un porqué es solo para variar
        for (int i = 0; i < image.Height; i++)
            for (int j = 0; j < image.Width; j++)
            {
                int x = j - image.Width / 2;
                int y = i - image.Height / 2;
                int radiusSquare = x * x + y * y;

                if (radiusSquare <= maxRadiusSquare)
                {
                    if(!(-rectangleWidthHalf <= x && x <= rectangleWidthHalf 
                        && -rectangleHeightHalf <= y && y <= rectangleHeightHalf))
                        image.SetPixel(j, i, LINE_COLOR);
                }
            }

        Save(image, "nft-golem5.jpg");
    }
}