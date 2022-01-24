namespace smple_face_recognition_app
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.txtPersonalName = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnspech = new System.Windows.Forms.Button();
            this.btnserver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.BackgroundImage = global::smple_face_recognition_app.Properties.Resources.pexels_harsch_shivam_2007647;
            this.picCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCapture.Location = new System.Drawing.Point(334, 2);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(521, 583);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            this.picCapture.Click += new System.EventHandler(this.picCapture_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCapture.Location = new System.Drawing.Point(861, 24);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(170, 23);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "1.Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDetectFaces.Location = new System.Drawing.Point(861, 77);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(170, 23);
            this.btnDetectFaces.TabIndex = 2;
            this.btnDetectFaces.Text = "2.Detect Faces";
            this.btnDetectFaces.UseVisualStyleBackColor = false;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // txtPersonalName
            // 
            this.txtPersonalName.Location = new System.Drawing.Point(861, 301);
            this.txtPersonalName.Name = "txtPersonalName";
            this.txtPersonalName.Size = new System.Drawing.Size(170, 20);
            this.txtPersonalName.TabIndex = 3;
            this.txtPersonalName.TextChanged += new System.EventHandler(this.txtPersonalName_TextChanged);
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTrain.Location = new System.Drawing.Point(861, 327);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(170, 23);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "4.Train Images";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecognize.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnRecognize.Image = global::smple_face_recognition_app.Properties.Resources._1629357556089;
            this.btnRecognize.Location = new System.Drawing.Point(0, 2);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(327, 126);
            this.btnRecognize.TabIndex = 6;
            this.btnRecognize.Text = "control motor";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // picDetected
            // 
            this.picDetected.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picDetected.Location = new System.Drawing.Point(861, 135);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(170, 115);
            this.picDetected.TabIndex = 7;
            this.picDetected.TabStop = false;
            this.picDetected.Click += new System.EventHandler(this.picDetected_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddPerson.Location = new System.Drawing.Point(861, 106);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(170, 23);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.Text = "3.AddPerson";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(861, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(999, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 192);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(861, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 192);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnspech
            // 
            this.btnspech.BackgroundImage = global::smple_face_recognition_app.Properties.Resources.picography_robot_white_artificial_intelligence_alex_knight_small;
            this.btnspech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnspech.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspech.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnspech.Location = new System.Drawing.Point(0, 135);
            this.btnspech.Margin = new System.Windows.Forms.Padding(4);
            this.btnspech.Name = "btnspech";
            this.btnspech.Size = new System.Drawing.Size(327, 186);
            this.btnspech.TabIndex = 12;
            this.btnspech.Text = "speech recognition ";
            this.btnspech.UseVisualStyleBackColor = true;
            this.btnspech.Click += new System.EventHandler(this.btnspech_Click);
            // 
            // btnserver
            // 
            this.btnserver.BackgroundImage = global::smple_face_recognition_app.Properties.Resources.charles_deluvio_jtmwD4i4v1U_unsplash;
            this.btnserver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnserver.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnserver.Location = new System.Drawing.Point(0, 329);
            this.btnserver.Margin = new System.Windows.Forms.Padding(4);
            this.btnserver.Name = "btnserver";
            this.btnserver.Size = new System.Drawing.Size(327, 188);
            this.btnserver.TabIndex = 13;
            this.btnserver.Text = "send command to server";
            this.btnserver.UseVisualStyleBackColor = true;
            this.btnserver.Click += new System.EventHandler(this.btnserver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::smple_face_recognition_app.Properties.Resources.pexels_pixabay_158826;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1127, 597);
            this.Controls.Add(this.btnserver);
            this.Controls.Add(this.btnspech);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.txtPersonalName);
            this.Controls.Add(this.btnDetectFaces);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picCapture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDetectFaces;
        private System.Windows.Forms.TextBox txtPersonalName;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.PictureBox picDetected;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnspech;
        private System.Windows.Forms.Button btnserver;
    }
}

