
namespace New_Test
{
    class Program
    {
        public static int GetUniqueNumber(int[] array)
        {
            int uniqueNum = 0;
            int answer;

            for (int i = 0; i < array.Length; i++)
            {
                for (int l = i + 1; l < array.Length; l++)
              {
                    uniqueNum = array[i];
                    if (uniqueNum == array[l])
                    {
                        uniqueNum = -1;
                        break;
                    }
                }
                answer = uniqueNum;
                if (uniqueNum != -1)
                {

                    return uniqueNum;

                }

            }
            return -1;
        }

        public static int GetSmallestInt(int[] array)
        {
            int answer = 1;
            for (int i = 0; i < array.Length; i++)
            {


                for (int l = 0; l < array.Length; l++)
                {
                    if (answer == array[l])
                    {
                        answer++;
                        break;
                    }

                }
            }


            return answer;
        }

        public static int[] GetUniqueArray(int[] array1, int[] array2)
        {
            int uniqueNum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int l = 0; l < array2.Length; l++)
                {
                    if (array1[i] == array2[l])
                    {
                        uniqueNum++;
                    }
                }

            }

            int[] newArray = new int[uniqueNum];
            int j = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int l = 0; l < array2.Length; l++)
                {
                    if (array1[i] == array2[l])
                    {
                        newArray[j] = array1[i];
                        j++;
                    }
                }

            }

            return newArray;
        }


        static void Main(string[] args)
        {
            
           Console.WriteLine(GetUniqueNumber(new int[] { 4, 10, 5, 4, 2, 10 }));
            Class.sayHi();
            Console.WriteLine(GetUniqueArray(new int[] { 2, 3, 1, 5 }, new int[] { 4, 1, 5, 8 }));//вывод на экран
            Console.WriteLine("Hello World");// тестирование новой функции
            Console.ReadLine();
        }
    }
}