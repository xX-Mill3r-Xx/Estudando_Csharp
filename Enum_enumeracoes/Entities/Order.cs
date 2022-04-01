using System;
using Enum_enumeracoes.Entities.Enums;

namespace Enum_enumeracoes.Entities
{
    class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStaus Status { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Moment}, {Status}";
        }
    }
}
