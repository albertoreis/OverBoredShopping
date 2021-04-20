using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OverBoredShopping.Models {
	public class Plataformas {

		public Plataformas() {
			// inicializa a lista de protudos de uma Plataforma
			ListaDeProdutos = new HashSet<Produtos>();
		}

		/// <summary>
		/// Identificador de cada Plataforma
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Nome de uma Plataforma
		/// </summary>
		public string Nome { get; set; }

		/// <summary>
		/// Logótipo de uma Plataforma
		/// </summary>
		public string Logotipo { get; set; }

		[ForeignKey(nameof(Plataforma))] // esta 'anotação' indica que o atributo 'PlataformasFK' está a executar o mesmo que o atributo 'Plataforma', e que representa uma FK para a class Plataformas 
		public int PlataformasFK { get; set; }
		public Plataformas Plataforma { get; set; }

		/// <summary>
		/// Lista de Produtos associados à Plataforma
		/// </summary>
		public ICollection<Produtos> ListaDeProdutos { get; set; }
	}
}
