using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    enum CountOfPictures
    {
        Min = 3,
        Mid = 6,
        Max = 10
    }

    enum Tags
    {
        Zero = 0,
        One,
        Two,
        Three,
        Four,
        Five,
        Siz,
        Seven,
        Eight,
    }

    class Card
    {
        public static Random RandomNum { get; set; }

        public static int[] RndNumsPict { get; private set; }

        public static List<Image> Cards { get; set; }

        static string file = "img/imgs.png";

        static Image tree = Image.FromFile("img/tree.png");
        static public Image ImageTree
        {
            get
            {
                return tree;
            }
        }

        static Bitmap image = (Bitmap)Image.FromFile(file);
        public static int Width { get; set; }
        public static int Height { get; set; }

        public Card()
        {
            RandomNum = new Random();
            Cards = new List<Image>();

            Width = image.Width / ((int)CountOfPictures.Max-1);
            Height = image.Height;
        }

        public static List<Image> RandomCards(int field)
        {
            switch (field)
            {
                case (int)ButtonsCount.Max:
                    {
                        RndNumsPict = new int[(int)ButtonsCount.Max/2];
                        RndNumsPict = RandomPictures3(RndNumsPict.Length, CountOfPictures.Max);
                        Crop(RndNumsPict);
                        return Cards;
                    }
                case (int)ButtonsCount.Mid:
                    {
                        RndNumsPict = new int[(int)ButtonsCount.Mid/2];
                        RndNumsPict = RandomPictures3(RndNumsPict.Length, CountOfPictures.Mid);
                        Crop(RndNumsPict);
                        return Cards;
                    }
                case (int)ButtonsCount.Min:
                    {
                        RndNumsPict = new int[(int)ButtonsCount.Min/2];
                        RndNumsPict = RandomPictures3(RndNumsPict.Length, CountOfPictures.Min);
                        Crop(RndNumsPict);
                        return Cards;
                    }
                default:
                    {
                        break;
                    }
            }
            return null;
        }

        private static int[] RandomPictures3(int number, CountOfPictures countOf)
        {
            int[] nums = new int[number];
            for (int i = 0; i < number; i++)
            {
                if (countOf == CountOfPictures.Max)
                {
                    nums[i] = RandomNum.Next(0, (int)countOf-1);
                }
                else
                {
                    nums[i] = RandomNum.Next(0, (int)countOf);
                }
            }
            return nums;
        }

        private static void Crop(int[] nums)
        {
            int value = 0;
            foreach (int i in nums)
            {
                value = i * Width;
                Bitmap bitmap = image.Clone(new Rectangle(value, 0, Width, Height), PixelFormat.DontCare);
                switch (i)
                {
                    case 0: {
                            bitmap.Tag = Tags.Zero.ToString();
                            break; }
                    case 1: {
                            bitmap.Tag = Tags.One.ToString();
                            break; }
                    case 2: {
                            bitmap.Tag = Tags.Two.ToString();
                            break; }
                    case 3: {
                            bitmap.Tag = Tags.Three.ToString();
                            break; }
                    case 4: {
                            bitmap.Tag = Tags.Four.ToString();
                            break; }
                    case 5: {
                            bitmap.Tag = Tags.Five.ToString();
                            break; }
                    case 6: {
                            bitmap.Tag = Tags.Siz.ToString();
                            break; }
                    case 7: {
                            bitmap.Tag = Tags.Seven.ToString();
                            break; }
                    case 8: {
                            bitmap.Tag = Tags.Eight.ToString();
                            break; }
                    default: { break; }
                }
                Cards.Add(bitmap);
            }
        }

    }
}
