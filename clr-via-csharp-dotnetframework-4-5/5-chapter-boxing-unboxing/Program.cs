using System;
using System.Collections;

namespace _5_chapter_boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            PointToArray pointToArray = new PointToArray();
            pointToArray.pointBoxingCast();

            TrueUnboxing trueUnboxing = new TrueUnboxing();
            trueUnboxing.boxUnbox();



        }
    }
}
