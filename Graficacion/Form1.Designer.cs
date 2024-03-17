
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtvalorYc = new System.Windows.Forms.TextBox();
            this.txtvalorXc = new System.Windows.Forms.TextBox();
            this.txtcaso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.dataGridViewResultados3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewResultados2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblvalorx = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txta2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.txta1 = new System.Windows.Forms.TextBox();
            this.lbla = new System.Windows.Forms.Label();
            this.chartResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados2)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(22, 100);
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
            this.label2.Location = new System.Drawing.Point(22, 53);
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
            this.label3.Location = new System.Drawing.Point(223, 100);
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
            this.label4.Location = new System.Drawing.Point(225, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ValorY1=";
            // 
            // txtvalorXa
            // 
            this.txtvalorXa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorXa.Location = new System.Drawing.Point(103, 49);
            this.txtvalorXa.Multiline = true;
            this.txtvalorXa.Name = "txtvalorXa";
            this.txtvalorXa.Size = new System.Drawing.Size(87, 40);
            this.txtvalorXa.TabIndex = 6;
            this.txtvalorXa.TextChanged += new System.EventHandler(this.txtvalorXa_TextChanged);
            // 
            // txtvalorYa
            // 
            this.txtvalorYa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorYa.Location = new System.Drawing.Point(304, 49);
            this.txtvalorYa.Multiline = true;
            this.txtvalorYa.Name = "txtvalorYa";
            this.txtvalorYa.Size = new System.Drawing.Size(87, 40);
            this.txtvalorYa.TabIndex = 7;
            this.txtvalorYa.TextChanged += new System.EventHandler(this.txtvalorYa_TextChanged);
            // 
            // txtvalorXb
            // 
            this.txtvalorXb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorXb.Location = new System.Drawing.Point(103, 97);
            this.txtvalorXb.Multiline = true;
            this.txtvalorXb.Name = "txtvalorXb";
            this.txtvalorXb.Size = new System.Drawing.Size(87, 40);
            this.txtvalorXb.TabIndex = 8;
            // 
            // txtvalorYb
            // 
            this.txtvalorYb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorYb.Location = new System.Drawing.Point(302, 97);
            this.txtvalorYb.Multiline = true;
            this.txtvalorYb.Name = "txtvalorYb";
            this.txtvalorYb.Size = new System.Drawing.Size(87, 40);
            this.txtvalorYb.TabIndex = 9;
            this.txtvalorYb.TextChanged += new System.EventHandler(this.txtvalorYb_TextChanged);
            // 
            // txtpendiente
            // 
            this.txtpendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpendiente.Location = new System.Drawing.Point(509, 27);
            this.txtpendiente.Multiline = true;
            this.txtpendiente.Name = "txtpendiente";
            this.txtpendiente.Size = new System.Drawing.Size(116, 62);
            this.txtpendiente.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "M=";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(663, 40);
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
            this.btnlimpiar.Location = new System.Drawing.Point(663, 148);
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
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.txtvalorYc);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.txtvalorXc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbltitulo);
            this.groupBox1.Controls.Add(this.txtvalorYb);
            this.groupBox1.Controls.Add(this.txtvalorYa);
            this.groupBox1.Controls.Add(this.txtpendiente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcaso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtvalorXb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtvalorXa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(4, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 209);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(223, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "ValorY3=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "ValorX3=";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtvalorYc
            // 
            this.txtvalorYc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorYc.Location = new System.Drawing.Point(302, 148);
            this.txtvalorYc.Multiline = true;
            this.txtvalorYc.Name = "txtvalorYc";
            this.txtvalorYc.Size = new System.Drawing.Size(87, 40);
            this.txtvalorYc.TabIndex = 11;
            // 
            // txtvalorXc
            // 
            this.txtvalorXc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorXc.Location = new System.Drawing.Point(103, 148);
            this.txtvalorXc.Multiline = true;
            this.txtvalorXc.Name = "txtvalorXc";
            this.txtvalorXc.Size = new System.Drawing.Size(87, 40);
            this.txtvalorXc.TabIndex = 10;
            // 
            // txtcaso
            // 
            this.txtcaso.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaso.Location = new System.Drawing.Point(509, 123);
            this.txtcaso.Multiline = true;
            this.txtcaso.Name = "txtcaso";
            this.txtcaso.Size = new System.Drawing.Size(116, 65);
            this.txtcaso.TabIndex = 6;
            this.txtcaso.TextChanged += new System.EventHandler(this.txtcaso_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 49);
            this.label7.TabIndex = 2;
            this.label7.Text = "Obtenemos coordenadas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.txtb3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtc1);
            this.groupBox2.Controls.Add(this.dataGridViewResultados3);
            this.groupBox2.Controls.Add(this.dataGridViewResultados2);
            this.groupBox2.Controls.Add(this.dataGridViewResultados);
            this.groupBox2.Controls.Add(this.txtb2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblvalorx);
            this.groupBox2.Controls.Add(this.txtb1);
            this.groupBox2.Controls.Add(this.txta2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblb);
            this.groupBox2.Controls.Add(this.txta1);
            this.groupBox2.Controls.Add(this.lbla);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 412);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txtb3
            // 
            this.txtb3.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Italic);
            this.txtb3.Location = new System.Drawing.Point(659, 86);
            this.txtb3.Multiline = true;
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(79, 31);
            this.txtb3.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(650, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Valor Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(550, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Valor X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(582, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "C)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(411, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Valor Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(311, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Valor X";
            // 
            // txtc1
            // 
            this.txtc1.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.txtc1.Location = new System.Drawing.Point(557, 86);
            this.txtc1.Multiline = true;
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(87, 31);
            this.txtc1.TabIndex = 12;
            // 
            // dataGridViewResultados3
            // 
            this.dataGridViewResultados3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewResultados3.Location = new System.Drawing.Point(509, 140);
            this.dataGridViewResultados3.Name = "dataGridViewResultados3";
            this.dataGridViewResultados3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultados3.Size = new System.Drawing.Size(242, 267);
            this.dataGridViewResultados3.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ValorX";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ValorY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewResultados2
            // 
            this.dataGridViewResultados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewResultados2.Location = new System.Drawing.Point(260, 140);
            this.dataGridViewResultados2.Name = "dataGridViewResultados2";
            this.dataGridViewResultados2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultados2.Size = new System.Drawing.Size(242, 267);
            this.dataGridViewResultados2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ValorX";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ValorY";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Valory});
            this.dataGridViewResultados.Location = new System.Drawing.Point(12, 140);
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
            // txtb2
            // 
            this.txtb2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb2.Location = new System.Drawing.Point(415, 86);
            this.txtb2.Multiline = true;
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(79, 31);
            this.txtb2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Valor Y";
            // 
            // lblvalorx
            // 
            this.lblvalorx.AutoSize = true;
            this.lblvalorx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorx.Location = new System.Drawing.Point(55, 117);
            this.lblvalorx.Name = "lblvalorx";
            this.lblvalorx.Size = new System.Drawing.Size(61, 20);
            this.lblvalorx.TabIndex = 3;
            this.lblvalorx.Text = "Valor X";
            // 
            // txtb1
            // 
            this.txtb1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb1.Location = new System.Drawing.Point(320, 85);
            this.txtb1.Multiline = true;
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(86, 31);
            this.txtb1.TabIndex = 11;
            // 
            // txta2
            // 
            this.txta2.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Italic);
            this.txta2.Location = new System.Drawing.Point(165, 84);
            this.txta2.Multiline = true;
            this.txta2.Name = "txta2";
            this.txta2.Size = new System.Drawing.Size(79, 31);
            this.txta2.TabIndex = 10;
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
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(347, 58);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(25, 20);
            this.lblb.TabIndex = 8;
            this.lblb.Text = "B)";
            // 
            // txta1
            // 
            this.txta1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta1.Location = new System.Drawing.Point(63, 84);
            this.txta1.Multiline = true;
            this.txta1.Name = "txta1";
            this.txta1.Size = new System.Drawing.Size(86, 31);
            this.txta1.TabIndex = 9;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(88, 51);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(25, 20);
            this.lbla.TabIndex = 7;
            this.lbla.Text = "A)";
            // 
            // chartResultados
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResultados.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResultados.Legends.Add(legend2);
            this.chartResultados.Location = new System.Drawing.Point(769, 9);
            this.chartResultados.Name = "chartResultados";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResultados.Series.Add(series2);
            this.chartResultados.Size = new System.Drawing.Size(589, 622);
            this.chartResultados.TabIndex = 16;
            this.chartResultados.Text = "chart1";
            this.chartResultados.Click += new System.EventHandler(this.chartResultados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 641);
            this.Controls.Add(this.chartResultados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewResultados3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridViewResultados2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

