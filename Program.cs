using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        //Hazardous distance zone classification tool
        //BS EN ISO 60079-10-1 (2015)

        //Inputs
        float S_leak;
        int P_atmospheric;
        int P;
        int Z_comp;
        int R;
        float C_p;
        float U_w;
        float Q_1;
        int F_ventilation_inefficiency;
        int T;
        int T_a;
        float C_d;
        float P_gas;
        float LFL;
        float M;
        float AIT;
        
        //InputValues
        S_leak = (float)000000.25;
        P_atmospheric = 101325;
        P = 1000000;
        Z_comp = 1;
        R = 8314;
        C_p = (float)1.6;
        U_w = (float)0.3;
        Q_1 = (float)6.804;
        F_ventilation_inefficiency = 3;
        T = 15;
        T_a = 20;
        C_d = (float)0.75;
        

        //DisplayValuesConsole
        Console.WriteLine("Hazardous distance zone classification tool");
        Console.WriteLine("");
        Console.WriteLine("Pre Populated Parameters");
        Console.WriteLine("cross section of the opening (hole), through which the fluid is released " + S_leak + "m^2");
        Console.WriteLine("atmospheric pressure " + P_atmospheric + "Pa");
        Console.WriteLine("pressure inside the container " + P + "Pa");
        Console.WriteLine("compressibility factor " + Z_comp);
        Console.WriteLine("universal gas constant " + R + "J/kmol K");
        Console.WriteLine("specific heat at constant pressure " + C_p + "J/kg K");
        Console.WriteLine("wind speed at a specified reference height or ventilation velocity at given release conditions where applicable " + U_w + "m/s");
        Console.WriteLine("volumetric flow rate of air entering the room through apertures " + Q_1 + "m^3/h");
        Console.WriteLine("ventilation inefficiency factor " + F_ventilation_inefficiency);
        Console.WriteLine("absolute temperature of the fluid, gas or liquid " + T + "°C");
        Console.WriteLine("absolute ambient temperature " + T_a + "°C");
        Console.WriteLine("discharge coefficient " + C_d);
        Console.WriteLine("");

        //SelectChemicalCompound
        Console.Write("Are you using Propane, Benzene or Natural gas? ");
        string userValue = Console.ReadLine();

        if (userValue == "Propane")
        {
            string message = "You've selected Propane...";
            Console.WriteLine(message);
            Console.WriteLine("");
            LFL = (float)0.017;
            M = (float)44.1;
            AIT = 450;
            P_gas = ((P_atmospheric * (float)M)) / (R * (T_a + (float)273.15));
            Console.WriteLine("gas density " + P_gas + " kg/m^3");
            Console.WriteLine("Lower flammable limit " + LFL + " vol/vol");
            Console.WriteLine("Molar mass " + M + " kg/kmol");
            Console.WriteLine("Auto-ignition temperature " + AIT + " °C");
        }
        else if (userValue == "Benzene")
        {
            string message = "You've selected Benzene...";
            Console.WriteLine(message);
            Console.WriteLine("");
            LFL = (float)0.012;
            M = (float)78.11;
            AIT = 498;
            P_gas = ((P_atmospheric * (float)M)) / (R * (T_a + (float)273.15));
            Console.WriteLine("gas density " + P_gas + " kg/m^3");
            Console.WriteLine("Lower flammable limit " + LFL + " vol/vol");
            Console.WriteLine("Molar mass " + M + " kg/kmol");
            Console.WriteLine("Auto-ignition temperature " + AIT + " °C"); ;
        }
        else if (userValue == "Natural gas")
        {
            string message = "You've selected Natural gas...";
            Console.WriteLine(message);
            Console.WriteLine("");
            LFL = (float)0.04;
            M = 20;
            AIT = 500;
            P_gas = ((P_atmospheric * (float)M)) / (R * (T_a + (float)273.15));
            Console.WriteLine("gas density " + P_gas + " kg/m^3");
            Console.WriteLine("Lower flammable limit " + LFL + " vol/vol");
            Console.WriteLine("Molar mass " + M + " kg/kmol");
            Console.WriteLine("Auto-ignition temperature " + AIT + " °C"); ;
        }
        else
        {
            string message = "No " + userValue + " option available sorry; please choose either Propane, Benzene or Natural gas";
            Console.WriteLine(message);
        }

        

        Console.ReadLine();



            //"Pressure inside the gas container is lower than the critical pressure (pc)";

            //"Pressure inside the gas container is higher than the critical pressure (pc)";

    }
}