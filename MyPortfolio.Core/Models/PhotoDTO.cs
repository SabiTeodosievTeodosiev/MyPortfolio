namespace MyPortfolio.Core.Models
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using static System.Net.Mime.MediaTypeNames;


	public class PhotoDTO
	{
		/// <summary>
		/// Photo identifier
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Photo title
		/// </summary>
		public string Title { get; set; } = null!;

		/// <summary>
		/// Photo author name
		/// </summary>
		public string AuthorName { get; set; }

		/// <summary>
		/// Photo location taken
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// Photo data
		/// </summary>
		public byte[] BinaryData { get; set; }
	}
}
