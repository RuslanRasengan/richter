using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_chapter_boxing_unboxing
{
    internal struct Point1
    {
        private Int32 m_x, m_y;

        public Point1 (Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }

        public void Change(Int32 x, Int32 y)
        {
            m_x = x; m_y = y;
        }

        public override String ToString()
        {
            return String.Format("({0}, {1})", m_x.ToString(), m_y.ToString());
        }
    }

    internal interface IChangeBoxedPoint
    {
        void Change(Int32 x, Int32 y);
    }

    internal struct Point2 : IChangeBoxedPoint
    {
        private Int32 m_x, m_y;

        public Point2(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }

        public void Change(Int32 x, Int32 y)
        {
            m_x = x; m_y = y;
        }

        public override String ToString()
        {
            return String.Format("({0}, {1})", m_x.ToString(), m_y.ToString());
        }
    }
    public class FieldChangesInBoxingViaInterface
    {
        public void WithoutInterface()
        {
            Point1 p = new Point1(1, 1);

            Console.WriteLine(p); // 1, 1

            p.Change(2, 2);
            Console.WriteLine(p); // 2, 2

            Object o = p;
            Console.WriteLine(o); // 2, 2

            ((Point1)o).Change(3, 3);
            Console.WriteLine(o); // 2, 2
        }

        public void WithInterface()
        {
            Point2 p = new Point2(1, 1);

            Console.WriteLine(p); // 1, 1

            p.Change(2, 2);
            Console.WriteLine(p); // 2, 2

            Object o = p;
            Console.WriteLine(o); // 2, 2

            ((Point2)o).Change(3, 3);
            Console.WriteLine(o); // 2, 2

            // р упаковывается, упакованный объект изменяется и освобождается
            ((IChangeBoxedPoint)p).Change(4, 4);
            Console.WriteLine(p); // 2, 2

            // Упаковывается объект изменяется и выводиться
            ((IChangeBoxedPoint)o).Change(5, 5);
            Console.WriteLine(o); // 5, 5                       
        }
    }
}
