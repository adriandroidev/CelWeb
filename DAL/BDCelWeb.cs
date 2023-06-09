﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public class BDCelWeb : DbContext
    {
        public BDCelWeb() : base(Conexion.ConexionString())
        {

        }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Formularios> Formularios { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<RolFormularios> RolFormularios { get; set; }
        public virtual DbSet<RolPermisos> RolPermisos { get; set; }
    }
}
