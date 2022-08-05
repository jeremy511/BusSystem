using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityTier;
using BusinessTier;

namespace PresentationTier
{
    public partial class AdminTrip : Form
    {
        private string IdBus;
        private string IdRoute;
        private string IdDriver;
        private string IdTrip;
        private bool Edit = false;

        

        E_Trip objEntity = new E_Trip();
        B_Trip objBusiness = new B_Trip();

        public AdminTrip()
        {
            InitializeComponent();
        }

        private void AdminTrip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sYSTEM_BUSDataSet.SP_LIST_AVAILABLE_JOURNEY' table. You can move, or remove it, as needed.
            this.sP_LIST_AVAILABLE_JOURNEYTableAdapter.Fill(this.sYSTEM_BUSDataSet.SP_LIST_AVAILABLE_JOURNEY);
            


            // TODO: This line of code loads data into the 'sYSTEM_BUSDataSet.SP_LIST_AVAILABLE_BUSES' table. You can move, or remove it, as needed.
            this.sP_LIST_AVAILABLE_BUSESTableAdapter.Fill(this.sYSTEM_BUSDataSet.SP_LIST_AVAILABLE_BUSES);


            // TODO: This line of code loads data into the 'sYSTEM_BUSDataSet.SP_LIST_AVAILABLE_DRIVER' table. You can move, or remove it, as needed.
            this.sP_LIST_AVAILABLE_DRIVERTableAdapter.Fill(this.sYSTEM_BUSDataSet.SP_LIST_AVAILABLE_DRIVER);


            // TODO: This line of code loads data into the 'sYSTEM_BUSDataSet.TRIPS' table. You can move, or remove it, as needed.
            this.tRIPSTableAdapter.Fill(this.sYSTEM_BUSDataSet.TRIPS);

            Find("");


            
        }
        public void Find(string find)
        {
            B_Trip objBusiness = new B_Trip();
            TripDataGrid.DataSource = objBusiness.ListAllTrip(find);
        }

        private void BtnSaveTrip_Click(object sender, EventArgs e)
        {
             if (Edit == false)
            {
                try
                {
                    objEntity.IdDriver = Convert.ToInt32(IdDriver);
                    objEntity.IdBus = Convert.ToInt32(IdBus);
                    objEntity.IdRoute = Convert.ToInt32(IdRoute);

                    objBusiness.InsertTrip(objEntity);
                    MessageBox.Show("Registro guardado.");
                    Clean();
                    Find("");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar el registro.");
                }            
            }

            if (Edit==true)
            {
                try
                {
                    objEntity.IdTrip = Convert.ToInt32(IdTrip);
                    objEntity.IdDriver = Convert.ToInt32(IdDriver);
                    objEntity.IdBus = Convert.ToInt32(IdBus);
                    objEntity.IdRoute = Convert.ToInt32(IdRoute);
                   

                    objBusiness.EditTrip(objEntity);
                    MessageBox.Show("Registro editado exitosamente.");
                    Clean();
                    Find("");
                    Edit = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro." + ex);
                }
            }
        }

        private void BtnDeleteTrip_Click(object sender, EventArgs e)
        {
            if (TripDataGrid.SelectedRows.Count > 0)
            {
                objEntity.IdTrip = Convert.ToInt32(TripDataGrid.CurrentRow.Cells[0].Value.ToString());
                objBusiness.DeleteTrip(objEntity);

                MessageBox.Show("El registro ha sido eliminado.");
                Find("");
            }
            else
            {
                MessageBox.Show("Seleccione un registro a eliminar.");
            }
        }

        private void BtnEditTrip_Click(object sender, EventArgs e)
        {

        }

        public void Clean()
        {
           AvailableDriverCombo.SelectedIndex = 0;
            AvailableBusCombo.SelectedIndex = 0;
            AvailableRouteCombo.SelectedIndex = 0;  
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.ShowInTaskbar = true;
            home.Show();
        }
    }
}
