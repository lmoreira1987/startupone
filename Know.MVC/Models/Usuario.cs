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
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Alunoes = new HashSet<Aluno>();
            this.Escolas = new HashSet<Escola>();
            this.Professors = new HashSet<Professor>();
            this.UsuarioPerfils = new HashSet<UsuarioPerfil>();
        }
    
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Documento { get; set; }
        public Nullable<long> IdEndereco { get; set; }
        public Nullable<long> IdFoto { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
    
        public virtual ICollection<Aluno> Alunoes { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Escola> Escolas { get; set; }
        public virtual Foto Foto { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
        public virtual ICollection<UsuarioPerfil> UsuarioPerfils { get; set; }
    }
}
