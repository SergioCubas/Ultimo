//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Proyecto_MVC.Models
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Tb_avion
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_avion()
        {

            this.Tb_vuelo = new HashSet<Tb_vuelo>();

        }

        [Display(Name = "Codigo Avion")]
        public int idAvion { get; set; }

        [Display(Name = "Capacidad")]
        public int capacidad { get; set; }

        [Display(Name = "Codigo")]
        public string codigo { get; set; }

        [Display(Name = "Fecha de Registro")]
        public Nullable<System.DateTime> F_Registro { get; set; }

        [Display(Name = "Fecha de Modificacion")]
        public Nullable<System.DateTime> F_Modificacion { get; set; }


        [Display(Name = "Estado")]
        public String est
        {
            get
            {
                return
                (
                    estado == 1 ? "Activo" :
                    "Desactivo"
                );
            }
        }
        public Nullable<int> estado { get; set; }

        [Display(Name = "Codigo Aerolinea")]
        public Nullable<int> idAerolinea { get; set; }



        public virtual Tb_aerolinea Tb_aerolinea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Tb_vuelo> Tb_vuelo { get; set; }

    }

}