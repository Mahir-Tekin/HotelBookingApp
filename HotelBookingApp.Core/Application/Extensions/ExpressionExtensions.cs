using System.Linq.Expressions;

namespace HotelBookingApp.Core.Application.Extensions
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> And<T>(
            this Expression<Func<T, bool>> expr1,
            Expression<Func<T, bool>> expr2)
        {
            // Yeni bir parametre tanımlıyoruz
            var parameter = Expression.Parameter(typeof(T), "x");

            // İki ifade gövdesini birleştiriyoruz
            var body = Expression.AndAlso(
                Expression.Invoke(expr1, parameter), // İlk expression
                Expression.Invoke(expr2, parameter)  // İkinci expression
            );

            // Yeni bir expression oluşturuyoruz
            return Expression.Lambda<Func<T, bool>>(body, parameter);
        }
    }
}
