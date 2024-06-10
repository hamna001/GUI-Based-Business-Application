using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBusinessApplicationWithGUI
{
    class customerDL
    {
        public static List<Order> orderinfo = new List<Order>();
        public static List<Customer> Feedbackinfo = new List<Customer>();

        public static void Add_Order_toList(Order Ord)
        {
            orderinfo.Add(Ord);
        }

        public static void Add_feedback_to_List(Customer C)
        {
            Feedbackinfo.Add(C);
        }
        public static void Add_Orders_To_File()
        {
            string path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\Orders.txt";
            StreamWriter file = new StreamWriter(path,true);
            foreach (Order O in orderinfo)
            {
                file.WriteLine(O.Get_productnametoOrder() + "," + O.Get_productPricetoOrder() + "," + O.Get_Quantity() + "," + O.GetUsername());
            }

            file.Flush();
            file.Close();
        }
        public static void Read_Orders_From_File()
        {
            string path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\Orders.txt";
            if (File.Exists(path))
            {
                int x = 0;
                StreamReader file = new StreamReader(path, true);
                string record;
                while ((record = file.ReadLine()) != null)
                {

                    string carname = ParseData(record, 1);
                    string price = ParseData(record, 2);
                    string quantity = ParseData(record, 3);
                    string username = ParseData(record, 4);


                    Order Ord = new Order(carname, quantity, price, username);
                    orderinfo.Add(Ord);
                    x++;
                    if (x > orderinfo.Count)
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
        public static void Add_Feedback_to_File()
        {
            string path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\feedback.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Customer C in Feedbackinfo)
            {
                file.WriteLine(C.GetFeedBack() + "," + C.getusernamefeedback());
            }

            file.Flush();
            file.Close();
        }
        public static void Read_Feedback_From_File()
        {
            string path = "C:\\Users\\hamna\\source\\repos\\FinalProjectBusinessApplicationWithGUI\\FinalProjectBusinessApplicationWithGUI\\feedback.txt";
            if (File.Exists(path))
            {
                int x = 0;
                StreamReader file = new StreamReader(path, true);
                string record;
                while ((record = file.ReadLine()) != null)
                {

                    string Feedback = ParseData(record, 1);
                    string username = ParseData(record, 2);

                    Customer C = new Customer(Feedback, username);
                    Feedbackinfo.Add(C);
                    x++;
                    if (x > Feedbackinfo.Count)
                    {
                        break;
                    }

                }
                file.Close();
            }

        }

        public static bool RemoveOrder(string carname)
        {
            bool flag = false;
            for (int i = 0; i < orderinfo.Count; i++)
            {
                if (carname == orderinfo[i].Get_productnametoOrder())
                {
                    orderinfo.RemoveAt(i);
                    Add_Orders_To_File();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return flag;
        }
        public static bool RemoveFeedBack(string username)
        {
            bool flag = false;
            for (int i = 0; i < Feedbackinfo.Count; i++)
            {
                if (username == Feedbackinfo[i].getusernamefeedback())
                {
                    Feedbackinfo.RemoveAt(i);
                    Add_Feedback_to_File();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return flag;
        }
    }
 }
