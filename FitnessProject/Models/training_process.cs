//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class training_process
    {
        public int id { get; set; }
        public Nullable<int> client_id { get; set; }
        public System.DateTime start { get; set; }
        public string category { get; set; }
        public int progress { get; set; }
        public string coach { get; set; }
        public string place { get; set; }
    
        public virtual Client Client { get; set; }
    }
}