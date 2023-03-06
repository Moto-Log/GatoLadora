
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_n1 = new System.Windows.Forms.Label();
            this.label_n2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.result_1 = new System.Windows.Forms.Label();
            this.numbox1 = new System.Windows.Forms.TextBox();
            this.numbox2 = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_n1
            // 
            this.label_n1.AutoSize = true;
            this.label_n1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_n1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_n1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_n1.Location = new System.Drawing.Point(45, 47);
            this.label_n1.Name = "label_n1";
            this.label_n1.Size = new System.Drawing.Size(67, 22);
            this.label_n1.TabIndex = 0;
            this.label_n1.Text = "Num.1";
            this.label_n1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_n2
            // 
            this.label_n2.AutoSize = true;
            this.label_n2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_n2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_n2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_n2.Location = new System.Drawing.Point(160, 47);
            this.label_n2.Name = "label_n2";
            this.label_n2.Size = new System.Drawing.Size(67, 22);
            this.label_n2.TabIndex = 1;
            this.label_n2.Text = "Num.2";
            this.label_n2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.result.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.result.Location = new System.Drawing.Point(89, 145);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 2;
            this.result.Text = "Resultado";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result_1
            // 
            this.result_1.AutoSize = true;
            this.result_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.result_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.result_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.result_1.Location = new System.Drawing.Point(128, 179);
            this.result_1.Name = "result_1";
            this.result_1.Size = new System.Drawing.Size(0, 22);
            this.result_1.TabIndex = 3;
            this.result_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result_1.Visible = false;
            // 
            // numbox1
            // 
            this.numbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.numbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.numbox1.Location = new System.Drawing.Point(49, 73);
            this.numbox1.Name = "numbox1";
            this.numbox1.Size = new System.Drawing.Size(63, 20);
            this.numbox1.TabIndex = 4;
            this.numbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numbox1.TextChanged += new System.EventHandler(this.numbox1_TextChanged);
            this.numbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbox1_KeyPress);
            // 
            // numbox2
            // 
            this.numbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.numbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.numbox2.Location = new System.Drawing.Point(164, 73);
            this.numbox2.Name = "numbox2";
            this.numbox2.Size = new System.Drawing.Size(63, 20);
            this.numbox2.TabIndex = 5;
            this.numbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button.Location = new System.Drawing.Point(104, 108);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 6;
            this.button.Text = "Calcular";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-",
            "/",
            "+",
            "x"});
            this.comboBox1.Location = new System.Drawing.Point(119, 70);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(39, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 7;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Calculadora.Properties.Resources._53a467f5cb78dd19cda32f4d37bb846e;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.result_1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.numbox2);
            this.Controls.Add(this.numbox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label_n2);
            this.Controls.Add(this.label_n1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_n1;
        private System.Windows.Forms.Label label_n2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label result_1;
        private System.Windows.Forms.TextBox numbox1;
        private System.Windows.Forms.TextBox numbox2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

