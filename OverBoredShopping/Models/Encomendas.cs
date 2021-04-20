using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OverBoredShopping.Models {
	public class Encomendas {

		public Encomendas() {
			// inicializa a lista de detalhes de uma Encomenda
			ListaDeEncomendaDetalhes = new HashSet<EncomendaDetalhes>();
		}

		/// <summary>
		/// Identificador de cada Encomenda
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Data de uma Encomenda
		/// </summary>
		public DateTime DataEncomenda { get; set; }

		/// <summary>
		/// FK para o Cliente da Encomenda
		/// </summary>
		[ForeignKey(nameof(Cliente))]   // esta 'anotação' indica que o atributo 'ClientesFK' está a executar o mesmo que o atributo 'Cliente', e que representa uma FK para a class Clientes 
		public int ClientesFK { get; set; }
		public Clientes Cliente { get; set; }

		/// <summary>
		/// Lista de detalhes de uma encomenda
		/// </summary>
		public virtual ICollection<EncomendaDetalhes> ListaDeEncomendaDetalhes { get; set; }
	}
}
