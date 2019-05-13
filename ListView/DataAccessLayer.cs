using ListView.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    public class DataAccessLayer
    {

        public string ConnectionString { get; set; }
        public DataAccessLayer(string dataSource, string databaseName, string userId, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = dataSource;
            builder.InitialCatalog = databaseName;
            builder.UserID = userId;
            builder.Password = password;
            ConnectionString = builder.ToString();
        }

        public List<Group> GetGroups()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string cmdText = @"select Groups.*,Filial.Name as Filial_Name,Filial.Id as 
                       FilialId from Groups Inner Join Filial ON Groups.Filial_Id=Filial.Id";
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Group> groups = new List<Group>();
                    while (reader.Read())
                    {
                        Group group = new Group();
                        group.Filial = new Filial();
                        group.Subject = new Subject();
                        group.Level = new Level();
                        //product.Id = reader.GetInt32(0);
                        //product.Name = reader.GetString(1);
                        //product.Barcode = reader.GetString(2);
                        //product.Price = reader.GetDecimal(3);

                        //product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        //product.Name = reader.GetString(reader.GetOrdinal("Name"));
                        //product.Barcode = reader.GetString(reader.GetOrdinal("Barcode"));
                        //product.Price = reader.GetDecimal(reader.GetOrdinal("Price"));


                        //product.Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? null : (decimal?) reader.GetDecimal(reader.GetOrdinal("Price"));

                        //product.Id = Convert.ToInt32(reader[0]);
                        //product.Name = Convert.ToString(reader[1]);
                        //product.Barcode = Convert.ToString(reader[2]);
                        //product.Price = Convert.ToDecimal(reader[3]);

                        group.Id = Convert.ToInt32(reader[nameof(group.Id)]);
                        group.Name = Convert.ToString(reader[nameof(group.Name)]);
                        group.Level_Id = Convert.ToInt32(reader[nameof(group.Level_Id)]);
                        group.Subject_Id = Convert.ToInt32(reader[nameof(group.Subject_Id)]);
                        group.Filial_Id = Convert.ToInt32(reader[nameof(group.Filial_Id)]);
                        group.Filial.Id = Convert.ToInt32(reader["FilialId"]);
                        group.Filial.Name = Convert.ToString(reader["Filial_Name"]);
                        group.Note = reader.IsDBNull(reader.GetOrdinal("Note")) ? null : reader.GetString(reader.GetOrdinal("Note"));

                        groups.Add(group);
                    }
                    return groups;

                }
            }
        }

        //public int AddProduct(Group group)
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        string cmdText = $"Insert into Products output inserted.Id values(@Name, @Barcode, @Price)";
        //        using (SqlCommand cmd = new SqlCommand(cmdText, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@Name", group.Name);
        //            cmd.Parameters.AddWithValue("@Barcode", group.Barcode);
        //            cmd.Parameters.AddWithValue("@Price", group.Price);

        //            //cmd.ExecuteNonQuery();
        //            return (int)cmd.ExecuteScalar();
        //        }
        //    }
        //}


    }
}
