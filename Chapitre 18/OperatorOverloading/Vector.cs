using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading
{
    public struct Vector
    {
        public int X, Y;

        public Vector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("X={0} Y={1}", this.X, this.Y);
        }

        public Vector Addition(Vector v)
        {
            return new Vector()
            {
                X = this.X + v.X,
                Y = this.Y + v.Y
            };
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector()
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y
            };
        }

        public static Vector operator +(Vector v1, int i)
        {
            return new Vector()
            {
                X = v1.X + i,
                Y = v1.Y + i
            };
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector)
            {
                return this == (Vector)obj;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
