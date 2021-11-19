namespace Patterns
{
    class Print : IVisitor<string>
    {
        public string Visit(Value e) => e.Val.ToString();

        public string Visit(AddExpr e) => e.Lhs.Accept(this) +"+"+ e.Rhs.Accept(this);

        public string Visit(MinusExpr e) => e.Lhs.Accept(this) +"-"+ e.Rhs.Accept(this);
    }
}
