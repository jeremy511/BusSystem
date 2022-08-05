using BusinessTier;
using EntityTier;
using System;
using System.Windows.Forms;

namespace PresentationTier
{
    public partial class AdminBus : Form
    {
        private string IdBus;
        private bool _isBusy = false;
        E_Bus obj_Entity = new E_Bus();
        B_Bus obj_Business = new B_Bus();

        public AdminBus()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.ShowInTaskbar = true;
            home.Show();
        }

        private void AdminBus_Load(object sender, EventArgs e)
        {

            Find("");
        }

        public void clean()
        {
            TxtBrand.Text = " ";
            TxtModel.Text = " ";
            TxtLicensePlate.Text = " ";
            TxtColor.Text = " ";
            TxtYear.Text = " ";
        }

        private void BtnSaveBus_Click(object sender, EventArgs e)
        {
            if(_isBusy == false)
            {
                try
                {
                     obj_Entity.Brand = TxtBrand.Text.ToUpper();
                    obj_Entity.Model = TxtModel.Text.ToUpper();
                    obj_Entity.License_Plate = TxtLicensePlate.Text.ToUpper();
                    obj_Entity.Color = TxtColor.Text.ToUpper();
                    obj_Entity.year = TxtYear.Text.ToUpper();

                    obj_Business.InsertBus(obj_Entity);

                    MessageBox.Show("Registro guardado.");                   
                    clean();
                    Find("");

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar el registro");
                }
            }

            if(_isBusy == true)
            {
                try
                {
                    obj_Entity.IdBus = Convert.ToInt32(IdBus);
                    obj_Entity.Brand = TxtBrand.Text.ToUpper();
                    obj_Entity.Model = TxtModel.Text.ToUpper();
                    obj_Entity.License_Plate = TxtLicensePlate.Text.ToUpper();
                    obj_Entity.Color = TxtColor.Text.ToUpper();
                    obj_Entity.year = TxtYear.Text.ToUpper();

                    obj_Business.EditBus(obj_Entity);
                    MessageBox.Show("Editado Correctamente.");
                    Find("");
                    clean();
                    _isBusy = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro." + ex);
                }
            }
        }

        public void Find(string find)
        {
            B_Bus obj_Business = new B_Bus();
            BusesDataGrid.DataSource = obj_Business.ListAllBus(find);
        }

        private void BtnDeleteBus_Click(object sender, EventArgs e)
        {
            if(BusesDataGrid.SelectedRows.Count > 0)
            {
                obj_Entity.IdBus = Convert.ToInt32(BusesDataGrid.CurrentRow.Cells[0].Value.ToString());
                obj_Business.DeleteBus(obj_Entity);

                MessageBox.Show("El registro ha sido eliminado.");
            }
            else
            {
                MessageBox.Show("Seleccione un registro a eliminar.");
            }
        }



  

        private void BtnEditBus_Click_1(object sender, EventArgs e)
        {
            if (BusesDataGrid.SelectedRows.Count > 0)
            {
                _isBusy = true;
                IdBus = BusesDataGrid.CurrentRow.Cells[0].Value.ToString();
                TxtBrand.Text = BusesDataGrid.CurrentRow.Cells[1].Value.ToString();
                TxtModel.Text = BusesDataGrid.CurrentRow.Cells[2].Value.ToString();
                TxtLicensePlate.Text = BusesDataGrid.CurrentRow.Cells[3].Value.ToString();
                TxtColor.Text = BusesDataGrid.CurrentRow.Cells[4].Value.ToString();
                TxtYear.Text = BusesDataGrid.CurrentRow.Cells[5].Value.ToString();


            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar.");
            }
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            Find(TxtId.Text);
        }

        private void TxtId_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
        }
    }
}
