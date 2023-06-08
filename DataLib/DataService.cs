using DataModels;

namespace DataLib
{
    public static class DataService
    {
        public static DataModel GetDataModel()
        {
            return new DataModel();
        }

        public static string Test()
        {
            return "test";
        }
    }
}
