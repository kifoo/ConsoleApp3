using API_GUI.Enums;

namespace API_GUI
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
            Title = new Label();
            character_description = new RichTextBox();
            buttonCharacter = new Button();
            character_box = new TextBox();
            Character_label = new Label();
            Gender_label = new Label();
            RB_internet = new RadioButton();
            RB_local = new RadioButton();
            picture_box = new PictureBox();
            type_box = new TextBox();
            character_list = new ListBox();
            Type_label = new Label();
            Search_label = new Label();
            Status_label = new Label();
            Species_label = new Label();
            species_box = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            gender_box = new ComboBox();
            status_box = new ComboBox();
            previous_button = new Button();
            next_button = new Button();
            ((System.ComponentModel.ISupportInitialize)picture_box).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.SeaGreen;
            Title.FlatStyle = FlatStyle.Popup;
            Title.Font = new Font("Viner Hand ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(355, 9);
            Title.Name = "Title";
            Title.Size = new Size(384, 44);
            Title.TabIndex = 1;
            Title.Text = "Rick and Morty Characters";
            // 
            // character_description
            // 
            character_description.BackColor = Color.DarkSeaGreen;
            character_description.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            character_description.Location = new Point(783, 319);
            character_description.Margin = new Padding(3, 2, 3, 2);
            character_description.Name = "character_description";
            character_description.Size = new Size(402, 302);
            character_description.TabIndex = 2;
            character_description.Text = "";
            character_description.Visible = false;
            // 
            // buttonCharacter
            // 
            buttonCharacter.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCharacter.Location = new Point(387, 348);
            buttonCharacter.Margin = new Padding(3, 2, 3, 2);
            buttonCharacter.Name = "buttonCharacter";
            buttonCharacter.Size = new Size(204, 35);
            buttonCharacter.TabIndex = 0;
            buttonCharacter.Text = "Get Result";
            buttonCharacter.UseVisualStyleBackColor = true;
            buttonCharacter.Click += characterButtonClick;
            // 
            // character_box
            // 
            character_box.BackColor = Color.DarkSeaGreen;
            character_box.Font = new Font("Papyrus", 11F);
            character_box.Location = new Point(78, 3);
            character_box.Name = "character_box";
            character_box.Size = new Size(204, 31);
            character_box.TabIndex = 3;
            // 
            // Character_label
            // 
            Character_label.AutoSize = true;
            Character_label.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Character_label.Location = new Point(3, 0);
            Character_label.Name = "Character_label";
            Character_label.Size = new Size(53, 25);
            Character_label.TabIndex = 4;
            Character_label.Text = "Name";
            // 
            // Gender_label
            // 
            Gender_label.AutoSize = true;
            Gender_label.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gender_label.Location = new Point(3, 149);
            Gender_label.Name = "Gender_label";
            Gender_label.Size = new Size(66, 25);
            Gender_label.TabIndex = 7;
            Gender_label.Text = "Gender";
            // 
            // RB_internet
            // 
            RB_internet.AutoSize = true;
            RB_internet.Font = new Font("Papyrus", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB_internet.Location = new Point(387, 286);
            RB_internet.Name = "RB_internet";
            RB_internet.Size = new Size(239, 28);
            RB_internet.TabIndex = 9;
            RB_internet.Text = "Search trough internet database";
            RB_internet.UseVisualStyleBackColor = true;
            RB_internet.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // RB_local
            // 
            RB_local.AutoSize = true;
            RB_local.Checked = true;
            RB_local.Font = new Font("Papyrus", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RB_local.Location = new Point(387, 315);
            RB_local.Name = "RB_local";
            RB_local.Size = new Size(219, 28);
            RB_local.TabIndex = 10;
            RB_local.TabStop = true;
            RB_local.Text = "Search trough local database";
            RB_local.UseVisualStyleBackColor = true;
            RB_local.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // picture_box
            // 
            picture_box.Location = new Point(783, 12);
            picture_box.Name = "picture_box";
            picture_box.Size = new Size(402, 302);
            picture_box.TabIndex = 8;
            picture_box.TabStop = false;
            // 
            // type_box
            // 
            type_box.BackColor = Color.DarkSeaGreen;
            type_box.Font = new Font("Papyrus", 11F);
            type_box.Location = new Point(78, 115);
            type_box.Name = "type_box";
            type_box.Size = new Size(204, 31);
            type_box.TabIndex = 3;
            // 
            // character_list
            // 
            character_list.BackColor = Color.DarkSeaGreen;
            character_list.BorderStyle = BorderStyle.FixedSingle;
            character_list.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            character_list.FormattingEnabled = true;
            character_list.ItemHeight = 25;
            character_list.Location = new Point(29, 12);
            character_list.MultiColumn = true;
            character_list.Name = "character_list";
            character_list.Size = new Size(296, 502);
            character_list.TabIndex = 14;
            character_list.SelectedIndexChanged += character_list_SelectedIndexChanged;
            // 
            // Type_label
            // 
            Type_label.AutoSize = true;
            Type_label.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Type_label.Location = new Point(3, 112);
            Type_label.Name = "Type_label";
            Type_label.Size = new Size(52, 25);
            Type_label.TabIndex = 5;
            Type_label.Text = "Type";
            // 
            // Search_label
            // 
            Search_label.AutoSize = true;
            Search_label.BorderStyle = BorderStyle.FixedSingle;
            Search_label.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search_label.Location = new Point(465, 56);
            Search_label.Name = "Search_label";
            Search_label.Size = new Size(146, 27);
            Search_label.TabIndex = 15;
            Search_label.Text = "Search Characters";
            // 
            // Status_label
            // 
            Status_label.AutoSize = true;
            Status_label.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Status_label.Location = new Point(3, 37);
            Status_label.Name = "Status_label";
            Status_label.Size = new Size(62, 25);
            Status_label.TabIndex = 16;
            Status_label.Text = "Status";
            // 
            // Species_label
            // 
            Species_label.AutoSize = true;
            Species_label.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Species_label.Location = new Point(3, 75);
            Species_label.Name = "Species_label";
            Species_label.Size = new Size(69, 25);
            Species_label.TabIndex = 17;
            Species_label.Text = "Species";
            // 
            // species_box
            // 
            species_box.BackColor = Color.DarkSeaGreen;
            species_box.Font = new Font("Papyrus", 11F);
            species_box.Location = new Point(78, 78);
            species_box.Name = "species_box";
            species_box.Size = new Size(204, 31);
            species_box.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(gender_box, 1, 4);
            tableLayoutPanel1.Controls.Add(Gender_label, 0, 4);
            tableLayoutPanel1.Controls.Add(Type_label, 0, 3);
            tableLayoutPanel1.Controls.Add(Species_label, 0, 2);
            tableLayoutPanel1.Controls.Add(Character_label, 0, 0);
            tableLayoutPanel1.Controls.Add(Status_label, 0, 1);
            tableLayoutPanel1.Controls.Add(character_box, 1, 0);
            tableLayoutPanel1.Controls.Add(type_box, 1, 3);
            tableLayoutPanel1.Controls.Add(species_box, 1, 2);
            tableLayoutPanel1.Controls.Add(status_box, 1, 1);
            tableLayoutPanel1.Location = new Point(387, 86);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(310, 193);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // gender_box
            // 
            gender_box.BackColor = Color.DarkSeaGreen;
            gender_box.Font = new Font("Papyrus", 11F);
            gender_box.FormattingEnabled = true;
            gender_box.Location = new Point(78, 152);
            gender_box.Name = "gender_box";
            gender_box.Size = new Size(204, 32);
            gender_box.TabIndex = 22;
            // 
            // status_box
            // 
            status_box.BackColor = Color.DarkSeaGreen;
            status_box.Font = new Font("Papyrus", 11F);
            status_box.FormattingEnabled = true;
            status_box.Location = new Point(78, 40);
            status_box.Name = "status_box";
            status_box.Size = new Size(204, 32);
            status_box.TabIndex = 23;
            // 
            // previous_button
            // 
            previous_button.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            previous_button.Location = new Point(29, 520);
            previous_button.Name = "previous_button";
            previous_button.Size = new Size(72, 31);
            previous_button.TabIndex = 21;
            previous_button.Text = "Prev";
            previous_button.UseVisualStyleBackColor = true;
            previous_button.Visible = false;
            previous_button.Click += PrevPageButtonClick;
            // 
            // next_button
            // 
            next_button.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            next_button.Location = new Point(253, 520);
            next_button.Name = "next_button";
            next_button.Size = new Size(72, 31);
            next_button.TabIndex = 22;
            next_button.Text = "Next";
            next_button.UseVisualStyleBackColor = true;
            next_button.Visible = false;
            next_button.Click += NextPageButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1201, 650);
            Controls.Add(next_button);
            Controls.Add(previous_button);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Search_label);
            Controls.Add(character_list);
            Controls.Add(RB_local);
            Controls.Add(RB_internet);
            Controls.Add(picture_box);
            Controls.Add(character_description);
            Controls.Add(Title);
            Controls.Add(buttonCharacter);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Rick&Morty";
            ((System.ComponentModel.ISupportInitialize)picture_box).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCharacter;
        private Label Title;
        private RichTextBox character_description;
        private Label Character_label;
        private Label Gender_label;
        private TextBox character_box;
        private PictureBox picture_box;
        private RadioButton RB_internet;
        private RadioButton RB_local;
        private TextBox type_box;
        private ListBox character_list;
        private Label Type_label;
        private Label Search_label;
        private Label Status_label;
        private Label Species_label;
        private TextBox species_box;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox gender_box;
        private ComboBox status_box;
        private Button previous_button;
        private Button next_button;
    }
}
