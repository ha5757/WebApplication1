﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DemoEntities : DbContext
    {
        public DemoEntities()
            : base("name=DemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DEPTDATA> DEPTDATAs { get; set; }
        public virtual DbSet<EMPDATA> EMPDATAs { get; set; }
        public virtual DbSet<vreport1> vreport1 { get; set; }
    
        public virtual int sp_insertprocedure(Nullable<int> eno, string ename, string job, Nullable<int> mgr, Nullable<System.DateTime> hiredate, Nullable<int> sal, Nullable<int> comm, Nullable<int> deptno, ObjectParameter result)
        {
            var enoParameter = eno.HasValue ?
                new ObjectParameter("eno", eno) :
                new ObjectParameter("eno", typeof(int));
    
            var enameParameter = ename != null ?
                new ObjectParameter("ename", ename) :
                new ObjectParameter("ename", typeof(string));
    
            var jobParameter = job != null ?
                new ObjectParameter("job", job) :
                new ObjectParameter("job", typeof(string));
    
            var mgrParameter = mgr.HasValue ?
                new ObjectParameter("mgr", mgr) :
                new ObjectParameter("mgr", typeof(int));
    
            var hiredateParameter = hiredate.HasValue ?
                new ObjectParameter("hiredate", hiredate) :
                new ObjectParameter("hiredate", typeof(System.DateTime));
    
            var salParameter = sal.HasValue ?
                new ObjectParameter("sal", sal) :
                new ObjectParameter("sal", typeof(int));
    
            var commParameter = comm.HasValue ?
                new ObjectParameter("comm", comm) :
                new ObjectParameter("comm", typeof(int));
    
            var deptnoParameter = deptno.HasValue ?
                new ObjectParameter("deptno", deptno) :
                new ObjectParameter("deptno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertprocedure", enoParameter, enameParameter, jobParameter, mgrParameter, hiredateParameter, salParameter, commParameter, deptnoParameter, result);
        }
    }
}