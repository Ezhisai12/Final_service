//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capsule_TaskManagerDL.Model
{
    using System;
    
    public partial class GET_TASK_DETAILS_Result
    {
        public Nullable<int> Task_ID { get; set; }
        public Nullable<int> Parent_ID { get; set; }
        public string Parent_Task { get; set; }
        public string Task { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<int> Project_ID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> User_ID { get; set; }
    }
}
