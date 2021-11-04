using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorDeContenedores
{
    //Nombre: José Daniel Medrano Guadamuz
    public partial class Form1 : Form
    {
        int cantidadJW;
        double costoTotalEmpaque;
        double costoTotalTransporte;
        double costoTotalJWs;
        double costoTotal;

        string lugarDeEnvio;

        Dictionary<string, int> cantidadContenedores;
        Dictionary<string, int> costosEmpaque;
        Dictionary<string, Dictionary<string, int>> costosTransporte;
        double costoCadaJW;
        public Form1()
        {
            InitializeComponent();
            cantidadJW = 0;
            costoTotalEmpaque = 0;
            costoTotalTransporte = 0;
            costoTotalJWs = 0;
            costoTotal = 0;

            lugarDeEnvio = "";
            costoCadaJW = 745.65;

            //Utilice diccionarios para que el código sea más entendible y que de esa manera no sean puros números.
            cantidadContenedores = new Dictionary<string, int>
            {
                {"Extragrandes", 0 },
                {"Grandes", 0 },
                {"Medianos", 0 },
                {"Pequeños", 0 }
            };

            costosEmpaque = new Dictionary<string, int>
            {
                {"Extragrandes", 650 },
                {"Grandes", 380 },
                {"Medianos", 210 },
                {"Pequeños", 90 }
            };

            costosTransporte = new Dictionary<string, Dictionary<string, int>>
            {
                {"Extragrandes", new Dictionary<string, int> { { "Central", 180 }, { "Sur", 230 }, { "Norte", 210 }, { "Pacífico", 200 }, { "Atlántico", 205 } } },
                {"Grandes",  new Dictionary<string, int> { { "Central", 105 }, { "Sur", 155 }, { "Norte", 145 }, { "Pacífico", 125 }, { "Atlántico", 130 } } },
                {"Medianos",  new Dictionary<string, int> { { "Central", 75 }, { "Sur", 125 }, { "Norte", 115 }, { "Pacífico", 95 }, { "Atlántico", 100 } } },
                {"Pequeños", new Dictionary<string, int> { { "Central", 30 }, { "Sur", 80 }, { "Norte", 70 }, { "Pacífico", 50 }, { "Atlántico", 55 } } }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                cantidadJW = Convert.ToInt32(cantidadJWTextBox.Text);
                if (comboBoxLugares.SelectedItem != null)
                {
                    lugarDeEnvio = comboBoxLugares.SelectedItem.ToString();
                    if (!EsLugarValido())
                    {
                        throw new Exception("Debe seleccionar el lugar a donde se envia.");
                    }
                }
                else
                {
                    throw new Exception("Debe seleccionar el lugar a donde se envia.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe introducir números enteros.", "Información", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK);
                return;
            }
            //PRINCIPALES METODOS: Los que llevan a cabo el cálculo de los contenedores y los costos, para despues mostrarlos. <<====
            CalcularContenedores(cantidadJW);
            CalcularCostos(lugarDeEnvio);
            Mostrar();
        }

        public bool EsLugarValido()
        {
            //Verifica si el lugar escogido por el usuario corresponde a uno de estos.
            if (lugarDeEnvio == "Central" || lugarDeEnvio == "Norte" || lugarDeEnvio == "Sur" || lugarDeEnvio == "Pacífico" || lugarDeEnvio == "Atlántico")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void CalcularContenedores(int cantidadJW)
        {
            //Donde va el sobrante que brinda el operador %.
            int residuo = 0;
            int capacidadContenedor = 20;
            //Se crea una lista con las llaves de contenedores, las cuales se iteraran, esto debido a que no se pueden hacer cambios en el diccionario mientras se itera en este.
            List<string> tamaños = new List<string>(cantidadContenedores.Keys);
            foreach (string tamañoContenedor in tamaños)
            {
                //Se obtiene el residuo de dividir la cantidad de JWs por la capacidad de un contenedor, para saber cuantos estarían sobrando.
                residuo = cantidadJW % capacidadContenedor;
                //A la cantidad de JWs se le resta el residuo para así obtener la cantidad exacta de contenedores dependiendo de su capacidad.
                cantidadContenedores[tamañoContenedor] = (cantidadJW - residuo) / capacidadContenedor;
                //Ahora se tiene que lidiar con el sobrante con contenedores de capacidad menor.
                cantidadJW = residuo;
                //Se va dividiendo a 20 entre dos, para que la capacidad varie en 20 -> 10 -> 5. Cuando se llega a 5 la capacidad de cada contenedor se vuelve 1.
                if (capacidadContenedor != 5)
                    capacidadContenedor /= 2;
                else
                    capacidadContenedor = 1;
            }
        }

        private void CalcularCostos(string lugarDeEnvio)
        {
            //Metodos para calcular los costos.
            CalcularCostosEmpaque();
            CalcularCostosTransporte(lugarDeEnvio);
            CalcularCostosDeJWs();
            costoTotal = costoTotalEmpaque + costoTotalTransporte + costoTotalJWs;
        }
        private void CalcularCostosEmpaque()
        {
            double costo = 0;
            //Se crea una lista con las llaves de contenedores, las cuales se iteraran, esto debido a que no se pueden hacer cambios en el diccionario mientras se itera en este.
            List<string> tamaños = new List<string>(cantidadContenedores.Keys);
            foreach (string tamañoContenedor in tamaños)
            {
                /*El costo varia dependiendo del tamaño, por ejemplo, 
                * 1 contenedor extragrande cuesta 650. Por eso se toma 
                * la cantidad total de contenedores de determinado tamaño
                * y se multiplica por su precio, que tambien depende del 
                * tamaño.
                */
                costo += cantidadContenedores[tamañoContenedor] * costosEmpaque[tamañoContenedor];
            }
            costoTotalEmpaque = costo;
        }
        private void CalcularCostosTransporte(string lugarDeEnvio)
        {
            double costo = 0;

            List<string> tamaños = new List<string>(cantidadContenedores.Keys);
            foreach (string tamañoContenedor in tamaños)
            {
                //El costo de trasporte dependerá de 2 cosas: el tamaño del contenedor y el lugar al que se envie. Por eso estos dos se utilizan con el diccionario costosTransporte.
                costo += cantidadContenedores[tamañoContenedor] * costosTransporte[tamañoContenedor][lugarDeEnvio];
            }
            costoTotalTransporte = costo;
        }
        public void CalcularCostosDeJWs()
        {
            //Cada JW cuesta 745.65 colones. Por lo tanto, se multiplica el total de JWs por 745.65 colones.
            costoTotalJWs = cantidadJW * costoCadaJW;
        }

        public void Mostrar()
        {
            //Se muestran los datos.
            labelContenedorXGrande.Text = cantidadContenedores["Extragrandes"].ToString();
            labelContenedorGrande.Text = cantidadContenedores["Grandes"].ToString();
            labelContenedorMediano.Text = cantidadContenedores["Medianos"].ToString();
            labelContenedorPequeño.Text = cantidadContenedores["Pequeños"].ToString();

            labelCostoEmpaque.Text = costoTotalEmpaque.ToString();
            labelCostoTransporte.Text = costoTotalTransporte.ToString();
            labelCostoJWs.Text = costoTotalJWs.ToString();
            labelCostoTotal.Text = costoTotal.ToString();
        }
    }
}
