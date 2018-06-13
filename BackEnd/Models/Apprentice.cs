using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Models
{
    //nuestro modelo siempre debemos marcarlo como publico sino podremos tener incovenientes en la implementacion
    public class Apprentice
    {
        //trabajaremos con los campos o atributos que forman parte de la clase
        //sino lo marcamos como publico por defecto se entiende que es privado
        //public int id;

        //encapsulamiento para proteger el acceso directo de nuestros datos

        // metodo largo

        //    //set para asignar
        //public void Setid (int i)
        //{

        //    id = i;
        //}
        //// get para obtener un dato
        //public int Getid ()
        //{
        //    return id;

       // }

      //  metodo corto
      
        public int Id
        {
            set;get;
        }

        

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}