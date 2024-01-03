
namespace Program2
{
    partial class deliveryCost
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
            this.title = new System.Windows.Forms.Label();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.deliveryTitle = new System.Windows.Forms.Label();
            this.companyATitle = new System.Windows.Forms.Label();
            this.companyBTitle = new System.Windows.Forms.Label();
            this.CompanyCTitle = new System.Windows.Forms.Label();
            this.compAOut = new System.Windows.Forms.Label();
            this.compBOut = new System.Windows.Forms.Label();
            this.compCOut = new System.Windows.Forms.Label();
            this.resultOut = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.peopleInput = new System.Windows.Forms.TextBox();
            this.deliveryInput = new System.Windows.Forms.TextBox();
            this.distanceInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(355, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(63, 20);
            this.title.TabIndex = 0;
            this.title.Text = "Results";
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(190, 101);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(62, 20);
            this.peopleLabel.TabIndex = 1;
            this.peopleLabel.Text = "People:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(190, 151);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(126, 20);
            this.distanceLabel.TabIndex = 2;
            this.distanceLabel.Text = "Distance (Miles):";
            // 
            // deliveryTitle
            // 
            this.deliveryTitle.AutoSize = true;
            this.deliveryTitle.Location = new System.Drawing.Point(190, 191);
            this.deliveryTitle.Name = "deliveryTitle";
            this.deliveryTitle.Size = new System.Drawing.Size(112, 20);
            this.deliveryTitle.TabIndex = 3;
            this.deliveryTitle.Text = "Delivery Days: ";
            // 
            // companyATitle
            // 
            this.companyATitle.AutoSize = true;
            this.companyATitle.Location = new System.Drawing.Point(488, 113);
            this.companyATitle.Name = "companyATitle";
            this.companyATitle.Size = new System.Drawing.Size(132, 20);
            this.companyATitle.TabIndex = 4;
            this.companyATitle.Text = "Company A Cost:";
            // 
            // companyBTitle
            // 
            this.companyBTitle.AutoSize = true;
            this.companyBTitle.Location = new System.Drawing.Point(488, 152);
            this.companyBTitle.Name = "companyBTitle";
            this.companyBTitle.Size = new System.Drawing.Size(132, 20);
            this.companyBTitle.TabIndex = 5;
            this.companyBTitle.Text = "Company B Cost:";
            // 
            // CompanyCTitle
            // 
            this.CompanyCTitle.AutoSize = true;
            this.CompanyCTitle.Location = new System.Drawing.Point(488, 192);
            this.CompanyCTitle.Name = "CompanyCTitle";
            this.CompanyCTitle.Size = new System.Drawing.Size(132, 20);
            this.CompanyCTitle.TabIndex = 6;
            this.CompanyCTitle.Text = "Company C Cost:";
            // 
            // compAOut
            // 
            this.compAOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compAOut.Location = new System.Drawing.Point(631, 112);
            this.compAOut.Name = "compAOut";
            this.compAOut.Size = new System.Drawing.Size(100, 23);
            this.compAOut.TabIndex = 7;
            // 
            // compBOut
            // 
            this.compBOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compBOut.Location = new System.Drawing.Point(631, 148);
            this.compBOut.Name = "compBOut";
            this.compBOut.Size = new System.Drawing.Size(100, 23);
            this.compBOut.TabIndex = 8;
            // 
            // compCOut
            // 
            this.compCOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compCOut.Location = new System.Drawing.Point(631, 191);
            this.compCOut.Name = "compCOut";
            this.compCOut.Size = new System.Drawing.Size(100, 23);
            this.compCOut.TabIndex = 9;
            // 
            // resultOut
            // 
            this.resultOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultOut.Location = new System.Drawing.Point(492, 246);
            this.resultOut.Name = "resultOut";
            this.resultOut.Size = new System.Drawing.Size(240, 23);
            this.resultOut.TabIndex = 10;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(325, 313);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(137, 34);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "Calculate Cost";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // peopleInput
            // 
            this.peopleInput.Location = new System.Drawing.Point(344, 106);
            this.peopleInput.Name = "peopleInput";
            this.peopleInput.Size = new System.Drawing.Size(100, 26);
            this.peopleInput.TabIndex = 12;
            // 
            // deliveryInput
            // 
            this.deliveryInput.Location = new System.Drawing.Point(344, 188);
            this.deliveryInput.Name = "deliveryInput";
            this.deliveryInput.Size = new System.Drawing.Size(100, 26);
            this.deliveryInput.TabIndex = 13;
            // 
            // distanceInput
            // 
            this.distanceInput.Location = new System.Drawing.Point(344, 151);
            this.distanceInput.Name = "distanceInput";
            this.distanceInput.Size = new System.Drawing.Size(100, 26);
            this.distanceInput.TabIndex = 14;
            // 
            // deliveryCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.distanceInput);
            this.Controls.Add(this.deliveryInput);
            this.Controls.Add(this.peopleInput);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.resultOut);
            this.Controls.Add(this.compCOut);
            this.Controls.Add(this.compBOut);
            this.Controls.Add(this.compAOut);
            this.Controls.Add(this.CompanyCTitle);
            this.Controls.Add(this.companyBTitle);
            this.Controls.Add(this.companyATitle);
            this.Controls.Add(this.deliveryTitle);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.peopleLabel);
            this.Controls.Add(this.title);
            this.Name = "deliveryCost";
            this.Text = "Food Delivery Cost Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label deliveryTitle;
        private System.Windows.Forms.Label companyATitle;
        private System.Windows.Forms.Label companyBTitle;
        private System.Windows.Forms.Label CompanyCTitle;
        private System.Windows.Forms.Label compAOut;
        private System.Windows.Forms.Label compBOut;
        private System.Windows.Forms.Label compCOut;
        private System.Windows.Forms.Label resultOut;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox peopleInput;
        private System.Windows.Forms.TextBox deliveryInput;
        private System.Windows.Forms.TextBox distanceInput;
    }
}

