using System.Reflection;

namespace ViewModelAndDto.Bussiness
{
    public static class TypeConversion
    {
        public static TResult Conversion<T,TResult>(T model) where TResult : class,new()
        {
            TResult result = new(); 

            typeof(T).GetProperties().ToList().ForEach(p =>
            {
                PropertyInfo property = typeof(TResult).GetProperty(p.Name);
                property.SetValue(result, p.GetValue(model));
            });


            return result;
        }

    }
}
