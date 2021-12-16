
namespace JogoDaVelha
{
    partial class DecidirVez
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
            this.label1 = new System.Windows.Forms.Label();
            this.jog1 = new System.Windows.Forms.Label();
            this.jog2 = new System.Windows.Forms.Label();
            this.jogar_dados = new System.Windows.Forms.Button();
            this.dado2 = new System.Windows.Forms.PictureBox();
            this.dado1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sortear para ver quem jogará primeiro";
            // 
            // jog1
            // 
            this.jog1.AutoSize = true;
            this.jog1.BackColor = System.Drawing.Color.MistyRose;
            this.jog1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jog1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.jog1.Location = new System.Drawing.Point(47, 189);
            this.jog1.Name = "jog1";
            this.jog1.Size = new System.Drawing.Size(52, 21);
            this.jog1.TabIndex = 3;
            this.jog1.Text = "label2";
            // 
            // jog2
            // 
            this.jog2.AutoSize = true;
            this.jog2.BackColor = System.Drawing.Color.MistyRose;
            this.jog2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jog2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.jog2.Location = new System.Drawing.Point(257, 189);
            this.jog2.Name = "jog2";
            this.jog2.Size = new System.Drawing.Size(52, 21);
            this.jog2.TabIndex = 4;
            this.jog2.Text = "label3";
            // 
            // jogar_dados
            // 
            this.jogar_dados.BackColor = System.Drawing.Color.SaddleBrown;
            this.jogar_dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jogar_dados.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogar_dados.ForeColor = System.Drawing.Color.White;
            this.jogar_dados.Location = new System.Drawing.Point(153, 239);
            this.jogar_dados.Name = "jogar_dados";
            this.jogar_dados.Size = new System.Drawing.Size(133, 37);
            this.jogar_dados.TabIndex = 5;
            this.jogar_dados.Text = "Jogar os dados";
            this.jogar_dados.UseVisualStyleBackColor = false;
            this.jogar_dados.Click += new System.EventHandler(this.jogar_dados_Click);
            // 
            // dado2
            // 
            this.dado2.Image = global::JogoDaVelha.Properties.Resources._0;
            this.dado2.Location = new System.Drawing.Point(260, 68);
            this.dado2.Name = "dado2";
            this.dado2.Size = new System.Drawing.Size(119, 111);
            this.dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dado2.TabIndex = 2;
            this.dado2.TabStop = false;
            // 
            // dado1
            // 
            this.dado1.Image = global::JogoDaVelha.Properties.Resources._0;
            this.dado1.Location = new System.Drawing.Point(50, 68);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(119, 111);
            this.dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dado1.TabIndex = 1;
            this.dado1.TabStop = false;
            // 
            // DecidirVez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaVelha.Properties.Resources.D_NQ_NP_719702_MLB26655206078_012018_O;
            this.ClientSize = new System.Drawing.Size(435, 312);
            this.Controls.Add(this.jogar_dados);
            this.Controls.Add(this.jog2);
            this.Controls.Add(this.jog1);
            this.Controls.Add(this.dado2);
            this.Controls.Add(this.dado1);
            this.Controls.Add(this.label1);
            this.Name = "DecidirVez";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecidirVez";
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dado1;
        private System.Windows.Forms.PictureBox dado2;
        private System.Windows.Forms.Label jog1;
        private System.Windows.Forms.Label jog2;
        private System.Windows.Forms.Button jogar_dados;
    }
}