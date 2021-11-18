using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ardalis.GuardClauses
{
    public static class CatalogGuards
    {
        public static void PictureUriErrada(this IGuardClause guardClause, string pictureUri)
        {
            if (string.IsNullOrEmpty(pictureUri) || 
                !pictureUri.StartsWith("http://catalogbaseurltobereplaced"))
                throw new InvalidOperationException("Uri da figura invalido");
        }
    }
}
