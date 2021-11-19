namespace Patterns
{
    interface IVisitor<T>
    {
        T Visit(Value e);
        T Visit(AddExpr e);
        T Visit(MinusExpr e);
    }
}
