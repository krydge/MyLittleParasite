using Microsoft.Xna.Framework;

namespace krydge
{
    public class GameObj
    {
        private Vector2 position;
        private float xVel;
        private float yVel;
        public void setPostion(Vector2 _pos)
        {
            position = _pos;
        }
        public Vector2 getPosition()
        {
            return position;
        }
        public void setxVel(float _x)
        {
            xVel = _x;
        }
        public void setyVel(float _y)
        {
            yVel = _y;
        }
        public float getXVel()
        {
            return xVel;
        }
        public float getYVel()
        {
            return yVel;
        }


    }
}