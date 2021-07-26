namespace Library_manager
{
    partial class edit
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
            this.cmd_clean = new System.Windows.Forms.Button();
            this.cmd_add = new System.Windows.Forms.Button();
            this.cmd_load = new System.Windows.Forms.Button();
            this.cmd_decr = new System.Windows.Forms.Button();
            this.cmd_incr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_editora = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.img_capa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_capa)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_clean
            // 
            this.cmd_clean.Location = new System.Drawing.Point(220, 178);
            this.cmd_clean.Name = "cmd_clean";
            this.cmd_clean.Size = new System.Drawing.Size(84, 23);
            this.cmd_clean.TabIndex = 35;
            this.cmd_clean.Text = "Limpar";
            this.cmd_clean.UseVisualStyleBackColor = true;
            this.cmd_clean.Click += new System.EventHandler(this.cmd_clean_Click);
            // 
            // cmd_add
            // 
            this.cmd_add.Location = new System.Drawing.Point(133, 178);
            this.cmd_add.Name = "cmd_add";
            this.cmd_add.Size = new System.Drawing.Size(84, 23);
            this.cmd_add.TabIndex = 34;
            this.cmd_add.Text = "Editar";
            this.cmd_add.UseVisualStyleBackColor = true;
            this.cmd_add.Click += new System.EventHandler(this.cmd_add_Click);
            // 
            // cmd_load
            // 
            this.cmd_load.Location = new System.Drawing.Point(310, 140);
            this.cmd_load.Name = "cmd_load";
            this.cmd_load.Size = new System.Drawing.Size(136, 23);
            this.cmd_load.TabIndex = 33;
            this.cmd_load.Text = "Procurar...";
            this.cmd_load.UseVisualStyleBackColor = true;
            this.cmd_load.Click += new System.EventHandler(this.cmd_load_Click);
            // 
            // cmd_decr
            // 
            this.cmd_decr.Location = new System.Drawing.Point(264, 140);
            this.cmd_decr.Name = "cmd_decr";
            this.cmd_decr.Size = new System.Drawing.Size(40, 23);
            this.cmd_decr.TabIndex = 32;
            this.cmd_decr.Text = "-";
            this.cmd_decr.UseVisualStyleBackColor = true;
            this.cmd_decr.Click += new System.EventHandler(this.cmd_decr_Click);
            // 
            // cmd_incr
            // 
            this.cmd_incr.Location = new System.Drawing.Point(221, 140);
            this.cmd_incr.Name = "cmd_incr";
            this.cmd_incr.Size = new System.Drawing.Size(40, 23);
            this.cmd_incr.TabIndex = 31;
            this.cmd_incr.Text = "+";
            this.cmd_incr.UseVisualStyleBackColor = true;
            this.cmd_incr.Click += new System.EventHandler(this.cmd_incr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Editora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(83, 142);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(134, 20);
            this.txt_quant.TabIndex = 24;
            this.txt_quant.Text = "1";
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(62, 116);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(242, 20);
            this.txt_ano.TabIndex = 23;
            // 
            // txt_editora
            // 
            this.txt_editora.Location = new System.Drawing.Point(62, 90);
            this.txt_editora.Name = "txt_editora";
            this.txt_editora.Size = new System.Drawing.Size(242, 20);
            this.txt_editora.TabIndex = 22;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(62, 64);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(242, 20);
            this.txt_autor.TabIndex = 21;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(62, 38);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(242, 20);
            this.txt_nome.TabIndex = 20;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(62, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(242, 20);
            this.txt_id.TabIndex = 19;
            // 
            // img_capa
            // 
            this.img_capa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.img_capa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_capa.Location = new System.Drawing.Point(310, 12);
            this.img_capa.Name = "img_capa";
            this.img_capa.Size = new System.Drawing.Size(136, 124);
            this.img_capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_capa.TabIndex = 18;
            this.img_capa.TabStop = false;
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 213);
            this.Controls.Add(this.cmd_clean);
            this.Controls.Add(this.cmd_add);
            this.Controls.Add(this.cmd_load);
            this.Controls.Add(this.cmd_decr);
            this.Controls.Add(this.cmd_incr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quant);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_editora);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.img_capa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Editar livro";
            this.Load += new System.EventHandler(this.edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_capa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_clean;
        private System.Windows.Forms.Button cmd_add;
        private System.Windows.Forms.Button cmd_load;
        private System.Windows.Forms.Button cmd_decr;
        private System.Windows.Forms.Button cmd_incr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_editora;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.PictureBox img_capa;

    }
}