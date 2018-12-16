using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Salle : ActorFactory

    {
        public override FixedActor CreateFixedActor()
        {
            return new Maitrehotel();
        }
        public override MobileActor CreateMobileActor()
        {
            return new waiter();
        }
		public override FixedActor CreateTable()
		{
			return new Table();
		}
    }
}
