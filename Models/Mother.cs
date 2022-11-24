using Microsoft.Xna.Framework;
using System;

namespace krydge
{
    public class Mother : GameObj
    {
        private bool HoldingBaby;

        private int healthPoints;
        private int energy;
        private bool holdingCandle;
        private DateTime lastUpdateHealth;

        enum MotherState{noBabyNoCandle,noBabyCandle,BabyNoCandle,BabyAndCandle,noenergy, nohealth};
        public Mother(Vector2 _pos)
        {
            this.setPostion(_pos);
            HoldingBaby = false;
            this.setxVel(0);
            this.setyVel(0);
            this.healthPoints = 50;
            this.energy = 100;
            this.holdingCandle=false;
        }

    }
}