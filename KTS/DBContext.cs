using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace KTS
{
   public class MyContext : DbContext
    {
        public MyContext() : base("MyContext") { }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
          }
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Profilactic> Profilactics { get; set; }

        public User GetUserByFamily(string family)
        {
            var usr = Users.FirstOrDefault(x => x.Familia == family);
             return usr;
        }
        public Device GetDeviceByName(string devName)
        {
            var Dev = Devices.FirstOrDefault(x => x.Name == devName);
            return Dev;
        }
        public List<Device> GetDevByUser(String Famil)
        {
            this.Users.Load();
            
            if (!Users.Any(x => x.Familia == Famil)) return new List<Device>();
           // User u = Users.First(x => x.Familia == Famil);
            //var UserID = Users.First(x => x.Familia == Famil).UserId;
            var DevList = Users.First(x => x.Familia == Famil).UserDevices;
            
            return DevList;
            //return Devices.Where(c => c.DeviceId == Users.Where(x => x.UserId==UserID).Where());
        }

        public string[] UserList()
        {
            var list = new List<string>();
            foreach (var usr in Users)
            {
                list.Add(usr.ToString());
            }
            return list.ToArray();
        }
        public User[] ListUsers()
        {
            List<User> returnUsers = new List<User>();
            foreach (var user in Users)
            {
                returnUsers.Add(user);
            }
            return returnUsers.ToArray();
        }
        public string[] DevList()
        {
            var list = new List<string>();
            foreach (var dev in Devices)
            {
                list.Add(dev.Name);
            }
            return list.ToArray();
        }
    }
    public class Profilactic
    {
        public int ProfilacticId { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Перидичность проведения профилактики в месяцах
        /// </summary>
        public float Period { get; set; }
       public  User user { get; set; }
       public Device device { get; set; }

        public override string ToString()
        {
            return Number + "=" + Description + "=" + Period + " месяц=" + user.Familia;// +"="+device.Name;
        }
    }
    public class User
    {
        public string Familia { get; set; }
        public string Name { get; set; }
        public string Sec_Name { get; set; }
        public int UserId { get; set; }

        public virtual List<Device> UserDevices { get; set; }
        public virtual List<Profilactic> UserProfilactics { get; set; }
        public override string ToString()
        {
            if (Familia != null && Name != null && Sec_Name != null &&
                Name.Length > 0 && Sec_Name.Length > 0)
                return Familia + " " + Name[0] + ". " + Sec_Name[0] + ".";
            else if (Familia != null) return Familia;
            else if (Name != null) return Name;
            else if (Sec_Name != null) return Sec_Name;
            else return "empty";
        }
       
    }

    public class Device
    {
        public string Name { get; set; }
        //public string ShortName { get; set; }
        public string Invent { get; set; }
        public int DeviceId { get; set; }
        public string Date { get; set; }
        public virtual List<User> DevUsers { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class Execution
    {
        public int ExecutionId { get; set; }
        public int UserId { get; set; }
        public int DeviceId { get; set; }
        public int ProfId { get; set; }
        public DateTime ExeDate { get; set; }

    }


}

