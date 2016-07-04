using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockWithMeno
{
    public class MyEvent
    {
        private DateTime DateAndTime;
        private string Message;
        private bool Active;

        public MyEvent(DateTime DateAndTime, string Message)
        {
            this.DateAndTime = DateAndTime;
            this.Message = Message;
            this.Active = true;
        }

        public DateTime GetDateAndTime() { return this.DateAndTime; }
        public string GetMessage() { return this.Message; }
        public bool IsActive() { return this.Active; }

        public void SetDateAndTime(DateTime DateAndTime) { this.DateAndTime = DateAndTime; }
        public void SetMessage(string Message) { this.Message = Message; }
        public void SetActive(bool State) { this.Active = State; }
    }

    public class SoundUtl
    {
        public System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        public MyEvent[] Events = new MyEvent[10];
        public short count = 0;

        public int getActiveCount()
        {
            int con = 0;
            for (int i = 0; i < count; i++)
                if (Events[i].IsActive())
                    con = con + 1;
            return con;
        }
        public void playsound()
        {
            sp.SoundLocation = (System.IO.Directory.GetCurrentDirectory() + @"\alarm_clock.wav");
            sp.Play();
        }
        public void sort()
        {
            for (int j = 0; j < count; j++)
                for (int i = 0; i < count - 1; i++)
                {
                    if (Events[i].IsActive() == false || Events[i].GetDateAndTime() > Events[i + 1].GetDateAndTime())
                    {
                        if (Events[i + 1].IsActive())
                        {
                            MyEvent tmp = Events[i];
                            Events[i] = Events[i + 1];
                            Events[i + 1] = tmp;
                        }
                    }
                }
        }
    }
}
