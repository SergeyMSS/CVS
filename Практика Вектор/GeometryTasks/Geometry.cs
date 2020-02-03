using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public Vector Add(Vector vector)
        {
            return Geometry.Add(this, vector);
        }

        public bool Belongs(Segment segment)
        {
            return Geometry.IsVectorInSegment(this, segment);
        }
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public bool Contains(Vector vector)
        {
            return Geometry.IsVectorInSegment(vector, segment: this);
        }
    }

    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt((vector.X * vector.X) + (vector.Y * vector.Y));
        }

        public static double GetLength(Segment segment)
        {
            double x1 = segment.Begin.X;
            double y1 = segment.Begin.Y;
            double x2 = segment.End.X;
            double y2 = segment.End.Y;

            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            Vector resultVector = new Vector();

            resultVector.X = vector1.X + vector2.X;
            resultVector.Y = vector1.Y + vector2.Y;
            return resultVector;
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            // через уравнение прямой

            double x = vector.X;
            double y = vector.Y;
            double x1 = segment.Begin.X;
            double y1 = segment.Begin.Y;
            double x2 = segment.End.X;
            double y2 = segment.End.Y;

            return ((x - x1) * (y2 - y1) == (y - y1) * (x2 - x1)) && (vector.X >= segment.Begin.X) && (vector.X <= segment.End.X) && (vector.Y >= segment.Begin.Y) && (vector.Y <= segment.End.Y);

        }
    }
}
