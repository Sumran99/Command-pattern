using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4_a_
{
    class CeilingFanOffCommand:Command
    {
		CeilingFan ceilingFan;
		int preSpeed;
		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}
		public void execute()
		{
			preSpeed = ceilingFan.getSpeed();
			ceilingFan.off();
			Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
			foreach (Label lbl in myPanel.Controls.OfType<Label>())
			{

				if (lbl.Name == "lbl_ceilingFan")
				{
					lbl.Text = "Ceiling fan Speed: " + ceilingFan.getSpeed().ToString();
				}

			}
		}
		public void undo()
		{
			if (preSpeed == Hottub.HIGH)
			{
				ceilingFan.high();
			}
			else if (preSpeed == Hottub.MEDIUM)
			{
				ceilingFan.medium();
			}
			else if (preSpeed == Hottub.LOW)
			{
				ceilingFan.low();
			}
			else if (preSpeed == Hottub.OFF)
			{
				ceilingFan.off();
			}
			Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
			foreach (Label lbl in myPanel.Controls.OfType<Label>())
			{

				if (lbl.Name == "lbl_ceilingFan")
				{
					lbl.Text = "Ceiling fan Speed: " + ceilingFan.getSpeed().ToString();
				}

			}
		}

	}
}
