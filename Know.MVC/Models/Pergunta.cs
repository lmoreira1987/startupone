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
    
    public partial class Pergunta
    {
        public Pergunta()
        {
            this.Respostas = new HashSet<Resposta>();
        }
    
        public long Id { get; set; }
        public long IdDisciplina { get; set; }
        public long IdSerie { get; set; }
        public long IdIdioma { get; set; }
        public long IdDificuldade { get; set; }
        public string Nome { get; set; }
        public long CodigoGrupo { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
    
        public virtual Dificuldade Dificuldade { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual Idioma Idioma { get; set; }
        public virtual Serie Serie { get; set; }
        public virtual ICollection<Resposta> Respostas { get; set; }
    }
}