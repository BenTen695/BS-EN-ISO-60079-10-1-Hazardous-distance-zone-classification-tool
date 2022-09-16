//Hazardous distance zone classification tool
//BS EN ISO 60079-10-1 (2015)

internal class Program
{
    public static void Main(string[] args)
    {
        // Defined Parameters (B.1)
        float C_p = (float)1.6; //specific heat at constant pressure (J/kg K);
        float Gamma; //polytropic index of adiabatic expansion or ratio of specific heats (dimensionless);
        float M; //molar mass of gas or vapour (kg/kmol)
        int P = 1000000; //pressure inside the container (Pa)
        float P_a = 101325; //atmospheric pressure (101 325 Pa);
        double P_c; //critical pressure (Pa);
        int R = 8314; //universal gas constant (8314 J/kmol K);
        float P_gas; //liquid density (kg/m3);
        float S_leak = (float)000000.25; //cross section of the opening (hole), through which the fluid is released (m2)
        int T = 15; //absolute temperature of the fluid, gas or liquid (K);
        int T_a = 20; //absolute ambient temperature (K)
        float U_w = (float)0.3; //wind speed over the liquid pool surface (m/s);
        int Z_comp = 1; //compressibility factor (dimensionless). 

        // Defined Parameters (C.1)
        float C_d = (float)0.75; //discharge coefficient (dimensionless), characteristic of large ventilation openings, inlet or outlet, and accounts for the turbulence and viscosity, typically 0, 50 to 0, 75; 
        float Q_1 = (float)6.804;; //volumetric flow rate of air entering the room through apertures (m3/s);
        int F_ventilation_inefficiency = 3; //mean background concentration Xb in the room divided by the concentration at the ventilation outlet(dimensionless);

        // Undefined Parameters (ChemicalCompoundSpecific)
        float AIT; //Autoignition temperature (°C)
        float LFL; //lower flammable limit (vol/vol);

        //Console Output
        Console.WriteLine("Hazardous distance zone classification tool");
        Console.WriteLine("");
        Console.WriteLine("Pre Populated Parameters");
        Console.WriteLine("cross section of the opening (hole), through which the fluid is released " + S_leak + "m^2");
        //Console.WriteLine("");
        Console.WriteLine("atmospheric pressure " + P_a + "Pa");
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
            //PropaneChemicalValues
            LFL = (float)0.017; //Lower Flammable Limit
            M = (float)44.1; //molar mass of gas or vapour (kg/kmol)
            AIT = 450; //Autoignition temperature (°C)

            //UniqueFormulas
            P_gas = P_a * (float)M / (R * (T_a + (float)273.15));
            Gamma = (float)M * (float)C_p / (M * C_p - R / 1000);
            double CriticalPressure = P_a * Math.Pow((((float)Gamma + 1) / 2), (float)Gamma / ((float)Gamma - 1));

            //Console Output
            string message = "You've selected Propane...";
            Console.WriteLine(message);
            Console.WriteLine("");
            Console.WriteLine("gas density " + P_gas + " kg/m^3");
            Console.WriteLine("Lower flammable limit " + LFL + " vol/vol");
            Console.WriteLine("Molar mass " + M + " kg/kmol");
            Console.WriteLine("Auto-ignition temperature " + AIT + " °C");
            Console.WriteLine("Polytropic index of adiabatic expansion " + Gamma);
            Console.WriteLine("critical pressure " + CriticalPressure + " Pa");
        }
        else if (userValue == "Benzene")
        {
            //BenzeneChemicalValues
            LFL = (float)0.012; //Lower Flammable Limit
            M = (float)78.11; //molar mass of gas or vapour (kg/kmol)
            AIT = 498; //Autoignition temperature (°C)

            //UniqueFormulas
            P_gas = P_a * (float)M / (R * (T_a + (float)273.15));
            Gamma = (float)M * (float)C_p / (M * C_p - R / 1000);
            double CriticalPressure = P_a * Math.Pow((((float)Gamma + 1) / 2), (float)Gamma / ((float)Gamma - 1));

            string message = "You've selected Benzene...";
            Console.WriteLine(message);
            Console.WriteLine("");
            Console.WriteLine("gas density " + P_gas + " kg/m^3");
            Console.WriteLine("Lower flammable limit " + LFL + " vol/vol");
            Console.WriteLine("Molar mass " + M + " kg/kmol");
            Console.WriteLine("Auto-ignition temperature " + AIT + " °C");
            Console.WriteLine("Polytropic index of adiabatic expansion " + Gamma);
            Console.WriteLine("critical pressure " + CriticalPressure + " Pa");
        }
        else if (userValue == "Natural gas")
        {
            //NaturalGasChemicalValues
            LFL = (float)0.04; //Lower Flammable Limit
            M = 20; //molar mass of gas or vapour (kg/kmol)
            AIT = 500; //Autoignition temperature (°C)         

            //UniqueFormulas
            P_gas = P_a * (float)M / (R * (T_a + (float)273.15));
            Gamma = (float)M * (float)C_p / (M * C_p - R / 1000);
            double CriticalPressure = P_a * Math.Pow((((float)Gamma + 1) / 2), (float)Gamma / ((float)Gamma - 1));

            //Console Output
            string message = "You've selected Natural gas...";
            Console.WriteLine(message);
            Console.WriteLine("");
            Console.WriteLine("gas density " + P_gas + " kg/m^3");
            Console.WriteLine("Lower flammable limit " + LFL + " vol/vol");
            Console.WriteLine("Molar mass " + M + " kg/kmol");
            Console.WriteLine("Auto-ignition temperature " + AIT + " °C");
            Console.WriteLine("Polytropic index of adiabatic expansion " + Gamma);
            Console.WriteLine("critical pressure " + CriticalPressure + " Pa");
        }
        else
        {
            //Console Output
            string message = "No " + userValue + " option available sorry; please choose either Propane, Benzene or Natural gas";
            Console.WriteLine(message);
        }

    }
}