namespace michaelD {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNaissance = new System.Windows.Forms.TextBox();
            this.butAffichInfos = new System.Windows.Forms.Button();
            this.lectureDepuisStruct = new System.Windows.Forms.CheckBox();
            this.butCollectInfos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(224, 68);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "prenom";
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(224, 123);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(100, 20);
            this.textPrenom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "date de naissance : jj/mm/aaaa";
            // 
            // textNaissance
            // 
            this.textNaissance.Location = new System.Drawing.Point(224, 196);
            this.textNaissance.Name = "textNaissance";
            this.textNaissance.Size = new System.Drawing.Size(100, 20);
            this.textNaissance.TabIndex = 4;
            // 
            // butAffichInfos
            // 
            this.butAffichInfos.Enabled = false;
            this.butAffichInfos.Location = new System.Drawing.Point(124, 354);
            this.butAffichInfos.Name = "butAffichInfos";
            this.butAffichInfos.Size = new System.Drawing.Size(110, 23);
            this.butAffichInfos.TabIndex = 6;
            this.butAffichInfos.Text = "Afficher les infos";
            this.butAffichInfos.UseVisualStyleBackColor = true;
            this.butAffichInfos.Click += new System.EventHandler(this.AffichageInfos);
            // 
            // lectureDepuisStruct
            // 
            this.lectureDepuisStruct.AutoSize = true;
            this.lectureDepuisStruct.Location = new System.Drawing.Point(428, 64);
            this.lectureDepuisStruct.Name = "lectureDepuisStruct";
            this.lectureDepuisStruct.Size = new System.Drawing.Size(237, 17);
            this.lectureDepuisStruct.TabIndex = 7;
            this.lectureDepuisStruct.Text = "lecture depuis structure (sinon depuis classe)";
            this.lectureDepuisStruct.UseVisualStyleBackColor = true;
            // 
            // butCollectInfos
            // 
            this.butCollectInfos.Location = new System.Drawing.Point(124, 313);
            this.butCollectInfos.Name = "butCollectInfos";
            this.butCollectInfos.Size = new System.Drawing.Size(113, 23);
            this.butCollectInfos.TabIndex = 8;
            this.butCollectInfos.Text = "Collecter les infos";
            this.butCollectInfos.UseVisualStyleBackColor = true;
            this.butCollectInfos.Click += new System.EventHandler(this.CollecteInfos);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butCollectInfos);
            this.Controls.Add(this.lectureDepuisStruct);
            this.Controls.Add(this.butAffichInfos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNaissance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNaissance;
        private System.Windows.Forms.Button butAffichInfos;
        private System.Windows.Forms.CheckBox lectureDepuisStruct;
        private System.Windows.Forms.Button butCollectInfos;
    }
}

