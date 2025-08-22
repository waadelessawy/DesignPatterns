using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns
{

    //example=> Protection

    //Old Code
   public interface IInternet
    {
        void ConnectTo(string host);
    }
    //public class RealInternet : IInternet
    //{
    //    public void ConnectTo(string host)
    //    {
    //        if ("banned.com" == host)
    //        {
    //            Console.WriteLine("Access Denied!");
    //            return;
    //        }
    //        Console.WriteLine("Opened connection to " + host);
    //    }
    //}

    //The solution
    public class RealInternet : IInternet
    {
        public void ConnectTo(string host)
        {
            Console.WriteLine("Opened connection to " + host);
        }
    }

    public class ProxyInternet : IInternet
    {
        public static readonly List<string> bannedSites = new List<string>
        {
           "banned.com"
        };
        private readonly IInternet internet = new RealInternet();

        public void ConnectTo(string host)
        {
            if (bannedSites.Contains(host))
            {
                Console.WriteLine("Access Denied");
                return;
            }
            internet.ConnectTo(host);
        }
    }


    ///Another example => Speed of access & caching

    //Old code

    public class Video
    {
        private string videoName;

        public Video(string videoName)
        {
            this.videoName = videoName;
        }
    }
    public interface VideoDownloader
    {
        Video GetVideo(string videoName);
    }
    public class RealVideoDownloader : VideoDownloader
    {
        public Video GetVideo(string videoName)
        {
            Console.WriteLine("Connecting to https://www.youtube.com/");
            Console.WriteLine("Downloadin video");
            Console.WriteLine("Retrieving video Metadata");

            return new Video(videoName);



        }
    }

    //The solution

    public class proxyVideoDownloader : VideoDownloader
    {
        private readonly Dictionary<string, Video> videoCache = new Dictionary<string, Video>();
        private readonly VideoDownloader downloader = new RealVideoDownloader();

        public Video GetVideo(string videoName)
        {
            if (!videoCache.ContainsKey(videoName))
            {
                videoCache.Add(videoName, downloader.GetVideo(videoName));
            }
            return videoCache[videoName];
        }
    }
}
