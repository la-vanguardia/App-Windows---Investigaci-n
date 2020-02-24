namespace Vehiculo_4x4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Right = new Bunifu.Framework.UI.BunifuImageButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Down = new Bunifu.Framework.UI.BunifuImageButton();
            this.Left = new Bunifu.Framework.UI.BunifuImageButton();
            this.Up = new Bunifu.Framework.UI.BunifuImageButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Recibido = new System.Windows.Forms.TextBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comBox_Puertos = new System.Windows.Forms.ComboBox();
            this.ConectarPuerto1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Slider = new Bunifu.Framework.UI.BunifuSlider();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Right)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Up)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConectarPuerto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Transparent;
            this.Right.Image = ((System.Drawing.Image)(resources.GetObject("Right.Image")));
            this.Right.ImageActive = null;
            this.Right.Location = new System.Drawing.Point(511, 180);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(87, 80);
            this.Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Right.TabIndex = 0;
            this.Right.TabStop = false;
            this.Right.Zoom = 10;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.64455F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.35545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuImageButton6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Down, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Left, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Right, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Up, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bunifuImageButton2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bunifuImageButton5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bunifuImageButton4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bunifuImageButton3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Slider, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.85635F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.14365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 547);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(408, 180);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(86, 80);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 3;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            // 
            // Down
            // 
            this.Down.BackColor = System.Drawing.Color.Transparent;
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.ImageActive = null;
            this.Down.Location = new System.Drawing.Point(408, 275);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(86, 80);
            this.Down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Down.TabIndex = 3;
            this.Down.TabStop = false;
            this.Down.Zoom = 10;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Transparent;
            this.Left.Image = ((System.Drawing.Image)(resources.GetObject("Left.Image")));
            this.Left.ImageActive = null;
            this.Left.Location = new System.Drawing.Point(306, 180);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(87, 80);
            this.Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Left.TabIndex = 1;
            this.Left.TabStop = false;
            this.Left.Zoom = 10;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.Color.Transparent;
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.ImageActive = null;
            this.Up.Location = new System.Drawing.Point(408, 84);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(86, 80);
            this.Up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Up.TabIndex = 2;
            this.Up.TabStop = false;
            this.Up.Zoom = 10;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.65693F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.34306F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Controls.Add(this.Recibido, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bunifuImageButton1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(613, 430);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 107);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // Recibido
            // 
            this.Recibido.Location = new System.Drawing.Point(153, 10);
            this.Recibido.Margin = new System.Windows.Forms.Padding(70, 10, 3, 3);
            this.Recibido.Name = "Recibido";
            this.Recibido.Size = new System.Drawing.Size(117, 20);
            this.Recibido.TabIndex = 7;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(158, 38);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(75, 1, 1, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(93, 68);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.64516F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.35484F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel3.Controls.Add(this.comBox_Puertos, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ConectarPuerto1, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 430);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.49123F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.50877F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(297, 114);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // comBox_Puertos
            // 
            this.comBox_Puertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Puertos.FormattingEnabled = true;
            this.comBox_Puertos.Location = new System.Drawing.Point(28, 12);
            this.comBox_Puertos.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.comBox_Puertos.Name = "comBox_Puertos";
            this.comBox_Puertos.Size = new System.Drawing.Size(92, 26);
            this.comBox_Puertos.TabIndex = 2;
            // 
            // ConectarPuerto1
            // 
            this.ConectarPuerto1.BackColor = System.Drawing.Color.Transparent;
            this.ConectarPuerto1.Image = ((System.Drawing.Image)(resources.GetObject("ConectarPuerto1.Image")));
            this.ConectarPuerto1.ImageActive = null;
            this.ConectarPuerto1.Location = new System.Drawing.Point(45, 54);
            this.ConectarPuerto1.Margin = new System.Windows.Forms.Padding(20, 1, 1, 1);
            this.ConectarPuerto1.Name = "ConectarPuerto1";
            this.ConectarPuerto1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ConectarPuerto1.Size = new System.Drawing.Size(66, 54);
            this.ConectarPuerto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConectarPuerto1.TabIndex = 0;
            this.ConectarPuerto1.TabStop = false;
            this.ConectarPuerto1.Zoom = 10;
            this.ConectarPuerto1.Click += new System.EventHandler(this.ConectarPuerto1_Click_1);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(306, 84);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(86, 80);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(511, 84);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(86, 80);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 9;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(306, 275);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(86, 80);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 8;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(511, 275);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(86, 80);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 7;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.Color.Transparent;
            this.Slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Slider.BorderRadius = 0;
            this.Slider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(113)))), ((int)(((byte)(198)))));
            this.Slider.Location = new System.Drawing.Point(670, 25);
            this.Slider.Margin = new System.Windows.Forms.Padding(60, 25, 3, 3);
            this.Slider.MaximumValue = 100;
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(186, 30);
            this.Slider.TabIndex = 2;
            this.Slider.Value = 0;
            this.Slider.ValueChanged += new System.EventHandler(this.Slider_ValueChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(921, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "4x4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Right)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Up)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConectarPuerto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton Right;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuImageButton Down;
        private Bunifu.Framework.UI.BunifuImageButton Left;
        private Bunifu.Framework.UI.BunifuImageButton Up;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuImageButton ConectarPuerto1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comBox_Puertos;
        private System.Windows.Forms.TextBox Recibido;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuSlider Slider;
    }
}

