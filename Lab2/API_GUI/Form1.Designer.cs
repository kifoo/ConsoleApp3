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
            searchInfoLabel = new Label();
            moreCharactersAPI = new Button();
            CharacterCount = new Label();
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
            buttonCharacter.Location = new Point(465, 293);
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
            character_list.Location = new Point(30, 12);
            character_list.Name = "character_list";
            character_list.Size = new Size(320, 602);
            character_list.TabIndex = 14;
            character_list.SelectedIndexChanged += Character_list_SelectedIndexChanged;
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
            // searchInfoLabel
            // 
            searchInfoLabel.AutoSize = true;
            searchInfoLabel.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchInfoLabel.Location = new Point(419, 405);
            searchInfoLabel.Name = "searchInfoLabel";
            searchInfoLabel.Size = new Size(278, 25);
            searchInfoLabel.TabIndex = 21;
            searchInfoLabel.Text = "Changed search from database to API";
            searchInfoLabel.Visible = false;
            // 
            // moreCharactersAPI
            // 
            moreCharactersAPI.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moreCharactersAPI.Location = new Point(465, 346);
            moreCharactersAPI.Margin = new Padding(3, 2, 3, 2);
            moreCharactersAPI.Name = "moreCharactersAPI";
            moreCharactersAPI.Size = new Size(204, 35);
            moreCharactersAPI.TabIndex = 22;
            moreCharactersAPI.Text = "Search through API";
            moreCharactersAPI.UseVisualStyleBackColor = true;
            moreCharactersAPI.Visible = false;
            moreCharactersAPI.Click += searchAPIButton_Click;
            // 
            // CharacterCount
            // 
            CharacterCount.AutoSize = true;
            CharacterCount.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CharacterCount.Location = new Point(69, 617);
            CharacterCount.Name = "CharacterCount";
            CharacterCount.Size = new Size(241, 25);
            CharacterCount.TabIndex = 23;
            CharacterCount.Text = "Found XXXX maching characters.";
            CharacterCount.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1201, 650);
            Controls.Add(CharacterCount);
            Controls.Add(moreCharactersAPI);
            Controls.Add(searchInfoLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Search_label);
            Controls.Add(character_list);
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
        private Label searchInfoLabel;
        private Button moreCharactersAPI;
        private Label CharacterCount;
    }
}
