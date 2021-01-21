using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using HtmlAgilityPack;
using System.Net;

namespace MangaKaDownloader
{
    class comicextra
    {
        public static void comicDown(string url, string path)
        {
            //https://www.comicextra.com/invincible-iron-man-2015/chapter-14

            if (url.Substring(url.Length - 5) != "/full")
            {
                url = (url + "/full");
            }


            HtmlAgilityPack.HtmlWeb hw = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = hw.Load(url);
            List<string> linky = new List<string>();



            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//img[@class='chapter_img']"))
            {
                //string.Empty
                string hrefValue = link.GetAttributeValue("src", "");

                linky.Add(hrefValue);
                //System.Threading.Thread.Sleep(100);
            }
            foreach (var item in linky)
            {
                Console.WriteLine(item);
            }

            string refer = "referer: https://www.comicextra.com/invincible-iron-man-2015/chapter-14/full";
            string FolderName = url.Substring(url.Length - 15);

            downloadFunctions.Download(linky, path, refer, FolderName);

        }
    }
}
