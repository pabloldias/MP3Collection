using System;
using System.Xml.Serialization;

[XmlType(TypeName = "album_item")]
public class Album
{
    public Album() { }

    public Album(string album, string artist, string dvd) 
    {
        AlbumName = album;
        ArtistName = artist;
        DVD = dvd;
    }

    [XmlElement("artista")]
    public string ArtistName { get; set; }
    
    [XmlElement("album")]
    public string AlbumName { get; set; }    

    [XmlElement("dvd")]
    public string DVD { get; set; }
}