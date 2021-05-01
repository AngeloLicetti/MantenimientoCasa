using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MantenimientoCasa.Models
{
    public class Casa
    {
        public int id { get; set; }
        
        [Display(Name = "Número de puertas")]
        [Required(ErrorMessage = "El número de puertas es requerido")]
        public int numPuertas { get; set; }
        [Required(ErrorMessage = "El número de ventanas es requerido")]
        [Display(Name = "Número de ventanas")]
        public int numVentanas { get; set; }
        [Display(Name = "Año de construcción")]
        [Required(ErrorMessage = "El año de construcción es requerido")]
        public int anoConstruccion { get; set; }
        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "La dirección es requerida")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "La dirección tiene que contener entre 10 y 150 caracteres")]
        public string direccion { get; set; }
        [Display(Name = "Metros de área")]
        [Required(ErrorMessage = "El metraje es requerido")]
        public double metrosArea { get; set; }
    }
}