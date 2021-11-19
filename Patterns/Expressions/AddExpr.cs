﻿namespace Patterns
{
    class AddExpr : IExpr
    {

        public IExpr Lhs { get; set; }
        public IExpr Rhs { get; set; }
        public T Accept<T>(IVisitor<T> visitor) => visitor.Visit(this);
    }
}