using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Collections.Generic;

namespace LeerData
{
    public class Curso
    {
        public int  CursoId {get; set;}
        public  string Titulo {get;set;}="";
        public string Descripcion {get; set;}="";
        public DateTime FechaPublicacion {get; set;}
        public Precio PrecioPromocion{get;set;}

        public ICollection<Comentario> ComentarioLista  {get;set;}
        public ICollection<Curso_Instructor> InstructoresLink  {get;set;}
    }
}