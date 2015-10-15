﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Webservice
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class cdkEntities : DbContext
    {
        public cdkEntities()
            : base("name=cdkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cdk_users> cdk_users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }
    
        public virtual ObjectResult<spGetEmployee_Result> spGetEmployee(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetEmployee_Result>("spGetEmployee", idParameter);
        }
    
        public virtual ObjectResult<spGetStudentByID_Result> spGetStudentByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetStudentByID_Result>("spGetStudentByID", iDParameter);
        }
    
        public virtual int spSaveEmployee(Nullable<int> id, string name, string gender, Nullable<System.DateTime> dateOfBirth, Nullable<int> employeeType, Nullable<int> annualSalary, Nullable<int> hourlyPay, Nullable<int> hoursWorked)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(System.DateTime));
    
            var employeeTypeParameter = employeeType.HasValue ?
                new ObjectParameter("EmployeeType", employeeType) :
                new ObjectParameter("EmployeeType", typeof(int));
    
            var annualSalaryParameter = annualSalary.HasValue ?
                new ObjectParameter("AnnualSalary", annualSalary) :
                new ObjectParameter("AnnualSalary", typeof(int));
    
            var hourlyPayParameter = hourlyPay.HasValue ?
                new ObjectParameter("HourlyPay", hourlyPay) :
                new ObjectParameter("HourlyPay", typeof(int));
    
            var hoursWorkedParameter = hoursWorked.HasValue ?
                new ObjectParameter("HoursWorked", hoursWorked) :
                new ObjectParameter("HoursWorked", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveEmployee", idParameter, nameParameter, genderParameter, dateOfBirthParameter, employeeTypeParameter, annualSalaryParameter, hourlyPayParameter, hoursWorkedParameter);
        }
    }
}
