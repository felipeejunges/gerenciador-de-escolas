using System;

namespace gerenciador_de_escolas.Config
{
    public class DomainException : Exception
    {

        public DomainException(string error) : base(error) {
            
        }

        public static void when(bool hasError, string error) {
            if(!hasError)
                throw new DomainException(error);
        }
    }
}