using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calificaciones_Alumnos
{
    public partial class Form1 : Form
    {
        AlumnosDatos aludatos = new AlumnosDatos();
        Alumnos alu = new Alumnos();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_abrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog excelFile = new OpenFileDialog() { Filter = "Excel Files|*.xlsx;*.xlsm" })
            {
                if (excelFile.ShowDialog() == DialogResult.OK)
                {   //Metodos para cargar y leer el archivo de excel
                    try {
                        FileStream fs = File.Open(excelFile.FileName, FileMode.Open, FileAccess.Read);
                        IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                        DataSet result = reader.AsDataSet();
                        //Data Reader methods
                        foreach (DataTable table in result.Tables)
                        {
                            int rowcount = table.Rows.Count;
                            int columncount = table.Columns.Count;
                            if (columncount > 6) {
                                MessageBox.Show("Formato de archivo invalido o tal vez se encuentre en uso por otro programa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else{
                                for (int i = 0; i < rowcount; i++)
                                {   //Array que mandaremos hacia la lista
                                    ArrayList arrAlumno = new ArrayList();
                                    for (int j = 0; j < columncount; j++)
                                    {
                                        string datoAlumno = table.Rows[i].ItemArray[j].ToString();
                                        arrAlumno.Add(datoAlumno);
                                    }
                                    if (i >= 1)
                                    { //Objeto que se mandara al metodo de agregar alumnos
                                        AlumnosDatos DatosdelAlumno = new AlumnosDatos()
                                        {
                                            Nombre = arrAlumno[0].ToString(),
                                            ApellidoP = arrAlumno[1].ToString(),
                                            ApellidoM = arrAlumno[2].ToString(),
                                            Grado = arrAlumno[3].ToString(),
                                            Grupo = arrAlumno[4].ToString(),
                                            Calificacion = Convert.ToDouble(arrAlumno[5]),
                                        };
                                        alu.agregar_Alumnos(DatosdelAlumno);
                                    }
                                }
                            }
                            
                        }
                        //Una vez cargados los datos de excel se llena el grafico
                        Fnc_LlenarChart();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Formato de archivo invalido o tal vez se encuentre en uso por otro programa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void Fnc_LlenarChart()
        {   // Llena el chart de las calificaciones de los alumnos
            try {
                pictureBox1.Hide();
                chart_Alumnos.Show();
                chart_Alumnos.Titles.Add("Calificaciones");
                int cont = alu.Lista_Alumnos.Count;
                for (int i = 0; i < cont; i++)
                {
                    // Nombres

                    Series serieAlumnos = chart_Alumnos.Series.Add(alu.Lista_Alumnos[i].Nombre);
                    chart_Alumnos.Series[i].ChartType = SeriesChartType.Bar;

                    // Calificaciones
                    serieAlumnos.Label = alu.Lista_Alumnos[i].Calificacion.ToString();
                    serieAlumnos.Points.Add(alu.Lista_Alumnos[i].Calificacion);
                    // Buscamos los alumnos con mayor y menor calificacion
                    Fnc_BuscarNombres();
                }

                //Llena el chart calificacion promedio de cada grado
                chart_Grados.Show();
                chart_Grados.Titles.Add("Promedio por Grado");

                var arrGrados = from item in alu.Lista_Alumnos
                                group item by item.Grado into g
                                select g;
                //Saca los valores de los grados
                IEnumerable<string> keys = arrGrados.Select(x => x.Key);
                // Recorre los grados
                for (int i = 0; i < arrGrados.Count(); i++)
                {
                    int contadorGrados = 0;
                    double promedioGrados = 0;
                    Boolean vuelta = false;
                    //Recorre la lista completa de alumnos
                    for (int j = 0; j < cont; j++)
                    {
                        if (j + 1 >= cont)
                        {
                            vuelta = true;
                        }
                        if (alu.Lista_Alumnos[j].Grado == keys.ElementAt(i) || vuelta == true)
                        {
                            if (vuelta == false)
                            {
                                promedioGrados += alu.Lista_Alumnos[j].Calificacion;
                                contadorGrados++;
                            }
                            //Termina el recorrido del grado
                            if (vuelta == true)
                            {
                                promedioGrados = promedioGrados / contadorGrados;
                                promedioGrados = Math.Round(promedioGrados, 2);
                                chart_Grados.DataSource = alu.Lista_Alumnos;
                                chart_Grados.Series["Promedio"].Points.AddXY("Grado " + keys.ElementAt(i), promedioGrados);
                                chart_Grados.Series["Promedio"].Points[i].Label = promedioGrados.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Formato de Excel inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Fnc_BuscarNombres() {
            int cont = alu.Lista_Alumnos.Count;
            double promediogral = 0;
            double mayorcalif=0;
            double menorcalif=10;
            string nombremayor = "";
            string nombremenor = "";
            for (int i = 0; i < cont; i++)
            {
                if (alu.Lista_Alumnos[i].Calificacion > mayorcalif) {
                    mayorcalif = alu.Lista_Alumnos[i].Calificacion;
                    nombremayor = alu.Lista_Alumnos[i].Nombre + " " + alu.Lista_Alumnos[i].ApellidoP + " " + alu.Lista_Alumnos[i].ApellidoM;
                }
                if (alu.Lista_Alumnos[i].Calificacion < menorcalif)
                {
                    menorcalif  = alu.Lista_Alumnos[i].Calificacion;
                    nombremenor = alu.Lista_Alumnos[i].Nombre + " " + alu.Lista_Alumnos[i].ApellidoP + " " + alu.Lista_Alumnos[i].ApellidoM;
                }
                //Promedio general de todos los alumnos
                promediogral += alu.Lista_Alumnos[i].Calificacion;
            }
            promediogral = promediogral / cont;
            promediogral = Math.Round(promediogral, 2);
            lblmayor.Show();
            lblmenor.Show();
            lblnombremayor.Show();
            lblnombremenor.Show();
            lblpromediogral.Show();
            lblpromedio.Show();
            lblnombremayor.Text = nombremayor;
            lblnombremenor.Text = nombremenor;
            lblpromedio.Text = promediogral.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            // Escondemos los formularios que no se usan
            chart_Alumnos.Hide();
            chart_Grados.Hide();
            lblmayor.Hide();
            lblmenor.Hide();
            lblpromediogral.Hide();
            lblpromedio.Hide();
            lblnombremayor.Hide();
            lblnombremenor.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
