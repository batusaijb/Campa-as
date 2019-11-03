using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Campañas.Models
{
    public class Campaña
    {
        [DataMember(Name = "idCamapana")]
        [Key]
        public int? IdCamapana { get; set; }

        /// <summary>
        /// Gets or Sets Descripcion
        /// </summary>
        [DataMember(Name = "descripcion")]
        public string Descripcion { get; set; }

        /// <summary>
        /// Gets or Sets FechaInicio
        /// </summary>
        [DataMember(Name = "fechaInicio")]
        public string FechaInicio { get; set; }

        /// <summary>
        /// Gets or Sets FechaFin
        /// </summary>
        [DataMember(Name = "fechaFin")]
        public string FechaFin { get; set; }

        /// <summary>
        /// Gets or Sets UsuarioCreador
        /// </summary>
        [DataMember(Name = "usuarioCreador")]
        public string UsuarioCreador { get; set; }

        /// <summary>
        /// Gets or Sets FechaCreacion
        /// </summary>
        [DataMember(Name = "fechaCreacion")]
        public string FechaCreacion { get; set; }

        /// <summary>
        /// Gets or Sets RutaBanner
        /// </summary>
        [DataMember(Name = "rutaBanner")]
        public string RutaBanner { get; set; }

        /// <summary>
        /// Gets or Sets IdProducto
        /// </summary>
        [DataMember(Name = "idProducto")]
        public int? IdProducto { get; set; }

        /// <summary>
        /// Gets or Sets nombreProducto
        /// </summary>
        [DataMember(Name = "nombreProducto")]
        public string nombreProducto { get; set; }

        /// <summary>
        /// Gets or Sets nombreProducto
        /// </summary>
        [DataMember(Name = "estado")]
        public string estado { get; set; }
    }
}
