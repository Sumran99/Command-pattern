using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4_a_
{
    class HottubOffCommand:Command
    {
		Hottub hottub;
		int preTemp;
		public HottubOffCommand(Hottub hottub)
		{
			this.hottub = hottub;
		}
		public void execute()
		{
			preTemp = hottub.getTemperature();
			hottub.off();
			Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
			foreach (Label lbl in myPanel.Controls.OfType<Label>())
			{

				if (lbl.Name == "lbl_hottubTemp")
				{
					lbl.Text = "Hottub temperature level: " + hottub.getTemperature().ToString();
				}

			}
		}
		public void undo()
		{
			if (preTemp == Hottub.HIGH)
			{
				hottub.high();
			}
			else if (preTemp == Hottub.MEDIUM)
			{
				hottub.medium();
			}
			else if (preTemp == Hottub.LOW)
			{
				hottub.low();
			}
			else if (preTemp == Hottub.OFF)
			{
				hottub.off();
			}
			Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
			foreach (Label lbl in myPanel.Controls.OfType<Label>())
			{

				if (lbl.Name == "lbl_hottubTemp")
				{
					lbl.Text = "Hottub temperature level: " + hottub.getTemperature().ToString();
				}

			}
		}
	}
}
