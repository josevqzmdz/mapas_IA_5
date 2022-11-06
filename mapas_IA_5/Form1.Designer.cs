namespace mapas_IA_5
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.inicioLB = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.destinoLB = new System.Windows.Forms.ListBox();
            this.resultadosTXT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(819, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(31, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // inicioLB
            // 
            this.inicioLB.FormattingEnabled = true;
            this.inicioLB.ItemHeight = 16;
            this.inicioLB.Items.AddRange(new object[] {
            "aquila,",
            "maruata,",
            "lazaro cardenas,",
            "nueva italia,",
            "apatzingan,",
            "tepalcatepec,",
            "los reyes,",
            "uruapan,",
            "sahuayo,",
            "zamora,",
            "zacapu,",
            "patzcuaro,",
            "morelia, ",
            "cd. hidalgo"});
            this.inicioLB.Location = new System.Drawing.Point(895, 52);
            this.inicioLB.Name = "inicioLB";
            this.inicioLB.Size = new System.Drawing.Size(163, 36);
            this.inicioLB.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(819, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // destinoLB
            // 
            this.destinoLB.FormattingEnabled = true;
            this.destinoLB.ItemHeight = 16;
            this.destinoLB.Items.AddRange(new object[] {
            "aquila,",
            "maruata,",
            "lazaro cardenas,",
            "nueva italia,",
            "apatzingan,",
            "tepalcatepec,",
            "los reyes,",
            "uruapan,",
            "sahuayo,",
            "zamora,",
            "zacapu,",
            "patzcuaro,",
            "morelia, ",
            "cd. hidalgo"});
            this.destinoLB.Location = new System.Drawing.Point(895, 94);
            this.destinoLB.Name = "destinoLB";
            this.destinoLB.Size = new System.Drawing.Size(163, 36);
            this.destinoLB.TabIndex = 9;
            // 
            // resultadosTXT
            // 
            this.resultadosTXT.Location = new System.Drawing.Point(819, 327);
            this.resultadosTXT.Multiline = true;
            this.resultadosTXT.Name = "resultadosTXT";
            this.resultadosTXT.Size = new System.Drawing.Size(239, 261);
            this.resultadosTXT.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 671);
            this.Controls.Add(this.resultadosTXT);
            this.Controls.Add(this.destinoLB);
            this.Controls.Add(this.inicioLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox inicioLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox destinoLB;
        private System.Windows.Forms.TextBox resultadosTXT;
    }
}

