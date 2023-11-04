namespace Assignment_2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "Strings, selection and iteration in C#";
            FunFeatures funfeatureObj = new FunFeatures();
            funfeatureObj.Start();

            Console.Title = "Let's work with numbers!";
            MathWork mathObj = new MathWork();
            mathObj.Start();

            Console.Title = "Let's convert celsius and farenheit!";
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            temperatureConverter.Start();

            WorkingSchedule workingObjct = new WorkingSchedule();
            workingObjct.Start();
        }
    }
}