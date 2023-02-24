using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS
{
    public interface ICommandHandler<TMessage> where TMessage : class
    {
        void Handle(TMessage message);
    }
}
