using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace LINQ_Single___SingleOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "IronMan" };
            // string[] Names = { };
            // In case we Give unexistant word or We declar an empty string, Programm will Give Error console soo we must use the SingleOrDefault(); Method to avoide the exception

            var FirstItem = Names.Single(); // IronMan

            #region comment 
            // In Single(); method we get the item exist in string list but the list must contain one item .
            #endregion
                
                Console.Write(FirstItem); 

            // Console.Write(FirstItem == null); // Does not exist soo we ask the programm if not exist == Null return True . 
        }
    }
}
