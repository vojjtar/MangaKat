using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//needed imports
using System.Text.RegularExpressions;
using System.Net.Http;
using HtmlAgilityPack;
using System.Net;
using System.IO;

namespace MangaKaDownloader
{
    class downloadFunctions
    {
        //image download function.
        //Takes in a list of all the links collected by the previous function
        //path string entered by the user, refer string that allow you to access the sites html
        //folder name string to name a new folder
        public static void Download(List<string> linky, string path, string refer, string FolderName)
        {
            //checks the last three characters in the first link in 'linky' to determine the image format
            var koncovkaCheck = linky[0].Substring(linky[0].Length - 3);
            string koncovka;

            //checks some common image formats
            switch (koncovkaCheck)
            {
                case "png":
                    koncovka = ".png";
                    break;
                case "jpg":
                    koncovka = ".jpg";
                    break;
                case "peg":
                    koncovka = ".jpeg";
                    break;
                default:
                    koncovka = ".jpg";
                    break;
            }
            

            //removes double \ from the path string > then converts it to string (just to be sure?)
            path = path.Replace(@"\\", @"\");
            path = Convert.ToString(path);

            //creates an empty directory with the folder name passed in earlier
            Directory.CreateDirectory(path + "\\" + FolderName);

            //will be used as final path in the next step
            string finalPath;

            //creating new web client named client
            using (WebClient client = new WebClient())
            {
                //loops for all the elements (image links) in the list 'linky'
                for (int i = 0; i < linky.Count; i++)
                {
                    //adding needed headers / credentials
                    client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    client.Headers.Add("User-Agent: Mozilla/ 5.0(Windows NT 10.0; Win64; x64; rv: 79.0) Gecko/20100101 Firefox/79.0");
                    client.Headers.Add(refer);
                    client.Headers.Add("Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");

                    //awkwardly naming the 
                    finalPath = ($"{path}\\{FolderName}\\" + i + koncovka);
                    
                    //downloads each image link and saves it to the final path
                    client.DownloadFile(linky[i], finalPath);

                    //sleeps for a while so it's not spamming the site with requests
                    //System.Threading.Thread.Sleep(downSpeed);
                    //this was moved
                }

            }
        }
    }
}
