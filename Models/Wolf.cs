using Microsoft.Xna.Framework;
using System;
namespace krydge{
    public class Wolf:GameObj{
        public bool HearsBaby;
        public bool SeeCandle;
        public Wolf(Vector2 _pos)
        {
            this.setPostion(_pos);
        }

        public bool SeesCandle(Mother mother){
            if(Math.Abs(getPosition().Y-mother.getPosition().Y)<10){

            }

        }

    }
}