using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class EncuestaRespondida
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EncuestaRespondidaId { get; set; }

        [Display(Name = "Fecha Respuesta")]
        [DataType(DataType.Date)]
        public DateTime datetimeRespuestaEncuesta { get; set; }

        //FK con Encuesta        
        public int EncuestaId { get; set; }
        [Display(Name = "Encuesta Respondida")]
        [ForeignKey("EncuestaId")]
        public virtual Encuesta encuesta { get; set; }

        
        public int PreguntaId { get; set; }
        [Display(Name = "Pregunta Respondida")]
        [ForeignKey("PreguntaId")]
        public virtual Pregunta pregunta { get; set; }

        
        public int OpcionPreguntaId { get; set; }
        [Display(Name = "Opcion Seleccionada")]
        [ForeignKey("OpcionPreguntaId")]
        public virtual OpcionPregunta opcionPregunta { get; set; }

        //FK con Usuario
        public int UsuarioId { get; set; }
        [Display(Name = "Usuario")]
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }


    }
}
