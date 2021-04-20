using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OverBoredShopping.Models {
	public class Clientes {

		public Clientes() {
			// inicializa a lista de encomendas de um Cliente
			ListaDeEncomendas = new HashSet<Encomendas>();
		}

		/// <summary>
		/// Identificador de cada Cliente
		/// </summary>
		[Key] 
		public int Id { get; set;}

		/// <summary>
		/// Nome de um Cliente
		/// </summary>
		public string Nome { get; set; }

		/// <summary>
		/// Email de um Cliente
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Morada de um Cliente
		/// </summary>
		public string Morada { get; set; }

		/// <summary>
		/// Código postal de um Cliente
		/// </summary>
		public string CodPostal { get; set; }

		/// <summary>
		/// Cidade de um Cliente
		/// </summary>
		public string Cidade { get; set; }

		/// <summary>
		/// País de um Cliente
		/// </summary>
		public string Pais { get; set; }

		/// <summary>
		/// Número de telemóvel de um Cliente
		/// </summary>
		public string Telemovel { get; set; }

		/// <summary>
		/// Número de identificação fiscal de um Cliente
		/// </summary>
		public string NIF { get; set; }

		/// <summary>
		/// Número de pontos de um Cliente
		/// </summary>
		public int Pontos { get; set; }

		/// <summary>
		/// Lista de encomendas associadas ao Cliente
		/// </summary>
		public ICollection<Encomendas> ListaDeEncomendas { get; set; }
	}
}
