using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TODO_list.Models;

namespace TODO_list.Data
{
    public class TODO_listContext : DbContext
    {
        public TODO_listContext (DbContextOptions<TODO_listContext> options)
            : base(options)
        {
        }

        public DbSet<TODO_list.Models.Task> Task { get; set; }
    }
}
