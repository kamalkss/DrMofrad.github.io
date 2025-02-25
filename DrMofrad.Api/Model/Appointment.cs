﻿using System;

#nullable disable

namespace DrMofrad.Api.Model
{
    public class Appointment
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Cell { get; set; }
        public string Clinic { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string Text { get; set; }
        public bool? IsReaded { get; set; }
    }
}