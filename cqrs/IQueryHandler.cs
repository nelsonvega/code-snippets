using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS
{
    public interface IQueryHandler<TMessage, TData> where TMessage : class
    {
        TData Handle(TMessage message);
    }
}
