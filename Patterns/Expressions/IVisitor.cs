namespace Patterns
{
    interface IVisitor<T>
    {
        T Visit(IntExpr e);
        T Visit(AddExpr e);
        T Visit(MinusExpr e);
    }
}
