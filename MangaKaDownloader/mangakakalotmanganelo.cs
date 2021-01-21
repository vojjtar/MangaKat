using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.Net.Http;
using HtmlAgilityPack;
using System.IO;

using System.Windows.Forms;

namespace MangaKaDownloader
{
    class mangakakalotmanganelo
    {
        public static int downSpeed = 3000;


        //function for downloading manga chapters from mangakakalot and manganelo
        public static void mangaKakalotManganelo(string url, string path, string element, string elemntEqual)
        {
            // very lazy check
            if (Form1.singleChapterDown == true)
            {
                singleChap(url, path, element, elemntEqual);
            }
            else
            {
                wholeManga(url, path, element, elemntEqual);
            }
        }

        public static async void singleChap(string url, string path, string element, string elemntEqual)
        {
            //try
            //{
                //refer needed to access the site's <HTML>
                string refer = "referer: https://mangakakalot.com/chapter/ro920198/chapter_5";

                //in this case the last 10 characters in the link are the number of the chapter
                string FolderName = url.Substring(url.Length - 10);

                //creating new httpclient
                var httpsClient = new HttpClient();
                //requesting <HTML>
                var html = await httpsClient.GetStringAsync(url);

                //loading the <HTML> with 'HtmlAgilityPack'
                var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(html);

                //searching for the chapter images using 'HtmlAgilityPack'
                //here element means the id/class of the div in which all the images are stored
                //elementEqual is the name of the id/class
                var imagesHTML = htmlDocument.DocumentNode.Descendants("div")
                    .Where(node => node.GetAttributeValue(element, "")
                    .Equals(elemntEqual)).ToList();

                string allLinks = Convert.ToString(imagesHTML[0].OuterHtml);

                List<string> linky = new List<string>();
                string link;

                htmlDocument.LoadHtml(allLinks);


                foreach (HtmlAgilityPack.HtmlNode node in htmlDocument.DocumentNode.SelectNodes("//img"))
                {
                    link = node.Attributes["src"].Value;
                    linky.Add(link);
                }

                downloadFunctions.Download(linky, path, refer, FolderName);
            //}
            /*catch (Exception)
            {
                //warns the user about bad url
                Form1.pathWarn();
            }*/
        }

        public static async void wholeManga(string url, string path, string element, string elemntEqual)
        {
            
            string elemntEqualLocal;
            if (url.Split('.')[0] == "https://manganelo")
            {
                elemntEqualLocal = "panel-story-chapter-list";
            }
            else
            {
                elemntEqualLocal = "chapter-list";
            }

            var httpsClient = new HttpClient();

            var html = await httpsClient.GetStringAsync(url);


            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var imagesHTML = htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals(elemntEqualLocal)).ToList();

            string htmlLinks = Convert.ToString(imagesHTML[0].OuterHtml);

            htmlDocument.LoadHtml(htmlLinks);
            List<string> linky = new List<string>();




            string link;
            foreach (HtmlAgilityPack.HtmlNode node in htmlDocument.DocumentNode.SelectNodes("//a"))
            {
                link = node.Attributes["href"].Value;
                linky.Add(link);
                //Console.WriteLine(link);
            }

            // reversing the list so it starts downloading from index 0
            linky.Reverse();

            string title = "Warning";
            string message = $"You are about to download {linky.Count} chapters of manga." +
                " Are you sure you want to proceed?" +
                " The length of this process mainly depends on your download speed." +
                " If you decide that you dont want to continue downloading you can just exit the application.";

            DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Directory.CreateDirectory(path + "\\" + (url.Substring(url.Length - 5)));
                path = path + "\\" + (url.Substring(url.Length - 4));

                foreach (var chapter in linky)
                {
                    singleChap(chapter, path, element, elemntEqual);
                    System.Threading.Thread.Sleep(downSpeed);
                }
            }
        }

    }
}
