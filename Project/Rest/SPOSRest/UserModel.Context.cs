﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPOSRest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class POSEntities1 : DbContext
    {
        public POSEntities1()
            : base("name=POSEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<USER> USERS { get; set; }
    
        public virtual ObjectResult<getUsers_Result> getUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getUsers_Result>("getUsers");
        }
    
        public virtual ObjectResult<validateUser_Result> validateUser(Nullable<int> pin)
        {
            var pinParameter = pin.HasValue ?
                new ObjectParameter("pin", pin) :
                new ObjectParameter("pin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<validateUser_Result>("validateUser", pinParameter);
        }
    
        public virtual ObjectResult<USER> ValidateUserCommand(Nullable<int> pin)
        {
            var pinParameter = pin.HasValue ?
                new ObjectParameter("pin", pin) :
                new ObjectParameter("pin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("ValidateUserCommand", pinParameter);
        }
    
        public virtual ObjectResult<USER> ValidateUserCommand(Nullable<int> pin, MergeOption mergeOption)
        {
            var pinParameter = pin.HasValue ?
                new ObjectParameter("pin", pin) :
                new ObjectParameter("pin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USER>("ValidateUserCommand", mergeOption, pinParameter);
        }
    }
}