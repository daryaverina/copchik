namespace View
{
    partial class ViewMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textControl1 = new WindowsFormsControlLibrary.TextControl();
            this.myControl1 = new WindowsFormsControlLibrary.ListboxControl();
            this.tableControl = new WindowsFormsControlLibrary.TableControl();
            this.ClearList = new System.Windows.Forms.Button();
            this.ButtonAddText = new System.Windows.Forms.Button();
            this.labelNumb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Визуальный компонент выбора";
            // 
            // textControl1
            // 
            this.textControl1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textControl1.Location = new System.Drawing.Point(316, 0);
            this.textControl1.Name = "textControl1";
            this.textControl1.Size = new System.Drawing.Size(294, 269);
            this.textControl1.TabIndex = 7;
          //  this.textControl1.ValueTextBox = null;
            // 
            // myControl1
            // 
            this.myControl1.BackColor = System.Drawing.Color.RosyBrown;
            this.myControl1.Location = new System.Drawing.Point(3, 0);
            this.myControl1.Name = "myControl1";
            this.myControl1.SelectedElement = "";
            this.myControl1.Size = new System.Drawing.Size(307, 472);
            this.myControl1.TabIndex = 5;
            // 
            // tableControl
            // 
            this.tableControl.BackColor = System.Drawing.Color.PapayaWhip;
            this.tableControl.Location = new System.Drawing.Point(616, 0);
            this.tableControl.Name = "tableControl";
            this.tableControl.Size = new System.Drawing.Size(325, 472);
            this.tableControl.TabIndex = 8;
            this.tableControl.Load += new System.EventHandler(this.tableControl_Load);
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(84, 149);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(75, 23);
            this.ClearList.TabIndex = 9;
            this.ClearList.Text = "clearlist";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // ButtonAddText
            // 
            this.ButtonAddText.Location = new System.Drawing.Point(410, 401);
            this.ButtonAddText.Name = "ButtonAddText";
            this.ButtonAddText.Size = new System.Drawing.Size(108, 23);
            this.ButtonAddText.TabIndex = 10;
            this.ButtonAddText.Text = "проверить";
            this.ButtonAddText.UseVisualStyleBackColor = true;
            this.ButtonAddText.Click += new System.EventHandler(this.ButtonAddText_Click);
            // 
            // labelNumb
            // 
            this.labelNumb.AutoSize = true;
            this.labelNumb.Location = new System.Drawing.Point(442, 310);
            this.labelNumb.Name = "labelNumb";
            this.labelNumb.Size = new System.Drawing.Size(0, 16);
            this.labelNumb.TabIndex = 11;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 543);
            this.Controls.Add(this.labelNumb);
            this.Controls.Add(this.ButtonAddText);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.tableControl);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsControlLibrary.ListboxControl myControl1;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary.TextControl textControl1;
        private WindowsFormsControlLibrary.TableControl tableControl;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Button ButtonAddText;
        private System.Windows.Forms.Label labelNumb;
    }
}

