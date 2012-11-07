﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.544
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oiko
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OikoDataBase")]
	public partial class OikoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definições do Método de Extensibilidade
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertConta(Conta instance);
    partial void UpdateConta(Conta instance);
    partial void DeleteConta(Conta instance);
    partial void InsertFormaPagamento(FormaPagamento instance);
    partial void UpdateFormaPagamento(FormaPagamento instance);
    partial void DeleteFormaPagamento(FormaPagamento instance);
    partial void InsertLancamento(Lancamento instance);
    partial void UpdateLancamento(Lancamento instance);
    partial void DeleteLancamento(Lancamento instance);
    #endregion
		
		public OikoDataContext() : 
				base(global::Oiko.Properties.Settings.Default.OikoDataBaseConnectionString4, mappingSource)
		{
			OnCreated();
		}
		
		public OikoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OikoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OikoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OikoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuario
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<Conta> Conta
		{
			get
			{
				return this.GetTable<Conta>();
			}
		}
		
		public System.Data.Linq.Table<FormaPagamento> FormaPagamento
		{
			get
			{
				return this.GetTable<FormaPagamento>();
			}
		}
		
		public System.Data.Linq.Table<Lancamento> Lancamento
		{
			get
			{
				return this.GetTable<Lancamento>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nome;
		
		private string _tipo;
		
		private EntitySet<Lancamento> _Lancamento;
		
    #region Definições do Método de Extensibilidade
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OntipoChanging(string value);
    partial void OntipoChanged();
    #endregion
		
		public Categoria()
		{
			this._Lancamento = new EntitySet<Lancamento>(new Action<Lancamento>(this.attach_Lancamento), new Action<Lancamento>(this.detach_Lancamento));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				if ((this._tipo != value))
				{
					this.OntipoChanging(value);
					this.SendPropertyChanging();
					this._tipo = value;
					this.SendPropertyChanged("tipo");
					this.OntipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Lancamento", Storage="_Lancamento", ThisKey="id", OtherKey="idCategoria")]
		public EntitySet<Lancamento> Lancamento
		{
			get
			{
				return this._Lancamento;
			}
			set
			{
				this._Lancamento.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Lancamento(Lancamento entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Lancamento(Lancamento entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nome;
		
		private string _login;
		
		private string _senha;
		
		private string _email;
		
		private EntitySet<Lancamento> _Lancamento;
		
    #region Definições do Método de Extensibilidade
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnsenhaChanging(string value);
    partial void OnsenhaChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public Usuario()
		{
			this._Lancamento = new EntitySet<Lancamento>(new Action<Lancamento>(this.attach_Lancamento), new Action<Lancamento>(this.detach_Lancamento));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_senha", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string senha
		{
			get
			{
				return this._senha;
			}
			set
			{
				if ((this._senha != value))
				{
					this.OnsenhaChanging(value);
					this.SendPropertyChanging();
					this._senha = value;
					this.SendPropertyChanged("senha");
					this.OnsenhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Lancamento", Storage="_Lancamento", ThisKey="id", OtherKey="idUsuario")]
		public EntitySet<Lancamento> Lancamento
		{
			get
			{
				return this._Lancamento;
			}
			set
			{
				this._Lancamento.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Lancamento(Lancamento entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Lancamento(Lancamento entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Conta")]
	public partial class Conta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nome;
		
		private decimal _saldo;
		
		private bool _saldoNegativo;
		
		private EntitySet<Lancamento> _Lancamento;
		
    #region Definições do Método de Extensibilidade
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnsaldoChanging(decimal value);
    partial void OnsaldoChanged();
    partial void OnsaldoNegativoChanging(bool value);
    partial void OnsaldoNegativoChanged();
    #endregion
		
		public Conta()
		{
			this._Lancamento = new EntitySet<Lancamento>(new Action<Lancamento>(this.attach_Lancamento), new Action<Lancamento>(this.detach_Lancamento));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_saldo", DbType="Decimal(18,2) NOT NULL")]
		public decimal saldo
		{
			get
			{
				return this._saldo;
			}
			set
			{
				if ((this._saldo != value))
				{
					this.OnsaldoChanging(value);
					this.SendPropertyChanging();
					this._saldo = value;
					this.SendPropertyChanged("saldo");
					this.OnsaldoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_saldoNegativo", DbType="Bit NOT NULL")]
		public bool saldoNegativo
		{
			get
			{
				return this._saldoNegativo;
			}
			set
			{
				if ((this._saldoNegativo != value))
				{
					this.OnsaldoNegativoChanging(value);
					this.SendPropertyChanging();
					this._saldoNegativo = value;
					this.SendPropertyChanged("saldoNegativo");
					this.OnsaldoNegativoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Conta_Lancamento", Storage="_Lancamento", ThisKey="id", OtherKey="idConta")]
		public EntitySet<Lancamento> Lancamento
		{
			get
			{
				return this._Lancamento;
			}
			set
			{
				this._Lancamento.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Lancamento(Lancamento entity)
		{
			this.SendPropertyChanging();
			entity.Conta = this;
		}
		
		private void detach_Lancamento(Lancamento entity)
		{
			this.SendPropertyChanging();
			entity.Conta = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FormaPagamento")]
	public partial class FormaPagamento : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nome;
		
		private EntitySet<Lancamento> _Lancamento;
		
    #region Definições do Método de Extensibilidade
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    #endregion
		
		public FormaPagamento()
		{
			this._Lancamento = new EntitySet<Lancamento>(new Action<Lancamento>(this.attach_Lancamento), new Action<Lancamento>(this.detach_Lancamento));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(30)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FormaPagamento_Lancamento", Storage="_Lancamento", ThisKey="id", OtherKey="idFormaPagamento")]
		public EntitySet<Lancamento> Lancamento
		{
			get
			{
				return this._Lancamento;
			}
			set
			{
				this._Lancamento.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Lancamento(Lancamento entity)
		{
			this.SendPropertyChanging();
			entity.FormaPagamento = this;
		}
		
		private void detach_Lancamento(Lancamento entity)
		{
			this.SendPropertyChanging();
			entity.FormaPagamento = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lancamento")]
	public partial class Lancamento : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.DateTime _dataLancamento;
		
		private string _descricao;
		
		private decimal _valor;
		
		private string _tipo;
		
		private System.Nullable<int> _jurosPorDia;
		
		private System.Nullable<int> _multa;
		
		private System.Nullable<System.DateTime> _dataRecebimentoPagamento;
		
		private bool _status;
		
		private System.Nullable<int> _idFormaPagamento;
		
		private System.Nullable<int> _idUsuario;
		
		private System.Nullable<int> _idConta;
		
		private int _idCategoria;
		
		private EntityRef<Categoria> _Categoria;
		
		private EntityRef<Conta> _Conta;
		
		private EntityRef<FormaPagamento> _FormaPagamento;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Definições do Método de Extensibilidade
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OndataLancamentoChanging(System.DateTime value);
    partial void OndataLancamentoChanged();
    partial void OndescricaoChanging(string value);
    partial void OndescricaoChanged();
    partial void OnvalorChanging(decimal value);
    partial void OnvalorChanged();
    partial void OntipoChanging(string value);
    partial void OntipoChanged();
    partial void OnjurosPorDiaChanging(System.Nullable<int> value);
    partial void OnjurosPorDiaChanged();
    partial void OnmultaChanging(System.Nullable<int> value);
    partial void OnmultaChanged();
    partial void OndataRecebimentoPagamentoChanging(System.Nullable<System.DateTime> value);
    partial void OndataRecebimentoPagamentoChanged();
    partial void OnstatusChanging(bool value);
    partial void OnstatusChanged();
    partial void OnidFormaPagamentoChanging(System.Nullable<int> value);
    partial void OnidFormaPagamentoChanged();
    partial void OnidUsuarioChanging(System.Nullable<int> value);
    partial void OnidUsuarioChanged();
    partial void OnidContaChanging(System.Nullable<int> value);
    partial void OnidContaChanged();
    partial void OnidCategoriaChanging(int value);
    partial void OnidCategoriaChanged();
    #endregion
		
		public Lancamento()
		{
			this._Categoria = default(EntityRef<Categoria>);
			this._Conta = default(EntityRef<Conta>);
			this._FormaPagamento = default(EntityRef<FormaPagamento>);
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dataLancamento", DbType="DateTime NOT NULL")]
		public System.DateTime dataLancamento
		{
			get
			{
				return this._dataLancamento;
			}
			set
			{
				if ((this._dataLancamento != value))
				{
					this.OndataLancamentoChanging(value);
					this.SendPropertyChanging();
					this._dataLancamento = value;
					this.SendPropertyChanged("dataLancamento");
					this.OndataLancamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descricao", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if ((this._descricao != value))
				{
					this.OndescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("descricao");
					this.OndescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor", DbType="Decimal(18,2) NOT NULL")]
		public decimal valor
		{
			get
			{
				return this._valor;
			}
			set
			{
				if ((this._valor != value))
				{
					this.OnvalorChanging(value);
					this.SendPropertyChanging();
					this._valor = value;
					this.SendPropertyChanged("valor");
					this.OnvalorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				if ((this._tipo != value))
				{
					this.OntipoChanging(value);
					this.SendPropertyChanging();
					this._tipo = value;
					this.SendPropertyChanged("tipo");
					this.OntipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jurosPorDia", DbType="Int")]
		public System.Nullable<int> jurosPorDia
		{
			get
			{
				return this._jurosPorDia;
			}
			set
			{
				if ((this._jurosPorDia != value))
				{
					this.OnjurosPorDiaChanging(value);
					this.SendPropertyChanging();
					this._jurosPorDia = value;
					this.SendPropertyChanged("jurosPorDia");
					this.OnjurosPorDiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_multa", DbType="Int")]
		public System.Nullable<int> multa
		{
			get
			{
				return this._multa;
			}
			set
			{
				if ((this._multa != value))
				{
					this.OnmultaChanging(value);
					this.SendPropertyChanging();
					this._multa = value;
					this.SendPropertyChanged("multa");
					this.OnmultaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dataRecebimentoPagamento", DbType="DateTime")]
		public System.Nullable<System.DateTime> dataRecebimentoPagamento
		{
			get
			{
				return this._dataRecebimentoPagamento;
			}
			set
			{
				if ((this._dataRecebimentoPagamento != value))
				{
					this.OndataRecebimentoPagamentoChanging(value);
					this.SendPropertyChanging();
					this._dataRecebimentoPagamento = value;
					this.SendPropertyChanged("dataRecebimentoPagamento");
					this.OndataRecebimentoPagamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit NOT NULL")]
		public bool status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idFormaPagamento", DbType="Int")]
		public System.Nullable<int> idFormaPagamento
		{
			get
			{
				return this._idFormaPagamento;
			}
			set
			{
				if ((this._idFormaPagamento != value))
				{
					if (this._FormaPagamento.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidFormaPagamentoChanging(value);
					this.SendPropertyChanging();
					this._idFormaPagamento = value;
					this.SendPropertyChanged("idFormaPagamento");
					this.OnidFormaPagamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="Int")]
		public System.Nullable<int> idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idConta", DbType="Int")]
		public System.Nullable<int> idConta
		{
			get
			{
				return this._idConta;
			}
			set
			{
				if ((this._idConta != value))
				{
					if (this._Conta.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidContaChanging(value);
					this.SendPropertyChanging();
					this._idConta = value;
					this.SendPropertyChanged("idConta");
					this.OnidContaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCategoria", DbType="Int NOT NULL")]
		public int idCategoria
		{
			get
			{
				return this._idCategoria;
			}
			set
			{
				if ((this._idCategoria != value))
				{
					if (this._Categoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCategoriaChanging(value);
					this.SendPropertyChanging();
					this._idCategoria = value;
					this.SendPropertyChanged("idCategoria");
					this.OnidCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Lancamento", Storage="_Categoria", ThisKey="idCategoria", OtherKey="id", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Lancamento.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Lancamento.Add(this);
						this._idCategoria = value.id;
					}
					else
					{
						this._idCategoria = default(int);
					}
					this.SendPropertyChanged("Categoria");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Conta_Lancamento", Storage="_Conta", ThisKey="idConta", OtherKey="id", IsForeignKey=true)]
		public Conta Conta
		{
			get
			{
				return this._Conta.Entity;
			}
			set
			{
				Conta previousValue = this._Conta.Entity;
				if (((previousValue != value) 
							|| (this._Conta.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Conta.Entity = null;
						previousValue.Lancamento.Remove(this);
					}
					this._Conta.Entity = value;
					if ((value != null))
					{
						value.Lancamento.Add(this);
						this._idConta = value.id;
					}
					else
					{
						this._idConta = default(Nullable<int>);
					}
					this.SendPropertyChanged("Conta");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FormaPagamento_Lancamento", Storage="_FormaPagamento", ThisKey="idFormaPagamento", OtherKey="id", IsForeignKey=true)]
		public FormaPagamento FormaPagamento
		{
			get
			{
				return this._FormaPagamento.Entity;
			}
			set
			{
				FormaPagamento previousValue = this._FormaPagamento.Entity;
				if (((previousValue != value) 
							|| (this._FormaPagamento.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._FormaPagamento.Entity = null;
						previousValue.Lancamento.Remove(this);
					}
					this._FormaPagamento.Entity = value;
					if ((value != null))
					{
						value.Lancamento.Add(this);
						this._idFormaPagamento = value.id;
					}
					else
					{
						this._idFormaPagamento = default(Nullable<int>);
					}
					this.SendPropertyChanged("FormaPagamento");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Lancamento", Storage="_Usuario", ThisKey="idUsuario", OtherKey="id", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Lancamento.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Lancamento.Add(this);
						this._idUsuario = value.id;
					}
					else
					{
						this._idUsuario = default(Nullable<int>);
					}
					this.SendPropertyChanged("Usuario");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
