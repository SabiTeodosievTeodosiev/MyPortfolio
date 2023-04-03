using MyPortfolio.Core.Contracts;
using MyPortfolio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Core.Services
{
	/// <summary>
	/// Manipulates photo data
	/// </summary>
	public class PhotoService : IPhotoService
	{
		/// <summary>
		/// Gets all photos
		/// </summary>
		/// <returns>List of photos</returns>
		public Task<IEnumerable<PhotoDTO>> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
