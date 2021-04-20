using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OverBoredShopping.Models {
	public class Multimedia {

		/// <summary>
		/// Identificador de cada Multimédia
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Source de uma Multimédia
		/// </summary>
		public string Source { get; set; }

		/// <summary>
		/// Tipo de uma Multimédia (Imagem ou Vídeo)
		/// </summary>
		public string Tipo { get; set; }

		/// <summary>
		/// FK para o Produto da Multimédia
		/// </summary>
		[ForeignKey(nameof(Produto))]   // esta 'anotação' indica que o atributo 'ProdutosFK' está a executar o mesmo que o atributo 'Produto', e que representa uma FK para a class Produtos 
		public int ProdutosFK { get; set; }
		public Produtos Produto { get; set; }
	}
}
