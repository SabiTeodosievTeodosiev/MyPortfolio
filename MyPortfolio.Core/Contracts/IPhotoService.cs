using MyPortfolio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Core.Contracts
{
	/// <summary>
	/// Manipulates photo data
	/// </summary>
	public interface IPhotoService
	{
		/// <summary>
		/// Gets all photos
		/// </summary>
		/// <returns>List of photos</returns>
		Task<IEnumerable<PhotoDTO>> GetAll();
	}
}
