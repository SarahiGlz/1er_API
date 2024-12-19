using System;
using LeerData;
using Microsoft.EntityFrameworkCore;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            //consulta tipica usando entity framework core
        
            /*using (var db = new AppVentaCursosContext())
            {
                var cursos = db.Curso.AsNoTracking();
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo + curso.Descripcion);
                }
            } */

            using(var db = new AppVentaCursosContext()){
                /* var cursos = db.Curso.Include(p=> p.PrecioPromocion).AsNoTracking();
                foreach(var curso in cursos){
                    Console.WriteLine(curso.Titulo + "----" + curso.PrecioPromocion.PrecioActual);
                } */

                //ver el nombre del curso y los comentarios que tiene
             /*    var cursos=db.Curso.Include(c=>c.ComentarioLista).AsNoTracking();
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    foreach(var comentario in curso.ComentarioLista){
                        Console.WriteLine("*******"+ comentario.ComentarioTexto);
                    }
                } */

                //ver el curso y su (s)instructor(es)
                var cursos=db.Curso.Include(c=> c.InstructoresLink).ThenInclude(ci=> ci.Instructor);
                foreach(var curso in cursos){
                    Console.WriteLine(curso.Titulo);
                    foreach(var insLink in curso.InstructoresLink){
                        Console.WriteLine("*******"+ insLink.Instructor.Nombre);                    }
                }
           
           
            }

        }
    }
}