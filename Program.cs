using System;
/*
 * Написать метод для добавления эелемента в начало массива, в конец массива и по указаному индексу.
 */
namespace RedactorOfArrayHW
{
    class Program
    {
        /// <summary>
        /// Метод добавляет элемент в массив с заданным индексом.
        /// </summary>
        /// <param name="arrayToChange"></param>
        /// <param name="indexOfElementToChange"></param>
        /// <returns></returns>
        static ref int[] RedactorOfArray(ref int[] arrayToChange, uint indexOfElementToChange, int valueOfElement)
        {
            if (arrayToChange.Length < indexOfElementToChange)
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
                if (indexOfElementToChange == currentElement)
                {
                    arrayToChange[indexOfElementToChange] = valueOfElement;
                    elementOfArrayToOuput++;
                }
                else if (indexOfElementToChange == arrayForSavingData.Length) 
                {
                    arrayToChange[indexOfElementToChange] = valueOfElement;
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
