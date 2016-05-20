using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTriangleArea
{
    public class TriangleAreaSpace
    {
        public static object TrianglrAreaSpace { get; set; }

        /// <summary>
        /// Вычисление площади прямоугольного треугольника.
        /// </summary>
        /// <param name="aCathetus"></param>
        /// <param name="bCathetus"></param>
        /// <param name="cHypotenuse"></param>
        /// <returns></returns>
        public static string TrianglrAreaS(double aCathetus, double bCathetus, double cHypotenuse)
        {
         
            // Проверка на исключения.
            if (aCathetus == 0 && bCathetus == 0)
            {
                return "Должен быть известен, хотябы один катет";
            }
            if (aCathetus == 0 || bCathetus == 0 && cHypotenuse == 0)
            {
                return "Если не известен один катет, должна быть известна гипотенуза";
            }
            if (aCathetus == 0 || bCathetus == 0)
            {
                if (aCathetus != 0)
                {
                    if (aCathetus > cHypotenuse)
                    {
                        return "Катет не может быть длинее гипотенузы.";
                    }

                }
                if (bCathetus != 0)
                {
                    if (bCathetus > cHypotenuse)
                    {
                        return "Катет не может быть длинее гипотенузы.";
                    }
                }
            }

            // Вычисление катетов по гипотенузе.
            if (aCathetus == 0 || bCathetus == 0)
            {


                if (aCathetus == 0)
                {
                    aCathetus = getCathetus(bCathetus, cHypotenuse);
                }
                if (bCathetus == 0)
                {
                    bCathetus = getCathetus(aCathetus, cHypotenuse);
                }
            }
            // Вычисление площади треугольника.
            return "Площадь треугольника: " + ((aCathetus * bCathetus) / 2).ToString();
        }

        protected static double getCathetus(double cathetus, double hypotenuse)
        {
            return Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(cathetus, 2));
        }

    }
}
