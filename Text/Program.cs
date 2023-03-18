//OTRAS PRUEBAS

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using EL;
//using BL;

//namespace Text
//{
// internal class Program
//{
// static void Main(string[] args)
//{
//EL_Cliente Cliente = new EL_Cliente();
//  Cliente.IdCliente = 1;
//Cliente.Nombre = "Marcos";
//Cliente.Telefono = "75269569";
//Cliente.Correo = "adrianzepeda020200@gmail.com";
//Cliente.Direccion = "Costado norte";
// Cliente.IdUsuarioActualizado = 1;

// int IdCliente = BL_Cliente.DeleteCliente(Cliente);
//  Console.WriteLine(IdCliente.ToString());
// Console.ReadLine();

// }
// }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using BL;
using System.Globalization;

namespace Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roles roles = new Roles();



            ///Eliminar

            roles.IdRol = 3;
         
            roles.IdUsuarioActualizado = 1;
            Console.WriteLine(BL_Roles.Delete(roles).ToString());
            Console.ReadLine();
            //Actualizar

            //roles.IdRol = 3;
           // roles.Rol = "Ventas";
            //roles.IdUsuarioActualizado = 1;
            //Console.WriteLine(BL_Roles.Update(roles).ToString());

           
            //Insertar


            //roles.Rol = "Jefe de Almacen";
            //roles.IdUsuarioRegistro = 1;
            //Console.WriteLine(BL_Roles.InsertarRoles(roles).IdRol);

            //roles.Rol = "Oficial de Bodega";
            //roles.IdUsuarioRegistro = 1;
            //Console.WriteLine(BL_Roles.InsertarRoles(roles).IdRol);

            //roles.Rol = "Jefe de Contabilidad";
            //roles.IdUsuarioRegistro = 1;
            //Console.WriteLine(BL_Roles.InsertarRoles(roles).IdRol);


            //roles.Rol = "Oficial Contable";
            //roles.IdUsuarioRegistro = 1;
            //Console.WriteLine(BL_Roles.InsertarRoles(roles).IdRol);

            //foreach (var item in BL_Roles.Buscar_("ca"))
            //{
            //    Console.WriteLine(item.IdRol + "\t" + item.Rol + "\n");
            //}

            //roles = BL_Roles.Registro___(5);
            //Console.WriteLine(roles.IdRol + "\t" + roles.Rol + "\n");

           // Permisos Permiso = new Permisos();
           // Permiso.IdPermiso = 3;
           // Permiso.Permiso = "Actualizar";
           // Permiso.IdUsuarioActualizado = 1;

           // Console.WriteLine(BL_Permisos.Update(Permiso));





            //Console.ReadLine();


        }
    }
}




