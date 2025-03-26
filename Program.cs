using System;
using System.IO;
using System.Net;

public class Program
{
    public static void Main()
    {
        Console.Title = "DirectMediaDownloader | Made by https://github.com/ZygoteCode/";
        byte[] data = null;
        
        while (true)
        {
            try
            {
                Console.Write("Please, insert the valid URI of the media to download here > ");
                string URI = Console.ReadLine();
                Console.WriteLine("Trying download, please wait a while.");
                
                using (WebClient webClient = new WebClient())
                {
                    data = webClient.DownloadData(URI);
                }

                Console.WriteLine("Media content succesfully downloaded!");
                break;
            }
            catch
            {
                Console.WriteLine("Failed to download content. Please, try again inserting a valid URI.");
            }
        }

        Console.Write("Name of the file to save (example: \"hello.png\") > ");
        File.WriteAllBytes(Console.ReadLine(), data);
        Console.WriteLine("File succesfully saved!");
        Console.WriteLine("Press ENTER in order to exit from the program.");
        Console.ReadLine();
    }
}
