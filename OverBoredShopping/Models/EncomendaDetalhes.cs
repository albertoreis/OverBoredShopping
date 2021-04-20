using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OverBoredShopping.Models {
	public class EncomendaDetalhes {

		/// <summary>
		/// Identificador de cada EncomendaDetalhes
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Quantidade de um produto encomendado
		/// </summary>
		public int Quantidade { get; set; }

		/// <summary>
		/// Preço de um produto encomendado
		/// </summary>
		public double Preco { get; set; }

		/// <summary>
		/// Nome do destinatário da encomenda
		/// </summary>
		public string NomeEntrega { get; set; }

		/// <summary>
		/// Morada do destinatário da encomenda
		/// </summary>
		public string MoradaEntrega { get; set; }

		/// <summary>
		/// Código Postal do destinatário da encomenda
		/// </summary>
		public string CodPostalEntrega { get; set; }

		/// <summary>
		/// FK para a Encomenda de EncomedaDetalhes
		/// </summary>
		[ForeignKey(nameof(Encomenda))]   // esta 'anotação' indica que o atributo 'EncomendasFK' está a executar o mesmo que o atributo 'Encomendas', e que representa uma FK para a class Encomendas 
		public int EncomendasFK { get; set; }
		public Encomendas Encomenda { get; set; }

		/// <summary>
		/// FK para o Produto de EncomedaDetalhes
		/// </summary>
		[ForeignKey(nameof(Produto))]   // esta 'anotação' indica que o atributo 'ProdutosFK' está a executar o mesmo que o atributo 'Produto', e que representa uma FK para a class Produtos 
		public int ProdutosFK { get; set; }
		public Produtos Produto { get; set; }
	}
}
