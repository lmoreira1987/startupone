//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Know.MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfessorDisciplina
    {
        public long Id { get; set; }
        public long IdProfessor { get; set; }
        public long IdDisciplina { get; set; }
    
        public virtual Disciplina Disciplina { get; set; }
        public virtual Professor Professor { get; set; }
    }
}