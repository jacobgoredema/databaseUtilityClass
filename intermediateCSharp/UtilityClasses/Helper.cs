using System.Configuration;

namespace intermediateCSharp.UtilityClasses
{
    public class Helper
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["EmpConnection"].ConnectionString;
            }
        }
    }
}