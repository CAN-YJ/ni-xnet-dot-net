namespace NiXnetTestApp
{
    partial class Form2
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
            this.switch1 = new NationalInstruments.UI.WindowsForms.Switch();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).BeginInit();
            this.SuspendLayout();
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(28, 22);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(60, 97);
            this.switch1.TabIndex = 0;
            this.switch1.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switch1_StateChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 311);
            this.Controls.Add(this.switch1);
            this.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.Switch switch1;
    }
}