using System.Reflection;

namespace ReflectionAndAttributeCrud.Helper
{
    public static class ObjectMapper
    {
        public static TTarget Map<TSource, TTarget>(TSource source) where TTarget : new()
        {
            TTarget target = new TTarget();
            foreach (var sourceProperty in typeof(TSource).GetProperties())
            {
                var attribute = sourceProperty.GetCustomAttribute<MapToAttribute>();
                if (attribute != null)
                {
                    var targetProperty = typeof(TTarget).GetProperty(attribute.TargetProperty);
                    if (targetProperty != null && targetProperty.CanWrite)
                    {
                        targetProperty.SetValue(target, sourceProperty.GetValue(source));
                    }
                }
            }
            return target;
        }
    }

}
