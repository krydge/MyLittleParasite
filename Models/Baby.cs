using Microsoft.Xna.Framework;

namespace krydge{
    public class Baby:GameObj{
        private bool isHeld;
        private bool isCrying;
        private int healthPoints;
        public Baby(Vector2 _pos)
        {
            this.setPostion(_pos);
            this.isHeld=false;
            this.isCrying=true;
            this.healthPoints=30;
        }

    }
}