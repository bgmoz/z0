using System;

namespace z0
{
    class Program
    {
       static void Main()
        {
            MedioPlayer medioPlayer = new MedioPlayer();
            medioPlayer.PlayFile(new Play());
        }
    }

    class MedioPlayer : Functions
    { 
        public string MedioFileName { get; set; }
        public string MedioFileTupe { get; set; }
        public string ListName { get; set; }

        public void PlayFile(Play play)
        {
            play.PlayFile(MedioFileTupe);
        }
        void Functions.Poisk(string MedioFile)
        { }
        void Functions.CreateList(string ListName)
        { }
        void Functions.AddItemInList(string MedioFile)
        { }
        void Functions.DelItemInList(string MedioFile)
        { }
        void Functions.ShowList(string ListName)
        { }

        
    }
    interface Functions 
    { 
        void Poisk(string MedioFile)
        { }
        void CreateList(string ListName)
        { }
        void AddItemInList(string MedioFile)
        { }
        void DelItemInList(string MedioFile)
        { }
        void ShowList(string ListName)
        { }


    }

    class Play
    {
        public virtual void PlayFile(string MedioFileTupe)
        { 

        }
    }
    class Mp3 : Play
    {
        public override void PlayFile(string MedioFileTupe)
        {
       
        }
    }
    class Mp4 : Play
    {
        public override void PlayFile(string MedioFileTupe)
        {

        }
    }
    class Photo : Play
    {
        public override void PlayFile(string MedioFileTupe)
        {
   
        }
    }

}
