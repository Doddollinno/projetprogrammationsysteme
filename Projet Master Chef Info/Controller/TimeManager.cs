using System;

namespace Controller {

	public class TimeManager {

        public delegate void MyDel();

		public int Heure { get; set; }
        public int Minute { get; set; }
        public int Seconde { get; set; }
        public int Jour { get; set; }
        public int Semaine { get; set; }

        public TimeManager()
        {
            Seconde = Minute = Heure = Jour = Semaine = 0;
            NextMinute = NextMinuteTime;
            NextHeure = NextHeureTime;
            NextDay = NextDayTime;
            NextSemaine = NextWeekTime;

        }

        public void Forward()
        {
            if (Seconde++ >= 60)
            {
                Seconde = 0;
                NextMinute();
            }
        }

        public void NextMinuteTime()
        {

                if (Minute++ >= 60)
                {
                    Minute = 0;
                    NextHeure();
                }
        }

        public void NextHeureTime()
        {
            if (Heure++ >= 24)
            {
                Heure = 0;
                NextDay();
                ClosedToStaff();
            }

            switch (Heure)
            {
                case 10:
                    OpenedToStaff();
                    break;

                case 12:
                    OpenedToClient();
                    break;

                case 15:
                    ClosedToClient();
                    break;

                case 17:
                    NewTeam();
                    break;

                case 19:
                    OpenedToClient();
                    break;

                case 22:
                    ClosedToClient();
                    break;

            }
        }

        public void NextDayTime()
        {
            if (Jour++ >= 7)
            {
                Jour = 0;
                NextSemaine();
            }
        }

        public void NextWeekTime()
        {
            Semaine++;
        }



        event MyDel NextDay;
        event MyDel OpenedToStaff;
        event MyDel ClosedToStaff;
        event MyDel OpenedToClient;
        event MyDel ClosedToClient;
        event MyDel NextMinute;
        event MyDel NextHeure;
        event MyDel NextSemaine;
        event MyDel NewTeam;

    }

}
