using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OverBoredShopping.Models {
	public class Produtos {

		/// <summary>
		/// Identificador de cada Produto
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Título de um Produto
		/// </summary>
		public string Titulo { get; set; }

		/// <summary>
		/// Preço de um Produto
		/// </summary>
		public double Preco { get; set; }

		/// <summary>
		/// Estado de um Produto (Novo ou Usado)
		/// </summary>
		public string Estado { get; set; }

		/// <summary>
		/// Quantidade disponível de um Produto
		/// </summary>
		public int Quantidade { get; set; }

		/// <summary>
		/// Género de um Produto
		/// </summary>
		public string Genero { get; set; }

		/// <summary>
		/// Descrição de um Produto
		/// </summary>
		public string Descricao { get; set; }

		/// <summary>
		/// Editora de um Produto
		/// </summary>
		public string Editora { get; set; }

		/// <summary>
		/// Data de lançamento de um Produto
		/// </summary>
		public DateTime DataLanc { get; set; }

		/// <summary>
		/// Classificação de idade de um Produto
		/// </summary>
		public string Idade { get; set; }

		/// <summary>
		/// Idioma(s) disponíveis no Produto
		/// </summary>
		public string Idioma { get; set; }

		/// <summary>
		/// Diz se um Produto tem ou não tem Multiplayer 
		/// </summary>
		public Boolean Multiplayer { get; set; }

		/// <summary>
		/// Pontos que um Produto vale
		/// </summary>
		public int Pontos { get; set; }
	}
}
