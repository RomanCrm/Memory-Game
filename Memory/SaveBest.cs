using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Memory
{
    class SaveBest
    {
        private static string path = "bestScore.xml";

        public static string Path
        {
            get { return path; }
        }

        public static void Save(Game game, Label labelBT, Label labelBS)
        {
            if (labelBT.Text != null && labelBS.Text != null)
            {
                TimeSpan prevTime = TimeSpan.Parse(labelBT.Text);
                TimeSpan curTime = TimeSpan.Parse(game.Time);
                if (curTime < prevTime)
                {
                    game.Time = curTime.ToString();
                }
                if (game.Scores > int.Parse(labelBS.Text))
                {
                    game.Scores = int.Parse(labelBS.Text);
                }
            }
            XmlSerializer serializer = new XmlSerializer(typeof(Game));
            if (File.Exists(Path))
            {
                using (Stream stream = new FileStream(Path, FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, game);
                }
            }
            else
            {
                using (Stream stream = new FileStream(Path, FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, game);
                }
            }
        }

        public static Game Open()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Game));
            Game game = new Game();
            if (File.Exists(Path))
            {
                using (Stream stream = new FileStream(Path, FileMode.Open, FileAccess.Read))
                {
                    game = serializer.Deserialize(stream) as Game;
                }
            }
            return game;
        }
    }
}
