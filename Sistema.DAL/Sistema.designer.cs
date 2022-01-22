#pragma warning disable 1591
//------------------------------------------------------------------------------
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EstrelaDaMorte")]
	public partial class SistemaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNaves(Naves instance);
    partial void UpdateNaves(Naves instance);
    partial void DeleteNaves(Naves instance);
    partial void InsertPilotos(Pilotos instance);
    partial void UpdatePilotos(Pilotos instance);
    partial void DeletePilotos(Pilotos instance);
    partial void InsertPilotosNaves(PilotosNaves instance);
    partial void UpdatePilotosNaves(PilotosNaves instance);
    partial void DeletePilotosNaves(PilotosNaves instance);
    partial void InsertPlanetas(Planetas instance);
    partial void UpdatePlanetas(Planetas instance);
    partial void DeletePlanetas(Planetas instance);
    #endregion
		
		public SistemaDataContext() : 
				base(global::Sistema.DAL.Properties.Settings.Default.EstrelaDaMorteConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HistoricoViagens> HistoricoViagens
		{
			get
			{
				return this.GetTable<HistoricoViagens>();
			}
		}
		
		public System.Data.Linq.Table<Naves> Naves
		{
			get
			{
				return this.GetTable<Naves>();
			}
		}
		
		public System.Data.Linq.Table<Pilotos> Pilotos
		{
			get
			{
				return this.GetTable<Pilotos>();
			}
		}
		
		public System.Data.Linq.Table<PilotosNaves> PilotosNaves
		{
			get
			{
				return this.GetTable<PilotosNaves>();
			}
		}
		
		public System.Data.Linq.Table<Planetas> Planetas
		{
			get
			{
				return this.GetTable<Planetas>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HistoricoViagens")]
	public partial class HistoricoViagens
	{
		
		private int _IdNave;
		
		private int _IdPiloto;
		
		private System.DateTime _DtSaida;
		
		private System.Nullable<System.DateTime> _DtChegada;
		
		public HistoricoViagens()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNave", DbType="Int NOT NULL")]
		public int IdNave
		{
			get
			{
				return this._IdNave;
			}
			set
			{
				if ((this._IdNave != value))
				{
					this._IdNave = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPiloto", DbType="Int NOT NULL")]
		public int IdPiloto
		{
			get
			{
				return this._IdPiloto;
			}
			set
			{
				if ((this._IdPiloto != value))
				{
					this._IdPiloto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DtSaida", DbType="DateTime NOT NULL")]
		public System.DateTime DtSaida
		{
			get
			{
				return this._DtSaida;
			}
			set
			{
				if ((this._DtSaida != value))
				{
					this._DtSaida = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DtChegada", DbType="DateTime")]
		public System.Nullable<System.DateTime> DtChegada
		{
			get
			{
				return this._DtChegada;
			}
			set
			{
				if ((this._DtChegada != value))
				{
					this._DtChegada = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Naves")]
	public partial class Naves : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdNave;
		
		private string _Nome;
		
		private string _Modelo;
		
		private int _Passageiros;
		
		private double _Carga;
		
		private string _Classe;
		
		private EntitySet<PilotosNaves> _PilotosNaves;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdNaveChanging(int value);
    partial void OnIdNaveChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnModeloChanging(string value);
    partial void OnModeloChanged();
    partial void OnPassageirosChanging(int value);
    partial void OnPassageirosChanged();
    partial void OnCargaChanging(double value);
    partial void OnCargaChanged();
    partial void OnClasseChanging(string value);
    partial void OnClasseChanged();
    #endregion
		
		public Naves()
		{
			this._PilotosNaves = new EntitySet<PilotosNaves>(new Action<PilotosNaves>(this.attach_PilotosNaves), new Action<PilotosNaves>(this.detach_PilotosNaves));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNave", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdNave
		{
			get
			{
				return this._IdNave;
			}
			set
			{
				if ((this._IdNave != value))
				{
					this.OnIdNaveChanging(value);
					this.SendPropertyChanging();
					this._IdNave = value;
					this.SendPropertyChanged("IdNave");
					this.OnIdNaveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modelo", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Modelo
		{
			get
			{
				return this._Modelo;
			}
			set
			{
				if ((this._Modelo != value))
				{
					this.OnModeloChanging(value);
					this.SendPropertyChanging();
					this._Modelo = value;
					this.SendPropertyChanged("Modelo");
					this.OnModeloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passageiros", DbType="Int NOT NULL")]
		public int Passageiros
		{
			get
			{
				return this._Passageiros;
			}
			set
			{
				if ((this._Passageiros != value))
				{
					this.OnPassageirosChanging(value);
					this.SendPropertyChanging();
					this._Passageiros = value;
					this.SendPropertyChanged("Passageiros");
					this.OnPassageirosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Carga", DbType="Float NOT NULL")]
		public double Carga
		{
			get
			{
				return this._Carga;
			}
			set
			{
				if ((this._Carga != value))
				{
					this.OnCargaChanging(value);
					this.SendPropertyChanging();
					this._Carga = value;
					this.SendPropertyChanged("Carga");
					this.OnCargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Classe", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Classe
		{
			get
			{
				return this._Classe;
			}
			set
			{
				if ((this._Classe != value))
				{
					this.OnClasseChanging(value);
					this.SendPropertyChanging();
					this._Classe = value;
					this.SendPropertyChanged("Classe");
					this.OnClasseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Naves_PilotosNaves", Storage="_PilotosNaves", ThisKey="IdNave", OtherKey="IdNave")]
		public EntitySet<PilotosNaves> PilotosNaves
		{
			get
			{
				return this._PilotosNaves;
			}
			set
			{
				this._PilotosNaves.Assign(value);
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
		
		private void attach_PilotosNaves(PilotosNaves entity)
		{
			this.SendPropertyChanging();
			entity.Naves = this;
		}
		
		private void detach_PilotosNaves(PilotosNaves entity)
		{
			this.SendPropertyChanging();
			entity.Naves = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pilotos")]
	public partial class Pilotos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPiloto;
		
		private string _Nome;
		
		private string _AnoNascimento;
		
		private int _IdPlaneta;
		
		private EntitySet<PilotosNaves> _PilotosNaves;
		
		private EntityRef<Planetas> _Planetas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPilotoChanging(int value);
    partial void OnIdPilotoChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnAnoNascimentoChanging(string value);
    partial void OnAnoNascimentoChanged();
    partial void OnIdPlanetaChanging(int value);
    partial void OnIdPlanetaChanged();
    #endregion
		
		public Pilotos()
		{
			this._PilotosNaves = new EntitySet<PilotosNaves>(new Action<PilotosNaves>(this.attach_PilotosNaves), new Action<PilotosNaves>(this.detach_PilotosNaves));
			this._Planetas = default(EntityRef<Planetas>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPiloto", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdPiloto
		{
			get
			{
				return this._IdPiloto;
			}
			set
			{
				if ((this._IdPiloto != value))
				{
					this.OnIdPilotoChanging(value);
					this.SendPropertyChanging();
					this._IdPiloto = value;
					this.SendPropertyChanged("IdPiloto");
					this.OnIdPilotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnoNascimento", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string AnoNascimento
		{
			get
			{
				return this._AnoNascimento;
			}
			set
			{
				if ((this._AnoNascimento != value))
				{
					this.OnAnoNascimentoChanging(value);
					this.SendPropertyChanging();
					this._AnoNascimento = value;
					this.SendPropertyChanged("AnoNascimento");
					this.OnAnoNascimentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPlaneta", DbType="Int NOT NULL")]
		public int IdPlaneta
		{
			get
			{
				return this._IdPlaneta;
			}
			set
			{
				if ((this._IdPlaneta != value))
				{
					if (this._Planetas.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdPlanetaChanging(value);
					this.SendPropertyChanging();
					this._IdPlaneta = value;
					this.SendPropertyChanged("IdPlaneta");
					this.OnIdPlanetaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pilotos_PilotosNaves", Storage="_PilotosNaves", ThisKey="IdPiloto", OtherKey="IdPiloto")]
		public EntitySet<PilotosNaves> PilotosNaves
		{
			get
			{
				return this._PilotosNaves;
			}
			set
			{
				this._PilotosNaves.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Planetas_Pilotos", Storage="_Planetas", ThisKey="IdPlaneta", OtherKey="IdPlaneta", IsForeignKey=true)]
		public Planetas Planetas
		{
			get
			{
				return this._Planetas.Entity;
			}
			set
			{
				Planetas previousValue = this._Planetas.Entity;
				if (((previousValue != value) 
							|| (this._Planetas.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Planetas.Entity = null;
						previousValue.Pilotos.Remove(this);
					}
					this._Planetas.Entity = value;
					if ((value != null))
					{
						value.Pilotos.Add(this);
						this._IdPlaneta = value.IdPlaneta;
					}
					else
					{
						this._IdPlaneta = default(int);
					}
					this.SendPropertyChanged("Planetas");
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
		
		private void attach_PilotosNaves(PilotosNaves entity)
		{
			this.SendPropertyChanging();
			entity.Pilotos = this;
		}
		
		private void detach_PilotosNaves(PilotosNaves entity)
		{
			this.SendPropertyChanging();
			entity.Pilotos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PilotosNaves")]
	public partial class PilotosNaves : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPiloto;
		
		private int _IdNave;
		
		private bool _FlagAutorizado;
		
		private EntityRef<Naves> _Naves;
		
		private EntityRef<Pilotos> _Pilotos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPilotoChanging(int value);
    partial void OnIdPilotoChanged();
    partial void OnIdNaveChanging(int value);
    partial void OnIdNaveChanged();
    partial void OnFlagAutorizadoChanging(bool value);
    partial void OnFlagAutorizadoChanged();
    #endregion
		
		public PilotosNaves()
		{
			this._Naves = default(EntityRef<Naves>);
			this._Pilotos = default(EntityRef<Pilotos>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPiloto", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdPiloto
		{
			get
			{
				return this._IdPiloto;
			}
			set
			{
				if ((this._IdPiloto != value))
				{
					if (this._Pilotos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdPilotoChanging(value);
					this.SendPropertyChanging();
					this._IdPiloto = value;
					this.SendPropertyChanged("IdPiloto");
					this.OnIdPilotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNave", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdNave
		{
			get
			{
				return this._IdNave;
			}
			set
			{
				if ((this._IdNave != value))
				{
					if (this._Naves.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdNaveChanging(value);
					this.SendPropertyChanging();
					this._IdNave = value;
					this.SendPropertyChanged("IdNave");
					this.OnIdNaveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FlagAutorizado", DbType="Bit NOT NULL")]
		public bool FlagAutorizado
		{
			get
			{
				return this._FlagAutorizado;
			}
			set
			{
				if ((this._FlagAutorizado != value))
				{
					this.OnFlagAutorizadoChanging(value);
					this.SendPropertyChanging();
					this._FlagAutorizado = value;
					this.SendPropertyChanged("FlagAutorizado");
					this.OnFlagAutorizadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Naves_PilotosNaves", Storage="_Naves", ThisKey="IdNave", OtherKey="IdNave", IsForeignKey=true)]
		public Naves Naves
		{
			get
			{
				return this._Naves.Entity;
			}
			set
			{
				Naves previousValue = this._Naves.Entity;
				if (((previousValue != value) 
							|| (this._Naves.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Naves.Entity = null;
						previousValue.PilotosNaves.Remove(this);
					}
					this._Naves.Entity = value;
					if ((value != null))
					{
						value.PilotosNaves.Add(this);
						this._IdNave = value.IdNave;
					}
					else
					{
						this._IdNave = default(int);
					}
					this.SendPropertyChanged("Naves");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pilotos_PilotosNaves", Storage="_Pilotos", ThisKey="IdPiloto", OtherKey="IdPiloto", IsForeignKey=true)]
		public Pilotos Pilotos
		{
			get
			{
				return this._Pilotos.Entity;
			}
			set
			{
				Pilotos previousValue = this._Pilotos.Entity;
				if (((previousValue != value) 
							|| (this._Pilotos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pilotos.Entity = null;
						previousValue.PilotosNaves.Remove(this);
					}
					this._Pilotos.Entity = value;
					if ((value != null))
					{
						value.PilotosNaves.Add(this);
						this._IdPiloto = value.IdPiloto;
					}
					else
					{
						this._IdPiloto = default(int);
					}
					this.SendPropertyChanged("Pilotos");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Planetas")]
	public partial class Planetas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPlaneta;
		
		private string _Nome;
		
		private double _Rotacao;
		
		private double _Orbita;
		
		private double _Diametro;
		
		private string _Clima;
		
		private int _Populacao;
		
		private EntitySet<Pilotos> _Pilotos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPlanetaChanging(int value);
    partial void OnIdPlanetaChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnRotacaoChanging(double value);
    partial void OnRotacaoChanged();
    partial void OnOrbitaChanging(double value);
    partial void OnOrbitaChanged();
    partial void OnDiametroChanging(double value);
    partial void OnDiametroChanged();
    partial void OnClimaChanging(string value);
    partial void OnClimaChanged();
    partial void OnPopulacaoChanging(int value);
    partial void OnPopulacaoChanged();
    #endregion
		
		public Planetas()
		{
			this._Pilotos = new EntitySet<Pilotos>(new Action<Pilotos>(this.attach_Pilotos), new Action<Pilotos>(this.detach_Pilotos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPlaneta", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdPlaneta
		{
			get
			{
				return this._IdPlaneta;
			}
			set
			{
				if ((this._IdPlaneta != value))
				{
					this.OnIdPlanetaChanging(value);
					this.SendPropertyChanging();
					this._IdPlaneta = value;
					this.SendPropertyChanged("IdPlaneta");
					this.OnIdPlanetaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rotacao", DbType="Float NOT NULL")]
		public double Rotacao
		{
			get
			{
				return this._Rotacao;
			}
			set
			{
				if ((this._Rotacao != value))
				{
					this.OnRotacaoChanging(value);
					this.SendPropertyChanging();
					this._Rotacao = value;
					this.SendPropertyChanged("Rotacao");
					this.OnRotacaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Orbita", DbType="Float NOT NULL")]
		public double Orbita
		{
			get
			{
				return this._Orbita;
			}
			set
			{
				if ((this._Orbita != value))
				{
					this.OnOrbitaChanging(value);
					this.SendPropertyChanging();
					this._Orbita = value;
					this.SendPropertyChanged("Orbita");
					this.OnOrbitaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diametro", DbType="Float NOT NULL")]
		public double Diametro
		{
			get
			{
				return this._Diametro;
			}
			set
			{
				if ((this._Diametro != value))
				{
					this.OnDiametroChanging(value);
					this.SendPropertyChanging();
					this._Diametro = value;
					this.SendPropertyChanged("Diametro");
					this.OnDiametroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Clima", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Clima
		{
			get
			{
				return this._Clima;
			}
			set
			{
				if ((this._Clima != value))
				{
					this.OnClimaChanging(value);
					this.SendPropertyChanging();
					this._Clima = value;
					this.SendPropertyChanged("Clima");
					this.OnClimaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Populacao", DbType="Int NOT NULL")]
		public int Populacao
		{
			get
			{
				return this._Populacao;
			}
			set
			{
				if ((this._Populacao != value))
				{
					this.OnPopulacaoChanging(value);
					this.SendPropertyChanging();
					this._Populacao = value;
					this.SendPropertyChanged("Populacao");
					this.OnPopulacaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Planetas_Pilotos", Storage="_Pilotos", ThisKey="IdPlaneta", OtherKey="IdPlaneta")]
		public EntitySet<Pilotos> Pilotos
		{
			get
			{
				return this._Pilotos;
			}
			set
			{
				this._Pilotos.Assign(value);
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
		
		private void attach_Pilotos(Pilotos entity)
		{
			this.SendPropertyChanging();
			entity.Planetas = this;
		}
		
		private void detach_Pilotos(Pilotos entity)
		{
			this.SendPropertyChanging();
			entity.Planetas = null;
		}
	}
}
#pragma warning restore 1591
