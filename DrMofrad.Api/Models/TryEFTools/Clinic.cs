﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DrMofrad.Api.Models.TryEFTools
{
    public partial class Clinic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? LangId { get; set; }

        public virtual Lang Lang { get; set; }
    }
}