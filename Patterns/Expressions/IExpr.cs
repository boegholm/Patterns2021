namespace Patterns
{
    interface IExpr
    {
        T Accept<T>(IVisitor<T> visitor);
    }
}
