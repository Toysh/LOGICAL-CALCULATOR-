namespace System.Linq
{
    internal class Dynamic
    {
        internal class DynamicExpressionParser
        {
            public DynamicExpressionParser()
            {
            }

            internal object Parse(Type type, string expression)
            {
                throw new NotImplementedException();
            }

            internal static object ParseLambda(Type[] types, object p, string expression)
            {
                throw new NotImplementedException();
            }
        }
    }
}