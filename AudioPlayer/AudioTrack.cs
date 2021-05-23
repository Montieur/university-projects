using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Odtwieracz
{
    public class AudioTrack
    {

        public AudioTrack(string filePath)
        {

            pathToFile = filePath;
            tagFile = TagLib.File.Create(filePath);

            duration = tagFile.Properties.Duration;
            audioBitrate = tagFile.Properties.AudioBitrate;

            if (tagFile.Tag.Title != null) 
                title = tagFile.Tag.Title;
            else
                title = tagFile.Name.Remove(0, tagFile.Name.LastIndexOf('\\') + 1);

            if (tagFile.Tag.FirstPerformer != null)
                artist = tagFile.Tag.FirstPerformer;
            else
                artist = "---";

            if (tagFile.Tag.FirstGenre != null)
                genre = tagFile.Tag.FirstGenre;
            else
                genre = "---";

            if (tagFile.Tag.Year != 0)
                year = tagFile.Tag.Year.ToString();
            else
                year = "---";

            trackImage = new Bitmap(getImage(), new Size(90, 90));
        }

        public Image getImage()
        {

            try
            {
                var bytes = tagFile.Tag.Pictures[0].Data.Data;
                var ms = new System.IO.MemoryStream(bytes);
                return Image.FromStream(ms);
            }
            catch (Exception)
            {
                return Properties.Resources.thumbnail;
            }

        }

        

        TagLib.File tagFile;
        public TimeSpan duration;
        public Image trackImage;
        public string pathToFile;
        public string title;
        public string artist;
        public string year;
        public string genre;
        public int audioBitrate;





        

        
    }
}
