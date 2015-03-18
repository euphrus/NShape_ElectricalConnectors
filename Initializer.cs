using Dataweb.NShape.Advanced;

namespace Windstream.NShape.Ports
{
	public static class NShapeLibraryInitializer
	{
		public static void Initialize(IRegistrar registrar)
		{
			registrar.RegisterLibrary(libraryName, repositoryVersion);
            registrar.RegisterShapeType(Bracket.GetShapeType());
            registrar.RegisterShapeType(Coax.GetShapeType());
            registrar.RegisterShapeType(Ethernet.GetShapeType());
            registrar.RegisterShapeType(Optic.GetShapeType());
            registrar.RegisterShapeType(Power.GetShapeType());
            registrar.RegisterShapeType(Undefined.GetShapeType());
            registrar.RegisterShapeType(Wire.GetShapeType());
		}

		private const string libraryName = "Ports";
		private const int repositoryVersion = 1;
	}
}