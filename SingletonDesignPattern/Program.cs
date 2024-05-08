namespace SingletonPatternExample
{
    class ThisApplication
    {
        private static ThisApplication _instance;
        private string name = "ThisApplication";

        private ThisApplication() { }

        public static ThisApplication Instance()
        {
            if (_instance == null)
            {
                _instance = new ThisApplication();
            }
            return _instance;
        }

        public string GetName() { return name; }

        public void SetName(string n) { name = n; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Pattern Example");

            ThisApplication app1 = ThisApplication.Instance();
            app1.SetName("App1");
            Console.WriteLine(app1.GetName());

            ThisApplication app2 = ThisApplication.Instance();
            app2.SetName("App2");
            Console.WriteLine(app2.GetName());

            Console.WriteLine(app1.GetName() + " = " + app2.GetName());
        }
    }
}
