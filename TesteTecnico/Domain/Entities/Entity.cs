using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Infra.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
    }
}
