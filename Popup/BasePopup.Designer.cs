namespace Popup
{
    partial class BasePopup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePopup));
            this.pbType = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerFirst = new System.Windows.Forms.Timer(this.components);
            this.timerSecond = new System.Windows.Forms.Timer(this.components);
            this.timerThird = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbType
            // 
            this.pbType.Location = new System.Drawing.Point(12, 8);
            this.pbType.Name = "pbType";
            this.pbType.Size = new System.Drawing.Size(50, 50);
            this.pbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbType.TabIndex = 0;
            this.pbType.TabStop = false;
            // 
            // pbclose
            // 
            this.pbclose.Image = global::Popup.Properties.Resources.close;
            this.pbclose.Location = new System.Drawing.Point(395, 12);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(20, 20);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 1;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.Pbclose_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(68, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(46, 17);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "succes.png");
            this.imageList1.Images.SetKeyName(1, "danger.png");
            this.imageList1.Images.SetKeyName(2, "error.png");
            this.imageList1.Images.SetKeyName(3, "info.png");
            // 
            // timerFirst
            // 
            this.timerFirst.Interval = 10;
            this.timerFirst.Tick += new System.EventHandler(this.TimerFirst_Tick);
            // 
            // timerSecond
            // 
            this.timerSecond.Interval = 10;
            this.timerSecond.Tick += new System.EventHandler(this.TimerSecond_Tick);
            // 
            // timerThird
            // 
            this.timerThird.Interval = 2000;
            this.timerThird.Tick += new System.EventHandler(this.TimerThird_Tick);
            // 
            // BasePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 70);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbclose);
            this.Controls.Add(this.pbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasePopup";
            this.Text = "BasePopup";
            this.Load += new System.EventHandler(this.BasePopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbType;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerFirst;
        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.Timer timerThird;
    }
}