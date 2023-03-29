using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213026
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(String Username)
        {
            this.Username = Username;
            Random rnd = new Random();
            id = rnd.Next();
            uploadedVideos = new List<SayaTubeVideo>();

        }

        public int GetTotalVideoPlayCount()
        {
            int jum = 0;
            foreach (SayaTubeVideo video in uploadedVideos) ;
            return jum ;
        }

        public void AddVideo(SayaTubeVideo video) { 
            
            uploadedVideos.Add(video);  
        }

        public void PrintAllVideoPlaycount() {
            for (int i = 0; i < uploadedVideos.Count || i< 8; i++) { 

                Console.WriteLine("Video "+ (i+1) + "judul "+ uploadedVideos[i].title + "count" + uploadedVideos[i].getPlayCount());
            }
        }





    }
}
