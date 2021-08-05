using System;
/*
 * Написать метод для добавления эелемента в начало массива, в конец массива и по указаному индексу.
 */
namespace RedactorOfArray
{
    class Program
    {
        /// <summary>
        /// Метод добавляет элемент в массив с заданным индексом.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElement"></param>
        /// <returns></returns>
        static void AddToArray(ref int[] arrayToChange, uint indexOfElement, int valueOfElement)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return;
            }

            if (arrayToChange.Length < indexOfElement)
            {
                Console.WriteLine("Заданный вами индекс находится за границами допустимого значения, массив не был обработан. Для данного массива максимальный допустимый индекс: " + arrayToChange.Length);
                return;
            }

            int[] arrayNew = new int[arrayToChange.Length + 1];

            arrayNew[indexOfElement] = valueOfElement;

            for (uint currentElement = 0; currentElement < indexOfElement; currentElement++)
                arrayNew[currentElement] = arrayToChange[currentElement];

            for (uint currentElement = indexOfElement; currentElement < arrayToChange.Length; currentElement++)
                arrayNew[currentElement + 1] = arrayToChange[currentElement];

            arrayToChange = arrayNew;

        }

        /// <summary>
        /// Метод добавляет элемент в массив с заданным индексом. Индекс и значение принимаются в типе string.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElementToChange"></param>
        /// <param name="valueOfElement"></param>
        /// <returns></returns>
        static void AddToArray(ref int[] arrayToChange, string indexOfElementString, string valueOfElementString)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return;
            }

            uint indexOfElement;
            int valueOfElement;

            bool succesInParsingIndex = true, succesInParsingValue = true;

            if (succesInParsingIndex != uint.TryParse(indexOfElementString, out indexOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для индекса. Допустимо только целое число без знака. Массив не был обработан.");
                return;
            }

            if (succesInParsingValue != int.TryParse(valueOfElementString, out valueOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для элемента массива. Допустимо только челое число. Массив не был обработан.");
                return;
            }

            if (arrayToChange.Length < indexOfElement)
            {
                Console.WriteLine("Заданный вами индекс находится за границами допустимого значения, массив не был обработан. Для данного массива максимальный допустимый индекс: " + arrayToChange.Length);
                return;
            }

            int[] arrayNew = new int[arrayToChange.Length + 1];

            arrayNew[indexOfElement] = valueOfElement;

            for (uint currentElement = 0; currentElement < indexOfElement; currentElement++)
                arrayNew[currentElement] = arrayToChange[currentElement];

            for (uint currentElement = indexOfElement; currentElement < arrayToChange.Length; currentElement++)
                arrayNew[currentElement + 1] = arrayToChange[currentElement];

            arrayToChange = arrayNew;
        }

        /// <summary>
        /// Метод добавляет элемент в массив с заданным индексом. Значение принимается в типе string.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElementSting"></param>
        /// <param name="valueOfElementString"></param>
        /// <returns></returns>
        static void AddToArray(ref int[] arrayToChange, uint indexOfElement, string valueOfElementString)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return;
            }

            int valueOfElement;

            bool succesInParsingValue = true;

            if (succesInParsingValue != int.TryParse(valueOfElementString, out valueOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для элемента массива. Допустимо только челое число. Массив не был обработан.");
                return;
            }

            if (arrayToChange.Length < indexOfElement)
            {
                Console.WriteLine("Заданный вами индекс находится за границами допустимого значения, массив не был обработан. Для данного массива максимальный допустимый индекс: " + arrayToChange.Length);
                return;
            }

            int[] arrayNew = new int[arrayToChange.Length + 1];

            arrayNew[indexOfElement] = valueOfElement;

            for (uint currentElement = 0; currentElement < indexOfElement; currentElement++)
                arrayNew[currentElement] = arrayToChange[currentElement];

            for (uint currentElement = indexOfElement; currentElement < arrayToChange.Length; currentElement++)
                arrayNew[currentElement + 1] = arrayToChange[currentElement];

            arrayToChange = arrayNew;
        }

        /// <summary>
        /// Метод добавляет элемент в массив с заданным индексом. Индекс принимается в типе string
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElementString"></param>
        /// <param name="valueOfElement"></param>
        /// <returns></returns>
        static void AddToArray(ref int[] arrayToChange, string indexOfElementString, int valueOfElement)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return;
            }

            uint indexOfElement;

            bool succesInParsingIndex = true;

            if (succesInParsingIndex != uint.TryParse(indexOfElementString, out indexOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для индекса. Допустимо только целое число без знака. Массив не был обработан.");
                return;
            }

            if (arrayToChange.Length < indexOfElement)
            {
                Console.WriteLine("Заданный вами индекс находится за границами допустимого значения, массив не был обработан. Для данного массива максимальный допустимый индекс: " + arrayToChange.Length);
                return;
            }

            int[] arrayNew = new int[arrayToChange.Length + 1];

            arrayNew[indexOfElement] = valueOfElement;

            for (uint currentElement = 0; currentElement < indexOfElement; currentElement++)
                arrayNew[currentElement] = arrayToChange[currentElement];

            for (uint currentElement = indexOfElement; currentElement < arrayToChange.Length; currentElement++)
                arrayNew[currentElement + 1] = arrayToChange[currentElement];

            arrayToChange = arrayNew;
        }

        /// <summary>
        /// Метод добавляет элемент в начало или конец массива.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="toBeFirst"></param>
        /// <param name="valueOfElement"></param>
        /// <returns></returns>
        static void AddFirst(ref int[] arrayToChange, int valueOfElement)
        {
            AddToArray(ref arrayToChange, 0, valueOfElement);
        }

        /// <summary>
        /// Метод добавляет элемент в начало или конец массива. Элемент массива принмается в виде строки.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="toBeFirst"></param>
        /// <param name="valueOfElementString"></param>
        /// <returns></returns>
        static void AddFirst(ref int[] arrayToChange, string valueOfElementString)
        {
            AddToArray(ref arrayToChange, 0, valueOfElementString);
        }

        /// <summary>
        /// Метод добовляет элемент в конец массива.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="valueOfElement"></param>
        /// <returns></returns>
        static void AddLast(ref int[] arrayToChange, int valueOfElement)
        {
            AddToArray(ref arrayToChange, Convert.ToUInt32(arrayToChange.Length), valueOfElement);
        }

        /// <summary>
        /// Метод добовляет элемент в конец массива. Элемент принмается в виде строки.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="valueOfElementString"></param>
        /// <returns></returns>
        static void AddLast(ref int[] arrayToChange, string valueOfElementString)
        {
            AddToArray(ref arrayToChange, Convert.ToUInt32(arrayToChange.Length), valueOfElementString);
        }
        static void Main()
        {
            int[] arrayForDemonstration = new int[3] { 1, 2, 3 };
            string index, value;
            uint indexUint;
            int valueInt;

            Console.WriteLine("Изначальный массив");
            foreach (var item in arrayForDemonstration)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            Console.Write("Ввидите индекс, под которым вы бы хотели добавить элемент: \t");
            index = Console.ReadLine();
            Console.WriteLine();
            try
            {
                indexUint = uint.Parse(index);
            }
            catch (Exception)
            {
                Console.WriteLine("Присвоен некооректный индекс, базовое значение равно 0.");
                indexUint = 0;
            }

            Console.Write("Введите значение элемента массива: \t");
            value = Console.ReadLine();
            Console.WriteLine();
            try
            {
                valueInt = int.Parse(value);
            }
            catch (Exception)
            {
                Console.WriteLine("Присвоено некооректное значение элемента, базовое значение равно 200.");
                valueInt = 200;
            }

            Console.WriteLine("Массив после обработки методом AddToArray");
            AddToArray(ref arrayForDemonstration, indexUint, valueInt);
            foreach (var item in arrayForDemonstration)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            arrayForDemonstration = new int[3] { 1, 2, 3 };

            Console.WriteLine("Массив после обработки методом принимая параметры индекса и значения элемента в виде строки:");
            AddToArray(ref arrayForDemonstration, index, value);
            foreach (var item in arrayForDemonstration)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            arrayForDemonstration = new int[3] { 1, 2, 3 };

            Console.WriteLine("Метод AddFirst добавляет элемент в начало массива.");
            AddFirst(ref arrayForDemonstration, valueInt);
            foreach (var item in arrayForDemonstration)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            arrayForDemonstration = new int[3] { 1, 2, 3 };

            Console.WriteLine("Массив после обработки методом AddLast");
            AddLast(ref arrayForDemonstration, valueInt);
            foreach (var item in arrayForDemonstration)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            ///AddToArray(ref arrayForDemonstration, valueInt);


            Console.ReadKey();
        }
    }
}