using System;
namespace Command
{
    public class Receiver
    {
        public string Content { get; set; }

        public Receiver()
        {
            Content = nameof(Receiver);
        }

        public void Play()
        {
            Console.WriteLine("Command executed!");
        }

        public void MakeBold()
        {
            Content = $"<b>{Content}<b>";
        }
    }
}
