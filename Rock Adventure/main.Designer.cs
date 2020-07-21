namespace Rock_Adventure
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.game_title = new System.Windows.Forms.Label();
            this.storyboard = new System.Windows.Forms.Panel();
            this.stage_1_action = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Label();
            this.inventory_label = new System.Windows.Forms.Label();
            this.choice_2 = new System.Windows.Forms.RadioButton();
            this.choice_1 = new System.Windows.Forms.RadioButton();
            this.start_game = new System.Windows.Forms.Button();
            this.story = new System.Windows.Forms.Label();
            this.stage_2_action = new System.Windows.Forms.Button();
            this.stage_3_action = new System.Windows.Forms.Button();
            this.storyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_title
            // 
            resources.ApplyResources(this.game_title, "game_title");
            this.game_title.BackColor = System.Drawing.Color.Transparent;
            this.game_title.ForeColor = System.Drawing.Color.White;
            this.game_title.Name = "game_title";
            // 
            // storyboard
            // 
            resources.ApplyResources(this.storyboard, "storyboard");
            this.storyboard.BackgroundImage = global::Rock_Adventure.Properties.Resources.storyboard_bg;
            this.storyboard.Controls.Add(this.stage_3_action);
            this.storyboard.Controls.Add(this.stage_2_action);
            this.storyboard.Controls.Add(this.stage_1_action);
            this.storyboard.Controls.Add(this.inventory);
            this.storyboard.Controls.Add(this.inventory_label);
            this.storyboard.Controls.Add(this.choice_2);
            this.storyboard.Controls.Add(this.choice_1);
            this.storyboard.Controls.Add(this.start_game);
            this.storyboard.Controls.Add(this.story);
            this.storyboard.ForeColor = System.Drawing.Color.Black;
            this.storyboard.Name = "storyboard";
            // 
            // stage_1_action
            // 
            resources.ApplyResources(this.stage_1_action, "stage_1_action");
            this.stage_1_action.BackColor = System.Drawing.Color.Transparent;
            this.stage_1_action.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stage_1_action.FlatAppearance.BorderSize = 2;
            this.stage_1_action.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stage_1_action.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.stage_1_action.Name = "stage_1_action";
            this.stage_1_action.UseVisualStyleBackColor = false;
            this.stage_1_action.Click += new System.EventHandler(this.stage_1_action_Click);
            // 
            // inventory
            // 
            resources.ApplyResources(this.inventory, "inventory");
            this.inventory.BackColor = System.Drawing.Color.Transparent;
            this.inventory.ForeColor = System.Drawing.Color.Black;
            this.inventory.Name = "inventory";
            // 
            // inventory_label
            // 
            resources.ApplyResources(this.inventory_label, "inventory_label");
            this.inventory_label.BackColor = System.Drawing.Color.Transparent;
            this.inventory_label.ForeColor = System.Drawing.Color.Black;
            this.inventory_label.Name = "inventory_label";
            // 
            // choice_2
            // 
            resources.ApplyResources(this.choice_2, "choice_2");
            this.choice_2.BackColor = System.Drawing.Color.Transparent;
            this.choice_2.ForeColor = System.Drawing.Color.Black;
            this.choice_2.Name = "choice_2";
            this.choice_2.TabStop = true;
            this.choice_2.UseVisualStyleBackColor = false;
            // 
            // choice_1
            // 
            resources.ApplyResources(this.choice_1, "choice_1");
            this.choice_1.BackColor = System.Drawing.Color.Transparent;
            this.choice_1.ForeColor = System.Drawing.Color.Black;
            this.choice_1.Name = "choice_1";
            this.choice_1.TabStop = true;
            this.choice_1.UseVisualStyleBackColor = false;
            // 
            // start_game
            // 
            resources.ApplyResources(this.start_game, "start_game");
            this.start_game.BackColor = System.Drawing.Color.Transparent;
            this.start_game.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.start_game.FlatAppearance.BorderSize = 2;
            this.start_game.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.start_game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.start_game.Name = "start_game";
            this.start_game.UseVisualStyleBackColor = false;
            this.start_game.Click += new System.EventHandler(this.start_game_Click);
            // 
            // story
            // 
            resources.ApplyResources(this.story, "story");
            this.story.BackColor = System.Drawing.Color.Transparent;
            this.story.ForeColor = System.Drawing.Color.Black;
            this.story.Name = "story";
            // 
            // stage_2_action
            // 
            resources.ApplyResources(this.stage_2_action, "stage_2_action");
            this.stage_2_action.BackColor = System.Drawing.Color.Transparent;
            this.stage_2_action.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stage_2_action.FlatAppearance.BorderSize = 2;
            this.stage_2_action.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stage_2_action.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.stage_2_action.Name = "stage_2_action";
            this.stage_2_action.UseVisualStyleBackColor = false;
            this.stage_2_action.Click += new System.EventHandler(this.stage_2_action_Click);
            // 
            // stage_3_action
            // 
            resources.ApplyResources(this.stage_3_action, "stage_3_action");
            this.stage_3_action.BackColor = System.Drawing.Color.Transparent;
            this.stage_3_action.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stage_3_action.FlatAppearance.BorderSize = 2;
            this.stage_3_action.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stage_3_action.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.stage_3_action.Name = "stage_3_action";
            this.stage_3_action.UseVisualStyleBackColor = false;
            this.stage_3_action.Click += new System.EventHandler(this.stage_3_action_Click);
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = global::Rock_Adventure.Properties.Resources.bg;
            this.Controls.Add(this.game_title);
            this.Controls.Add(this.storyboard);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(86)))));
            this.Name = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.storyboard.ResumeLayout(false);
            this.storyboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label game_title;
        private System.Windows.Forms.Panel storyboard;
        private System.Windows.Forms.Label story;
        private System.Windows.Forms.Button start_game;
        private System.Windows.Forms.RadioButton choice_2;
        private System.Windows.Forms.RadioButton choice_1;
        private System.Windows.Forms.Label inventory_label;
        private System.Windows.Forms.Label inventory;
        private System.Windows.Forms.Button stage_1_action;
        private System.Windows.Forms.Button stage_2_action;
        private System.Windows.Forms.Button stage_3_action;
    }
}

