﻿
namespace Proyecto_fina
{
    partial class FormConsultarRecibos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_consulta = new System.Windows.Forms.DataGridView();
            this.btn_consultar_tickets = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar_notas_credito = new System.Windows.Forms.Button();
            this.btn_reimprimir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_consulta
            // 
            this.dg_consulta.AllowUserToAddRows = false;
            this.dg_consulta.AllowUserToDeleteRows = false;
            this.dg_consulta.AllowUserToResizeColumns = false;
            this.dg_consulta.AllowUserToResizeRows = false;
            this.dg_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_consulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.dg_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_consulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_consulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_consulta.EnableHeadersVisualStyles = false;
            this.dg_consulta.GridColor = System.Drawing.SystemColors.Control;
            this.dg_consulta.Location = new System.Drawing.Point(271, 52);
            this.dg_consulta.Name = "dg_consulta";
            this.dg_consulta.ReadOnly = true;
            this.dg_consulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_consulta.RowHeadersVisible = false;
            this.dg_consulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_consulta.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_consulta.Size = new System.Drawing.Size(781, 577);
            this.dg_consulta.TabIndex = 120;
            // 
            // btn_consultar_tickets
            // 
            this.btn_consultar_tickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consultar_tickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_consultar_tickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar_tickets.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_consultar_tickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_consultar_tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_tickets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consultar_tickets.Location = new System.Drawing.Point(11, 68);
            this.btn_consultar_tickets.Name = "btn_consultar_tickets";
            this.btn_consultar_tickets.Size = new System.Drawing.Size(105, 47);
            this.btn_consultar_tickets.TabIndex = 119;
            this.btn_consultar_tickets.Text = "Venta";
            this.btn_consultar_tickets.UseVisualStyleBackColor = false;
            this.btn_consultar_tickets.Click += new System.EventHandler(this.btn_consultar_tickets_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(35, 11);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(195, 22);
            this.txt_id.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 117;
            this.label1.Text = "ID";
            // 
            // btn_consultar_notas_credito
            // 
            this.btn_consultar_notas_credito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consultar_notas_credito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_consultar_notas_credito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar_notas_credito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_consultar_notas_credito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_consultar_notas_credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_notas_credito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consultar_notas_credito.Location = new System.Drawing.Point(128, 68);
            this.btn_consultar_notas_credito.Name = "btn_consultar_notas_credito";
            this.btn_consultar_notas_credito.Size = new System.Drawing.Size(105, 47);
            this.btn_consultar_notas_credito.TabIndex = 121;
            this.btn_consultar_notas_credito.Text = "Devolución";
            this.btn_consultar_notas_credito.UseVisualStyleBackColor = false;
            this.btn_consultar_notas_credito.Click += new System.EventHandler(this.btn_consultar_notas_credito_Click);
            // 
            // btn_reimprimir
            // 
            this.btn_reimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_reimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reimprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reimprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reimprimir.Location = new System.Drawing.Point(11, 8);
            this.btn_reimprimir.Name = "btn_reimprimir";
            this.btn_reimprimir.Size = new System.Drawing.Size(219, 30);
            this.btn_reimprimir.TabIndex = 122;
            this.btn_reimprimir.Text = "Reimprimir";
            this.btn_reimprimir.UseVisualStyleBackColor = false;
            this.btn_reimprimir.Click += new System.EventHandler(this.btn_reimprimir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 20);
            this.label8.TabIndex = 123;
            this.label8.Text = "Consulta de ventas y devoluciones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.btn_consultar_tickets);
            this.panel1.Controls.Add(this.btn_consultar_notas_credito);
            this.panel1.Location = new System.Drawing.Point(16, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 127);
            this.panel1.TabIndex = 124;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.btn_reimprimir);
            this.panel2.Location = new System.Drawing.Point(16, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 47);
            this.panel2.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(51, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 126;
            this.label2.Text = "¿Qué desea consultar?";
            // 
            // FormConsultarRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dg_consulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultarRecibos";
            this.Text = "FormConsultarRecibos";
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_consulta;
        private System.Windows.Forms.Button btn_consultar_tickets;
        public System.Windows.Forms.NumericUpDown txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar_notas_credito;
        private System.Windows.Forms.Button btn_reimprimir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}