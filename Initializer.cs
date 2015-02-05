using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{
    public static class NShapeLibraryInitializer
    {
        public static void Initialize(IRegistrar registrar)
        {
            registrar.RegisterLibrary(libraryName, preferredRepositoryVersion);
            registrar.RegisterShapeType(Blade.GetShapeType());
            registrar.RegisterShapeType(BNC.GetShapeType());
            registrar.RegisterShapeType(EarthGround.GetShapeType());
            registrar.RegisterShapeType(EightP8C.GetShapeType());
            registrar.RegisterShapeType(FC.GetShapeType());
            registrar.RegisterShapeType(FourP4C.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C01.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C02.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C05.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C06.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C07.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C08.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C09.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C10.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C13.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C14.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C15.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C16.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C17.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C18.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C19.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C20.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C21.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C22.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C23.GetShapeType());
            registrar.RegisterShapeType(IEC60320_C24.GetShapeType());
            registrar.RegisterShapeType(Jumper.GetShapeType());
            registrar.RegisterShapeType(LC.GetShapeType());
            registrar.RegisterShapeType(Lug.GetShapeType());
            registrar.RegisterShapeType(MiniBNC.GetShapeType());
            registrar.RegisterShapeType(MU.GetShapeType());
            registrar.RegisterShapeType(Nema_1_15P.GetShapeType());
            registrar.RegisterShapeType(Nema_1_20P.GetShapeType());
            registrar.RegisterShapeType(Nema_5_15P.GetShapeType());
            registrar.RegisterShapeType(Nema_5_20P.GetShapeType());
            registrar.RegisterShapeType(Nema_5_30P.GetShapeType());
            registrar.RegisterShapeType(Nema_5_50P.GetShapeType());
            registrar.RegisterShapeType(Nema_6_50P.GetShapeType());
            registrar.RegisterShapeType(PowerSupplyVoltageSwitch.GetShapeType());
            registrar.RegisterShapeType(RF_N_Plug.GetShapeType());
            registrar.RegisterShapeType(RF_SMA_Plug.GetShapeType());
            registrar.RegisterShapeType(RF_TNC_Plug.GetShapeType());
            registrar.RegisterShapeType(Ring.GetShapeType());
            registrar.RegisterShapeType(RJ21.GetShapeType());
            registrar.RegisterShapeType(SC.GetShapeType());
            registrar.RegisterShapeType(T568A.GetShapeType());
            registrar.RegisterShapeType(T568B.GetShapeType());
            registrar.RegisterShapeType(WireWrap.GetShapeType());
        }

        private const string libraryName = "ElectricalConnectors";
        private const int preferredRepositoryVersion = 1;
    }
}
