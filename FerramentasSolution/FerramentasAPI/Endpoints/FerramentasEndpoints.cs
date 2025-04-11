using FerramentasAPI.Endpoints.Ferramentas;

namespace FerramentasAPI.Endpoints
{
    public static class FerramentaEndpoints
    {
        public static void MapFerramentaEndpoints(this WebApplication app)
        {
            app.MapPostFerramenta();
            app.MapGetFerramentaById();
            app.MapPutFerramenta();
            app.MapDeleteFerramenta();
            app.MapGetListFerramenta();
        }
    }
}
