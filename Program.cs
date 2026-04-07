using Modul6_103022430007;

SayaMusicUser user1 = new SayaMusicUser("radit.rchmd");
SayaMusicTrack track1 = new SayaMusicTrack("Himne Institut Teknologi Sepuluh Nopember");
SayaMusicTrack track2 = new SayaMusicTrack("Jingle Gerigi ITS 2025");
SayaMusicTrack track3 = new SayaMusicTrack("Can't Stop");
SayaMusicTrack track4 = new SayaMusicTrack("Terbuang Dalam Waktu");
SayaMusicTrack track5 = new SayaMusicTrack("Kita");
SayaMusicTrack track6 = new SayaMusicTrack("Dan");
SayaMusicTrack track7 = new SayaMusicTrack("Terlintas di Kepala");
SayaMusicTrack track8 = new SayaMusicTrack("Breed");
SayaMusicTrack track9 = new SayaMusicTrack("Enter Sandman");
SayaMusicTrack track10 = new SayaMusicTrack("Minggu");

track1.IncreasePlayCount(10);
track2.IncreasePlayCount(43);
track3.IncreasePlayCount(65);
track4.IncreasePlayCount(12);
track5.IncreasePlayCount(90);
track6.IncreasePlayCount(45);
track7.IncreasePlayCount(76);
track8.IncreasePlayCount(12);
track9.IncreasePlayCount(76);
track10.IncreasePlayCount(98);

user1.AddTrack(track1);
user1.AddTrack(track2);
user1.AddTrack(track3);
user1.AddTrack(track4);
user1.AddTrack(track5);
user1.AddTrack(track6);
user1.AddTrack(track7);
user1.AddTrack(track8);
user1.AddTrack(track9);
user1.AddTrack(track10);

user1.PrintAllTracks();
Console.WriteLine("Total Play Count: " + user1.GetTotalPlayCount());
