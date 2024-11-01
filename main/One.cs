using System;
using System.Collections.Generic;

namespace main
{
    static class Ex1
    {
        static void Main(string[] args)
        {
            // 0 - отокуда стартуем,
            // 1 ... - заказы
            List<string> map = new List<string>();

            // Размерность улицы
            int n, m;
            Console.Write("Введите ваш N: ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Введите ваш M: ");
            m = Int32.Parse(Console.ReadLine());

            // Проверка размерности улицы (1 <= N, M <= 1000)
            if ((m >= 1 && m <= 1000) && (n >= 1 && m <= 1000))
            {
                Console.Write("Введите ваш адрес: ");
                string address = Console.ReadLine();
                map.Add(address);

                Console.Write("Введите количество заказов: ");
                int count = Int32.Parse(Console.ReadLine());

                // Вводим заказы
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Введите {i + 1} адрес: ");
                    string addressDevilery = Console.ReadLine();
                    map.Add(addressDevilery);
                }

                // Машина сейчас на начальной позиции
                int currentH, currentV;
                int carH, carV;

                (currentH, currentV) = GetCoord(map);
                carH = currentH;
                carV = currentV;

                Console.WriteLine("H" + currentH + " V" + currentV);

                int steps = 0;

                for (int i = 1; i <= map.Count; i++)
                {
                    // Возвращение в точку начала
                    if (i == map.Count)
                    {
                        steps += Math.Abs(carH - currentH);
                        steps += Math.Abs(carV - currentV);

                        break;
                    }

                    // Получаю координаты следующего заказа
                    int currentAdressH, currentAdressV;
                    (currentAdressH, currentAdressV) = GetCoord(map, i);

                    // Прибавляю количество дорог
                    steps += Math.Abs(carH - currentAdressH);
                    steps += Math.Abs(carV - currentAdressV);

                    // Машина теперь на этом адресе
                    carH = currentAdressH;
                    carV = currentAdressV;
                }

                Console.WriteLine(steps * 100);
                // return steps * 100;
                Console.ReadLine();
            }
            else {
                Console.WriteLine("ERROR:\n1 <= N,M <= 1000");
            }
        }


        // Получение координат
        static (int H, int V) GetCoord(List<string> map, int index = 0)
        {
            // Берем n элемент
            char[] temp = map[index].ToCharArray();
            int currentH, currentV;

            // Переулки начинаются с 1
            double tempCount = 1;

            // Ниже получаем номер дома 
            int firstSpaceIndex = map[index].IndexOf(' ');

            // tempNum = номер дома на улице
            int tempNum = Int32.Parse( map[index].Substring(firstSpaceIndex + 1) );

            // Поиск номера H или V улицы
            // Если номер четный
            if (tempNum % 2 == 0)
            {
                for (int i = 0; i < tempNum; i += 2)
                {
                    // Почему 0.5?
                    // Потому что у нас 2 стороны дороги
                    tempCount += 0.5;
                }
            }
            else
            {
                for (int i = 1; i <= tempNum; i += 2)
                {
                    tempCount += 0.5;
                }
            }

            if (temp[0] == 'V')
            {
                currentH = (int)tempCount;
                currentV = Int32.Parse(map[index].Substring(1, firstSpaceIndex - 1));
            }
            else
            {
                currentH = Int32.Parse(map[index].Substring(1, firstSpaceIndex - 1));
                currentV = (int)tempCount;
            }

            return (currentH, currentV);
        }
    }
}
