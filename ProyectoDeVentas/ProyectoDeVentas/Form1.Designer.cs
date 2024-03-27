namespace ProyectoDeVentas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tiendaToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            marcasToolStripMenuItem = new ToolStripMenuItem();
            afiliadosToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            sueldosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            diariasToolStripMenuItem = new ToolStripMenuItem();
            semanalesToolStripMenuItem = new ToolStripMenuItem();
            mensualesToolStripMenuItem = new ToolStripMenuItem();
            anualesToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiendaToolStripMenuItem, empleadosToolStripMenuItem, ventasToolStripMenuItem, loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(627, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiendaToolStripMenuItem
            // 
            tiendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, marcasToolStripMenuItem, afiliadosToolStripMenuItem });
            tiendaToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            tiendaToolStripMenuItem.Size = new Size(54, 20);
            tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(128, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // marcasToolStripMenuItem
            // 
            marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            marcasToolStripMenuItem.Size = new Size(128, 22);
            marcasToolStripMenuItem.Text = "Marcas";
            // 
            // afiliadosToolStripMenuItem
            // 
            afiliadosToolStripMenuItem.Name = "afiliadosToolStripMenuItem";
            afiliadosToolStripMenuItem.Size = new Size(128, 22);
            afiliadosToolStripMenuItem.Text = "Afiliados";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaToolStripMenuItem, sueldosToolStripMenuItem });
            empleadosToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(115, 22);
            listaToolStripMenuItem.Text = "Lista";
            // 
            // sueldosToolStripMenuItem
            // 
            sueldosToolStripMenuItem.Name = "sueldosToolStripMenuItem";
            sueldosToolStripMenuItem.Size = new Size(115, 22);
            sueldosToolStripMenuItem.Text = "Sueldos";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { diariasToolStripMenuItem, semanalesToolStripMenuItem, mensualesToolStripMenuItem, anualesToolStripMenuItem });
            ventasToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // diariasToolStripMenuItem
            // 
            diariasToolStripMenuItem.Name = "diariasToolStripMenuItem";
            diariasToolStripMenuItem.Size = new Size(130, 22);
            diariasToolStripMenuItem.Text = "Diarias";
            // 
            // semanalesToolStripMenuItem
            // 
            semanalesToolStripMenuItem.Name = "semanalesToolStripMenuItem";
            semanalesToolStripMenuItem.Size = new Size(130, 22);
            semanalesToolStripMenuItem.Text = "Semanales";
            // 
            // mensualesToolStripMenuItem
            // 
            mensualesToolStripMenuItem.Name = "mensualesToolStripMenuItem";
            mensualesToolStripMenuItem.Size = new Size(130, 22);
            mensualesToolStripMenuItem.Text = "Mensuales";
            // 
            // anualesToolStripMenuItem
            // 
            anualesToolStripMenuItem.Name = "anualesToolStripMenuItem";
            anualesToolStripMenuItem.Size = new Size(130, 22);
            anualesToolStripMenuItem.Text = "Anuales";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarToolStripMenuItem, registrarToolStripMenuItem, logoutToolStripMenuItem });
            loginToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(120, 22);
            ingresarToolStripMenuItem.Text = "Ingresar";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(120, 22);
            registrarToolStripMenuItem.Text = "Registrar";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(120, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.png_transparent_new_york_city_skyline_illustration_city_night_building_photography_condominium_thumbnail;
            ClientSize = new Size(627, 450);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Pantalla Gerente";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiendaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem marcasToolStripMenuItem;
        private ToolStripMenuItem afiliadosToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem sueldosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem diariasToolStripMenuItem;
        private ToolStripMenuItem semanalesToolStripMenuItem;
        private ToolStripMenuItem mensualesToolStripMenuItem;
        private ToolStripMenuItem anualesToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}