using LiteDB;

namespace Tarifario
{
    public class RepositorioVehiculos : IDisposable
    {
        private readonly LiteDatabase _db;
        private readonly ILiteCollection<Vehiculo> _vehiculos;

        public RepositorioVehiculos(string rutaArchivoDb)
        {
            _db = new LiteDatabase($"Filename={rutaArchivoDb};Connection=shared");
            _vehiculos = _db.GetCollection<Vehiculo>("vehiculos");
        }

        public int Guardar(Vehiculo vehiculo)
        {
            return _vehiculos.Insert(vehiculo);
        }

        public bool Actualizar(Vehiculo vehiculo)
        {
            return _vehiculos.Update(vehiculo);
        }

        public bool Eliminar(int id)
        {
            return _vehiculos.Delete(id);
        }

        public List<Vehiculo> ObtenerTodos()
        {
            return _vehiculos
                .FindAll()
                .OrderByDescending(v => v.Id)
                .ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}