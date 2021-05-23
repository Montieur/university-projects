using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Filmowiec
{

    public class Video
    {

        TagLib.File tagFile;
        public TimeSpan duration;
        
        public string pathToFile, title, codec;
        public int width, height;
        public long size;
        

        public Video(string filePath)
        {

            pathToFile = filePath;
            tagFile = TagLib.File.Create(filePath);

            foreach (var item in tagFile.Properties.Codecs)
                codec += item.Description + "\r\n";

            duration = tagFile.Properties.Duration;
            width = tagFile.Properties.VideoWidth;
            height = tagFile.Properties.VideoHeight;
            size = new System.IO.FileInfo(filePath).Length;

            if (tagFile.Tag.Title != null)
                title = tagFile.Tag.Title;
            else
                title = tagFile.Name.Remove(0, tagFile.Name.LastIndexOf('\\') + 1);            
        }

    }

}
