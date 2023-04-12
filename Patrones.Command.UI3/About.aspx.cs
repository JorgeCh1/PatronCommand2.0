using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Patrones.Prototype;

namespace Patrones.Command.UI3
{
        public partial class About : System.Web.UI.Page
        {
            private Dictionary<int, Computer> computers = new Dictionary<int, Computer>();

            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    computers.Add(0, new Computer("Dell", "i7", 16, 512));
                    computers.Add(1, new Computer("HP", "i5", 8, 256));
                    BindComputers();
                }
            }

            protected void AddButton_Click(object sender, EventArgs e)
            {
                string modelo = txtModelo.Text;
                string procesador = txtProcesadors.Text;
                int memory = int.Parse(txtMemoria.Text);
                int almacenamiento = int.Parse(txtAlmacenamiento.Text);

                Computer computer = new Computer(modelo, procesador, memory, almacenamiento);

            int nextIndex = computers.Count;
            computers.Add(nextIndex, computer);
            BindComputers();

  
            }

        protected void CloneButton_Command(object sender, CommandEventArgs e)
        {
            int index = int.Parse(e.CommandArgument.ToString());

            if (index >= 0 && index < computers.Count)
            {
                Computer computerToClone = computers[index];
                Computer clonedComputer = (Computer)computerToClone.Clone();

                int nextIndex = computers.Count;
                computers.Add(nextIndex, clonedComputer);

                BindComputers();
            }
            else
            {
                lblMensaje.Text = "Mensaje pa ver el error";
            }
        }

            private void BindComputers()
            {
                ComputersRepeater.DataSource = computers.Values;
                ComputersRepeater.DataBind();
            }
        }
    }