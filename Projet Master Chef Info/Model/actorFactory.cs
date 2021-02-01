using System;
namespace Model {
    abstract class ActorFactory

    {
        public abstract FixedActor CreateFixedActor();
		public abstract FixedActor CreateTable();
        public abstract MobileActor CreateMobileActor();
    }

}

}
