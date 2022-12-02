﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fina
{
    public partial class FormVenta : Form
    {
        Utilidades uti = new Utilidades();
        private int id_usuario_rol_pagina = 0;
        public int caja_activa;
        public int lista = 1;
        public float iva = 1.16f;
        public double descuento = 0;
        public FormVenta(int id_usuario_rol, int caja)
        {
            caja_activa = caja;
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }
        private void btn_nuevo_producto_Click(object sender, EventArgs e)
        {
            int id_producto = (int)txt_codigo_producto_carrito.Value;
            if (txt_cantidad_producto_carrito.Value > 0)
            {
                if (getCantidadInventario((int)txt_codigo_producto_carrito.Value) >= txt_cantidad_producto_carrito.Value)
                {
                    try
                    {
                        if (existeProducto(id_producto))
                        {
                            if (existeEnLista(id_producto))
                            {
                                for (int i = 0; i < dg_carrito.RowCount; i++)
                                {
                                    if (id_producto == Convert.ToInt32(dg_carrito.Rows[i].Cells["id_producto"].Value))
                                    {
                                        int cantidad = (int)dg_carrito.Rows[i].Cells["cantidad"].Value + (int)txt_cantidad_producto_carrito.Value;
                                        int descuento = (int)dg_carrito.Rows[i].Cells["descuento_producto"].Value;
                                        double precio = (double)dg_carrito.Rows[i].Cells["precio_producto"].Value;
                                        double subtotal = cantidad * precio;
                                        double total_descuento = Math.Round(((double)subtotal * ((double)((int)descuento) / 100)), 2);
                                        double total = (subtotal - (total_descuento)) * iva;
                                        dg_carrito.Rows[i].Cells["cantidad"].Value = cantidad;
                                        dg_carrito.Rows[i].Cells["total_descuento_producto"].Value = total_descuento;
                                        dg_carrito.Rows[i].Cells["subtotal"].Value = Math.Round(subtotal, 2);
                                        dg_carrito.Rows[i].Cells["total"].Value = Math.Round(total, 2);
                                    }
                                }
                            }
                            else
                            {
                                string nombre = "";
                                int cantidad = 0;
                                double precio = 0;
                                string um = "";
                                int descuento = 0;
                                double descuentoTotal = 0;
                                double subtotal = 0;
                                double total = 0;

                                Conexion con = new Conexion();
                                SqlCommand cmd = new SqlCommand("SP_EXISTE_PRODUCTO", con.conectar());
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                if (dt.Rows.Count > 0)
                                {
                                    id_producto = (int)dt.Rows[0][0];
                                    nombre = (string)dt.Rows[0][1];
                                    cantidad = (int)txt_cantidad_producto_carrito.Value;
                                    um = (string)dt.Rows[0][2];
                                    precio = (double)dt.Rows[0][4];
                                    descuento = validarDescuento(id_producto);
                                    subtotal = Math.Round((cantidad * precio), 2);
                                    descuentoTotal = Math.Round(((double)subtotal * ((double)((int)descuento) / 100)), 2);
                                    total = Math.Round(((subtotal - (descuentoTotal)) * iva), 2);
                                    dg_carrito.Rows.Add(lista + "", id_producto, nombre, cantidad, um, precio, descuento, descuentoTotal, subtotal, total);
                                    lista++;
                                }
                            }
                            double descuentoTotalCarrito = 0;
                            double subtotalCarrito = 0;
                            double totalCarrito = 0;
                            foreach (DataGridViewRow row in dg_carrito.Rows)
                            {
                                descuentoTotalCarrito += (double)row.Cells["total_descuento_producto"].Value;
                                subtotalCarrito += (double)row.Cells["subtotal"].Value;
                                totalCarrito += (double)row.Cells["total"].Value;
                            }
                            descuento = descuentoTotalCarrito;
                            txt_subtotal_carrito.Value = (decimal)(double)subtotalCarrito;
                            txt_total_carrito.Value = (decimal)(double)totalCarrito;
                        }
                        else
                        {
                            MessageBox.Show("No existen productos con el ID: " + id_producto + "", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No hay suficientes productos en el inventario", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Ingresa una cantidad mayor a 0", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            dg_carrito.ClearSelection();
            dg_carrito.MultiSelect = false;
        }
        public bool existeEnLista(int codigo_producto)
        {
            bool existe = false;
            for(int i = 0; i< dg_carrito.RowCount; i++)
            {
                if(Convert.ToInt32(dg_carrito.Rows[i].Cells["id_producto"].Value) == codigo_producto)
                {
                    existe = true;
                    return existe;
                }
                else
                {
                    existe = false;
                }               
            }
            return existe;
        }
        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if (dg_carrito.RowCount > 0)
            {
                FormPago frm = new FormPago(id_usuario_rol_pagina, caja_activa, (double)txt_total_carrito.Value, (double)txt_subtotal_carrito.Value, descuento, dg_carrito);
                AddOwnedForm(frm);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ningún producto agregado a la lista", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cerrar_productos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("¿Está seguro que quiere cerrar esta pestaña?" + Environment.NewLine + "Cualquier cambio no guardado se perderá", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cerrar != DialogResult.Yes)
            {
                e.Cancel = true;
            }
    }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            FormBuscarProducto frm = new FormBuscarProducto(id_usuario_rol_pagina);
            AddOwnedForm(frm);
            frm.ShowDialog();

        }
        public int getCantidadInventario(int id_producto)
        {
            int cantidad = 0;
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_CANTIDAD_INVENTARIO", con.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id_producto);
            cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            return cantidad;
        }
        public int validarDescuento(int id_producto)
        {
            int cantidad = 0;
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_VALIDAR_FECHA_DESCUENTO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                return cantidad;
            }
            catch (Exception ex)
            {
                return cantidad;
            }
        }
        public bool existeProducto(int id_producto)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_EXISTE_PRODUCTO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

