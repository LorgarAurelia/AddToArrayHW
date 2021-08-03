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
        static ref int[] AddToArray(ref int[] arrayToChange, string indexOfElementSting, string valueOfElementString) 
        {
            uint indexOfElement;
            int valueOfElement;

            bool succesInParsingIndex = true, succesInParsingValue = true;

            if (succesInParsingIndex != uint.TryParse(indexOfElementSting, out indexOfElement))
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
        /// Метод добавляет элемент в массив с заданным индексом. Значение принимаются в типе string.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElementSting"></param>
        /// <param name="valueOfElementString"></param>
        /// <returns></returns>
        static ref int[] AddToArray(ref int[] arrayToChange, uint indexOfElement, string valueOfElementString) 
        {
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
        static void Main()
        {
        }
    }
}
