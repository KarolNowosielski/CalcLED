using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLED.Models;


namespace CalcLED
{
    public class Helper
    {
        const decimal MaxCurrentPer1mm2 = 9;
        const int NumberOfWiresInCircut = 2;
        const int M2toMM2 = 1000000;

        public CalculationReslut FindWireCeossSection(Wire wire, LedStrip ledStrip, decimal maxVoltageDrop, decimal maxCrossSection)
        {
            foreach (var cs in Definitions.WireCrossSections.Where(x => x.CrossSection <= maxCrossSection).OrderBy(x => x.CrossSection))
            {
                // Condition 1 - Max Current
                if (ledStrip.Current > cs.CrossSection * MaxCurrentPer1mm2)
                {
                    continue;
                }

                // Condition 2 - Max Voltage Drop
                var resistance = wire.WireType.Resistivity * M2toMM2 * wire.Lenght * NumberOfWiresInCircut / cs.CrossSection;
                var voltageDrop = resistance * ledStrip.Current;
                if (voltageDrop > maxVoltageDrop)
                {
                    continue;
                }

                // Both conditions met, so return result
                return new CalculationReslut { VoltageDrop = voltageDrop, CrossSection = cs };
            }

            return null;
        }
    }
}
