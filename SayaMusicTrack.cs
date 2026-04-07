using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            try
            {
                Debug.Assert(title != null);
                Debug.Assert(title.Length < 200, "Max title length is 200");

                this.title = title;
                this.playCount = 0;

                Random ran = new Random();
                this.id = ran.Next(10000, 99999);
            }
            catch
            {
                Console.WriteLine("Title length: min. 0 max. 200");
            }
        }

        public void IncreasePlayCount(int count)
        {
            try
            {
                Debug.Assert(count >= 0);
                Debug.Assert(count <= 25000000);

                checked { this.playCount += count; }

                playCount += checked(count);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Max playcount for this song has been exceeded");
            }
            catch
            {
                Console.WriteLine("Playcount: min. 0 max 25.000.000");
            }
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
