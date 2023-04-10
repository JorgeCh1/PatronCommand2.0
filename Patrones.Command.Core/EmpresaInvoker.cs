using System.Collections.Generic;

namespace Patrones.Command.Core
{
    public class EmpresaInvoker
    {
        // Lista de órdenes
        private List<OrdenCommand> ordenes = new List<OrdenCommand>();

        // Llena la lista de ordenes
        public void TomarOrden(OrdenCommand cmd)
        {
            ordenes.Add(cmd);
        }

        // Recorre toda la lista de ordenes y por cada una ejecutarla
        public void ProcesarOrdenes()
        {
            foreach (var orden in ordenes)
                orden.Ejecutar();
            ordenes.Clear();
        }
    }
}