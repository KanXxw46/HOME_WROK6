using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_06
{
    public class Gruppa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
