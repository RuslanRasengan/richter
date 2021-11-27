using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_chapter_boxing_unboxing
{
    public class TrueUnboxing
    {
        public void boxUnbox()
        {

            //Int32 x = 5;
            //Object o = x;       // Упаковка x; о указівает на упакованный объект
            //Int16 y = (Int16) o; // Генерируется InvalidCastException

            //Int32 x = 5;
            //Object o = x;               // Упаковка x; о указівает на упакованный объект
            //Int16 y = (Int16)(Int32)o;  // Распаковка, а затем приведение типа

            //Point p;
            //p.x = p.y = 1;
            //Object o = p;  // Упаковка р; о указывает на упакованный объект
            //p = (Point) o; // Распаковка о и копирование полей из экземпляра в стек

            Point p;
            p.x = p.y = 1;
            Object o = p; // Упаковка p; о указывает на упакованный экземпляр

            // Изменение поля х структуры Point (присвоение числа 2).
            p = (Point) o; // Распаковка о и копирование полей из єкземпляра
                           // в переменную в стеке
            p.x = 2;   // Изменение состояния переменной в стеке
            o = p;     // Упаковка р; о ссылается на новый упакованный экземпляр

        }
    }
}
