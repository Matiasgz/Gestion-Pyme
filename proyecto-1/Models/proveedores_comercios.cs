//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyecto_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class proveedores_comercios
    {
        public int id_provedor_comercio { get; set; }
        public int id_proveedor { get; set; }
        public int id_comercio { get; set; }
    
        public virtual comercio comercio { get; set; }
        public virtual proveedores proveedores { get; set; }
    }
}