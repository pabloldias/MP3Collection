using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.IO;
using System.Xml.Serialization;

namespace MP3Collection
{
    class AlbumController
    {
        public List<Album> albums = new List<Album>();

        private List<Album> albumsFromDir = new List<Album>();
        private string xmlFile = "";

        public AlbumController() { }

        public AlbumController(string XMLFile) 
        {
            xmlFile = XMLFile;
        }

        public List<Album> getList()
        {
            return albums;
        }

        public List<Album> getListFromDir(string dir, string dvd)
        {
            albumsFromDir.Clear();
            albumsFromDir = getFolders(dir, dvd);
            return albumsFromDir;
        }

        public void mergeLists()
        {
            foreach (Album a in albumsFromDir) 
            {
                albums.Add(a);
            }
        }

        public int getCount()
        {
            return albums.Count;
        }

        private static int compareAlbums(Album x, Album y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    int compareArtistName = x.ArtistName.CompareTo(y.ArtistName);
                    if (compareArtistName != 0)
                    {
                        return compareArtistName;
                    }
                    else
                    {
                        return x.AlbumName.CompareTo(y.AlbumName);
                    }                    
                }
            }
        }


        public void serialize()
        {
            XmlRootAttribute root = new XmlRootAttribute("albuns");
            XmlSerializer serializer =
              new XmlSerializer(typeof(List<Album>), root);
            TextWriter textWriter = new StreamWriter(xmlFile);
            serializer.Serialize(textWriter, albums);
            textWriter.Close();
        }

        public void deserialize()
        {
            XmlRootAttribute root = new XmlRootAttribute("albuns");
            XmlSerializer deserializer =
               new XmlSerializer(typeof(List<Album>), root);
            TextReader textReader = new StreamReader(xmlFile);
            albums = (List<Album>)deserializer.Deserialize(textReader);
            textReader.Close();

            albums.Sort(compareAlbums);
        }

        public List<Album> filterAlbums(string filterText, int filterType)
        {
            if (filterText != "")
            {
                switch (filterType)
                {
                    case 0:
                        return albums.FindAll(delegate(Album album) { 
                            return album.ArtistName.IndexOf(filterText, StringComparison.InvariantCultureIgnoreCase) >= 0; 
                        });
                    case 1:
                        return albums.FindAll(delegate(Album album) {
                            return album.AlbumName.IndexOf(filterText, StringComparison.InvariantCultureIgnoreCase) >= 0;  
                        });
                    case 2:
                        return albums.FindAll(delegate(Album album) {
                            return album.DVD.IndexOf(filterText, StringComparison.InvariantCultureIgnoreCase) >= 0;  
                        });
                    default:
                        return albums;
                }
                
            }
            else
            {
                return albums;
            }
        }

        private List<Album> getFolders(string path, string dvd)
        {
            List<Album> albums = new List<Album>();
            try
            {
                foreach (string d in Directory.GetDirectories(path))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(d);
                    foreach (string subDir in Directory.GetDirectories(dirInfo.FullName))
                    {
                        DirectoryInfo subDirInfo = new DirectoryInfo(subDir);
                        Album album = new Album();
                        album.ArtistName = dirInfo.Name;
                        album.AlbumName = subDirInfo.Name;
                        album.DVD = dvd;
                        albums.Add(album);
                    }
                }                
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return albums;
        }
    }
}
