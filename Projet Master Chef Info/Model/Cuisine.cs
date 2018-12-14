using System;
namespace Model {
    class Cuisine : ActorFactory

    {
        public override FixedActor CreateFixedActor()
        {
            return new cooker();
        }
        public override MobileActor CreateMobileActor()
        {
            return new waiter();
        }
    }

}
