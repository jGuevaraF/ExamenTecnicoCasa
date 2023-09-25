﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class JGuevaraExamenTecnicoEntities : DbContext
    {
        public JGuevaraExamenTecnicoEntities()
            : base("name=JGuevaraExamenTecnicoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artista> Artistas { get; set; }
        public virtual DbSet<Disco> Discoes { get; set; }
        public virtual DbSet<Distribuidora> Distribuidoras { get; set; }
        public virtual DbSet<GeneroMusical> GeneroMusicals { get; set; }
    
        public virtual int ArtistaDelete(Nullable<int> idArtista)
        {
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ArtistaDelete", idArtistaParameter);
        }
    
        public virtual ObjectResult<ArtistaGetAll_Result> ArtistaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ArtistaGetAll_Result>("ArtistaGetAll");
        }
    
        public virtual ObjectResult<ArtistaGetById_Result> ArtistaGetById(Nullable<int> idArtista)
        {
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ArtistaGetById_Result>("ArtistaGetById", idArtistaParameter);
        }
    
        public virtual int ArtistaUpdate(Nullable<int> idArtista, string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ArtistaUpdate", idArtistaParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter);
        }
    
        public virtual int DiscoDelete(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoDelete", idDiscoParameter);
        }
    
        public virtual ObjectResult<DiscoGetAll_Result> DiscoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiscoGetAll_Result>("DiscoGetAll");
        }
    
        public virtual ObjectResult<DiscoGetById_Result> DiscoGetById(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("idDisco", idDisco) :
                new ObjectParameter("idDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiscoGetById_Result>("DiscoGetById", idDiscoParameter);
        }
    
        public virtual int DiscoUpdate(Nullable<int> idDisco, string titulo, string duracion, Nullable<System.DateTime> anio, Nullable<decimal> ventas, Nullable<bool> disponibilidad, Nullable<int> idArtista, Nullable<int> idGenero, Nullable<int> idDistribuidora)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var duracionParameter = duracion != null ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(string));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("Anio", anio) :
                new ObjectParameter("Anio", typeof(System.DateTime));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(decimal));
    
            var disponibilidadParameter = disponibilidad.HasValue ?
                new ObjectParameter("Disponibilidad", disponibilidad) :
                new ObjectParameter("Disponibilidad", typeof(bool));
    
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            var idGeneroParameter = idGenero.HasValue ?
                new ObjectParameter("IdGenero", idGenero) :
                new ObjectParameter("IdGenero", typeof(int));
    
            var idDistribuidoraParameter = idDistribuidora.HasValue ?
                new ObjectParameter("IdDistribuidora", idDistribuidora) :
                new ObjectParameter("IdDistribuidora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoUpdate", idDiscoParameter, tituloParameter, duracionParameter, anioParameter, ventasParameter, disponibilidadParameter, idArtistaParameter, idGeneroParameter, idDistribuidoraParameter);
        }
    
        public virtual int DistribuidoraAdd(string nombre, string direccion, string email, string telefono)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DistribuidoraAdd", nombreParameter, direccionParameter, emailParameter, telefonoParameter);
        }
    
        public virtual ObjectResult<DistribuidoraGetAll_Result> DistribuidoraGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DistribuidoraGetAll_Result>("DistribuidoraGetAll");
        }
    
        public virtual ObjectResult<DistribuidoraGetById_Result> DistribuidoraGetById(Nullable<int> idDistribuidora)
        {
            var idDistribuidoraParameter = idDistribuidora.HasValue ?
                new ObjectParameter("IdDistribuidora", idDistribuidora) :
                new ObjectParameter("IdDistribuidora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DistribuidoraGetById_Result>("DistribuidoraGetById", idDistribuidoraParameter);
        }
    
        public virtual int DistribuidoraUpdate(Nullable<int> idDistribuidora, string nombre, string direccion, string email, string telefono)
        {
            var idDistribuidoraParameter = idDistribuidora.HasValue ?
                new ObjectParameter("IdDistribuidora", idDistribuidora) :
                new ObjectParameter("IdDistribuidora", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DistribuidoraUpdate", idDistribuidoraParameter, nombreParameter, direccionParameter, emailParameter, telefonoParameter);
        }
    
        public virtual ObjectResult<GeneroMusicalGetAll_Result> GeneroMusicalGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GeneroMusicalGetAll_Result>("GeneroMusicalGetAll");
        }
    
        public virtual int ArtistaAdd(string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ArtistaAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter);
        }
    
        public virtual int DiscoAdd(string titulo, string duracion, Nullable<System.DateTime> anio, Nullable<decimal> ventas, Nullable<int> idArtista, Nullable<int> idGenero, Nullable<int> idDistribuidora)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var duracionParameter = duracion != null ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(string));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("Anio", anio) :
                new ObjectParameter("Anio", typeof(System.DateTime));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(decimal));
    
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            var idGeneroParameter = idGenero.HasValue ?
                new ObjectParameter("IdGenero", idGenero) :
                new ObjectParameter("IdGenero", typeof(int));
    
            var idDistribuidoraParameter = idDistribuidora.HasValue ?
                new ObjectParameter("IdDistribuidora", idDistribuidora) :
                new ObjectParameter("IdDistribuidora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoAdd", tituloParameter, duracionParameter, anioParameter, ventasParameter, idArtistaParameter, idGeneroParameter, idDistribuidoraParameter);
        }
    
        public virtual int DistribuidoraDelete(Nullable<int> idDistribuidora)
        {
            var idDistribuidoraParameter = idDistribuidora.HasValue ?
                new ObjectParameter("IdDistribuidora", idDistribuidora) :
                new ObjectParameter("IdDistribuidora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DistribuidoraDelete", idDistribuidoraParameter);
        }
    }
}
