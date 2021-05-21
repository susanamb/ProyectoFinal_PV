namespace ProyectoFinal
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ahorcadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.memoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.piedraPapelTijeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.piedraPapelTijeraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OrangeRed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.juegosToolStripMenuItem,
            this.scoresToolStripMenuItem,
            this.ventanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.verUsuariosToolStripMenuItem,
            this.editarUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver usuarios";
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar usuario";
            // 
            // juegosToolStripMenuItem
            // 
            this.juegosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unJugadorToolStripMenuItem,
            this.dosJugadoresToolStripMenuItem});
            this.juegosToolStripMenuItem.Name = "juegosToolStripMenuItem";
            this.juegosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.juegosToolStripMenuItem.Text = "Juegos";
            // 
            // unJugadorToolStripMenuItem
            // 
            this.unJugadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ahorcadoToolStripMenuItem1,
            this.memoriaToolStripMenuItem1,
            this.piedraPapelTijeraToolStripMenuItem});
            this.unJugadorToolStripMenuItem.Name = "unJugadorToolStripMenuItem";
            this.unJugadorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.unJugadorToolStripMenuItem.Text = "Un jugador";
            // 
            // ahorcadoToolStripMenuItem1
            // 
            this.ahorcadoToolStripMenuItem1.Name = "ahorcadoToolStripMenuItem1";
            this.ahorcadoToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.ahorcadoToolStripMenuItem1.Text = "Ahorcado";
            this.ahorcadoToolStripMenuItem1.Click += new System.EventHandler(this.ahorcadoToolStripMenuItem1_Click);
            // 
            // memoriaToolStripMenuItem1
            // 
            this.memoriaToolStripMenuItem1.Name = "memoriaToolStripMenuItem1";
            this.memoriaToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.memoriaToolStripMenuItem1.Text = "Memoria";
            this.memoriaToolStripMenuItem1.Click += new System.EventHandler(this.memoriaToolStripMenuItem1_Click);
            // 
            // piedraPapelTijeraToolStripMenuItem
            // 
            this.piedraPapelTijeraToolStripMenuItem.Name = "piedraPapelTijeraToolStripMenuItem";
            this.piedraPapelTijeraToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.piedraPapelTijeraToolStripMenuItem.Text = "Piedra Papel Tijera";
            this.piedraPapelTijeraToolStripMenuItem.Click += new System.EventHandler(this.piedraPapelTijeraToolStripMenuItem_Click);
            // 
            // dosJugadoresToolStripMenuItem
            // 
            this.dosJugadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gatoToolStripMenuItem1,
            this.piedraPapelTijeraToolStripMenuItem1});
            this.dosJugadoresToolStripMenuItem.Name = "dosJugadoresToolStripMenuItem";
            this.dosJugadoresToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dosJugadoresToolStripMenuItem.Text = "Dos jugadores";
            // 
            // gatoToolStripMenuItem1
            // 
            this.gatoToolStripMenuItem1.Name = "gatoToolStripMenuItem1";
            this.gatoToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.gatoToolStripMenuItem1.Text = "Gato";
            this.gatoToolStripMenuItem1.Click += new System.EventHandler(this.gatoToolStripMenuItem1_Click);
            // 
            // piedraPapelTijeraToolStripMenuItem1
            // 
            this.piedraPapelTijeraToolStripMenuItem1.Name = "piedraPapelTijeraToolStripMenuItem1";
            this.piedraPapelTijeraToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.piedraPapelTijeraToolStripMenuItem1.Text = "Piedra Papel Tijera";
            this.piedraPapelTijeraToolStripMenuItem1.Click += new System.EventHandler(this.piedraPapelTijeraToolStripMenuItem1_Click);
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verScoresToolStripMenuItem});
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.scoresToolStripMenuItem.Text = "Puntajes";
            // 
            // verScoresToolStripMenuItem
            // 
            this.verScoresToolStripMenuItem.Name = "verScoresToolStripMenuItem";
            this.verScoresToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.verScoresToolStripMenuItem.Text = "Ver puntajes";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.logo_shido4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 461);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Jueguitos Perrones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ahorcadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem memoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dosJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piedraPapelTijeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piedraPapelTijeraToolStripMenuItem1;
    }
}

