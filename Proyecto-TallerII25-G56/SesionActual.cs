namespace Proyecto_TallerII25_G56
{
    public static class SesionActual
    {
        public static int IdUsuario { get; set; } = 0;
        public static string Nombre { get; set; } = string.Empty;
        public static string Apellido { get; set; } = string.Empty;
        public static string Correo { get; set; } = string.Empty;
        public static string TipoUsuario { get; set; } = string.Empty;
        public static bool Activo { get; set; }

        public static void Limpiar()
        {
            IdUsuario = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Correo = string.Empty;
            TipoUsuario = string.Empty;
        }
    }
}
