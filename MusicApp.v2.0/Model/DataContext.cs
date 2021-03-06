﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class DataContext
    {
        public static List<Artist> Artists { get;}
        public static List<Album> Albums { get; set; }
        public static List<Song> Songs { get; set; }

        static DataContext()
        {
            Artists = InitArtists();
            Albums = Artists.GetCompleteList(x => x.Albums).ToList();
            Songs = Albums.GetCompleteList(x => x.Songs).ToList();
        }

        public static List<Artist> InitArtists()
        {
            Artist prodigy = new Artist();
            prodigy.ArtistName = "The Prodigy";
            prodigy.ID = 0;
            prodigy.Albums = new List<Album>();

            Album experience = new Album();
            experience.ID = 0;
            experience.ArtistID = 0;
            experience.Name = "Experience";
            experience.ReleaseDate = new DateTime(1992, 9, 28);


            experience.Songs = new List<Song>();

            Song song1 = new Song { Name = "Jericho", DurationInSeconds = 222, AlbumID = 0 ,ID=0};
            experience.Songs.Add(song1);
            Song song2 = new Song { Name = "Music Reach", DurationInSeconds = 252, AlbumID = 0, ID = 1 };
            experience.Songs.Add(song2);
            Song song3 = new Song { Name = "Wind It Up", DurationInSeconds = 273, AlbumID = 0, ID = 2 };
            experience.Songs.Add(song3);
            Song song4 = new Song { Name = "Your Love", DurationInSeconds = 330, AlbumID = 0, ID = 3 };
            experience.Songs.Add(song4);
            Song song5 = new Song { Name = "Hyperspeed", DurationInSeconds = 316, AlbumID = 0, ID = 4 };
            experience.Songs.Add(song5);
            Song song6 = new Song { Name = "Charly", DurationInSeconds = 312, AlbumID = 0, ID = 5 };
            experience.Songs.Add(song6);
            Song song7 = new Song { Name = "Out Of Space", DurationInSeconds = 297, AlbumID = 0, ID = 6 };
            experience.Songs.Add(song7);
            Song song8 = new Song { Name = "Everybody In The Place", DurationInSeconds = 250, AlbumID = 0, ID = 7 };
            experience.Songs.Add(song8);
            Song song9 = new Song { Name = "Weather Expirience", DurationInSeconds = 486, AlbumID = 0, ID = 8 };
            experience.Songs.Add(song9);
            Song song10 = new Song { Name = "Fire", DurationInSeconds = 297, AlbumID = 0, ID = 9 };
            experience.Songs.Add(song10);
            Song song11 = new Song { Name = "Ruff In The Jungle Bizness", DurationInSeconds = 310, AlbumID = 0, ID = 10 };
            experience.Songs.Add(song11);
            Song song12 = new Song { Name = "Death Of The Prodigy Dancers", DurationInSeconds = 223, AlbumID = 0, ID = 11 };
            experience.Songs.Add(song12);

            prodigy.Albums.Add(experience);

            Album musicForTheJiltedGeneration = new Album { Name = "Music For The Jilted Generation", ReleaseDate = new DateTime(1994, 7, 4), Songs = new List<Song>(), ID=1 };

            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "Intro", DurationInSeconds = 45 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "Break & Enter", DurationInSeconds = 504 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "Their Law", DurationInSeconds = 400 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "Full Throttle", DurationInSeconds = 302 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "Voodoo People", DurationInSeconds = 387 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "Speedway", DurationInSeconds = 536 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "The Heat(The Energy)", DurationInSeconds = 267 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "Poison", DurationInSeconds = 402 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "No Good(Start The Dance)", DurationInSeconds = 377 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "One Love", DurationInSeconds = 233 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "The Narcotic Suite: 3 Kilos", DurationInSeconds = 445 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "The Narcotic Suite: Skylined", DurationInSeconds = 356 });
            musicForTheJiltedGeneration.Songs.Add(new Song { Name = "The Narcotic Suite: Claustrophobic Sting", DurationInSeconds = 433 });

            prodigy.Albums.Add(musicForTheJiltedGeneration);

            Album theFatOfTheLand = new Album
            {
                Name = "The Fat Of The Land",
                ReleaseDate = new DateTime(1997, 6, 30),
                Songs = new List<Song> {
                    new Song {Name="Smack My Bitch Up",DurationInSeconds = 342 },
                    new Song {Name="Breathe",DurationInSeconds = 335 },
                    new Song {Name="Diesel Power",DurationInSeconds = 257 },
                    new Song {Name="Funky Shit",DurationInSeconds = 316 },
                    new Song {Name="Serial Thrilla",DurationInSeconds = 311 },
                    new Song {Name="Mindfields",DurationInSeconds = 340 },
                    new Song {Name="Narayan",DurationInSeconds = 545 },
                    new Song {Name="Firestarter",DurationInSeconds = 280 },
                    new Song {Name="Climbatize",DurationInSeconds = 398 },
                    new Song {Name="Fuel My Fire",DurationInSeconds = 259 }
                }
            };

            prodigy.Albums.Add(theFatOfTheLand);


            Artist nirvana = new Artist
            {
                ArtistName = "Nirvana",
                Albums = new List<Album>
                    {
                    new Album
                        {
                        Name = "Bleach",
                        ReleaseDate = new DateTime(1989,6,15),
                        Songs = new List<Song>
                        {
                            new Song {Name = "Blew", DurationInSeconds = 175 },
                            new Song {Name = "Floyd The Barber", DurationInSeconds = 138 },
                            new Song {Name = "About A Girl", DurationInSeconds = 168 },
                            new Song {Name = "School", DurationInSeconds = 162 },
                            new Song {Name = "Love Buzz", DurationInSeconds = 215 },
                            new Song {Name = "Paper Cuts", DurationInSeconds = 246 },
                            new Song {Name = "Negative Creep", DurationInSeconds = 174 },
                            new Song {Name = "Scoff", DurationInSeconds = 250 },
                            new Song {Name = "Swap Meet", DurationInSeconds = 183 },
                            new Song {Name = "Mr Moustache", DurationInSeconds = 204 },
                            new Song {Name = "Sifting", DurationInSeconds = 322 },
                            new Song {Name = "Big Cheese", DurationInSeconds = 222 },
                            new Song {Name = "Downer", DurationInSeconds = 103 }
                        }
                    },
                    new Album
                    {
                        Name = "Nevermind",
                        ReleaseDate = new DateTime(1991,9,24),
                        Songs = new List<Song>
                        {
                            new Song {Name="Smells Like Teen Spirit", DurationInSeconds=301 },
                            new Song {Name="In Bloom", DurationInSeconds=254 },
                            new Song {Name="Come As You Are", DurationInSeconds=219 },
                            new Song {Name="Breed", DurationInSeconds=183 },
                            new Song {Name="Lithium", DurationInSeconds=257 },
                            new Song {Name="Polly", DurationInSeconds=177 },
                            new Song {Name="Territorial Pissings", DurationInSeconds=142 },
                            new Song {Name="Drain You", DurationInSeconds=223 },
                            new Song {Name="Lounge Act", DurationInSeconds=156 },
                            new Song {Name="Stay Away", DurationInSeconds=212 },
                            new Song {Name="On A Plain", DurationInSeconds=196 },
                            new Song {Name="Something In The Way", DurationInSeconds=1235 }

                        }
                    },
                    new Album
                    {
                        Name = "In Utero",
                        ReleaseDate = new DateTime(1993,9,21),
                        Songs = new List<Song>
                        {
                            new Song {Name = "Serve The Servants", DurationInSeconds = 216 },
                            new Song {Name = "Scentless Apprentice", DurationInSeconds = 228 },
                            new Song {Name = "Heart-Shaped Box", DurationInSeconds = 281 },
                            new Song {Name = "Rape Me", DurationInSeconds = 170 },
                            new Song {Name = "Frances Farmer Will Have Her Revenge On Seattle", DurationInSeconds = 249 },
                            new Song {Name = "Dumb", DurationInSeconds = 152 },
                            new Song {Name = "Very Ape", DurationInSeconds = 114 },
                            new Song {Name = "Milk It", DurationInSeconds = 235 },
                            new Song {Name = "Pennyroal Tea", DurationInSeconds = 217 },
                            new Song {Name = "Radio Friendly Unit Shifter", DurationInSeconds = 291 },
                            new Song {Name = "Tourette's", DurationInSeconds = 95 },
                            new Song {Name = "All Apologies", DurationInSeconds = 231 }
                        }
                    }
                }
            };

            Artist tool = new Artist
            {
                ArtistName = "Tool",

                Albums = new List<Album>
                {
                    new Album
                    {
                        Name = "Undertow",
                        ReleaseDate = new DateTime(1993,4,6),
                        Songs = new List<Song>

                            {
                                new Song {Name = "Intolerance", DurationInSeconds=296 },
                                new Song {Name = "Prison Sex", DurationInSeconds=294 },
                                new Song {Name = "Sober", DurationInSeconds=306 },
                                new Song {Name = "Bottom", DurationInSeconds=434 },
                                new Song {Name = "Crawl Away", DurationInSeconds=329 },
                                new Song {Name = "Swamp Song", DurationInSeconds=322 },
                                new Song {Name = "Undertow", DurationInSeconds=363 },
                                new Song {Name = "4 Degrees", DurationInSeconds=363 },
                                new Song {Name = "Flood", DurationInSeconds=465 },
                                new Song {Name = "Disgustipated", DurationInSeconds=947 }

                            }
                        },
                        new Album
                        {
                            Name = "Lateralus",
                            ReleaseDate = new DateTime(2001,5,15),
                            Songs = new List<Song>
                            {
                                new Song {Name = "The Grudge", DurationInSeconds =  516},
                                new Song {Name = "Eon Blue Apocalypse", DurationInSeconds =  64},
                                new Song {Name = "The Patient", DurationInSeconds =  433},
                                new Song {Name = "Mantra", DurationInSeconds =  72},
                                new Song {Name = "Schism", DurationInSeconds =  407},
                                new Song {Name = "Parabol", DurationInSeconds =  184},
                                new Song {Name = "Parabola", DurationInSeconds =  363},
                                new Song {Name = "Ticks And Leeches", DurationInSeconds =  490},
                                new Song {Name = "Lateralus", DurationInSeconds =  474},
                                new Song {Name = "Disposition", DurationInSeconds =  286},
                                new Song {Name = "Reflection", DurationInSeconds =  667},
                                new Song {Name = "Triad", DurationInSeconds =  496},
                                new Song {Name = "Faaip De Oiad", DurationInSeconds =  159}
                            }
                        },
                        new Album
                        {
                            Name = "10,000 Days",
                            ReleaseDate = new DateTime(2006,5,2),
                            Songs = new List<Song>
                            {
                                new Song {Name = "Vicarious", DurationInSeconds = 426 },
                                new Song {Name = "Jambi", DurationInSeconds = 448 },
                                new Song {Name = "Wings for Marie (Pt 1)", DurationInSeconds = 371 },
                                new Song {Name = "10,000 Days (Wings Pt 2)", DurationInSeconds = 674 },
                                new Song {Name = "The Pot", DurationInSeconds = 382 },
                                new Song {Name = "Lipan Conjuring", DurationInSeconds = 71 },
                                new Song {Name = "Lost Keys (Blame Hofmann)", DurationInSeconds = 226 },
                                new Song {Name = "Rosetta Stoned"  , DurationInSeconds = 671 },
                                new Song {Name = "Intension", DurationInSeconds = 441 },
                                new Song {Name = "Right In Two", DurationInSeconds = 445 },
                                new Song {Name = "Viginti Trees", DurationInSeconds = 302 }


                            }
                        }

                    }
            };

            List<Artist> listOfArtists = new List<Artist> { prodigy, nirvana, tool };
            return listOfArtists;
        }

    }
}
