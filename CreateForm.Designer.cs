namespace GeographyQuizGame
{
    partial class CreateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelMC;
        private System.Windows.Forms.TextBox txtOptA;
        private System.Windows.Forms.TextBox txtOptB;
        private System.Windows.Forms.TextBox txtOptC;
        private System.Windows.Forms.TextBox txtOptD;
        private System.Windows.Forms.ComboBox comboCorrect;
        private System.Windows.Forms.Panel panelOE;
        private System.Windows.Forms.TextBox txtOpenAnswers;
        private System.Windows.Forms.Panel panelTF;
        private System.Windows.Forms.RadioButton radioTrue;
        private System.Windows.Forms.RadioButton radioFalse;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelMC = new System.Windows.Forms.Panel();
            this.txtOptA = new System.Windows.Forms.TextBox();
            this.txtOptB = new System.Windows.Forms.TextBox();
            this.txtOptC = new System.Windows.Forms.TextBox();
            this.txtOptD = new System.Windows.Forms.TextBox();
            this.comboCorrect = new System.Windows.Forms.ComboBox();
            this.panelOE = new System.Windows.Forms.Panel();
            this.txtOpenAnswers = new System.Windows.Forms.TextBox();
            this.panelTF = new System.Windows.Forms.Panel();
            this.radioTrue = new System.Windows.Forms.RadioButton();
            this.radioFalse = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelMC.SuspendLayout();
            this.panelOE.SuspendLayout();
            this.panelTF.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.Location = new System.Drawing.Point(12, 12);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(343, 264);
            this.listBoxQuestions.TabIndex = 0;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(450, 12);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(350, 20);
            this.txtQuestion.TabIndex = 1;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.Location = new System.Drawing.Point(450, 38);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(200, 21);
            this.comboType.TabIndex = 2;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(379, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(882, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelMC
            // 
            this.panelMC.Controls.Add(this.txtOptA);
            this.panelMC.Controls.Add(this.txtOptB);
            this.panelMC.Controls.Add(this.txtOptC);
            this.panelMC.Controls.Add(this.txtOptD);
            this.panelMC.Controls.Add(this.comboCorrect);
            this.panelMC.Location = new System.Drawing.Point(450, 105);
            this.panelMC.Name = "panelMC";
            this.panelMC.Size = new System.Drawing.Size(350, 130);
            this.panelMC.TabIndex = 3;
            // 
            // txtOptA
            // 
            this.txtOptA.Location = new System.Drawing.Point(0, 0);
            this.txtOptA.Name = "txtOptA";
            this.txtOptA.Size = new System.Drawing.Size(200, 20);
            this.txtOptA.TabIndex = 0;
            this.txtOptA.Text = "Option A";
            // 
            // txtOptB
            // 
            this.txtOptB.Location = new System.Drawing.Point(0, 30);
            this.txtOptB.Name = "txtOptB";
            this.txtOptB.Size = new System.Drawing.Size(200, 20);
            this.txtOptB.TabIndex = 1;
            this.txtOptB.Text = "Option B";
            // 
            // txtOptC
            // 
            this.txtOptC.Location = new System.Drawing.Point(0, 60);
            this.txtOptC.Name = "txtOptC";
            this.txtOptC.Size = new System.Drawing.Size(200, 20);
            this.txtOptC.TabIndex = 2;
            this.txtOptC.Text = "Option C";
            // 
            // txtOptD
            // 
            this.txtOptD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOptD.Location = new System.Drawing.Point(0, 90);
            this.txtOptD.Name = "txtOptD";
            this.txtOptD.Size = new System.Drawing.Size(200, 22);
            this.txtOptD.TabIndex = 3;
            this.txtOptD.Text = "Option D";
            // 
            // comboCorrect
            // 
            this.comboCorrect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCorrect.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboCorrect.Location = new System.Drawing.Point(220, 0);
            this.comboCorrect.Name = "comboCorrect";
            this.comboCorrect.Size = new System.Drawing.Size(120, 21);
            this.comboCorrect.TabIndex = 4;
            // 
            // panelOE
            // 
            this.panelOE.Controls.Add(this.txtOpenAnswers);
            this.panelOE.Location = new System.Drawing.Point(450, 79);
            this.panelOE.Name = "panelOE";
            this.panelOE.Size = new System.Drawing.Size(406, 130);
            this.panelOE.TabIndex = 4;
            this.panelOE.Visible = false;
            // 
            // txtOpenAnswers
            // 
            this.txtOpenAnswers.Location = new System.Drawing.Point(0, 0);
            this.txtOpenAnswers.Name = "txtOpenAnswers";
            this.txtOpenAnswers.Size = new System.Drawing.Size(350, 20);
            this.txtOpenAnswers.TabIndex = 0;
            // 
            // panelTF
            // 
            this.panelTF.Controls.Add(this.radioTrue);
            this.panelTF.Controls.Add(this.radioFalse);
            this.panelTF.Location = new System.Drawing.Point(450, 76);
            this.panelTF.Name = "panelTF";
            this.panelTF.Size = new System.Drawing.Size(406, 130);
            this.panelTF.TabIndex = 5;
            this.panelTF.Visible = false;
            // 
            // radioTrue
            // 
            this.radioTrue.Location = new System.Drawing.Point(0, 0);
            this.radioTrue.Name = "radioTrue";
            this.radioTrue.Size = new System.Drawing.Size(104, 24);
            this.radioTrue.TabIndex = 0;
            this.radioTrue.Text = "True";
            // 
            // radioFalse
            // 
            this.radioFalse.Location = new System.Drawing.Point(0, 30);
            this.radioFalse.Name = "radioFalse";
            this.radioFalse.Size = new System.Drawing.Size(104, 24);
            this.radioFalse.TabIndex = 1;
            this.radioFalse.Text = "False";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(548, 249);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 30);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(725, 249);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CreateForm
            // 
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1040, 517);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panelMC);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listBoxQuestions);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.panelOE);
            this.Controls.Add(this.panelTF);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Name = "CreateForm";
            this.Text = "Manage Questions";
            this.panelMC.ResumeLayout(false);
            this.panelMC.PerformLayout();
            this.panelOE.ResumeLayout(false);
            this.panelOE.PerformLayout();
            this.panelTF.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}