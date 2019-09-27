using CalcLED.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcLED
{
    public partial class fMainWindow : Form
    {
        Wire wire = new Wire();
        LedStrip ledStrip = new LedStrip();
        CalculationReslut calculationResult;

        bool internalChangeLock = false;


        public fMainWindow()
        {
            InitializeComponent();
        }

        private void FMainWindow_Load(object sender, EventArgs e)
        {
            cVoltage.DisplayMember = nameof(VoltageType.DisplayName);
            cVoltage.ValueMember = nameof(VoltageType.Voltage);

            cWireType.DisplayMember = nameof(WireType.DisplayName);
            cWireType.ValueMember = nameof(WireType.Resistivity);

            cMaxCrossSection.DisplayMember = nameof(WireCrossSection.DisplayName);
            cMaxCrossSection.ValueMember = nameof(WireCrossSection.CrossSection);

            cLedStrip.DisplayMember = nameof(LedStrip.Name);
            cLedStrip.ValueMember = nameof(LedStrip.Ref);

            cStripType.DisplayMember = nameof(StripType.Type);
            cStripType.ValueMember = nameof(StripType.Type);

            InitializeData();
        }

        private void NPower_ValueChanged(object sender, EventArgs e)
        {
            SetUserDefinedStrip();
            RecalculateCurrent();
            AutoCalculate();
        }

        private void NCurrent_ValueChanged(object sender, EventArgs e)
        {
            SetUserDefinedStrip();
            RecalculatePower();
            AutoCalculate();
        }

        private void CVoltage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUserDefinedStrip();
            RecalculateMaxVoltageDrop();
            RecalculateCurrent();
            AutoCalculate();
        }

        private void CWireType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCalculate();
        }

        private void NWireLenght_ValueChanged(object sender, EventArgs e)
        {
            AutoCalculate();
        }

        private void NMaxVoltageDrop_ValueChanged(object sender, EventArgs e)
        {
            AutoCalculate();
        }

        private void CMaxCrossSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCalculate();
        }

        private void CStripType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUserDefinedStrip();
        }

        private void CLedStrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cLedStrip.SelectedItem == null)
            {
                return;
            }

            internalChangeLock = true;

            ledStrip = (LedStrip)cLedStrip.SelectedItem;

            cStripType.SelectedItem = ledStrip.Type;
            cVoltage.SelectedItem = ledStrip.Voltage;
            nCurrent.Value = ledStrip.Current;
            tStripLenght.Text = ledStrip.Lenght.ToString();

            internalChangeLock = false;
        }

        private void InitializeData()
        {
            cVoltage.DataSource = Definitions.Voltages;

            cWireType.DataSource = Definitions.WireTypes;
            cWireType.SelectedIndex = Definitions.WireTypeDefaultIndex;

            cMaxCrossSection.DataSource = Definitions.WireCrossSections;
            cMaxCrossSection.SelectedIndex = Definitions.WireCrossSectionDefaultIndex;

            cStripType.DataSource = Definitions.StripTypes;

            cLedStrip.DataSource = Definitions.LedStrips;
            cLedStrip.SelectedIndex = Definitions.LedStripsDefaultIndex;

            nWireLenght.Value = 10;
            nMaxVoltageDrop.Value = Definitions.DefaultMaxVoltageDrop;
        }

        private void RecalculateCurrent()
        {
            if (cVoltage.SelectedValue != null)
            {
                nCurrent.Value = nPower.Value / Convert.ToDecimal(cVoltage.SelectedValue);
            }
            else
            {
                nCurrent.Value = default;
            }
        }

        private void RecalculatePower()
        {
            if (cVoltage.SelectedValue != null)
            {
                nPower.Value = nCurrent.Value * Convert.ToDecimal(cVoltage.SelectedValue);
            }
            else
            {
                nPower.Value = default;
            }
        }

        private void RecalculateMaxVoltageDrop()
        {
            if (cVoltage.SelectedValue != null)
            {
                nMaxVoltageDrop.Maximum = Convert.ToDecimal(cVoltage.SelectedValue);

                if (nMaxVoltageDrop.Value >= nMaxVoltageDrop.Maximum)
                {
                    nMaxVoltageDrop.Value = Definitions.DefaultMaxVoltageDrop;
                }
            }
            else
            {
                nMaxVoltageDrop.Maximum = default;
                nMaxVoltageDrop.Value = default;
            }
        }

        private void AutoCalculate()
        {
            if (cWireType.SelectedItem == null || cVoltage.SelectedItem == null || cMaxCrossSection.SelectedItem == null)
            {
                return;
            }

            wire.WireType = (WireType)cWireType.SelectedItem;
            wire.Lenght = nWireLenght.Value;

            ledStrip.Type = (StripType)cStripType.SelectedItem;
            ledStrip.Voltage = (VoltageType)cVoltage.SelectedItem;
            ledStrip.Power = nCurrent.Value;
            ledStrip.Current = nCurrent.Value;
            ledStrip.Lenght = 0;

            var maxCs = (decimal)cMaxCrossSection.SelectedValue;

            calculationResult = new Helper().FindWireCeossSection(wire, ledStrip, nMaxVoltageDrop.Value, maxCs);
            if (calculationResult != null)
            {
                tVoltageDrop.Text = calculationResult.VoltageDrop.ToString("0.00");
                tCrossSection.Text = calculationResult.CrossSection.CrossSection.ToString();
                tVoltageDrop.BackColor = Color.YellowGreen;
                tCrossSection.BackColor = Color.YellowGreen;
            }
            else
            {
                tVoltageDrop.Text = "! >" + nMaxVoltageDrop.Value;
                tCrossSection.Text = "! >" + maxCs;
                tVoltageDrop.BackColor = Color.Tomato;
                tCrossSection.BackColor = Color.Tomato;
            }
        }

        private void SetUserDefinedStrip()
        {
            if (internalChangeLock)
            {
                return;
            }

            cLedStrip.SelectedItem = null;
            ledStrip.Ref = "";
            ledStrip.Name = "[User Defined]";
            ledStrip.Lenght = 0;

            tStripLenght.Text = "";
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            PrintHelpPage();
        }

        private void PrintHelpPage()
        {
            var html = @"
<html>
	<body>
		<h3>You calculation for a Led Strip circut.</h3>
		<div>
			<table>
				<tbody>
					<tr><td colspan=""2""><b>LED Strip</b></td></tr>
					<tr><td>Strip Model</td><td>{0}</td></tr>
					<tr><td>Type</td><td>{1}</td></tr>
					<tr><td>Voltage</td><td>{2}</td></tr>
					<tr><td>Power</td><td>{3}</td></tr>
					<tr><td>Current</td><td>{4}</td></tr>
					<tr><td>Lenght</td><td>{5}</td></tr>
					<tr><td>&nbsp;</td></tr>
					<tr><td colspan=""2""><b>Wire</b></td></tr>
					<tr><td>Wire type</td><td>{6}</td></tr>
					<tr><td>Lenght</td><td>{7}</td></tr>
					<tr><td>Voltage drop</td><td><font color=""blue""><b>{8}</b></font></td></tr>
                    <tr><td>Cross section</td><td><font color=""blue""><b>{9}</b></font></td></tr>
				</tbody>
			</table>
		</div>
	</body>
</html>";

            var formattedHtml = string.Format(html,
                                              ledStrip.Name,
                                              ledStrip.Type.Type,
                                              ledStrip.Voltage.DisplayName,
                                              ledStrip.Power.ToString("0.0W"),
                                              ledStrip.Current,
                                              ledStrip.Lenght,
                                              wire.WireType.DisplayName,
                                              wire.Lenght,
                                              calculationResult.VoltageDrop.ToString("0.00V"),
                                              calculationResult.CrossSection.DisplayName
                                            );

            using (PrintWindow pw = new PrintWindow(ledStrip.Name, formattedHtml))
            {
                pw.ShowDialog(this);
            }
        }
    }
}
