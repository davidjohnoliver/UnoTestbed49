using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoTestbed49.Skia.Tizen
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new UnoTestbed49.App(), args);
			host.Run();
		}
	}
}
