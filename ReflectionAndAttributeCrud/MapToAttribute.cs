namespace ReflectionAndAttributeCrud
{

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class MapToAttribute : Attribute
    {
        public string TargetProperty { get; }
        public MapToAttribute(string targetProperty)
        {
            TargetProperty = targetProperty;
        }
    }
}
