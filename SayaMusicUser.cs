using System;
using System.Collections.Generic;
using System.Text;

namespace Modul6_103022430007
{
    public class SayaMusicUser
    {
        private int id;
        public string username;
        private List<SayaMusicTrack> uploadedTracks;

        public SayaMusicUser(string username)
        {
            this.uploadedTracks = new List<SayaMusicTrack>();
            this.username = username;

            Random ran = new Random();
            this.id = ran.Next(10000, 99999);
        }

        public int GetTotalPlayCount()
        {
            int totalPlayCount = 0;

            foreach (var track in uploadedTracks)
            {
                totalPlayCount += track.GetPlayCount();
            }

            return totalPlayCount;
        }

        public void AddTrack(SayaMusicTrack track)
        {
            uploadedTracks.Add(track);
        }

        public void PrintAllTracks()
        {
            Console.WriteLine("User: " + username);

            for (int i = 0; i < uploadedTracks.Count; i++)
            {
                Console.WriteLine("Track " + (i+1) + " judul: " + uploadedTracks[i].title);
            }
        }
    }
}
