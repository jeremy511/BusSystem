using EntityTier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class D_Trip
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public List<E_Trip> ListAllTrip(string find)
        {
            SqlCommand command = new SqlCommand("SP_LIST_TRIP", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();

           
            SqlDataReader Reader = command.ExecuteReader();
            List<E_Trip> Listar = new List<E_Trip>();

            while (Reader.Read())
            {
                Listar.Add(new E_Trip
                {
                    IdTrip = Reader.GetInt32(0),
                    IdDriver = Reader.GetInt32(1),
                    Driver = Reader.GetString(2),
                    Idtification = Reader.GetString(3),
                    IdBus = Reader.GetInt32(4),
                    Model = Reader.GetString(5),
                    Brand = Reader.GetString(6),
                    IdRoute = Reader.GetInt32(7),
                    Route = Reader.GetString(8),
                    Distance = Reader.GetString(9),
                    Stop = Reader.GetInt32(10),
                });
            }
            conn.Close();
            Reader.Close();
            return Listar;

        }

        public void InsertTrip(E_Trip trip)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_TRIP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID_DRIVER", trip.IdDriver);
            cmd.Parameters.AddWithValue("@ID_BUS", trip.IdBus);
            cmd.Parameters.AddWithValue("@ID_JOURNEY", trip.IdRoute);


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditTrip(E_Trip trip)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_TRIP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID",trip.IdTrip);
            cmd.Parameters.AddWithValue("@ID_DRIVER", trip.IdDriver);
            cmd.Parameters.AddWithValue("@ID_BUS", trip.IdBus);
            cmd.Parameters.AddWithValue("@ID_JOURNEY", trip.IdRoute);


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteTrip(E_Trip trip)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETE_TRIP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID", trip.IdTrip);

            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
