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
    public partial class AdminDriver : Form
    {
        private string idDriver;
        private bool edit = false;
        E_Driver objEntity = new E_Driver();
        B_Driver objBusiness = new B_Driver();

        public AdminDriver()
        {
            InitializeComponent();
        }

        public void clean()
        {
            TxtName.Text = "";
            TxtLastname.Text = "";
            TxtCedula.Text = "";
            DriverBirthDate.Text = DateTime.Now.Date.ToString();

        }

        private void AdminDriver_Load(object sender, EventArgs e)
        {
            Find("");
        }

        //guardar registro
        private void BtnSaveDriver_Click(object sender, EventArgs e)
        {

            
            if(edit == false)
            {
                try
                {
                    objEntity.Name = TxtName.Text.ToUpper();
                    objEntity.Lastname = TxtLastname.Text.ToUpper();
                    objEntity.Cedula = TxtCedula.Text.ToUpper();
                    objEntity.BirthDate = DriverBirthDate.Value;

                    objBusiness.InsertDriver(objEntity);
                    MessageBox.Show("Registro guardado.");
                    clean();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro." + ex);
                }
            }
           
            if (edit == true)
            {
                try
                {
                    objEntity.IdDriver = Convert.ToInt32(TxtId.Text.ToUpper());
                    objEntity.Name = TxtName.Text.ToUpper();
                    objEntity.Lastname = TxtLastname.Text.ToUpper();
                    objEntity.Cedula = TxtCedula.Text.ToUpper();
                    objEntity.BirthDate = DriverBirthDate.Value;

                    objBusiness.InsertDriver(objEntity);
                    MessageBox.Show("Registro Editado.");
                    clean();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro." + ex);
                }
            }

            if(edit == true)
            {
                try
                {
                    objEntity.IdDriver = Convert.ToInt32(idDriver);
                    objEntity.Name = TxtName.Text.ToUpper();
                    objEntity.Lastname = TxtLastname.Text.ToUpper();
                    objEntity.Cedula = TxtCedula.Text.ToUpper();
                    objEntity.BirthDate = DriverBirthDate.Value;

                    objBusiness.EditDriver(objEntity);
                    MessageBox.Show("Registro editado exitosamente.");
                    clean();
                    edit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro." + ex);
                }
            }
        }

        private void BtnDeleteDriver_Click(object sender, EventArgs e)
        {
            if(DriverDataGrid.SelectedRows.Count > 0)
            {
                objEntity.IdDriver = Convert.ToInt32(DriverDataGrid.CurrentRow.Cells[0].Value.ToString());
                objBusiness.DeleteDriver(objEntity);

                MessageBox.Show("El registro ha sido eliminado.");
            }
            else
            {
                MessageBox.Show("Seleccione un registro a eliminar.");
            }
        }

        private void BtnEditDriver_Click(object sender, EventArgs e)
        {
            if (DriverDataGrid.SelectedRows.Count > 0)
            {
                edit = true;
                idDriver = DriverDataGrid.CurrentRow.Cells[0].Value.ToString();
                TxtName.Text = DriverDataGrid.CurrentRow.Cells[1].Value.ToString();
                TxtLastname.Text = DriverDataGrid.CurrentRow.Cells[2].Value.ToString();
                DriverBirthDate.Text = DriverDataGrid.CurrentRow.Cells[3].Value.ToString();
                TxtCedula.Text = DriverDataGrid.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar.");
            }

        }
        public void Find(string find)
        {
            B_Driver objBusiness = new B_Driver();
            DriverDataGrid.DataSource = objBusiness.ListAllDriver(find);
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
