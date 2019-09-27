using CalcLED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLED
{
    public static class Definitions
    {
        public static int DefaultMaxVoltageDrop => 1;

        public static VoltageType[] Voltages { get; } = {

            new VoltageType { DisplayName = "12V", Voltage = 12},
            new VoltageType { DisplayName = "24V", Voltage = 24},
        };


        public static WireType[] WireTypes { get; } = {

            new WireType {DisplayName = "Aluminum", Resistivity = 0.0000000282m },
            new WireType {DisplayName = "Copper", Resistivity = 0.0000000172m },
            new WireType {DisplayName = "Silver", Resistivity = 0.0000000159m },
        };

        public static int WireTypeDefaultIndex => 1;
        

        public static WireCrossSection[] WireCrossSections { get; } = {

            new WireCrossSection {DisplayName = "0,5 mm2", CrossSection = 0.5m},
            new WireCrossSection {DisplayName = "0,75 mm2", CrossSection = 0.75m},
            new WireCrossSection {DisplayName = "1 mm2", CrossSection = 1},
            new WireCrossSection {DisplayName = "1,5 mm2", CrossSection = 1.5m},
            new WireCrossSection {DisplayName = "2,5 mm2", CrossSection = 2.5m},
            new WireCrossSection {DisplayName = "4 mm2", CrossSection = 4},
            new WireCrossSection {DisplayName = "6 mm2", CrossSection = 6},
            new WireCrossSection {DisplayName = "10 mm2", CrossSection = 10},
            new WireCrossSection {DisplayName = "16 mm2", CrossSection = 16},
            new WireCrossSection {DisplayName = "25 mm2", CrossSection = 25},
            new WireCrossSection {DisplayName = "35 mm2", CrossSection = 35},
        };

        public static int WireCrossSectionDefaultIndex => 6;


        public static StripType[] StripTypes { get; } = {

            new StripType {Type = "LED", Chanels = 1 },
            new StripType {Type = "RGB", Chanels = 3 },
            new StripType {Type = "RGBW", Chanels = 4 }
        };

        public static LedStrip[] LedStrips { get; } = {

            new LedStrip {Ref = "000", Name = "Led A", Type = StripTypes.Where(x=>x.Type=="LED").Single(), Voltage = Voltages.Where(x=>x.Voltage == 12).Single() , Power = 4.8m, Current = 1.1m, Lenght = 5},
            new LedStrip {Ref = "001", Name = "Led B", Type = StripTypes.Where(x=>x.Type=="RGB").Single(), Voltage = Voltages.Where(x=>x.Voltage == 12).Single(), Power = 4.1m, Current = 1.2m, Lenght = 4},
            new LedStrip {Ref = "002", Name = "Led C", Type = StripTypes.Where(x=>x.Type=="RGBW").Single(), Voltage = Voltages.Where(x=>x.Voltage == 24).Single(), Power = 3.6m, Current = 1.3m, Lenght = 3},
            new LedStrip {Ref = "003", Name = "Led D", Type = StripTypes.Where(x=>x.Type=="LED").Single(), Voltage = Voltages.Where(x=>x.Voltage == 24).Single(), Power = 3.3m, Current = 1.4m, Lenght = 2},
        };

        public static int LedStripsDefaultIndex => 0;
    }
}
