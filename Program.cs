using Modul6_103022430007;

SayaMusicUser user1 = new SayaMusicUser("radit.rchmd");
SayaMusicTrack track1 = new SayaMusicTrack("Minggu");
SayaMusicTrack track2 = new SayaMusicTrack("Disarankan di Bandung");

track1.IncreasePlayCount(60);
track2.IncreasePlayCount(7);

user1.AddTrack(track1);
user1.AddTrack(track2);

user1.PrintAllTracks();
Console.WriteLine("Total Play Count: " + user1.GetTotalPlayCount());