using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_chapter_boxing_unboxing
{
    public class BoxUnboxDetailedResearch
    {
        public void PrintPrimitive()
        {
            Int32 v = 5;  // Создание неупакованной переменной значимого типа о
            Object o = v; // указывает на упаковонное Int32, содержащее 5
            v = 123;      // Изменяем неупакованное значение на 123  

            Console.WriteLine(v + ", " + (Int32)o); // Отображается "123, 5"

            //Console.WriteLine(v + ", " + o); // Отображается "123, 5"
            //Разница в том что лишнее приведение убирает упаковку и распаковку

            //Console.WriteLine(v.ToString() + ", " + o); // Отображается "123, 5"
            //Здесь мы избавились от еще одной упаковки 
        }

        //.method public hidebysing void PrintPrimitive() cil managed
        //{
        //.entrypoint             45(0x2d)
        // Размер кода
        //.maxstack 3
        //.locals init([0]Int32 v,
        //            [1] object o)
        // Загружаем 5 в v
        //IL_0000: ldc.i4.5
        //IL_0000: stloc.0

        // Упакуем v и сохраняем указатель в о.                 1
        //IL_0002: ldloc.0
        //IL_0004: box            [mscorlib]System.Int32
        //IL_0008: stloc.1

        // Загружаем 123 в v
        //IL_0009: ldc.i4s 123
        //IL_000b: stloc.0

        // Упакуем v и сохраняем в стеке указатель для Concat    2
        //IL_000c: ldloc.0
        //IL_000d: box            [mscorlib]System.Int32

        // Загружаем строку в стек для Concat
        //IL_0012: ldstr          ", "

        // Распакуем o: берем указатель в поле Int32 в стеке       1.1
        //IL_0017: ldloc.1
        //IL_0018: unbox.any      [mscorlib]System.Int32

        // Упакуем Int32 и сохраняем в стеке указатель для Concat   3
        //IL_001d: box            [mscorlib]System.Int32
        // Вызываем Concat
        //IL_0022: call           string [mscorlib]System.String::Concat(object,
        //                                                               object,
        //                                                               object)
        // Строку, возвращенную из Concat, передаем в WriteLine
        //IL_0027: call           void [mscorlib]System.Console::WriteLine(string)

        // Метод PrintPrimitive возвращает управление, и приложение завершается
        //IL_002c: ret
        // Конец метода App::PrintPrimitive
        //}

        //-----------------------------------------------------------
    }
}
