using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Vorbis;

namespace Blenderv2
{
    public class ProjectTrack
    {
        public int trackID;
        public AudioFileReader audio;
        public string filename, filepath, tempFilepath;
        public bool markedForEdit = false;
        public float pitch = 1.0f;
        
        public ProjectTrack()
        {

        }

    }
}