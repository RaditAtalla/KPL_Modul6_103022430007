using System;
using System.Collections.Generic;
using System.Text;

namespace Modul6_103022430007
{
    public class SayaMusicTrack
    {
        private int id;
        public string title;
        private int playCount;

        public SayaMusicTrack(string title)
        {
            this.title = title;
            this.playCount = 0;

            Random ran = new Random();
            this.id = ran.Next(10000, 99999);
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("[id]" + id + " [title]" + title + " [playCount]" + playCount);
        }

        public int GetPlayCount()
        {
            return playCount;
        }
    }
}
