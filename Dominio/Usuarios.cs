﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Dominio;

public partial class Usuarios
{
    public int id { get; set; }

    public string nombre { get; set; }

    public string correo { get; set; }

    public string contraseña { get; set; }

    public virtual ICollection<Reservas> Reservas { get; set; } = new List<Reservas>();
}