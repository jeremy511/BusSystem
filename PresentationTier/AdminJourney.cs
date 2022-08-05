using BusinessTier;
using EntityTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class AdminJourney : Form
    {
        private string Stops;
        private string IdRoute;
        private bool Edit = false;

        E_Route objEntity = new E_Route();
        B_Route objBusiness = new B_Route();

        public AdminJourney()
        {
            InitializeComponent();
        }

        private void AdminJourney_Load(object sender, EventArgs e)
        {
            Find("");
        }

        public void Find(string find)
        {
            B_Route obj_Business = new B_Route();
            DataGridRoute.DataSource = objBusiness.ListAllRoute(find);
        }
        public void Clean()
        {
            TxtNameRoute.Text = "";
            TxtDistance.Text = "";
            TxtStops.Text = "";   
        }


        private void BtnSaveRoute_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                try
                {
                    objEntity.Name = TxtNameRoute.Text.ToUpper();
                    objEntity.Distance = TxtDistance.Text.ToUpper();
                    objEntity.Stop = Convert.ToInt32(Stops);

                    objBusiness.InsertRoute(objEntity);
                    MessageBox.Show("Registro guardado.");
                    Clean();
                    Find("");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar el registro.");
                }            
            }

            if (Edit)
            {
                try
                {
                    objEntity.IdRoute = Convert.ToInt32(IdRoute);
                    objEntity.Name = TxtNameRoute.Text.ToUpper();
                    objEntity.Distance = TxtDistance.Text.ToUpper();
                    objEntity.Stop = Convert.ToInt32(Stops);

                    objBusiness.EditRoute(objEntity);
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

        private void BtnDeleteRoute_Click(object sender, EventArgs e)
        {
            if (DataGridRoute.SelectedRows.Count > 0)
            {
                objEntity.IdRoute = Convert.ToInt32(DataGridRoute.CurrentRow.Cells[0].Value.ToString());
                objBusiness.DeleteRoute(objEntity);

                MessageBox.Show("El registro ha sido eliminado.");
                Find("");
            }
            else
            {
                MessageBox.Show("Seleccione un registro a eliminar.");
            }
        }

        private void BtnEditRoute_Click(object sender, EventArgs e)
        {
            if (DataGridRoute.SelectedRows.Count > 0)
            {
                Edit = true;
                IdRoute = DataGridRoute.CurrentRow.Cells[0].Value.ToString();
                TxtNameRoute.Text = DataGridRoute.CurrentRow.Cells[1].Value.ToString();
                TxtDistance.Text = DataGridRoute.CurrentRow.Cells[2].Value.ToString();
                TxtStops.Text = DataGridRoute.CurrentRow.Cells[3].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar.");
            }
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
