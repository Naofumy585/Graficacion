
namespace Graficacion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalorXa = new System.Windows.Forms.TextBox();
            this.txtvalorYa = new System.Windows.Forms.TextBox();
            this.txtvalorXb = new System.Windows.Forms.TextBox();
            this.txtvalorYb = new System.Windows.Forms.TextBox();
            this.txtpendiente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtvalorYc = new System.Windows.Forms.TextBox();
            this.txtvalorXc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txta2 = new System.Windows.Forms.TextBox();
            this.txta1 = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.txtcaso = new System.Windows.Forms.TextBox();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblvalorx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(54, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(280, 25);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Ingresa los siguientes datos";
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ValorX2=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ValorX1=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ValorY2=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ValorY1=";
            // 
            // txtvalorXa
            // 
            this.txtvalorXa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorXa.Location = new System.Drawing.Point(103, 73);
            this.txtvalorXa.Multiline = true;
            this.txtvalorXa.Name = "txtvalorXa";
            this.txtvalorXa.Size = new System.Drawing.Size(87, 40);
            this.txtvalorXa.TabIndex = 6;
            // 
            // txtvalorYa
            // 
            this.txtvalorYa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorYa.Location = new System.Drawing.Point(302, 74);
            this.txtvalorYa.Multiline = true;
            this.txtvalorYa.Name = "txtvalorYa";
            this.txtvalorYa.Size = new System.Drawing.Size(87, 40);
            this.txtvalorYa.TabIndex = 7;
            // 
            // txtvalorXb
            // 
            this.txtvalorXb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorXb.Location = new System.Drawing.Point(103, 27);
            this.txtvalorXb.Multiline = true;
            this.txtvalorXb.Name = "txtvalorXb";
            this.txtvalorXb.Size = new System.Drawing.Size(87, 40);
            this.txtvalorXb.TabIndex = 8;
            // 
            // txtvalorYb
            // 
            this.txtvalorYb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorYb.Location = new System.Drawing.Point(302, 28);
            this.txtvalorYb.Multiline = true;
            this.txtvalorYb.Name = "txtvalorYb";
            this.txtvalorYb.Size = new System.Drawing.Size(87, 40);
            this.txtvalorYb.TabIndex = 9;
            this.txtvalorYb.TextChanged += new System.EventHandler(this.txtvalorYb_TextChanged);
            // 
            // txtpendiente
            // 
            this.txtpendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpendiente.Location = new System.Drawing.Point(85, 169);
            this.txtpendiente.Multiline = true;
            this.txtpendiente.Name = "txtpendiente";
            this.txtpendiente.Size = new System.Drawing.Size(116, 69);
            this.txtpendiente.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "M=";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(229, 187);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 33);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(314, 187);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 33);
            this.btnlimpiar.TabIndex = 13;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtvalorYc);
            this.groupBox1.Controls.Add(this.txtvalorXc);
            this.groupBox1.Controls.Add(this.lbltitulo);
            this.groupBox1.Controls.Add(this.txtvalorYb);
            this.groupBox1.Controls.Add(this.txtvalorYa);
            this.groupBox1.Controls.Add(this.txtpendiente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtvalorXb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtvalorXa);
            this.groupBox1.Location = new System.Drawing.Point(4, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 244);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtvalorYc
            // 
            this.txtvalorYc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorYc.Location = new System.Drawing.Point(302, 120);
            this.txtvalorYc.Multiline = true;
            this.txtvalorYc.Name = "txtvalorYc";
            this.txtvalorYc.Size = new System.Drawing.Size(87, 40);
            this.txtvalorYc.TabIndex = 11;
            // 
            // txtvalorXc
            // 
            this.txtvalorXc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorXc.Location = new System.Drawing.Point(103, 119);
            this.txtvalorXc.Multiline = true;
            this.txtvalorXc.Name = "txtvalorXc";
            this.txtvalorXc.Size = new System.Drawing.Size(87, 40);
            this.txtvalorXc.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtc1);
            this.groupBox2.Controls.Add(this.txtb2);
            this.groupBox2.Controls.Add(this.txtb1);
            this.groupBox2.Controls.Add(this.txta2);
            this.groupBox2.Controls.Add(this.txta1);
            this.groupBox2.Controls.Add(this.lblb);
            this.groupBox2.Controls.Add(this.lbla);
            this.groupBox2.Controls.Add(this.txtcaso);
            this.groupBox2.Controls.Add(this.dataGridViewResultados);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblvalorx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 374);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(273, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "C)";
            // 
            // txtc1
            // 
            this.txtc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc1.Location = new System.Drawing.Point(254, 296);
            this.txtc1.Multiline = true;
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(87, 40);
            this.txtc1.TabIndex = 12;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(350, 219);
            this.txtb2.Multiline = true;
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(59, 32);
            this.txtb2.TabIndex = 12;
            // 
            // txtb1
            // 
            this.txtb1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb1.Location = new System.Drawing.Point(248, 217);
            this.txtb1.Multiline = true;
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(86, 32);
            this.txtb1.TabIndex = 11;
            // 
            // txta2
            // 
            this.txta2.Location = new System.Drawing.Point(350, 133);
            this.txta2.Multiline = true;
            this.txta2.Name = "txta2";
            this.txta2.Size = new System.Drawing.Size(59, 32);
            this.txta2.TabIndex = 10;
            // 
            // txta1
            // 
            this.txta1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta1.Location = new System.Drawing.Point(248, 133);
            this.txta1.Multiline = true;
            this.txta1.Name = "txta1";
            this.txta1.Size = new System.Drawing.Size(86, 32);
            this.txta1.TabIndex = 9;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(275, 191);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(25, 20);
            this.lblb.TabIndex = 8;
            this.lblb.Text = "B)";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(273, 101);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(25, 20);
            this.lbla.TabIndex = 7;
            this.lbla.Text = "A)";
            // 
            // txtcaso
            // 
            this.txtcaso.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaso.Location = new System.Drawing.Point(207, 13);
            this.txtcaso.Multiline = true;
            this.txtcaso.Name = "txtcaso";
            this.txtcaso.Size = new System.Drawing.Size(134, 56);
            this.txtcaso.TabIndex = 6;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Valory});
            this.dataGridViewResultados.Location = new System.Drawing.Point(0, 101);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultados.Size = new System.Drawing.Size(242, 267);
            this.dataGridViewResultados.TabIndex = 5;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "ValorX";
            this.Valor.Name = "Valor";
            // 
            // Valory
            // 
            this.Valory.HeaderText = "ValorY";
            this.Valory.Name = "Valory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Valor Y";
            // 
            // lblvalorx
            // 
            this.lblvalorx.AutoSize = true;
            this.lblvalorx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorx.Location = new System.Drawing.Point(8, 68);
            this.lblvalorx.Name = "lblvalorx";
            this.lblvalorx.Size = new System.Drawing.Size(61, 20);
            this.lblvalorx.TabIndex = 3;
            this.lblvalorx.Text = "Valor X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Obtenemos coordenadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 1;
            // 
            // chartResultados
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResultados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResultados.Legends.Add(legend1);
            this.chartResultados.Location = new System.Drawing.Point(454, 12);
            this.chartResultados.Name = "chartResultados";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResultados.Series.Add(series1);
            this.chartResultados.Size = new System.Drawing.Size(607, 643);
            this.chartResultados.TabIndex = 16;
            this.chartResultados.Text = "chart1";
            this.chartResultados.Click += new System.EventHandler(this.chartResultados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 645);
            this.Controls.Add(this.chartResultados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvalorXa;
        private System.Windows.Forms.TextBox txtvalorYa;
        private System.Windows.Forms.TextBox txtvalorXb;
        private System.Windows.Forms.TextBox txtvalorYb;
        private System.Windows.Forms.TextBox txtpendiente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcaso;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblvalorx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txta2;
        private System.Windows.Forms.TextBox txta1;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultados;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtvalorYc;
        private System.Windows.Forms.TextBox txtvalorXc;
        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.Label label9;
    }
}

