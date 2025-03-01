﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_fina
{
    public partial class FormProductos : Form
    {
        private int id_usuario_rol_pagina = 0;
        public FormProductos(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }
        ProductosCAD productos = new ProductosCAD();
        DepartamentosCAD departamento = new DepartamentosCAD();
        DescuentosCAD descuento = new DescuentosCAD();
        Productos p = new Productos();
        Utilidades u = new Utilidades();
        private void FormProductos_Load(object sender, EventArgs e)
        {
            mostrarProductos();
            dg_productos.MultiSelect = false;
            dg_productos.ClearSelection();
        }
        public void mostrarProductos()
        {
            DataTable datos = productos.cargarProductos();
            if (datos.Rows.Count == 0)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
                label1.Visible = false;
                txt_usuario_cambio.Visible = false;
                txt_fecha_cambio.Visible = false;
                btn_editar_producto.Visible = false;
                btn_eliminar_producto.Visible = false;
                dg_productos.Visible = false;
            }
            else
            {
                lbl_tabla_vacia.Visible = false;
                img_tabla_vacia.Visible = false;
                label1.Visible = true;
                txt_usuario_cambio.Visible = true;
                txt_fecha_cambio.Visible = true;
                btn_editar_producto.Visible = true;
                btn_eliminar_producto.Visible = true;
                dg_productos.Visible = true;
                dg_productos.DataSource = datos.DefaultView;
            }
        }
        private void btn_nuevo_producto_Click_1(object sender, EventArgs e)
        {
            FormNuevoProducto frm = new FormNuevoProducto(id_usuario_rol_pagina); 
            frm.Text = "Nuevo producto";
            frm.ShowDialog();
            mostrarProductos();
        }
        private void btn_editar_producto_Click(object sender, EventArgs e)
        {
            FormNuevoProducto frm = new FormNuevoProducto(id_usuario_rol_pagina);
            if(dg_productos.SelectedRows.Count > 0)
            {
                frm.lbl_id_producto.Text = dg_productos.CurrentRow.Cells[0].Value.ToString(); 
                frm.txt_nombre_producto.Text = dg_productos.CurrentRow.Cells[3].Value.ToString();
                frm.cb_departamento_producto.Text = dg_productos.CurrentRow.Cells[1].Value.ToString();
                frm.cb_descuento_producto.Text = dg_productos.CurrentRow.Cells[2].Value.ToString(); 
                //frm.txt_cantidad_descuento_producto.Value = (int)dg_productos.CurrentRow.Cells[9].Value; //
                frm.txt_existencia_producto.Value = Convert.ToDecimal(dg_productos.CurrentRow.Cells[4].Value);
                frm.cb_unidad_medida_producto.Text = dg_productos.CurrentRow.Cells[5].Value.ToString();
                frm.txt_punto_reorden_producto.Value = Convert.ToDecimal(dg_productos.CurrentRow.Cells[9].Value);
                frm.txt_costo_producto.Value = Convert.ToDecimal(dg_productos.CurrentRow.Cells[6].Value);
                frm.txt_precio_unitario_producto.Value = Convert.ToDecimal(dg_productos.CurrentRow.Cells[7].Value);
                frm.txt_descripcion_producto.Text = dg_productos.CurrentRow.Cells[10].Value.ToString();
                if ((bool)dg_productos.CurrentRow.Cells[11].Value == true)
                {
                    frm.rb_habilitado_producto.Checked = true;
                }
                else
                {
                    frm.rb_inhabilitado_producto.Checked = true;
                }
                frm.label11.Visible = true;
                frm.lbl_id_producto.Visible = true;
                frm.lbl_id_producto.Text = dg_productos.CurrentRow.Cells[0].Value.ToString();
                frm.Text = "Editar producto";
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccione un producto a editar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            mostrarProductos();
        }

        private void btn_eliminar_producto_Click(object sender, EventArgs e)
        {
            if (dg_productos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione el producto a eliminar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    p.Codigo_producto = (int)dg_productos.CurrentRow.Cells[0].Value;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro(a) que desea eliminar el producto con ID:" + p.Codigo_producto + "?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        p.Nuevo_id_usuario = id_usuario_rol_pagina;
                        if (ProductosCAD.eliminarProducto(p))
                        {
                            mostrarProductos();
                            MessageBox.Show("Producto eliminado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el producto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_filtro_producto_Click(object sender, EventArgs e)
        {
            string departamento;
            int productos_agotados;
            int existencia_minima;
            int merma;

        }
        private void dg_productos_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dg_productos.SelectedRows.Count > 0)
            {
                label1.Visible = true;
                txt_usuario_cambio.Visible = true;
                txt_fecha_cambio.Visible = true;

                p.Codigo_producto = (int)dg_productos.CurrentRow.Cells[0].Value;

                SqlDataReader rd = Utilidades.getUsuarioCambio("tb_productos", "id_producto", p.Codigo_producto);
                SqlDataReader rd2 = Utilidades.getFechaCambio("tb_productos", "id_producto", p.Codigo_producto);

                if (rd.HasRows && rd2.HasRows)
                {
                    rd.Read();
                    rd2.Read();
                    txt_usuario_cambio.Text = rd.GetString(0);
                    txt_fecha_cambio.Text = rd2.GetDateTime(0).ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("¿Está seguro que quieres cerrar esta pestaña? Cualquier cambio no guardado se perderá", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cerrar == DialogResult.Yes)
            {
                this.Close();
            }
            else if (cerrar == DialogResult.No)
            {
                return;
            }
        }
    }
}

