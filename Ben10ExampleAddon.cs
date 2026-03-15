using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace Ben10ExampleAddon {
	public class Ben10ExampleAddon : Mod {
		public override void Load() {
			if (!ModLoader.TryGetMod("Ben10Mod", out _)) {
				Logger.Warn("Ben10Mod was not found. This addon requires Ben10Mod.");
			}
		}
	}
}