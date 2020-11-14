using System.Configuration;
using TopSystemsOOPExample.Classes.Factories;
using TopSystemsOOPExample.Interfaces;

namespace TopSystemsOOPExample.Classes.Singleton
{
    internal sealed class Singleton
    {
        private static Singleton s_value = new Singleton();

        private Singleton()
        {
            ShapesFactory = new DefaultShapesFactory();
            var dataSourceType = ConfigurationManager.AppSettings["datasourcetype"];

            if (dataSourceType == "xmldata")
                ShapesFactory = new ShapesFromXmlFactory();
            if (dataSourceType == "linedata")
                ShapesFactory = new ShapesFromLinesFactory();
        }

        public IShapesFactory ShapesFactory { get; set; }

        public static Singleton GetSingleton()
        {
            return s_value;
        }
    }
}
