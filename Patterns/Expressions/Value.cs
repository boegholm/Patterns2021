using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    class Value : IExpr
    {
        public string Name { get; set; }
        public int Val { get; set; }
        public T Accept<T>(IVisitor<T> visitor) => visitor.Visit(this);
    }
}
