﻿namespace RestApi_1304.Models
{
    public class Veranstaltungen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Datum { get; set; }

        public string Ort { get; set; }

    }
}
