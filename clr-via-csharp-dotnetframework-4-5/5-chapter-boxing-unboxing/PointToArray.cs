using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_chapter_boxing_unboxing
{
    struct Point
    {
        public Int32 x, y;
    }
    public class PointToArray
    {
        public void pointBoxingCast()
        {
            ArrayList a = new ArrayList();

            Point p; // Выделяется память для Point(не в куче)

            for (Int32 i = 0; i < 10; i++)
            {
                p.x = p.y = i;// Инициализация членов в нашем значимом типе
                a.Add(p);     // Упаковка значимого типа и добавление
                              // ссылки в ArrayList
            }
            // Add Inside
            //
            // Summary:
            //     Adds an object to the end of the System.Collections.ArrayList.
            //
            // Parameters:
            //   value:
            //     The System.Object to be added to the end of the System.Collections.ArrayList.
            //     The value can be null.
            //
            // Returns:
            //     The System.Collections.ArrayList index at which the value has been added.
            //
            // Exceptions:
            //   T:System.NotSupportedException:
            //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
            //     has a fixed size.
            //
            //
            //public virtual int Add(object? value);
        }
    }
}
