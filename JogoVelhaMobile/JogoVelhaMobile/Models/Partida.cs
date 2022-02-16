using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelhaXamarin.Models
{
    public class Partida
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Ganhador { get; set; }
        public string Data { get; set; }
    }
}
