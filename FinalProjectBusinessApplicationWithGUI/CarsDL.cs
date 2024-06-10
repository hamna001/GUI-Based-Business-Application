using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBusinessApplicationWithGUI
{
    class CarsDL
    {
        public static List<Cars> carinfo = new List<Cars>();

        public static void Add_Cars_to_List(Cars car)
        {
            carinfo.Add(car);
        }

        public static void Add_Cars_To_File()
        {
            string path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\cars.txt";
            StreamWriter file = new StreamWriter(path,true);
            foreach (Cars car in carinfo)
            {
                file.WriteLine(car.GetCarName() + "," + car.GetcarModel() + "," + car.GetcarColor() + "," + car.GetcarPrice() + "," + car.GetcarQuantity());
            }

            file.Flush();
            file.Close();
        }
        public static void Read_Cars_From_File()
        {
            string path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\cars.txt";
            if (File.Exists(path))
            {
                int x = 0;
                StreamReader file = new StreamReader(path, true);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    //string[] records = record.Split(',');

                    string carname = ParseData(record, 1);
                    string model = ParseData(record, 2);
                    string color = ParseData(record, 3);
                    string price = ParseData(record, 4);
                    string quantity = ParseData(record, 5);

                    Cars C = new Cars(carname, model, color, price, quantity);
                    carinfo.Add(C);
                    x++;
                    if (x > carinfo.Count)
                    {
                        break;
                    }

                }
                file.Close();
            }

        }
        public static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        public static bool RemoveCar(string carname)
        {
            bool flag = false;
           for(int i=0;i<carinfo.Count;i++)
            {
                if(carname==carinfo[i].GetCarName())
                {
                    carinfo.RemoveAt(i);
                    Add_Cars_To_File();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return flag;
        }
        public static int checkExixtingCar(string carname)
        {
           for(int i=0;i<carinfo.Count;i++)
           {
                if(carname==carinfo[i].GetCarName())
                {
                    return i;
                }
           }
            return -1;
        }

    }
}
