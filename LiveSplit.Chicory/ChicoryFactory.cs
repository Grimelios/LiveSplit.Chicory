using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Autosplit;
using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace LiveSplit.Chicory
{
	public class ChicoryFactory : AutosplitFactory
	{
		public override IComponent Create(LiveSplitState state)
		{
			return new ChicoryComponent();
		}
	}
}
