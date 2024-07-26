﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
	public class CD_Venta
	{
		public int ObtenerCorrelativo()
		{
			int idcorrelativo = 0;

			using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
			{
				try
				{
					StringBuilder query = new StringBuilder();
					query.AppendLine("select count(*) + 1 from VENTA");
					SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
					cmd.CommandType = CommandType.Text;

					oconexion.Open();

					idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
				}
				catch (Exception)
				{
					idcorrelativo = 0;
				}
			}

			return idcorrelativo;
		}

		public bool RestarStock(int idproducto, int cantidad)
		{
			bool respuesta = true;

			using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
			{
				try
				{
					StringBuilder query = new StringBuilder();
					query.AppendLine("Update PRODUCTO Set Stock = Stock - @cantidad Where IdProducto = @idproducto");

					SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
					cmd.Parameters.AddWithValue("@cantidad", cantidad);
					cmd.Parameters.AddWithValue("@idproducto", idproducto);
					cmd.CommandType = CommandType.Text;
					oconexion.Open();

					respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
				}
				catch (Exception ex)
				{
					respuesta = false;
				}
			}
			return respuesta;
		}

		public bool SumarStock(int idproducto, int cantidad)
		{
			bool respuesta = true;

			using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
			{
				try
				{
					StringBuilder query = new StringBuilder();
					query.AppendLine("Update PRODUCTO Set Stock = Stock + @cantidad Where IdProducto = @idproducto");

					SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
					cmd.Parameters.AddWithValue("@cantidad", cantidad);
					cmd.Parameters.AddWithValue("@idproducto", idproducto);
					cmd.CommandType = CommandType.Text;
					oconexion.Open();

					respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
				}
				catch (Exception ex)
				{
					respuesta = false;
				}
			}
			return respuesta;
		}

		public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
		{
			bool Respuesta = false;
			Mensaje = string.Empty;

			using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
			{
				try
				{
					SqlCommand cmd = new SqlCommand("SP_RegistrarVenta", oconexion);
					cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.idUsuario);
					cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
					cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
					cmd.Parameters.AddWithValue("DocumentoCliente", obj.DocumentoCliente);
					cmd.Parameters.AddWithValue("NombreCliente", obj.NombreCliente);
					cmd.Parameters.AddWithValue("MontoPago", obj.MontoPago);
					cmd.Parameters.AddWithValue("MontoCambio", obj.MontoCambio);
					cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
					cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
					cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
					cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
					cmd.CommandType = CommandType.StoredProcedure;

					oconexion.Open();
					cmd.ExecuteNonQuery();

					Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
					Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
				}
				catch (Exception ex)
				{
					Respuesta = false;
					Mensaje = ex.Message;
				}
			}

			return Respuesta;
		}
	}
}
