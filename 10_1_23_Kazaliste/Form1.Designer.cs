namespace _10_1_23_Kazaliste
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumTicket = new System.Windows.Forms.Label();
            this.rbtParter = new System.Windows.Forms.RadioButton();
            this.rbtLoza = new System.Windows.Forms.RadioButton();
            this.btnReservation = new System.Windows.Forms.Button();
            this.lblShowReturn = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumTicket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(51, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime:";
            // 
            // lblNumTicket
            // 
            this.lblNumTicket.AutoSize = true;
            this.lblNumTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumTicket.Location = new System.Drawing.Point(17, 72);
            this.lblNumTicket.Name = "lblNumTicket";
            this.lblNumTicket.Size = new System.Drawing.Size(69, 15);
            this.lblNumTicket.TabIndex = 1;
            this.lblNumTicket.Text = "Broj karata:";
            // 
            // rbtParter
            // 
            this.rbtParter.AutoSize = true;
            this.rbtParter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtParter.Location = new System.Drawing.Point(68, 105);
            this.rbtParter.Name = "rbtParter";
            this.rbtParter.Size = new System.Drawing.Size(58, 19);
            this.rbtParter.TabIndex = 2;
            this.rbtParter.TabStop = true;
            this.rbtParter.Text = "Parter";
            this.rbtParter.UseVisualStyleBackColor = true;
            // 
            // rbtLoza
            // 
            this.rbtLoza.AutoSize = true;
            this.rbtLoza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtLoza.Location = new System.Drawing.Point(140, 105);
            this.rbtLoza.Name = "rbtLoza";
            this.rbtLoza.Size = new System.Drawing.Size(52, 19);
            this.rbtLoza.TabIndex = 3;
            this.rbtLoza.TabStop = true;
            this.rbtLoza.Text = "Loža";
            this.rbtLoza.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReservation.Location = new System.Drawing.Point(205, 46);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(75, 39);
            this.btnReservation.TabIndex = 4;
            this.btnReservation.Text = "Rezerviraj";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // lblShowReturn
            // 
            this.lblShowReturn.AutoSize = true;
            this.lblShowReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblShowReturn.Location = new System.Drawing.Point(27, 158);
            this.lblShowReturn.Name = "lblShowReturn";
            this.lblShowReturn.Size = new System.Drawing.Size(0, 15);
            this.lblShowReturn.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(92, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 6;
            // 
            // txtNumTicket
            // 
            this.txtNumTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumTicket.Location = new System.Drawing.Point(92, 69);
            this.txtNumTicket.Name = "txtNumTicket";
            this.txtNumTicket.Size = new System.Drawing.Size(100, 21);
            this.txtNumTicket.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 300);
            this.Controls.Add(this.txtNumTicket);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblShowReturn);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.rbtLoza);
            this.Controls.Add(this.rbtParter);
            this.Controls.Add(this.lblNumTicket);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumTicket;
        private System.Windows.Forms.RadioButton rbtParter;
        private System.Windows.Forms.RadioButton rbtLoza;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Label lblShowReturn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumTicket;
    }
}

