﻿using Newtonsoft.Json;
using WinFormsMusic2.Models;
namespace WinFormsMusic2.Services
{
    public class MusicCatalog
    {
        private const string ArtistsFile = "C:/Users/duffi/source/repos/WinFormsMusic2/WinFormsMusic2/Data/artists.json";
        private const string AlbumsFile = "C:/Users/duffi/source/repos/WinFormsMusic2/WinFormsMusic2/Data/albums.json";
        private const string CompilationsFile = "C:/Users/duffi/source/repos/WinFormsMusic2/WinFormsMusic2/Data/compilations.json";
        private const string TracksFile = "C:/Users/duffi/source/repos/WinFormsMusic2/WinFormsMusic2/Data/tracks.json";

        public List<Artist> Artists { get; private set; }
        public List<Album> Albums { get; private set; }
        public List<Compilation> Compilations { get; private set; }
        public List<Track> Tracks { get; private set; }

        public MusicCatalog()
        {
            LoadData();
        }

        private void LoadData()
        {
            Artists = LoadFromFile<Artist>(ArtistsFile);
            Albums = LoadFromFile<Album>(AlbumsFile);
            Compilations = LoadFromFile<Compilation>(CompilationsFile);
            Tracks = LoadFromFile<Track>(TracksFile);
           
        }

        private List<T> LoadFromFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<T>();
            }
            var jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<T>>(jsonData) ?? new List<T>();
        }

        public void SaveToFile<T>(string filePath, List<T> data)
        {
            var jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
        public void SaveTracks()
        {
            SaveToFile(TracksFile, Tracks);
        }
        public void SaveCompilations()
        {
            SaveToFile(CompilationsFile, Compilations);
        }
        public void AddArtist(Artist artist)
        {
            artist.Id = Artists.Count + 1;
            Artists.Add(artist);
            SaveToFile(ArtistsFile, Artists);
        }

        public void AddAlbum(Album album)
        {
            album.Id = Albums.Count + 1;
            Albums.Add(album);
            SaveToFile(AlbumsFile, Albums);
        }

        public void AddCompilation(Compilation compilation)
        {
            compilation.Id = Compilations.Count + 1;
            compilation.TrackIds = compilation.Tracks.Select(t => t.Id).ToList(); 
            Compilations.Add(compilation);
            SaveToFile(CompilationsFile, Compilations);
        }

        public void AddTrack(WinFormsMusic2.Models.Track track)
        {
            track.Id = Tracks.Count + 1;
            Tracks.Add(track);
            SaveToFile(TracksFile, Tracks);
        }

    }
}
