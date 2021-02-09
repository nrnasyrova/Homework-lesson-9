using System;

namespace HomeworkLesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = {1, 4, 9, 0};
            int [] newArr = ArrayHelper.Slice(arr, -1, -2);
            foreach (var item in newArr)
            {
                Console.Write($"{item} ");
            }
        }
    }

    public static class ArrayHelper
    {
        public static T Pop<T>(ref T[] arr)
        {
            T LastElement = arr[^1];
            T[] newArray = new T[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return LastElement;
        }

        public static int Push<T>(ref T[] arr, T el)
        {
            T[] newArray = new T[arr.Length + 1];
            newArray[arr.Length] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }

        public static T Shift<T>(ref T[] arr)
        {
            T FirstElement = arr[0];
            T[] newArray = new T[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
            return FirstElement;
        }

        public static int UnShift<T>(ref T[] arr, T el)
        {
            T[] newArray = new T[arr.Length + 1];
            newArray[0] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }

        public static T[] Slice<T>(T[] newArr, int beginIndex = 0, int endIndex = 0)
        {
            T[] arr = new T[newArr.Length];

            if (beginIndex > newArr.Length)
            {
                return arr;
            }
            if (endIndex == 0)
            {
                endIndex = newArr.Length;
            }
            if (beginIndex >= 0)
            {
                if (endIndex >= 0)
                {
                    for (int i = beginIndex; i < endIndex; i++)
                    {
                        int j = 0;
                        arr[j] = newArr[i];
                        j++;
                    }
                }
                else if (endIndex < 0)
                {
                    for (int i = beginIndex; i < newArr.Length + endIndex; i++)
                    {
                        int j = 0;
                        arr[j] = newArr[i];
                        j++;
                    }
                }
            }
            if (beginIndex < 0)
            {
                if (endIndex >= 0)
                {
                    for (int i = newArr.Length-1; i >= newArr.Length + beginIndex; i--)
                    {
                        int j = 0;
                        arr[j] = newArr[i];
                        j++;
                    }
                }
                else if (endIndex <= 0)
                {
                    for (int i = newArr.Length - 1 + endIndex; i > beginIndex + newArr.Length - 1 + endIndex; i--)
                    {
                        int j = 0;
                        arr[j] = newArr[i];
                        j++;
                    }
                }
            }
            return arr;
        }
    }
}
