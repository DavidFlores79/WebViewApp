﻿namespace WebViewApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            Ir = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 54);
            webView21.Name = "webView21";
            webView21.Size = new Size(776, 384);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // Ir
            // 
            Ir.Location = new Point(278, 18);
            Ir.Name = "Ir";
            Ir.Size = new Size(75, 23);
            Ir.TabIndex = 1;
            Ir.Text = "Ir";
            Ir.UseVisualStyleBackColor = true;
            Ir.Click += Ir_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Ir);
            Controls.Add(webView21);
            Name = "Form1";
            Text = "Web Viewer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button Ir;
        private TextBox textBox1;
    }
}
