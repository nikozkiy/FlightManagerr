using System;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using System.Data.Entity.Validation;
namespace FlightManagerr
{
    public class FlightManager : DbContext
    {


        public FlightManager() : base("name=FlightManager")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }


    }

    public class User
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string Name { get; set; }


        public User(string name, string username)
        {
            Name = name;
            Username = username;
        }
        public User()
        {
        }





    }

    public class Flight
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Reservation> ReservationList { get; set; }

        public Flight(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }


        public Flight()
        {
        }

    }
    public class Reservation
    {

        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public virtual User UserId { get; set; }
        [Required]
        public virtual List<Flight> Flight { get; set; }
        //public object User { get;  set; }
        //public string Flight { get; set; }

        //public Reservation(string name, string username, string flight)
        //{
        //    this.Name = name;
        //    this.Username = username;
        //    this.Flight = new List<Flights>();
        //    this.Flight.Add(PickFlight(db));




        //}
        public Reservation()
        { }





    }


}
