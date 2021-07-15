using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo6.Models
{
    public class RegisterationRepositry
    {
        private List<Registeration> registerations;
        public RegisterationRepositry()
        {
            registerations = new List<Registeration>();
        }
        public Registeration Add(Registeration registeration)
        {
            registerations.Add(registeration);
            return registeration;
        }
    }
}
