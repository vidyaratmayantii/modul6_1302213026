using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213026
{
    internal class SayaTubeVideo
    {
        private int id;
        public string title;
        private int playCount;


        public SayaTubeVideo(string title) { 
            this.title = title;
            Random rnd = new Random();
            id = rnd.Next();
            playCount = 0;
        }

        public int getPlayCount() { return playCount; }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount = this.playCount+playCount;
        }

        public void PrintVideoDetail() { 
            Console.WriteLine("id: "+ id);
            Console.WriteLine("title:" + title);
            Console.WriteLine("play count:" + playCount);
        }
    }
}
