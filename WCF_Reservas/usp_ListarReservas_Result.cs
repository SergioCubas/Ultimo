//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Reservas
{
    using System;
    
    public partial class usp_ListarReservas_Result
    {
        public string Nombre_completo { get; set; }
        public string Numero_Documento { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string genero { get; set; }
        public string Asiento { get; set; }
        public string tipo { get; set; }
        public decimal precio { get; set; }
        public string Aeropuerto_Origen { get; set; }
        public string Aerolinea { get; set; }
        public string Pais_Origen { get; set; }
        public string Ciudad_Origen { get; set; }
        public string Imagen_Origen { get; set; }
        public Nullable<System.DateTime> Fecha_Salida { get; set; }
        public string Aeropuerto_Destino { get; set; }
        public string Pais_Destino { get; set; }
        public string Ciudad_Destino { get; set; }
        public string Imagen_Destino { get; set; }
        public Nullable<System.DateTime> Fecha_Llegada { get; set; }
        public Nullable<int> Estado_Reserva { get; set; }
        public Nullable<int> Estado_Pago { get; set; }
    }
}
