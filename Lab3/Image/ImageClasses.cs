using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3.Image
{
    internal class ImageClasses
    {
        public Bitmap[] images = new Bitmap[4];

        public ImageClasses(Bitmap img)
        {
            images[0] = new Bitmap(img);
            images[1] = new Bitmap(img);
            images[2] = new Bitmap(img);
            images[3] = new Bitmap(img);
        }

        public void ParrallelConverter(PictureBox[] pictureBox)
        {
            Parallel.For(0, 4, i =>
            {
                int i_temp = i;
                imageConverter(images[i_temp], 3-i_temp, pictureBox[i_temp]);
            });
        }

        public void ThreadConverter(PictureBox[] pictureBox)
        {
            Thread[] threads = new Thread[4];
            for (int i = 0; i < 4; i++)
            {
                int i_temp = i;
                threads[i_temp] = new Thread(() => 
                {
                    imageConverter(images[i_temp], 3-i_temp, pictureBox[i_temp]);
                });
                threads[i].Name = $" Thread : {i + 1}";
            }
            foreach (Thread x in threads) x.Start();
            foreach (Thread x in threads) x.Join();
        }


        private void imageConverter(Bitmap image, int threadNumber, PictureBox pictureBox)
        {
           
            switch (threadNumber)
            {
                case 0:
                    // Convert in image pixels with greater value of RGB than average to average
                    image = AboveAvgToAvg(image);
                    image = Mirror(image);
                    pictureBox.Image = image;
                    break;
                case 1:
                    // Convert the image to negative
                    image = Negative(image);
                    pictureBox.Image = image;
                    break;
                case 2:
                    // Convert the image to mirror reflection in grayscale
                    image = GrayScale(image);
                    image = Mirror(image);
                    pictureBox.Image = image;
                    break;
                case 3:
                    // Convert the image with erosion (grayscale) 
                    image = Erosion(image);
                    pictureBox.Image = image;
                    break;
                default:
                    break;
            }
        }

        private Bitmap AboveAvgToAvg(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            int red = 0;
            int green = 0;
            int blue = 0;
            int size = image.Width * image.Height;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var pixel = image.GetPixel(i, j);
                    red += pixel.R;
                    green += pixel.G;
                    blue += pixel.B;
                }
            }
            red /= size;
            green /= size;
            blue /= size;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var pixel = image.GetPixel(i, j);
                    newImage.SetPixel(i, j, Color.FromArgb(255, (pixel.R > red ? red: pixel.R),( pixel.G > green ? green : pixel.G), (pixel.B > blue ? blue : pixel.B)));
                }
            }
            return newImage;
        }

        private Bitmap Negative(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var pixel = image.GetPixel(i, j);
                    newImage.SetPixel(i, j, Color.FromArgb(255, 255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }
            return newImage;
        }
        private Bitmap GrayScale(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var pixel = image.GetPixel(i, j);
                    int grayScale = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                    newImage.SetPixel(i, j, Color.FromArgb(255, grayScale, grayScale, grayScale));
                }
            }
            return newImage;
        }
        private Bitmap Mirror(Bitmap image)
        {
            /*  Mirror reflection of original image
                Swap Pixels Width position on the same Height position  */
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int j = 0; j < image.Height; j++)
            {
                for (int i = 0; i <= image.Width/2; i++)
                {
                    newImage.SetPixel(i, j, image.GetPixel(image.Width - i - 1, j));
                    newImage.SetPixel(image.Width - i - 1, j, image.GetPixel(i, j));
                }
            }
            return newImage;
        }
        private Bitmap Erosion(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            const int kernelSize = 5; 
            int kernelRadius = kernelSize / 2;
            // Create kernel
            int[,] kernel = new int[kernelSize, kernelSize] {   {0, 0, 1, 0, 0},
                                                                {0, 1, 1, 1, 0}, 
                                                                {1, 1, 1, 1, 1},
                                                                {0, 1, 1, 1, 0},
                                                                {0, 0, 1, 0, 0} };

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    int minValue = 255;
                    for (int k = -kernelRadius; k <= kernelRadius; k++)
                    {
                        for (int l = -kernelRadius; l <= kernelRadius; l++)
                        {
                            // Get the begining point of kernel
                            int x = i + k; 
                            int y = j + l;
                            if (x >= 0 && x < image.Width && y >= 0 && y < image.Height)
                            {
                                var pixel = image.GetPixel(x, y);
                                if (kernel[k + kernelRadius, l + kernelRadius] == 1)
                                {
                                    if(pixel.R < minValue)
                                        minValue = pixel.R;
                                    else if(pixel.G < minValue)
                                        minValue = pixel.G;
                                    else if(pixel.B < minValue)
                                        minValue = pixel.B;
                                }
                            }
                        }
                    }
                    newImage.SetPixel(i, j, Color.FromArgb(255, minValue, minValue, minValue));
                }
            }
            return newImage;
        }
    }
}
