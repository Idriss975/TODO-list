using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODO_list.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public ICollection<Task> Blogs { get; set; }
    }
    public class Task
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public Task_status Status { get; set; }
        public String? Description { get; set; }
        public AppUser AppUser { get; set; }
    }

    public enum Task_status
    {
        Closed,
        High_Priority,
        Medium_Priority,
        Low_Priority,
        Open
    }
}
