using System;
namespace Model {
    class Cuisine : ActorFactory

    {
        public override FixedActor CreateFixedActor()
        {
            return new Chiefcooker();
        }
        public override MobileActor CreateMobileActor()
        {
            return new Cooker();
        }
    }

}
