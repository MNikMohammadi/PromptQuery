namespace PromptQuery
{
    using System;


    public class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            do
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("نام جدول را وارد کنید :");
                string tableName = Console.ReadLine();
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("(لطفا ستون های مورد نظر را وارد کنید (با کاما از هم جدا کنید ");
                string columns = Console.ReadLine();
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("نوع عملیات را انتخاب کنید: SELECT, WHERE, JOIN");
                string operation = Console.ReadLine().ToUpper();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-------------------------------------");


                string query = string.Empty;

                switch (operation)
                {

                    case "SELECT":
                        query = $"SELECT{columns} FROM {tableName}";
                        break;


                    case "WHERE":
                        
                        
                        
                        Console.WriteLine("لطفاً شرط WHERE را وارد کنید (مثال: ColumnName = 'Value'):");
                        string whereCondition = Console.ReadLine();
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("-------------------------------------");

                        query = $"SELECT{columns} FROM {tableName} WHERE {whereCondition}";
                        break;
                        


                    case "JOIN":
                        Console.WriteLine("نام جدول را وارد کنید :");
                        string secondTable = Console.ReadLine();
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine("لطفا شرط Join" + "وارد کنید " + "(مثال: Table1.Column = Table2.Column):");


                        string joinCondition = Console.ReadLine();

                        query = $"SELECT{columns} FROM {tableName} JOIN {secondTable} WHERE {joinCondition}";
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("-------------------------------------");
                        break;

                    default:
                        Console.WriteLine("عملیات انتخاب شده معتبر نیست.");
                        break;
                }

                if (!string.IsNullOrEmpty(query))
                {
                    Console.WriteLine("\nکوئری ساخته شده");
                    Console.WriteLine(query);
                }
                Console.WriteLine("\nپایان برنامه. کلید Enter را فشار دهید.");
                Console.ReadLine();

                Console.WriteLine("برنامه در حال اجرا است...");

                // سوال از کاربر برای ادامه یا خروج
                Console.WriteLine("آیا می‌خواهید برنامه دوباره اجرا شود؟ (Y/N)");
                userChoice = Console.ReadLine()?.ToUpper();

            } while (userChoice == "Y");

            Console.WriteLine("Program Completed By MNikMohammadi");

        }
    }
}
