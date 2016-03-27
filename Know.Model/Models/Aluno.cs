//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Know.Model.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aluno
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Nullable<long> IdSerie { get; set; }
        public string Matricula { get; set; }
        public string Telefone { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public string Cpf { get; set; }
        public Nullable<long> IdSexo { get; set; }
        public Nullable<long> IdEscola { get; set; }
        public Nullable<long> IdEndereco { get; set; }
        public Nullable<long> IdFoto { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
    
        public virtual Endereco Endereco { get; set; }
        public virtual Escola Escola { get; set; }
        public virtual Foto Foto { get; set; }
        public virtual Serie Serie { get; set; }
        public virtual Sexo Sexo { get; set; }
    }
}