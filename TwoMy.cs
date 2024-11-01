using System;

public class Class1
{
	public Class1()
	{
        static List<string> GetRoute (List<string> map, int count)
        {
            // Переменные где мы сейчас
            int currentH, currentV;
            int carH, carV;
            int currentCustomerH, currentCustomerV;

            // Получаем конкретные координаты где мы
            (currentH, currentV) = GetCoord(map);
            carH = currentH;
            carV = currentV;
            // Заказчик
            (currentCustomerH, currentCustomerV) = GEtCoord(map, 1);

            // Конечный лист, куда будем заносить порядок следования
            List<string> addressCustomer = new List<string>(count);

            int minDistance = currentH - currentCustomerH + currentV - currentCustomerV;

            int route = 0;
            for (int i = 0; i != K; i++)
            {
                int currentAdressH, currentAdressV;
                (currentAdressH, currentAdressV) = GetCoord(map, i);

                for (int j = 0; j != K; j++)
                {
                    if (minDistance > (currentLocate[0] - locateCustomer[0] + currentLocate[1] - locateCustomer[1]))
                    {
                        minDistance = locateCompany[0] - locateCustomer[0] + locateCompany[1] - locateCustomer[1];
                        route = j;
                    }
                }
                store = addressCustomer[route];
                addressCustomer[route] = addressCustomer[i];
                addressCustomer[i] = store;
                currentLocate = locateCustomer;
            }
        }
    }
}
