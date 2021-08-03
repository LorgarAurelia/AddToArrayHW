using System;
/*
 * Написать метод для добавления эелемента в начало массива, в конец массива и по указаному индексу.
 */
namespace AddToArray
{
    class Program
    {
        /// <summary>
        /// Метод добавляет элемент в массив с заданным индексом.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElement"></param>
        /// <returns></returns>
        static ref int[] AddToArray(ref int[] arrayToChange, uint indexOfElement, int valueOfElement)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return ref arrayToChange;
            }

            if (arrayToChange.Length < indexOfElement)
            {
                Console.WriteLine("Заданный вами индекс находится за границами допустимого значения, массив не был обработан. Для данного массива максимальный допустимый индекс: " + arrayToChange.Length);
                return ref arrayToChange;
            }

            int[] arrayForSavingData = new int[arrayToChange.Length];
            uint newLengthOfArray = Convert.ToUInt32(arrayToChange.Length) + 1;

            for (int currentElement = 0; currentElement < arrayToChange.Length; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToChange[currentElement];
            }

            arrayToChange = new int[newLengthOfArray];

            for (uint currentElement = 0, elementOfArrayToOuput = 0; currentElement < arrayForSavingData.Length; currentElement++, elementOfArrayToOuput++)
            {
                if (indexOfElement == currentElement)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                    elementOfArrayToOuput++;
                }
                else if (indexOfElement == arrayForSavingData.Length)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                }
                arrayToChange[elementOfArrayToOuput] = arrayForSavingData[currentElement];
            }

            return ref arrayToChange;
        }

        /// <summary>
        /// Метод добавляет элемент в массив с заданным индексом. Индекс и значение принимаются в типе string.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElementToChange"></param>
        /// <param name="valueOfElement"></param>
        /// <returns></returns>
        static ref int[] AddToArray(ref int[] arrayToChange, string indexOfElementString, string valueOfElementString)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return ref arrayToChange;
            }

            uint indexOfElement;
            int valueOfElement;

            bool succesInParsingIndex = true, succesInParsingValue = true;

            if (succesInParsingIndex != uint.TryParse(indexOfElementString, out indexOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для индекса. Допустимо только целое число без знака. Массив не был обработан.");
                return ref arrayToChange;
            }

            if (succesInParsingValue != int.TryParse(valueOfElementString, out valueOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для элемента массива. Допустимо только челое число. Массив не был обработан.");
                return ref arrayToChange;
            }

            if (arrayToChange.Length < indexOfElement)
            {
                Console.WriteLine("Заданный вами индекс находится за границами допустимого значения, массив не был обработан. Для данного массива максимальный допустимый индекс: " + arrayToChange.Length);
                return ref arrayToChange;
            }

            int[] arrayForSavingData = new int[arrayToChange.Length];
            uint newLengthOfArray = Convert.ToUInt32(arrayToChange.Length) + 1;

            for (int currentElement = 0; currentElement < arrayToChange.Length; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToChange[currentElement];
            }

            arrayToChange = new int[newLengthOfArray];

            for (uint currentElement = 0, elementOfArrayToOuput = 0; currentElement < arrayForSavingData.Length; currentElement++, elementOfArrayToOuput++)
            {
                if (indexOfElement == currentElement)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                    elementOfArrayToOuput++;
                }
                else if (indexOfElement == arrayForSavingData.Length)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                }
                arrayToChange[elementOfArrayToOuput] = arrayForSavingData[currentElement];
            }

            return ref arrayToChange;
        }

        /// <summary>
        /// Метод добавляет элемент в массив с заданным индексом. Значение принимается в типе string.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElementSting"></param>
        /// <param name="valueOfElementString"></param>
        /// <returns></returns>
        static ref int[] AddToArray(ref int[] arrayToChange, uint indexOfElement, string valueOfElementString)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return ref arrayToChange;
            }

            int valueOfElement;

            bool succesInParsingValue = true;

            if (succesInParsingValue != int.TryParse(valueOfElementString, out valueOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для элемента массива. Допустимо только челое число. Массив не был обработан.");
                return ref arrayToChange;
            }

            if (arrayToChange.Length < indexOfElement)
            {
                Console.WriteLine("Заданный вами индекс находится за границами допустимого значения, массив не был обработан. Для данного массива максимальный допустимый индекс: " + arrayToChange.Length);
                return ref arrayToChange;
            }

            int[] arrayForSavingData = new int[arrayToChange.Length];
            uint newLengthOfArray = Convert.ToUInt32(arrayToChange.Length) + 1;

            for (int currentElement = 0; currentElement < arrayToChange.Length; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToChange[currentElement];
            }

            arrayToChange = new int[newLengthOfArray];

            for (uint currentElement = 0, elementOfArrayToOuput = 0; currentElement < arrayForSavingData.Length; currentElement++, elementOfArrayToOuput++)
            {
                if (indexOfElement == currentElement)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                    elementOfArrayToOuput++;
                }
                else if (indexOfElement == arrayForSavingData.Length)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                }
                arrayToChange[elementOfArrayToOuput] = arrayForSavingData[currentElement];
            }

            return ref arrayToChange;
        }

        /// <summary>
        /// Метод добавляет элемент в массив с заданным индексом. Индекс принимается в типе string
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElementString"></param>
        /// <param name="valueOfElement"></param>
        /// <returns></returns>
        static ref int[] AddToArray(ref int[] arrayToChange, string indexOfElementString, int valueOfElement)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return ref arrayToChange;
            }

            uint indexOfElement;

            bool succesInParsingIndex = true;

            if (succesInParsingIndex != uint.TryParse(indexOfElementString, out indexOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для индекса. Допустимо только целое число без знака. Массив не был обработан.");
                return ref arrayToChange;
            }

            if (arrayToChange.Length < indexOfElement)
            {
                Console.WriteLine("Заданный вами индекс находится за границами допустимого значения, массив не был обработан. Для данного массива максимальный допустимый индекс: " + arrayToChange.Length);
                return ref arrayToChange;
            }

            int[] arrayForSavingData = new int[arrayToChange.Length];
            uint newLengthOfArray = Convert.ToUInt32(arrayToChange.Length) + 1;

            for (int currentElement = 0; currentElement < arrayToChange.Length; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToChange[currentElement];
            }

            arrayToChange = new int[newLengthOfArray];

            for (uint currentElement = 0, elementOfArrayToOuput = 0; currentElement < arrayForSavingData.Length; currentElement++, elementOfArrayToOuput++)
            {
                if (indexOfElement == currentElement)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                    elementOfArrayToOuput++;
                }
                else if (indexOfElement == arrayForSavingData.Length)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                }
                arrayToChange[elementOfArrayToOuput] = arrayForSavingData[currentElement];
            }

            return ref arrayToChange;
        }

        /// <summary>
        /// Метод добавляет элемент в начало или конец массива. toBeFirst = true - в начало, toBeFirst = false в конец.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="toBeFirst"></param>
        /// <param name="valueOfElement"></param>
        /// <returns></returns>
        static ref int[] AddToArray(ref int[] arrayToChange, bool toBeFirst, int valueOfElement)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return ref arrayToChange;
            }

            uint indexOfElement = toBeFirst ? 0 : Convert.ToUInt32((arrayToChange.Length));

            int[] arrayForSavingData = new int[arrayToChange.Length];
            uint newLengthOfArray = Convert.ToUInt32(arrayToChange.Length) + 1;

            for (int currentElement = 0; currentElement < arrayToChange.Length; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToChange[currentElement];
            }

            arrayToChange = new int[newLengthOfArray];

            for (uint currentElement = 0, elementOfArrayToOuput = 0; currentElement < arrayForSavingData.Length; currentElement++, elementOfArrayToOuput++)
            {
                if (indexOfElement == currentElement)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                    elementOfArrayToOuput++;
                }
                else if (indexOfElement == arrayForSavingData.Length)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                }
                arrayToChange[elementOfArrayToOuput] = arrayForSavingData[currentElement];
            }

            return ref arrayToChange;
        }

        /// <summary>
        /// Метод добавляет элемент в начало или конец массива. toBeFirst = true - в начало, toBeFirst = false в конец. Элемент массива принмается в виде строки.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="toBeFirst"></param>
        /// <param name="valueOfElementString"></param>
        /// <returns></returns>
        static ref int[] AddToArray(ref int[] arrayToChange, bool toBeFirst, string valueOfElementString)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return ref arrayToChange;
            }

            uint indexOfElement = toBeFirst ? 0 : Convert.ToUInt32((arrayToChange.Length));

            int valueOfElement;

            bool succesInParsingValue = true;

            if (succesInParsingValue != int.TryParse(valueOfElementString, out valueOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для элемента массива. Допустимо только челое число. Массив не был обработан.");
                return ref arrayToChange;
            }

            int[] arrayForSavingData = new int[arrayToChange.Length];
            uint newLengthOfArray = Convert.ToUInt32(arrayToChange.Length) + 1;

            for (int currentElement = 0; currentElement < arrayToChange.Length; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToChange[currentElement];
            }

            arrayToChange = new int[newLengthOfArray];

            for (uint currentElement = 0, elementOfArrayToOuput = 0; currentElement < arrayForSavingData.Length; currentElement++, elementOfArrayToOuput++)
            {
                if (indexOfElement == currentElement)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                    elementOfArrayToOuput++;
                }
                else if (indexOfElement == arrayForSavingData.Length)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                }
                arrayToChange[elementOfArrayToOuput] = arrayForSavingData[currentElement];
            }

            return ref arrayToChange;
        }

        /// <summary>
        /// Метод добовляет элемент в конец массива.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="valueOfElement"></param>
        /// <returns></returns>
        static ref int[] AddToArray(ref int[] arrayToChange, int valueOfElement)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return ref arrayToChange;
            }

            uint indexOfElement = Convert.ToUInt32((arrayToChange.Length));

            int[] arrayForSavingData = new int[arrayToChange.Length];
            uint newLengthOfArray = Convert.ToUInt32(arrayToChange.Length) + 1;

            for (int currentElement = 0; currentElement < arrayToChange.Length; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToChange[currentElement];
            }

            arrayToChange = new int[newLengthOfArray];

            for (uint currentElement = 0, elementOfArrayToOuput = 0; currentElement < arrayForSavingData.Length; currentElement++, elementOfArrayToOuput++)
            {
                if (indexOfElement == arrayForSavingData.Length)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                }
                arrayToChange[elementOfArrayToOuput] = arrayForSavingData[currentElement];
            }

            return ref arrayToChange;
        }

        /// <summary>
        /// Метод добовляет элемент в конец массива. Элемент принмается в виде строки.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="valueOfElementString"></param>
        /// <returns></returns>
        static ref int[] AddToArray(ref int[] arrayToChange, string valueOfElementString)
        {
            if (arrayToChange == null)
            {
                Console.WriteLine("Переданный массив хранит NULL, массив не был обработан.");
                return ref arrayToChange;
            }

            uint indexOfElement = Convert.ToUInt32((arrayToChange.Length));

            int valueOfElement;

            bool succesInParsingValue = true;

            if (succesInParsingValue != int.TryParse(valueOfElementString, out valueOfElement))
            {
                Console.WriteLine("Вы ввели некорректное значение для элемента массива. Допустимо только челое число. Массив не был обработан.");
                return ref arrayToChange;
            }

            int[] arrayForSavingData = new int[arrayToChange.Length];
            uint newLengthOfArray = Convert.ToUInt32(arrayToChange.Length) + 1;

            for (int currentElement = 0; currentElement < arrayToChange.Length; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToChange[currentElement];
            }

            arrayToChange = new int[newLengthOfArray];

            for (uint currentElement = 0, elementOfArrayToOuput = 0; currentElement < arrayForSavingData.Length; currentElement++, elementOfArrayToOuput++)
            {
                if (indexOfElement == arrayForSavingData.Length)
                {
                    arrayToChange[indexOfElement] = valueOfElement;
                }
                arrayToChange[elementOfArrayToOuput] = arrayForSavingData[currentElement];
            }

            return ref arrayToChange;
        }
        static void Main()
        {
            int[] arrayForDemonstration = new int[3] { 1, 2, 3 };
            string index , value, atBeginString;
            uint indexUint;
            int valueInt;
            bool atBegin = true;

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
                Console.WriteLine("Присвоен некооректное значение элемента, базовое значение равно 200.");
                valueInt = 200;
            }

            Console.WriteLine("Массив после обработки методом");
            AddToArray(ref arrayForDemonstration,indexUint,valueInt);
            foreach (var item in arrayForDemonstration)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            arrayForDemonstration = new int[3] { 1, 2, 3 };

            Console.WriteLine("Массив после обработки методом принимая параметры индекса и хначения элемента в виде строки:");
            AddToArray(ref arrayForDemonstration,index,value);
            foreach (var item in arrayForDemonstration)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            arrayForDemonstration = new int[3] { 1, 2, 3 };

            Console.Write("Введите хотите ли вы добавить элемент в начало массива(Введите true) или введите что угодно, чтобы ставить в конец: \t");
            atBeginString = Console.ReadLine();
            Console.WriteLine();

            atBegin = atBeginString == "true" ? true : false;

            Console.WriteLine("Массив после обработки методом, принявшим булево значение отвечающие за добавление элемента либо в начало, либо в конец.");
            AddToArray(ref arrayForDemonstration,atBegin,valueInt);
            foreach (var item in arrayForDemonstration)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            arrayForDemonstration = new int[3] { 1, 2, 3 };

            Console.WriteLine("Массив после обработки методом, принявшим только значение элемента");
            AddToArray(ref arrayForDemonstration, valueInt);
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