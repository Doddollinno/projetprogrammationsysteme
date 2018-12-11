using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Cette classe mettra de determiner la position d'un personnage, et d'un objet. Modifier si nécéssire */

namespace Model
    {
        public class Position
        {
            private int m_x;
            public int x
            {
                get { return m_x; }
                set { m_x = value; }
            }

            private int m_y;
            public int y
            {
                get { return m_y; }
                set { m_y = value; }
            }

            public Position(int x, int y)
            {
                this.m_x = x;
                this.m_y = y;
            }
            
            public void move(PictureBox personnage1, PictureBox pictureBox547 )
        {
            if (personnage1.Location.X < pictureBox547.Location.X)
            {
                personnage1.Left += 2;

            }
            else if (personnage1.Location.X > pictureBox547.Location.X)
            {
                personnage1.Left -= 2;
            }
            if (personnage1.Location.Y < pictureBox547.Location.Y)
            {
                personnage1.Top += 2;

            }
            else if (personnage1.Location.Y > pictureBox547.Location.Y)
            {
                personnage1.Top -= 2;
            }
        }
        */
        }
    }









