using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoInversion
{
    public partial class Form1 : Form
    {
        //Constantes Cánones de Bolsa 2020
        public static float CANON_BOLSA_1 = 1.10f;
        public static float CANON_BOLSA_2 = 2.45f;
        public static float CANON_BOLSA_3 = 4.65f;
        public static float CANON_BOLSA_4 = 6.40f;
        public static float CANON_BOLSA_5 = 9.20f;
        public static float CANON_BOLSA_6 = 13.40f;
        public static float PORCENTAJE_2 = 0.024f;
        public static float PORCENTAJE_3 = 0.012f;
        public static float PORCENTAJE_4 = 0.007f;
        public static float PORCENTAJE_5 = 0.003f;

        //Constantes rangos cánones
        public static int RANGO_1 = 300;
        public static int RANGO_2 = 3000;
        public static int RANGO_3 = 3500;
        public static int RANGO_4 = 7000;
        public static int RANGO_5 = 140000;

        //Constantes tarifas
        public static int RANGO_TARIFA_1 = 2000;
        public static int RANGO_TARIFA_2 = 15000;
        public static int TARIFA_NACIONAL_1 = 3;
        public static int TARIFA_NACIONAL_2 = 6;
        public static float TARIFA_NACIONAL_3 = 0.25f;
        public static int TARIFA_INTERNACIONAL_1 = 20;
        public static float TARIFA_INTERNACIONAL_2 = 0.35f;

        //Variables datos
        private float m_deposito;
        private float m_precioAccion;
        private float m_dividendo;
        private float m_custodia;

        //Variables resultados
        private string m_numeroAcciones;
        private string m_dividendoTotal;
        private string m_ingresoAnual;
        private string m_recuperar;
        private string m_inversionTotal;
        private float m_efectivo;
        private float m_acciones;
        private float m_ingresoDividendo;
        private float m_ingresos;
        private float m_tiempo;
        private float m_inversion;
        private float m_costesAbsoluto;
        private float m_costesRelativo;

        public Form1()
        {
            InitializeComponent();

            m_numeroAcciones = labelNumAcciones.Text;
            m_dividendoTotal = labelDividendoTotal.Text;
            m_ingresoAnual = labelIngresoAnual.Text;
            m_recuperar = labelTiempo.Text;
            m_inversionTotal = labelInversionTotal.Text;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            leerDatos();
            calculoTarifasBanco();
            calculoTarifaCanones();
            calculoResultados();
            mostrarResultados();
        }

        private void leerDatos()
        {
            m_deposito = float.Parse(textBoxDeposito.Text);
            m_precioAccion = float.Parse(textBoxPrecio.Text);
            m_dividendo = float.Parse(textBoxDividendo.Text);
            m_custodia = float.Parse(textBoxCustodia.Text);
        }

        private void calculoTarifasBanco()
        {
            if (checkBoxInternacional.Checked)
            {
                if (m_deposito <= RANGO_TARIFA_2)
                {
                    m_efectivo = m_deposito - TARIFA_INTERNACIONAL_1;
                }
                else
                {
                    m_efectivo = m_deposito - ((m_deposito * TARIFA_INTERNACIONAL_2) / 100);
                }
            }
            else
            {
                if (m_deposito <= RANGO_TARIFA_1)
                {
                    m_efectivo = m_deposito - TARIFA_NACIONAL_1;
                }
                else if(m_deposito <= RANGO_TARIFA_2)
                {
                    m_efectivo = m_deposito - TARIFA_NACIONAL_2;
                }
                else
                {
                    m_efectivo = m_deposito - ((m_deposito * TARIFA_NACIONAL_3) / 100);
                }
            }
        }

        private void calculoTarifaCanones()
        {
            if(m_deposito >= CANON_BOLSA_1)
            {
                m_costesAbsoluto = CANON_BOLSA_1;
                m_costesRelativo = 0;
            }
            else if (m_deposito >= CANON_BOLSA_2)
            {
                m_costesAbsoluto = CANON_BOLSA_2;
                m_costesRelativo = m_deposito * PORCENTAJE_2;
            }
            else if (m_deposito >= CANON_BOLSA_3)
            {
                m_costesAbsoluto = CANON_BOLSA_3;
                m_costesRelativo = m_deposito * PORCENTAJE_3;
            }
            else if (m_deposito >= CANON_BOLSA_4)
            {
                m_costesAbsoluto = CANON_BOLSA_4;
                m_costesRelativo = m_deposito * PORCENTAJE_4;
            }
            else if (m_deposito >= CANON_BOLSA_5)
            {
                m_costesAbsoluto = CANON_BOLSA_5;
                m_costesRelativo = m_deposito * PORCENTAJE_5;
            }
            else
            {
                m_costesAbsoluto = CANON_BOLSA_6;
                m_costesRelativo = 0;
            }

            if(m_costesRelativo > m_costesAbsoluto)
            {
                m_efectivo = m_efectivo - m_costesAbsoluto;
            }
            else
            {
                m_efectivo = m_efectivo - m_costesRelativo;
            }
        }

        private void calculoResultados()
        {
            m_acciones = m_efectivo / m_precioAccion;
            m_ingresoDividendo = m_acciones * m_dividendo;
            m_ingresos = m_ingresoDividendo - m_custodia;
            m_tiempo = m_deposito / m_ingresos;
            m_inversion = m_acciones * m_precioAccion;
        }

        private void mostrarResultados()
        {
            labelNumAcciones.Text = m_numeroAcciones + " " +  m_acciones;
            labelDividendoTotal.Text = m_dividendoTotal + " " + m_ingresoDividendo + "€";
            labelIngresoAnual.Text = m_ingresoAnual + " " + m_ingresos + "€";
            labelTiempo.Text = m_recuperar + " " + m_tiempo + " años";
            labelInversionTotal.Text = m_inversionTotal + " " + m_inversion + "€";
        }
    }
}
