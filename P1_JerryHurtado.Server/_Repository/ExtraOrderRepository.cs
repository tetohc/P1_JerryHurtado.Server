using Microsoft.EntityFrameworkCore;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server.Models.ModelsDB;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace P1_JerryHurtado.Server._Repository
{
    public class ExtraOrderRepository : IExtraOrderRepository<ExtraPedido>
    {
        private readonly string _dbConnectionString;

        public ExtraOrderRepository()
        {
            _dbConnectionString = ConfigurationManager.ConnectionStrings["RestUned"].ConnectionString;
        }

        public bool Add(ExtraPedido model)
        {
            using (var connection = new SqlConnection(_dbConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        var exist = GetById(model.IdPedido, model.IdPlato, model.IdExtra);
                        if (exist == null)
                        {
                            command.CommandText = "INSERT INTO ExtraPedido VALUES(@IdPedido, @IdPlato, @IdExtra)";
                            command.Parameters.Add("@IdPedido", SqlDbType.Int).Value = model.IdPedido;
                            command.Parameters.Add("@IdPlato", SqlDbType.Int).Value = model.IdPlato;
                            command.Parameters.Add("@IdExtra", SqlDbType.Int).Value = model.IdExtra;

                            command.Connection = connection;
                            command.Transaction = transaction;
                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    return true;
                }
                catch (DbUpdateConcurrencyException)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public IEnumerable<ExtraPedido> GetAll()
        {
            var modelList = new List<ExtraPedido>();
            using (var connection = new SqlConnection(_dbConnectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = "SELECT * FROM ExtraPedido";
                connection.Open();
                command.Connection = connection;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model = new ExtraPedido();
                        model.IdPedido = (int)reader[0];
                        model.IdPlato = (int)reader[1];
                        model.IdExtra = (int)reader[2];
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        public ExtraPedido GetById(int orderId, int dishId, int extraId)
        {
            var model = new ExtraPedido();
            using (var connection = new SqlConnection(_dbConnectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = @"SELECT * FROM ExtraPedido
                                            Where IdPedido = @orderId AND IdPlato = @dishId AND IdExtra = @extraId";

                command.Parameters.Add("@orderId", SqlDbType.Int).Value = orderId;
                command.Parameters.Add("@dishId", SqlDbType.Int).Value = dishId;
                command.Parameters.Add("@extraId", SqlDbType.Int).Value = extraId;

                connection.Open();
                command.Connection = connection;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        model.IdPedido = (int)reader[0];
                        model.IdPlato = (int)reader[1];
                        model.IdExtra = (int)reader[2];
                    }
                }
            }
            return model.IdPedido == 0 && model.IdPlato == 0 && model.IdExtra == 0 ? null : model;
        }
    }
}