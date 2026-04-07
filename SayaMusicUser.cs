using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(username != null);
            Debug.Assert(username.Length <= 100);

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
            Debug.Assert(track != null);
            Debug.Assert(track.GetPlayCount() < int.MaxValue);

            uploadedTracks.Add(track);
        }

        public void PrintAllTracks()
        {
            Console.WriteLine("User: " + username);

            int shownNum = uploadedTracks.Count > 8 ? 8 : uploadedTracks.Count;

            for (int i = 0; i < shownNum; i++)
            {
                Console.WriteLine("Track " + (i+1) + " judul: " + uploadedTracks[i].title);
            }
        }
    }
}
