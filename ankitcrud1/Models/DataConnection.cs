using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ankitcrud1.Models
{
    public class DataConnection:DbContext
    {
        public DataConnection() : base("Data Source=LAPTOP-1R97UAQP\\SQLEXPRESS;Initial Catalog=Computer;Integrated Security=True;Pooling=False") { }
        public DbSet<Employee> Acer { get; set; }
    }
}