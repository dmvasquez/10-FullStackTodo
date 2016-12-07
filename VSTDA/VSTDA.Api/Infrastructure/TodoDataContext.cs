using System;
using System.Collections.Generic;
using System.Data.Entity;
using VSTDA.Api.Models;
using System.Linq;
using System.Web;

namespace VSTDA.Api.Infrastructure
{
    public class TodoDataContext : DbContext
    {
        public TodoDataContext() : base("Todo")
        {

        }

        public IDbSet<Todo> Todoes { get; set; }
    }
}