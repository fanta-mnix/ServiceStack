#if !SILVERLIGHT && !XBOX && !PCL
using System.Data;

namespace ServiceStack.DataAccess
{
	public interface IHasDbConnection
	{
		IDbConnection DbConnection { get; }
	}
}
#endif