namespace ScheduleUI
{
    partial class ScheduleForm
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
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageTemplateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(ScheduleModel.Schedule);
            // 
            // messageTemplateBindingSource
            // 
            this.messageTemplateBindingSource.DataSource = typeof(ScheduleModel.MessageTemplate);
            // 
            // scheduleItemBindingSource
            // 
            this.scheduleItemBindingSource.DataSource = typeof(ScheduleModel.ScheduleItem);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 456);
            this.Name = "ScheduleForm";
            this.Text = "Schedule Form";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageTemplateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.BindingSource messageTemplateBindingSource;
        private System.Windows.Forms.BindingSource scheduleItemBindingSource;
    }
}