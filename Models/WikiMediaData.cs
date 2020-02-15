using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BionicWars.Models
{
    public class WikiMediaData
    {
        public string revision { get; set; }
        public string tid { get; set; }
        public List<Item> items { get; set; }
    }
    public class Srcset
    {
        public string src { get; set; }
        public string scale { get; set; }
    }

    public class Titles
    {
        public string canonical { get; set; }
        public string normalized { get; set; }
        public string display { get; set; }
    }

    public class Thumbnail
    {
        public string source { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string mime { get; set; }
    }

    public class Original
    {
        public string source { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string mime { get; set; }
    }

    public class Artist
    {
        public string html { get; set; }
        public string text { get; set; }
    }

    public class Credit
    {
        public string html { get; set; }
        public string text { get; set; }
    }

    public class License
    {
        public string type { get; set; }
        public string url { get; set; }
        public string code { get; set; }
    }

    public class Description
    {
        public string html { get; set; }
        public string text { get; set; }
        public string lang { get; set; }
    }

    public class Captions
    {
    }

    public class Structured
    {
        public Captions captions { get; set; }
    }

    public class Caption
    {
        public string html { get; set; }
        public string text { get; set; }
    }

    public class Item
    {
        public int section_id { get; set; }
        public string type { get; set; }
        public bool showInGallery { get; set; }
        public List<Srcset> srcset { get; set; }
        public Titles titles { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Original original { get; set; }
        public string file_page { get; set; }
        public Artist artist { get; set; }
        public Credit credit { get; set; }
        public License license { get; set; }
        public Description description { get; set; }
        public Structured structured { get; set; }
        public Caption caption { get; set; }
        public string wb_entity_id { get; set; }
    }


}
