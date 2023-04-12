using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype
{
    public class ComputerRegistry
    {
        private List<Computer> computers = new List<Computer>();

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public List<Computer> GetComputers()
        {
            return computers;
        }
    }

}
