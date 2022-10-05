using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.ComponentModel.DataAnnotations;
using System.Buffers.Text;

namespace NewMir
{
    public class BloggingContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Talon> Talons { get; set; }
        public DbSet<Good_Talon> Good_Talons { get; set; }
        public DbSet<Story> Stores { get; set; }
        public DbSet<Vrach> Vrachs { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Kabinet> Kabinets { get; set; }
        public DbSet<Yslyga> Yslygs { get; set; }

        public BloggingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=users.db");

        
    }

    public class User
    {
        //public User() { }

        //public User(int id,string login,string password,string email) 
        //{
        //    this.id = id;
        //    this.login = login;
        //    this.password = password;
        //    this.email = email;
        //}
        private string Login, Password, Email, Name, Fio, Otchestvo, Data;
        public int id
        {
            get;
            set;
        }

        public string login
        {
            get { return Login;}
            set { Login = value;}
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string fio
        {
            get { return Fio; }
            set { Fio = value; }
        }
        public string otchestvo
        {
            get { return Otchestvo; }
            set { Otchestvo = value; }
        }
        public string data
        {
            get { return Data; }
            set { Data = value; }
        }
        public bool prava_dostypa { get; set; }

        public string img { get; set; }

        
 
    }
    public class Talon
    {
        public int id
        {
            get;
            set;
        }
        public string name { get; set; }
        public string fio { get; set; }
        public string otchestvo { get; set; }
        public string vrach { get; set; }
        
        public string data { get; set; }
        public string time { get; set; }
        public int yslyga { get; set; }
    }
    public class Good_Talon
    {
        public int id
        {
            get;
            set;
        }
        public string name { get; set; }
        public string fio { get; set; }
        public string otchestvo { get; set; }
        public string vrach { get; set; }
        
        public string data { get; set; }
        public string time { get; set; }
        public string name_hospital { get; set; }
        public string number_kabinet { get; set; }
        public int stoimost { get; set; }
    }
    public class Story
    {
        public int id
        {
            get;
            set;
        }
        public string name { get; set; }
        public string fio { get; set; }
        public string otchestvo { get; set; }
        public string vrach { get; set; }    
        public string data { get; set; }
        public string time { get; set; }
        public string name_hospital { get; set; }
        public int number_kabinet { get; set; }
        public int stoimost { get; set; }
    }
    public class Kabinet
    {
        public int id
        {
            get;
            set;
        }
        public int number_kabinet { get; set; }
    }
    public class Vrach
    {
        public int id
        {
            get;
            set;
        }
        public string name { get; set; }
        
        public string fio { get; set; }
        public string otchestvo { get; set; }
        public string spechialnost { get; set; }
        public string Grahic_vrach { get; set; }
        public string time { get; set; }
        public string name_hospital { get; set; }
        public int number_kabinet { get; set; }
        public string img { get; set; }
    }
    public class Hospital
    {
        public int id
        {
            get;
            set;
        }
        public string name { get; set; }
        
        public string adres { get; set; }

        public string all_vrach { get; set; }

        public string img { get; set; }

    }
    public class Yslyga
    {
        public int id
        {
            get;
            set;
        }
        public string name { get; set; }
        public int stoimost { get; set; }
    }
}

