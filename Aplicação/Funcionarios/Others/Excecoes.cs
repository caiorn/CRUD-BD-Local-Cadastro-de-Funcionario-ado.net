using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Others
{
    [Serializable()]
    public class ExceptionNomeVazio : Exception 
    {
        public ExceptionNomeVazio() : base() { }
        public ExceptionNomeVazio(string message) : base(message) { }
        public ExceptionNomeVazio(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected ExceptionNomeVazio(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }

    [Serializable()]
    public class ExceptionRegistroExistente : Exception
    {
        public ExceptionRegistroExistente() : base() { }
        public ExceptionRegistroExistente(string message) : base(message) { }
        public ExceptionRegistroExistente(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected ExceptionRegistroExistente(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}
