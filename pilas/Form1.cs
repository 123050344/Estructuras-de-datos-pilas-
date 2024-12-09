using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pilas
{
    public partial class Form1 : Form
    {
        private Stack<int> pila = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                pila.Push(numero); // Agrega el n�mero a la pila
                txtNumero.Clear();
                ActualizarLista(); // Llama al m�todo para actualizar la lista
                MessageBox.Show($"N�mero {numero} agregado a la pila.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero v�lido.");
            }
        }

        private void ActualizarLista()
        {
            lstPila.Items.Clear();
            foreach (int numero in pila)
            {
                lstPila.Items.Add(numero.ToString());
            }
        }


        private void btnPop_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                int eliminado = pila.Pop(); // Elimina el �ltimo elemento
                ActualizarLista(this);
                MessageBox.Show($"N�mero {eliminado} eliminado de la pila.");
            }
            else
            {
                MessageBox.Show("La pila est� vac�a.");
            }
        }

        private void ActualizarLista(Form1 @this)
        {
            lstPila.Items.Clear();

            // Agregar cada elemento de la pila al ListBox
            foreach (int numero in pila)
            {
                lstPila.Items.Add(numero.ToString()); // Conversi�n expl�cita
            }
        }
    }
}
