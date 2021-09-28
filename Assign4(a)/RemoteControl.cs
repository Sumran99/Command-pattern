using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4_a_
{
	class RemoteControl
	{
		Command[] onCommands;
		Command[] offCommands;
		Command undoCommand;

		public RemoteControl()
		{
			onCommands = new Command[10];
			offCommands = new Command[10];
			
			Command noCommand = new NoCommand();
			for (int i = 0; i < 10; i++)
			{
				onCommands[i] = noCommand;
				offCommands[i] = noCommand;
			}
			undoCommand = noCommand;

			
		}

		public void setCommand(int slot, Command onCommand, Command offCommand)
		{
			
			onCommands[slot] = onCommand;
			offCommands[slot] = offCommand;
		}
		public void onButtonWasPushed(int slot)
		{
			
			onCommands[slot].execute();
			undoCommand = onCommands[slot];
		}

		public void offButtonWasPushed(int slot)
		{
			offCommands[slot].execute();
			undoCommand = offCommands[slot];
		}

		public void undoButtonWasPushed()
		{
			undoCommand.undo();
		}


	}
}
