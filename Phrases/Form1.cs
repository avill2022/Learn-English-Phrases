using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace Phrases
{
    public partial class Form1 : Form
    {
        int opcion;
        List<String> lista = new List<string>();
        Random random = new Random();
        Stack<Phrase> StackPhrase = new Stack<Phrase>();

        public Form1()
        {
            InitializeComponent();
            opcion = 0;
        }
        private void agregaItems()
        {
            Selecciona.Items.Add("50 Basic English Phrases - 1");
            Selecciona.Items.Add("50 Basic English Phrases - 2");
        }
        private void reiniciar()
        {
            opcion = 1;
            Entender.Visible = true;
            Escribir.Visible = true;
            Traducir.Visible = true;
            Selecciona.Visible = false;
            Play.Visible = false;
            R.Visible = false;
            LR.Visible = false;
            Entrada.Visible = false;
            Regresar.Visible = false;
            Restantes.Visible = false;
            Restantes.Text = "Restantes: ?";
            opcion = 0;
            lista.Clear();
            random = new Random();
            StackPhrase.Clear();
            Selecciona.Items.Clear();
            Opciones.Visible = false;
        }
        private void Entender_Click(object sender, EventArgs e)
        {
            opcion = 1;
            Regresar.Visible = true;
            Entender.Visible = false;
            Escribir.Visible = false;
            Traducir.Visible = false;
            Selecciona.Visible = true;
            Play.Visible = false;
            R.Visible = false;
            LR.Visible = false;
            Entrada.Visible = false;
            Restantes.Visible = false;
            agregaItems();
        }
        private void Escribir_Click(object sender, EventArgs e)
        {
            opcion = 2;
            Regresar.Visible = true;
            Entender.Visible = false;
            Escribir.Visible = false;
            Traducir.Visible = false;
            Selecciona.Visible = true;
            Play.Visible = false;
            R.Visible = false;
            LR.Visible = false;
            Entrada.Visible = false;
            Restantes.Visible = false;
            agregaItems();
        }
        private void Traducir_Click(object sender, EventArgs e)
        {
            opcion = 3;
            Regresar.Visible = true;
            Entender.Visible = false;
            Escribir.Visible = false;
            Traducir.Visible = false;
            Selecciona.Visible = true;
            Play.Visible = false;
            R.Visible = false;
            LR.Visible = false;
            Entrada.Visible = false;
            Restantes.Visible = false;
            agregaItems();
        }
        private bool estaEnLista(String nombre, List<String> lista)
        {
            foreach (String s in lista)
                if (s == nombre)
                    return true;
            return false;
        }
        private List<String> eliminaLista(String nombre, List<String> lista)
        {
            List<String> AUX = new List<string>();
            foreach (String s in lista)
                if (s != nombre)
                    AUX.Add(s);
            return AUX;
        }
        private void Selecciona_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            String nombre = Selecciona.SelectedItem.ToString();
            if (estaEnLista(nombre, lista) == false)
                lista.Add(nombre);
            else
                lista = eliminaLista(nombre, lista);
            if (lista.Count != 0)
                Aceptar.Visible = true;
            else
                Aceptar.Visible = false;
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            Entender.Visible = false;
            Escribir.Visible = false;
            Traducir.Visible = false;
            Selecciona.Visible = false;
            Aceptar.Visible = false;
            Play.Visible = true;
            R.Visible = true;
            LR.Visible = true;
            Entrada.Visible = true;
            Opciones.Visible = true;
            Restantes.Visible = true;

            foreach(String s in lista)
            {
                cargaArchivo(s);
            }
            if (opcion == 2)
            {
                Phrase rase = StackPhrase.Peek();
                LR.Text = rase._phraseE;
            }else
            if (opcion == 3)
            {
                Phrase rase = StackPhrase.Peek();
                LR.Text = rase._phraseI;
            }
            Restantes.Text = "Restantes: " + StackPhrase.Count.ToString();
        }
        private string limpiaCadena(string tex)
        {
            string te = "";
            for (int i = 0; i < tex.Length; i++)
            {
                if(tex[i] != '\n' && tex[i] != '\r')
                    te += tex[i].ToString();
            }
            return te;
        }
        private void Entrada_TextChanged(object sender, EventArgs e)
        {
            if(Entrada.Text.Length!=0)
                if (Entrada.Text[Entrada.Text.Length - 1] == '\n')
                {
                    if (comparaCadenas(limpiaCadena((string)Entrada.Text), StackPhrase.Peek()) == true)
                    {
                        MessageBox.Show("Correcto");
                        LR.Text = "Respuesta";
                        StackPhrase.Pop();
                        Restantes.Text = "Restantes: " + StackPhrase.Count.ToString();
                        if (StackPhrase.Count != 0)
                        {
                            StackPhrase.Peek().play();
                            if (opcion == 2)
                            {
                                Phrase rase = StackPhrase.Peek();
                                LR.Text = rase._phraseE;
                            }
                            else
                                if (opcion == 3)
                                {
                                    Phrase rase = StackPhrase.Peek();
                                    LR.Text = rase._phraseI;
                                }
                        }
                        else
                        {
                            MessageBox.Show("Ejersicio completado");
                            reiniciar();
                        }

                    }
                    Entrada.Text = "";
                }
        }
        private bool comparaCadenas(string caden, Phrase phrase)
        {
            switch (opcion)
            {
                case 1:
                   if (caden == phrase._phraseE)
                        return true;
                    else
                        return false;
                case 2:
                    if (caden == phrase._phraseI)
                        return true;
                    else
                        return false;
                case 3:
                    if (caden == phrase._phraseE)
                        return true;
                    else
                        return false;
            }
            return false;
        }
        private void cargaArchivo(String nombre)
        {
            FileStream archivo = new FileStream("phrases_\\"+ nombre +".txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(archivo);
            String n = "";
            List<Phrase> aux = new List<Phrase>();
            while (leer.Peek() != -1)
            {
               n = leer.ReadLine().ToString();
               
               String n1 = "";
               String n2 = "";
               String n3 = "";
                int tip = 0;
               for (int i = 0; i < n.Length; i++)
               {
                   if (n[i] == '-')
                       tip += 1;
                   else
                   {
                       switch (tip)
                       { 
                           case 0:
                               n1 = n1 + n[i].ToString();
                               break;
                           case 1:
                               n2 = n2 + n[i].ToString();
                               break;
                           case 2:
                               n3 = n3 + n[i].ToString();
                               break;
                       }
                   }
               }
               aux.Add(new Phrase(limpiaCadena(n1),limpiaCadena(n2), int.Parse(n3)));
            }
            reordenaLista(aux);
            leer.Close();
        }
        private void reordenaLista(List<Phrase> listaP)
        {
            while(listaP.Count!=0)
            {
                int num = random.Next(listaP.Count - 1);
                StackPhrase.Push(listaP[num]);
                listaP.RemoveAt(num);
            }
        }
        private void Play_Click(object sender, EventArgs e)
        {
            StackPhrase.Peek().play();
        }
        private void R_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 1:
                    LR.Text = StackPhrase.Peek()._phraseE;
                    break;
                case 2:
                    LR.Text = StackPhrase.Peek()._phraseI;
                    break;
                case 3:
                    LR.Text = StackPhrase.Peek()._phraseE;
                    break;
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }
    }
}
