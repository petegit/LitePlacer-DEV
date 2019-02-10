using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accord;
using Accord.Math.Geometry;

namespace LitePlacer
{
	public class Shapes
	{
        public class Component
        {
            public Accord.Point Center { get; set; }    // Centerpoint of component
            public double Alignment { get; set; }       // angle of component
            public List<IntPoint> Outline { get; set; }
            public LineSegment Longest { get; set; }    // Longest line segment in Outline (needed in drawing, avoid calculating twice)
            public Accord.Point NormalStart { get; set; }  // (needed in drawing, avoid calculating twice)
            public Accord.Point NormalEnd { get; set; }     // (needed in drawing, avoid calculating twice)

            public Component(Accord.Point centr, double alignmnt, List<IntPoint> outln,
                             LineSegment lngst, Accord.Point Nstart, Accord.Point Nend)
            {
                Center = centr;
                Alignment = alignmnt;
                Outline = outln;
                Longest = lngst;
                NormalStart = Nstart;
                NormalEnd = Nend;
            }
        }

        public class Rectangle
        {
            public Accord.Point Center { get; set; }    // Centerpoint
            public float Alignment { get; set; }       // angle
            public List<IntPoint> Corners { get; set; }

            public Rectangle(Accord.Point centr, float alignmnt, List<IntPoint> crnrs)
            {
                Center = centr;
                Alignment = alignmnt;
                Corners = crnrs;
            }
        }

        public class Circle
		{
			public double X { get; set; }
			public double Y { get; set; }
			public double Radius { get; set; }

			public Circle(double x, double y, double r)
			{
				X = x;
				Y = y;
				Radius = r;
			}
		}

	}


}
