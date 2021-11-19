namespace Patterns
{
    class ReversePolishNotationVisitor : IVisitor<string>
    {
        public string Visit(IntExpr e) => e.Val.ToString();
        public string Visit(AddExpr e) => e.Lhs.Accept(this) + " " + e.Rhs.Accept(this) + " +";
        public string Visit(MinusExpr e) =>  e.Lhs.Accept(this) + " " + e.Rhs.Accept(this) + " -";
    }
}
