namespace AlgoDes6;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        suitChoicePanel = new System.Windows.Forms.Panel();
        SuitChoiceTitle = new System.Windows.Forms.Label();
        ClubsButton = new System.Windows.Forms.Button();
        DiamondsButton = new System.Windows.Forms.Button();
        HeartsButton = new System.Windows.Forms.Button();
        SpadesButton = new System.Windows.Forms.Button();
        Title = new System.Windows.Forms.Label();
        StartButton = new System.Windows.Forms.Button();
        ExitButton = new System.Windows.Forms.Button();
        BeatenButton = new System.Windows.Forms.Button();
        TakeCardsButton = new System.Windows.Forms.Button();
        suitChoicePanel.SuspendLayout();
        SuspendLayout();
        // 
        // suitChoicePanel
        // 
        suitChoicePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
        suitChoicePanel.Controls.Add(SuitChoiceTitle);
        suitChoicePanel.Controls.Add(ClubsButton);
        suitChoicePanel.Controls.Add(DiamondsButton);
        suitChoicePanel.Controls.Add(HeartsButton);
        suitChoicePanel.Controls.Add(SpadesButton);
        suitChoicePanel.Location = new System.Drawing.Point(307, 391);
        suitChoicePanel.Name = "suitChoicePanel";
        suitChoicePanel.Size = new System.Drawing.Size(348, 226);
        suitChoicePanel.TabIndex = 3;
        suitChoicePanel.Tag = "suitChoice";
        suitChoicePanel.Visible = false;
        // 
        // SuitChoiceTitle
        // 
        SuitChoiceTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        SuitChoiceTitle.Location = new System.Drawing.Point(48, 0);
        SuitChoiceTitle.Name = "SuitChoiceTitle";
        SuitChoiceTitle.Size = new System.Drawing.Size(251, 51);
        SuitChoiceTitle.TabIndex = 0;
        SuitChoiceTitle.Tag = "suitChoiceTitle";
        SuitChoiceTitle.Text = "Оберіть масть";
        SuitChoiceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ClubsButton
        // 
        ClubsButton.BackgroundImage = ((System.Drawing.Image)resources.GetObject("ClubsButton.BackgroundImage"));
        ClubsButton.Location = new System.Drawing.Point(249, 88);
        ClubsButton.Name = "ClubsButton";
        ClubsButton.Size = new System.Drawing.Size(67, 71);
        ClubsButton.TabIndex = 4;
        ClubsButton.UseVisualStyleBackColor = true;
        ClubsButton.Click += ClubsButton_Click;
        // 
        // DiamondsButton
        // 
        DiamondsButton.BackgroundImage = ((System.Drawing.Image)resources.GetObject("DiamondsButton.BackgroundImage"));
        DiamondsButton.Location = new System.Drawing.Point(30, 88);
        DiamondsButton.Name = "DiamondsButton";
        DiamondsButton.Size = new System.Drawing.Size(67, 71);
        DiamondsButton.TabIndex = 3;
        DiamondsButton.UseVisualStyleBackColor = true;
        DiamondsButton.Click += DiamondsButton_Click;
        // 
        // HeartsButton
        // 
        HeartsButton.BackgroundImage = ((System.Drawing.Image)resources.GetObject("HeartsButton.BackgroundImage"));
        HeartsButton.Location = new System.Drawing.Point(103, 88);
        HeartsButton.Name = "HeartsButton";
        HeartsButton.Size = new System.Drawing.Size(67, 71);
        HeartsButton.TabIndex = 2;
        HeartsButton.UseVisualStyleBackColor = true;
        HeartsButton.Click += HeartsButton_Click;
        // 
        // SpadesButton
        // 
        SpadesButton.BackgroundImage = ((System.Drawing.Image)resources.GetObject("SpadesButton.BackgroundImage"));
        SpadesButton.Location = new System.Drawing.Point(176, 88);
        SpadesButton.Name = "SpadesButton";
        SpadesButton.Size = new System.Drawing.Size(67, 71);
        SpadesButton.TabIndex = 1;
        SpadesButton.UseVisualStyleBackColor = true;
        SpadesButton.Click += SpadesButton_Click;
        // 
        // Title
        // 
        Title.BackColor = System.Drawing.Color.Transparent;
        Title.Font = new System.Drawing.Font("SimSun", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Title.ForeColor = System.Drawing.SystemColors.Desktop;
        Title.Location = new System.Drawing.Point(272, 97);
        Title.Name = "Title";
        Title.Size = new System.Drawing.Size(476, 83);
        Title.TabIndex = 0;
        Title.Tag = "title";
        Title.Text = "SWOI KOZYRI";
        // 
        // StartButton
        // 
        StartButton.BackColor = System.Drawing.Color.Gainsboro;
        StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
        StartButton.FlatAppearance.BorderSize = 0;
        StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        StartButton.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        StartButton.ForeColor = System.Drawing.SystemColors.HotTrack;
        StartButton.Location = new System.Drawing.Point(209, 276);
        StartButton.Name = "StartButton";
        StartButton.Size = new System.Drawing.Size(210, 67);
        StartButton.TabIndex = 1;
        StartButton.Tag = "startButton";
        StartButton.Text = "Почати";
        StartButton.UseVisualStyleBackColor = false;
        StartButton.Click += StartButton_Click;
        // 
        // ExitButton
        // 
        ExitButton.BackColor = System.Drawing.Color.Gainsboro;
        ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
        ExitButton.FlatAppearance.BorderSize = 0;
        ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        ExitButton.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        ExitButton.ForeColor = System.Drawing.Color.DarkRed;
        ExitButton.Location = new System.Drawing.Point(594, 276);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new System.Drawing.Size(210, 67);
        ExitButton.TabIndex = 2;
        ExitButton.Tag = "exitButton";
        ExitButton.Text = "Вийти";
        ExitButton.UseVisualStyleBackColor = false;
        ExitButton.Click += ExitButton_Click;
        // 
        // BeatenButton
        // 
        BeatenButton.BackColor = System.Drawing.Color.Gainsboro;
        BeatenButton.Cursor = System.Windows.Forms.Cursors.Hand;
        BeatenButton.FlatAppearance.BorderSize = 0;
        BeatenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        BeatenButton.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BeatenButton.ForeColor = System.Drawing.Color.DarkRed;
        BeatenButton.Location = new System.Drawing.Point(741, 391);
        BeatenButton.Name = "BeatenButton";
        BeatenButton.Size = new System.Drawing.Size(210, 67);
        BeatenButton.TabIndex = 4;
        BeatenButton.Tag = "beatenButton";
        BeatenButton.Text = "Бито";
        BeatenButton.UseVisualStyleBackColor = false;
        BeatenButton.Visible = false;
        BeatenButton.Click += BeatenButton_Click;
        // 
        // TakeCardsButton
        // 
        TakeCardsButton.BackColor = System.Drawing.Color.Gainsboro;
        TakeCardsButton.Cursor = System.Windows.Forms.Cursors.Hand;
        TakeCardsButton.FlatAppearance.BorderSize = 0;
        TakeCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        TakeCardsButton.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        TakeCardsButton.ForeColor = System.Drawing.Color.DarkRed;
        TakeCardsButton.Location = new System.Drawing.Point(741, 391);
        TakeCardsButton.Name = "TakeCardsButton";
        TakeCardsButton.Size = new System.Drawing.Size(210, 67);
        TakeCardsButton.TabIndex = 5;
        TakeCardsButton.Tag = "takeCardsButton";
        TakeCardsButton.Text = "Узяти";
        TakeCardsButton.UseVisualStyleBackColor = false;
        TakeCardsButton.Visible = false;
        TakeCardsButton.Click += TakeCardsButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
        ClientSize = new System.Drawing.Size(963, 563);
        Controls.Add(TakeCardsButton);
        Controls.Add(BeatenButton);
        Controls.Add(StartButton);
        Controls.Add(ExitButton);
        Controls.Add(suitChoicePanel);
        Controls.Add(Title);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Location = new System.Drawing.Point(19, 19);
        Text = "Свої козирі";
        suitChoicePanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button TakeCardsButton;

    private System.Windows.Forms.Button BeatenButton;

    private System.Windows.Forms.Button HeartsButton;
    private System.Windows.Forms.Button DiamondsButton;
    private System.Windows.Forms.Button ClubsButton;

    private System.Windows.Forms.Button SpadesButton;

    private System.Windows.Forms.Label SuitChoiceTitle;

    private System.Windows.Forms.Panel suitChoicePanel;

    private System.Windows.Forms.Button ExitButton;

    private System.Windows.Forms.Button StartButton;

    private System.Windows.Forms.Label Title;

    #endregion
}