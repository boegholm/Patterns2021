namespace Patterns
{
    class CalcVisitor : IVisitor<int>
    {
        public int Visit(IntExpr value) => value.Val;

        public int Visit(AddExpr e)  => e.Lhs.Accept(this) + e.Rhs.Accept(this);

        public int Visit(MinusExpr e) => e.Lhs.Accept(this) - e.Rhs.Accept(this);
    }
}
