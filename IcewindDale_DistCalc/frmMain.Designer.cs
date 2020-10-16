namespace IcewindDale_DistCalc
{
    partial class frmMain
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
            this.gbxTerrain = new System.Windows.Forms.GroupBox();
            this.gbxMethod = new System.Windows.Forms.GroupBox();
            this.gbxResting = new System.Windows.Forms.GroupBox();
            this.gbxOrigin = new System.Windows.Forms.GroupBox();
            this.gbxDestination = new System.Windows.Forms.GroupBox();
            this.gbxResults = new System.Windows.Forms.GroupBox();
            this.radTundra = new System.Windows.Forms.RadioButton();
            this.radRoad = new System.Windows.Forms.RadioButton();
            this.radMountain = new System.Windows.Forms.RadioButton();
            this.radDogsled = new System.Windows.Forms.RadioButton();
            this.radAxeBeak = new System.Windows.Forms.RadioButton();
            this.radSnowshoes = new System.Windows.Forms.RadioButton();
            this.radUnaided = new System.Windows.Forms.RadioButton();
            this.radResting = new System.Windows.Forms.RadioButton();
            this.radUnrested = new System.Windows.Forms.RadioButton();
            this.radOriginDougansHole = new System.Windows.Forms.RadioButton();
            this.radOriginGoodMead = new System.Windows.Forms.RadioButton();
            this.radOriginIntersection = new System.Windows.Forms.RadioButton();
            this.radOriginEasthaven = new System.Windows.Forms.RadioButton();
            this.radOriginCaerDineval = new System.Windows.Forms.RadioButton();
            this.radOriginCaerKonig = new System.Windows.Forms.RadioButton();
            this.radOriginBrynShander = new System.Windows.Forms.RadioButton();
            this.radOriginTargos = new System.Windows.Forms.RadioButton();
            this.radOriginBremen = new System.Windows.Forms.RadioButton();
            this.radOriginTermalaine = new System.Windows.Forms.RadioButton();
            this.radOriginLonelywood = new System.Windows.Forms.RadioButton();
            this.radOriginOther = new System.Windows.Forms.RadioButton();
            this.radDestDougansHole = new System.Windows.Forms.RadioButton();
            this.radDestGoodMead = new System.Windows.Forms.RadioButton();
            this.radDestIntersection = new System.Windows.Forms.RadioButton();
            this.radDestEasthaven = new System.Windows.Forms.RadioButton();
            this.radDestCaerDineval = new System.Windows.Forms.RadioButton();
            this.radDestCaerKonig = new System.Windows.Forms.RadioButton();
            this.radDestBrynShander = new System.Windows.Forms.RadioButton();
            this.radDestTargos = new System.Windows.Forms.RadioButton();
            this.radDestBremen = new System.Windows.Forms.RadioButton();
            this.radDestTermalaine = new System.Windows.Forms.RadioButton();
            this.radDestLonelywood = new System.Windows.Forms.RadioButton();
            this.radDestOther = new System.Windows.Forms.RadioButton();
            this.txtOtherDistance = new System.Windows.Forms.TextBox();
            this.lblOtherDistance = new System.Windows.Forms.Label();
            this.gbxPace = new System.Windows.Forms.GroupBox();
            this.radSlow = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radFast = new System.Windows.Forms.RadioButton();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.gbxUndead = new System.Windows.Forms.GroupBox();
            this.radLiving = new System.Windows.Forms.RadioButton();
            this.radUndead = new System.Windows.Forms.RadioButton();
            this.gbxPlayerExhaust = new System.Windows.Forms.GroupBox();
            this.radPlayerHealthy = new System.Windows.Forms.RadioButton();
            this.radPlayerExhausted = new System.Windows.Forms.RadioButton();
            this.txtUntraveled = new System.Windows.Forms.TextBox();
            this.lblUntraveledDistance = new System.Windows.Forms.Label();
            this.lblUDDesc = new System.Windows.Forms.Label();
            this.gbxTerrain.SuspendLayout();
            this.gbxMethod.SuspendLayout();
            this.gbxResting.SuspendLayout();
            this.gbxOrigin.SuspendLayout();
            this.gbxDestination.SuspendLayout();
            this.gbxResults.SuspendLayout();
            this.gbxPace.SuspendLayout();
            this.gbxUndead.SuspendLayout();
            this.gbxPlayerExhaust.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTerrain
            // 
            this.gbxTerrain.Controls.Add(this.radMountain);
            this.gbxTerrain.Controls.Add(this.radRoad);
            this.gbxTerrain.Controls.Add(this.radTundra);
            this.gbxTerrain.Location = new System.Drawing.Point(12, 12);
            this.gbxTerrain.Name = "gbxTerrain";
            this.gbxTerrain.Size = new System.Drawing.Size(200, 100);
            this.gbxTerrain.TabIndex = 0;
            this.gbxTerrain.TabStop = false;
            this.gbxTerrain.Text = "Terrain";
            // 
            // gbxMethod
            // 
            this.gbxMethod.Controls.Add(this.radUnaided);
            this.gbxMethod.Controls.Add(this.radSnowshoes);
            this.gbxMethod.Controls.Add(this.radAxeBeak);
            this.gbxMethod.Controls.Add(this.radDogsled);
            this.gbxMethod.Location = new System.Drawing.Point(12, 118);
            this.gbxMethod.Name = "gbxMethod";
            this.gbxMethod.Size = new System.Drawing.Size(200, 120);
            this.gbxMethod.TabIndex = 1;
            this.gbxMethod.TabStop = false;
            this.gbxMethod.Text = "Method";
            // 
            // gbxResting
            // 
            this.gbxResting.Controls.Add(this.radUnrested);
            this.gbxResting.Controls.Add(this.radResting);
            this.gbxResting.Location = new System.Drawing.Point(12, 244);
            this.gbxResting.Name = "gbxResting";
            this.gbxResting.Size = new System.Drawing.Size(200, 72);
            this.gbxResting.TabIndex = 2;
            this.gbxResting.TabStop = false;
            this.gbxResting.Text = "Resting";
            // 
            // gbxOrigin
            // 
            this.gbxOrigin.Controls.Add(this.radOriginOther);
            this.gbxOrigin.Controls.Add(this.radOriginLonelywood);
            this.gbxOrigin.Controls.Add(this.radOriginTermalaine);
            this.gbxOrigin.Controls.Add(this.radOriginBremen);
            this.gbxOrigin.Controls.Add(this.radOriginTargos);
            this.gbxOrigin.Controls.Add(this.radOriginBrynShander);
            this.gbxOrigin.Controls.Add(this.radOriginCaerKonig);
            this.gbxOrigin.Controls.Add(this.radOriginCaerDineval);
            this.gbxOrigin.Controls.Add(this.radOriginEasthaven);
            this.gbxOrigin.Controls.Add(this.radOriginIntersection);
            this.gbxOrigin.Controls.Add(this.radOriginGoodMead);
            this.gbxOrigin.Controls.Add(this.radOriginDougansHole);
            this.gbxOrigin.Location = new System.Drawing.Point(219, 13);
            this.gbxOrigin.Name = "gbxOrigin";
            this.gbxOrigin.Size = new System.Drawing.Size(184, 362);
            this.gbxOrigin.TabIndex = 4;
            this.gbxOrigin.TabStop = false;
            this.gbxOrigin.Text = "Origin";
            // 
            // gbxDestination
            // 
            this.gbxDestination.Controls.Add(this.lblOtherDistance);
            this.gbxDestination.Controls.Add(this.txtOtherDistance);
            this.gbxDestination.Controls.Add(this.radDestOther);
            this.gbxDestination.Controls.Add(this.radDestLonelywood);
            this.gbxDestination.Controls.Add(this.radDestTermalaine);
            this.gbxDestination.Controls.Add(this.radDestBremen);
            this.gbxDestination.Controls.Add(this.radDestTargos);
            this.gbxDestination.Controls.Add(this.radDestBrynShander);
            this.gbxDestination.Controls.Add(this.radDestCaerKonig);
            this.gbxDestination.Controls.Add(this.radDestCaerDineval);
            this.gbxDestination.Controls.Add(this.radDestEasthaven);
            this.gbxDestination.Controls.Add(this.radDestIntersection);
            this.gbxDestination.Controls.Add(this.radDestGoodMead);
            this.gbxDestination.Controls.Add(this.radDestDougansHole);
            this.gbxDestination.Location = new System.Drawing.Point(409, 12);
            this.gbxDestination.Name = "gbxDestination";
            this.gbxDestination.Size = new System.Drawing.Size(165, 363);
            this.gbxDestination.TabIndex = 5;
            this.gbxDestination.TabStop = false;
            this.gbxDestination.Text = "Destination";
            // 
            // gbxResults
            // 
            this.gbxResults.Controls.Add(this.lblUDDesc);
            this.gbxResults.Controls.Add(this.lblUntraveledDistance);
            this.gbxResults.Controls.Add(this.txtUntraveled);
            this.gbxResults.Controls.Add(this.lblMinutes);
            this.gbxResults.Controls.Add(this.lblHours);
            this.gbxResults.Controls.Add(this.lblDays);
            this.gbxResults.Controls.Add(this.txtMinutes);
            this.gbxResults.Controls.Add(this.txtHours);
            this.gbxResults.Controls.Add(this.txtDays);
            this.gbxResults.Location = new System.Drawing.Point(219, 381);
            this.gbxResults.Name = "gbxResults";
            this.gbxResults.Size = new System.Drawing.Size(355, 119);
            this.gbxResults.TabIndex = 6;
            this.gbxResults.TabStop = false;
            this.gbxResults.Text = "Results";
            // 
            // radTundra
            // 
            this.radTundra.AutoSize = true;
            this.radTundra.Location = new System.Drawing.Point(7, 20);
            this.radTundra.Name = "radTundra";
            this.radTundra.Size = new System.Drawing.Size(59, 17);
            this.radTundra.TabIndex = 0;
            this.radTundra.TabStop = true;
            this.radTundra.Text = "Tundra";
            this.radTundra.UseVisualStyleBackColor = true;
            this.radTundra.CheckedChanged += new System.EventHandler(this.radTundra_CheckedChanged);
            // 
            // radRoad
            // 
            this.radRoad.AutoSize = true;
            this.radRoad.Location = new System.Drawing.Point(7, 44);
            this.radRoad.Name = "radRoad";
            this.radRoad.Size = new System.Drawing.Size(51, 17);
            this.radRoad.TabIndex = 1;
            this.radRoad.TabStop = true;
            this.radRoad.Text = "Road";
            this.radRoad.UseVisualStyleBackColor = true;
            this.radRoad.CheckedChanged += new System.EventHandler(this.radRoad_CheckedChanged);
            // 
            // radMountain
            // 
            this.radMountain.AutoSize = true;
            this.radMountain.Location = new System.Drawing.Point(7, 68);
            this.radMountain.Name = "radMountain";
            this.radMountain.Size = new System.Drawing.Size(69, 17);
            this.radMountain.TabIndex = 2;
            this.radMountain.TabStop = true;
            this.radMountain.Text = "Mountain";
            this.radMountain.UseVisualStyleBackColor = true;
            this.radMountain.CheckedChanged += new System.EventHandler(this.radMountain_CheckedChanged);
            // 
            // radDogsled
            // 
            this.radDogsled.AutoSize = true;
            this.radDogsled.Location = new System.Drawing.Point(7, 20);
            this.radDogsled.Name = "radDogsled";
            this.radDogsled.Size = new System.Drawing.Size(64, 17);
            this.radDogsled.TabIndex = 0;
            this.radDogsled.TabStop = true;
            this.radDogsled.Text = "Dogsled";
            this.radDogsled.UseVisualStyleBackColor = true;
            this.radDogsled.CheckedChanged += new System.EventHandler(this.radDogsled_CheckedChanged);
            // 
            // radAxeBeak
            // 
            this.radAxeBeak.AutoSize = true;
            this.radAxeBeak.Location = new System.Drawing.Point(7, 44);
            this.radAxeBeak.Name = "radAxeBeak";
            this.radAxeBeak.Size = new System.Drawing.Size(71, 17);
            this.radAxeBeak.TabIndex = 1;
            this.radAxeBeak.TabStop = true;
            this.radAxeBeak.Text = "Axe Beak";
            this.radAxeBeak.UseVisualStyleBackColor = true;
            this.radAxeBeak.CheckedChanged += new System.EventHandler(this.radAxeBeak_CheckedChanged);
            // 
            // radSnowshoes
            // 
            this.radSnowshoes.AutoSize = true;
            this.radSnowshoes.Location = new System.Drawing.Point(7, 68);
            this.radSnowshoes.Name = "radSnowshoes";
            this.radSnowshoes.Size = new System.Drawing.Size(80, 17);
            this.radSnowshoes.TabIndex = 2;
            this.radSnowshoes.TabStop = true;
            this.radSnowshoes.Text = "Snowshoes";
            this.radSnowshoes.UseVisualStyleBackColor = true;
            this.radSnowshoes.CheckedChanged += new System.EventHandler(this.radSnowshoes_CheckedChanged);
            // 
            // radUnaided
            // 
            this.radUnaided.AutoSize = true;
            this.radUnaided.Location = new System.Drawing.Point(7, 92);
            this.radUnaided.Name = "radUnaided";
            this.radUnaided.Size = new System.Drawing.Size(65, 17);
            this.radUnaided.TabIndex = 3;
            this.radUnaided.TabStop = true;
            this.radUnaided.Text = "Unaided";
            this.radUnaided.UseVisualStyleBackColor = true;
            this.radUnaided.CheckedChanged += new System.EventHandler(this.radUnaided_CheckedChanged);
            // 
            // radResting
            // 
            this.radResting.AutoSize = true;
            this.radResting.Location = new System.Drawing.Point(7, 20);
            this.radResting.Name = "radResting";
            this.radResting.Size = new System.Drawing.Size(43, 17);
            this.radResting.TabIndex = 0;
            this.radResting.TabStop = true;
            this.radResting.Text = "Yes";
            this.radResting.UseVisualStyleBackColor = true;
            this.radResting.CheckedChanged += new System.EventHandler(this.radResting_CheckedChanged);
            // 
            // radUnrested
            // 
            this.radUnrested.AutoSize = true;
            this.radUnrested.Location = new System.Drawing.Point(7, 44);
            this.radUnrested.Name = "radUnrested";
            this.radUnrested.Size = new System.Drawing.Size(39, 17);
            this.radUnrested.TabIndex = 1;
            this.radUnrested.TabStop = true;
            this.radUnrested.Text = "No";
            this.radUnrested.UseVisualStyleBackColor = true;
            this.radUnrested.CheckedChanged += new System.EventHandler(this.radUnrested_CheckedChanged);
            // 
            // radOriginDougansHole
            // 
            this.radOriginDougansHole.AutoSize = true;
            this.radOriginDougansHole.Location = new System.Drawing.Point(7, 19);
            this.radOriginDougansHole.Name = "radOriginDougansHole";
            this.radOriginDougansHole.Size = new System.Drawing.Size(95, 17);
            this.radOriginDougansHole.TabIndex = 0;
            this.radOriginDougansHole.TabStop = true;
            this.radOriginDougansHole.Text = "Dougan\'s Hole";
            this.radOriginDougansHole.UseVisualStyleBackColor = true;
            this.radOriginDougansHole.CheckedChanged += new System.EventHandler(this.radOriginDougansHole_CheckedChanged);
            // 
            // radOriginGoodMead
            // 
            this.radOriginGoodMead.AutoSize = true;
            this.radOriginGoodMead.Location = new System.Drawing.Point(7, 43);
            this.radOriginGoodMead.Name = "radOriginGoodMead";
            this.radOriginGoodMead.Size = new System.Drawing.Size(81, 17);
            this.radOriginGoodMead.TabIndex = 1;
            this.radOriginGoodMead.TabStop = true;
            this.radOriginGoodMead.Text = "Good Mead";
            this.radOriginGoodMead.UseVisualStyleBackColor = true;
            this.radOriginGoodMead.CheckedChanged += new System.EventHandler(this.radOriginGoodMead_CheckedChanged);
            // 
            // radOriginIntersection
            // 
            this.radOriginIntersection.AutoSize = true;
            this.radOriginIntersection.Location = new System.Drawing.Point(7, 67);
            this.radOriginIntersection.Name = "radOriginIntersection";
            this.radOriginIntersection.Size = new System.Drawing.Size(80, 17);
            this.radOriginIntersection.TabIndex = 2;
            this.radOriginIntersection.TabStop = true;
            this.radOriginIntersection.Text = "Intersection";
            this.radOriginIntersection.UseVisualStyleBackColor = true;
            this.radOriginIntersection.CheckedChanged += new System.EventHandler(this.radOriginIntersection_CheckedChanged);
            // 
            // radOriginEasthaven
            // 
            this.radOriginEasthaven.AutoSize = true;
            this.radOriginEasthaven.Location = new System.Drawing.Point(7, 91);
            this.radOriginEasthaven.Name = "radOriginEasthaven";
            this.radOriginEasthaven.Size = new System.Drawing.Size(76, 17);
            this.radOriginEasthaven.TabIndex = 3;
            this.radOriginEasthaven.TabStop = true;
            this.radOriginEasthaven.Text = "Easthaven";
            this.radOriginEasthaven.UseVisualStyleBackColor = true;
            this.radOriginEasthaven.CheckedChanged += new System.EventHandler(this.radOriginEasthaven_CheckedChanged);
            // 
            // radOriginCaerDineval
            // 
            this.radOriginCaerDineval.AutoSize = true;
            this.radOriginCaerDineval.Location = new System.Drawing.Point(7, 115);
            this.radOriginCaerDineval.Name = "radOriginCaerDineval";
            this.radOriginCaerDineval.Size = new System.Drawing.Size(86, 17);
            this.radOriginCaerDineval.TabIndex = 4;
            this.radOriginCaerDineval.TabStop = true;
            this.radOriginCaerDineval.Text = "Caer-Dineval";
            this.radOriginCaerDineval.UseVisualStyleBackColor = true;
            this.radOriginCaerDineval.CheckedChanged += new System.EventHandler(this.radOriginCaerDineval_CheckedChanged);
            // 
            // radOriginCaerKonig
            // 
            this.radOriginCaerKonig.AutoSize = true;
            this.radOriginCaerKonig.Location = new System.Drawing.Point(7, 139);
            this.radOriginCaerKonig.Name = "radOriginCaerKonig";
            this.radOriginCaerKonig.Size = new System.Drawing.Size(77, 17);
            this.radOriginCaerKonig.TabIndex = 5;
            this.radOriginCaerKonig.TabStop = true;
            this.radOriginCaerKonig.Text = "Caer-Konig";
            this.radOriginCaerKonig.UseVisualStyleBackColor = true;
            this.radOriginCaerKonig.CheckedChanged += new System.EventHandler(this.radOriginCaerKonig_CheckedChanged);
            // 
            // radOriginBrynShander
            // 
            this.radOriginBrynShander.AutoSize = true;
            this.radOriginBrynShander.Location = new System.Drawing.Point(7, 163);
            this.radOriginBrynShander.Name = "radOriginBrynShander";
            this.radOriginBrynShander.Size = new System.Drawing.Size(89, 17);
            this.radOriginBrynShander.TabIndex = 6;
            this.radOriginBrynShander.TabStop = true;
            this.radOriginBrynShander.Text = "Bryn Shander";
            this.radOriginBrynShander.UseVisualStyleBackColor = true;
            this.radOriginBrynShander.CheckedChanged += new System.EventHandler(this.radOriginBrynShander_CheckedChanged);
            // 
            // radOriginTargos
            // 
            this.radOriginTargos.AutoSize = true;
            this.radOriginTargos.Location = new System.Drawing.Point(7, 187);
            this.radOriginTargos.Name = "radOriginTargos";
            this.radOriginTargos.Size = new System.Drawing.Size(58, 17);
            this.radOriginTargos.TabIndex = 7;
            this.radOriginTargos.TabStop = true;
            this.radOriginTargos.Text = "Targos";
            this.radOriginTargos.UseVisualStyleBackColor = true;
            this.radOriginTargos.CheckedChanged += new System.EventHandler(this.radOriginTargos_CheckedChanged);
            // 
            // radOriginBremen
            // 
            this.radOriginBremen.AutoSize = true;
            this.radOriginBremen.Location = new System.Drawing.Point(7, 211);
            this.radOriginBremen.Name = "radOriginBremen";
            this.radOriginBremen.Size = new System.Drawing.Size(61, 17);
            this.radOriginBremen.TabIndex = 8;
            this.radOriginBremen.TabStop = true;
            this.radOriginBremen.Text = "Bremen";
            this.radOriginBremen.UseVisualStyleBackColor = true;
            this.radOriginBremen.CheckedChanged += new System.EventHandler(this.radOriginBremen_CheckedChanged);
            // 
            // radOriginTermalaine
            // 
            this.radOriginTermalaine.AutoSize = true;
            this.radOriginTermalaine.Location = new System.Drawing.Point(7, 235);
            this.radOriginTermalaine.Name = "radOriginTermalaine";
            this.radOriginTermalaine.Size = new System.Drawing.Size(77, 17);
            this.radOriginTermalaine.TabIndex = 9;
            this.radOriginTermalaine.TabStop = true;
            this.radOriginTermalaine.Text = "Termalaine";
            this.radOriginTermalaine.UseVisualStyleBackColor = true;
            this.radOriginTermalaine.CheckedChanged += new System.EventHandler(this.radOriginTermalaine_CheckedChanged);
            // 
            // radOriginLonelywood
            // 
            this.radOriginLonelywood.AutoSize = true;
            this.radOriginLonelywood.Location = new System.Drawing.Point(7, 259);
            this.radOriginLonelywood.Name = "radOriginLonelywood";
            this.radOriginLonelywood.Size = new System.Drawing.Size(82, 17);
            this.radOriginLonelywood.TabIndex = 10;
            this.radOriginLonelywood.TabStop = true;
            this.radOriginLonelywood.Text = "Lonelywood";
            this.radOriginLonelywood.UseVisualStyleBackColor = true;
            this.radOriginLonelywood.CheckedChanged += new System.EventHandler(this.radOriginLonelywood_CheckedChanged);
            // 
            // radOriginOther
            // 
            this.radOriginOther.AutoSize = true;
            this.radOriginOther.Location = new System.Drawing.Point(7, 283);
            this.radOriginOther.Name = "radOriginOther";
            this.radOriginOther.Size = new System.Drawing.Size(51, 17);
            this.radOriginOther.TabIndex = 11;
            this.radOriginOther.TabStop = true;
            this.radOriginOther.Text = "Other";
            this.radOriginOther.UseVisualStyleBackColor = true;
            this.radOriginOther.CheckedChanged += new System.EventHandler(this.radOriginOther_CheckedChanged);
            // 
            // radDestDougansHole
            // 
            this.radDestDougansHole.AutoSize = true;
            this.radDestDougansHole.Location = new System.Drawing.Point(7, 19);
            this.radDestDougansHole.Name = "radDestDougansHole";
            this.radDestDougansHole.Size = new System.Drawing.Size(95, 17);
            this.radDestDougansHole.TabIndex = 0;
            this.radDestDougansHole.TabStop = true;
            this.radDestDougansHole.Text = "Dougan\'s Hole";
            this.radDestDougansHole.UseVisualStyleBackColor = true;
            this.radDestDougansHole.CheckedChanged += new System.EventHandler(this.radDestDougansHole_CheckedChanged);
            // 
            // radDestGoodMead
            // 
            this.radDestGoodMead.AutoSize = true;
            this.radDestGoodMead.Location = new System.Drawing.Point(7, 43);
            this.radDestGoodMead.Name = "radDestGoodMead";
            this.radDestGoodMead.Size = new System.Drawing.Size(81, 17);
            this.radDestGoodMead.TabIndex = 1;
            this.radDestGoodMead.TabStop = true;
            this.radDestGoodMead.Text = "Good Mead";
            this.radDestGoodMead.UseVisualStyleBackColor = true;
            this.radDestGoodMead.CheckedChanged += new System.EventHandler(this.radDestGoodMead_CheckedChanged);
            // 
            // radDestIntersection
            // 
            this.radDestIntersection.AutoSize = true;
            this.radDestIntersection.Location = new System.Drawing.Point(7, 67);
            this.radDestIntersection.Name = "radDestIntersection";
            this.radDestIntersection.Size = new System.Drawing.Size(80, 17);
            this.radDestIntersection.TabIndex = 2;
            this.radDestIntersection.TabStop = true;
            this.radDestIntersection.Text = "Intersection";
            this.radDestIntersection.UseVisualStyleBackColor = true;
            this.radDestIntersection.CheckedChanged += new System.EventHandler(this.radDestIntersection_CheckedChanged);
            // 
            // radDestEasthaven
            // 
            this.radDestEasthaven.AutoSize = true;
            this.radDestEasthaven.Location = new System.Drawing.Point(7, 91);
            this.radDestEasthaven.Name = "radDestEasthaven";
            this.radDestEasthaven.Size = new System.Drawing.Size(76, 17);
            this.radDestEasthaven.TabIndex = 3;
            this.radDestEasthaven.TabStop = true;
            this.radDestEasthaven.Text = "Easthaven";
            this.radDestEasthaven.UseVisualStyleBackColor = true;
            this.radDestEasthaven.CheckedChanged += new System.EventHandler(this.radDestEasthaven_CheckedChanged);
            // 
            // radDestCaerDineval
            // 
            this.radDestCaerDineval.AutoSize = true;
            this.radDestCaerDineval.Location = new System.Drawing.Point(7, 115);
            this.radDestCaerDineval.Name = "radDestCaerDineval";
            this.radDestCaerDineval.Size = new System.Drawing.Size(86, 17);
            this.radDestCaerDineval.TabIndex = 4;
            this.radDestCaerDineval.TabStop = true;
            this.radDestCaerDineval.Text = "Caer-Dineval";
            this.radDestCaerDineval.UseVisualStyleBackColor = true;
            this.radDestCaerDineval.CheckedChanged += new System.EventHandler(this.radDestCaerDineval_CheckedChanged);
            // 
            // radDestCaerKonig
            // 
            this.radDestCaerKonig.AutoSize = true;
            this.radDestCaerKonig.Location = new System.Drawing.Point(7, 139);
            this.radDestCaerKonig.Name = "radDestCaerKonig";
            this.radDestCaerKonig.Size = new System.Drawing.Size(77, 17);
            this.radDestCaerKonig.TabIndex = 5;
            this.radDestCaerKonig.TabStop = true;
            this.radDestCaerKonig.Text = "Caer-Konig";
            this.radDestCaerKonig.UseVisualStyleBackColor = true;
            this.radDestCaerKonig.CheckedChanged += new System.EventHandler(this.radDestCaerKonig_CheckedChanged);
            // 
            // radDestBrynShander
            // 
            this.radDestBrynShander.AutoSize = true;
            this.radDestBrynShander.Location = new System.Drawing.Point(7, 163);
            this.radDestBrynShander.Name = "radDestBrynShander";
            this.radDestBrynShander.Size = new System.Drawing.Size(89, 17);
            this.radDestBrynShander.TabIndex = 6;
            this.radDestBrynShander.TabStop = true;
            this.radDestBrynShander.Text = "Bryn Shander";
            this.radDestBrynShander.UseVisualStyleBackColor = true;
            this.radDestBrynShander.CheckedChanged += new System.EventHandler(this.radDestBrynShander_CheckedChanged);
            // 
            // radDestTargos
            // 
            this.radDestTargos.AutoSize = true;
            this.radDestTargos.Location = new System.Drawing.Point(7, 187);
            this.radDestTargos.Name = "radDestTargos";
            this.radDestTargos.Size = new System.Drawing.Size(58, 17);
            this.radDestTargos.TabIndex = 7;
            this.radDestTargos.TabStop = true;
            this.radDestTargos.Text = "Targos";
            this.radDestTargos.UseVisualStyleBackColor = true;
            this.radDestTargos.CheckedChanged += new System.EventHandler(this.radDestTargos_CheckedChanged);
            // 
            // radDestBremen
            // 
            this.radDestBremen.AutoSize = true;
            this.radDestBremen.Location = new System.Drawing.Point(7, 211);
            this.radDestBremen.Name = "radDestBremen";
            this.radDestBremen.Size = new System.Drawing.Size(61, 17);
            this.radDestBremen.TabIndex = 8;
            this.radDestBremen.TabStop = true;
            this.radDestBremen.Text = "Bremen";
            this.radDestBremen.UseVisualStyleBackColor = true;
            this.radDestBremen.CheckedChanged += new System.EventHandler(this.radDestBremen_CheckedChanged);
            // 
            // radDestTermalaine
            // 
            this.radDestTermalaine.AutoSize = true;
            this.radDestTermalaine.Location = new System.Drawing.Point(7, 235);
            this.radDestTermalaine.Name = "radDestTermalaine";
            this.radDestTermalaine.Size = new System.Drawing.Size(77, 17);
            this.radDestTermalaine.TabIndex = 9;
            this.radDestTermalaine.TabStop = true;
            this.radDestTermalaine.Text = "Termalaine";
            this.radDestTermalaine.UseVisualStyleBackColor = true;
            this.radDestTermalaine.CheckedChanged += new System.EventHandler(this.radDestTermalaine_CheckedChanged);
            // 
            // radDestLonelywood
            // 
            this.radDestLonelywood.AutoSize = true;
            this.radDestLonelywood.Location = new System.Drawing.Point(7, 259);
            this.radDestLonelywood.Name = "radDestLonelywood";
            this.radDestLonelywood.Size = new System.Drawing.Size(82, 17);
            this.radDestLonelywood.TabIndex = 10;
            this.radDestLonelywood.TabStop = true;
            this.radDestLonelywood.Text = "Lonelywood";
            this.radDestLonelywood.UseVisualStyleBackColor = true;
            this.radDestLonelywood.CheckedChanged += new System.EventHandler(this.radDestLonelywood_CheckedChanged);
            // 
            // radDestOther
            // 
            this.radDestOther.AutoSize = true;
            this.radDestOther.Location = new System.Drawing.Point(7, 283);
            this.radDestOther.Name = "radDestOther";
            this.radDestOther.Size = new System.Drawing.Size(51, 17);
            this.radDestOther.TabIndex = 11;
            this.radDestOther.TabStop = true;
            this.radDestOther.Text = "Other";
            this.radDestOther.UseVisualStyleBackColor = true;
            this.radDestOther.CheckedChanged += new System.EventHandler(this.radDestOther_CheckedChanged);
            // 
            // txtOtherDistance
            // 
            this.txtOtherDistance.Location = new System.Drawing.Point(7, 326);
            this.txtOtherDistance.Name = "txtOtherDistance";
            this.txtOtherDistance.Size = new System.Drawing.Size(100, 20);
            this.txtOtherDistance.TabIndex = 12;
            this.txtOtherDistance.TextChanged += new System.EventHandler(this.txtOtherDistance_TextChanged);
            // 
            // lblOtherDistance
            // 
            this.lblOtherDistance.AutoSize = true;
            this.lblOtherDistance.Location = new System.Drawing.Point(7, 309);
            this.lblOtherDistance.Name = "lblOtherDistance";
            this.lblOtherDistance.Size = new System.Drawing.Size(105, 13);
            this.lblOtherDistance.TabIndex = 13;
            this.lblOtherDistance.Text = "Other Total Distance";
            // 
            // gbxPace
            // 
            this.gbxPace.Controls.Add(this.radFast);
            this.gbxPace.Controls.Add(this.radNormal);
            this.gbxPace.Controls.Add(this.radSlow);
            this.gbxPace.Location = new System.Drawing.Point(12, 323);
            this.gbxPace.Name = "gbxPace";
            this.gbxPace.Size = new System.Drawing.Size(86, 89);
            this.gbxPace.TabIndex = 7;
            this.gbxPace.TabStop = false;
            this.gbxPace.Text = "Pace";
            // 
            // radSlow
            // 
            this.radSlow.AutoSize = true;
            this.radSlow.Location = new System.Drawing.Point(7, 20);
            this.radSlow.Name = "radSlow";
            this.radSlow.Size = new System.Drawing.Size(48, 17);
            this.radSlow.TabIndex = 0;
            this.radSlow.TabStop = true;
            this.radSlow.Text = "Slow";
            this.radSlow.UseVisualStyleBackColor = true;
            this.radSlow.CheckedChanged += new System.EventHandler(this.radSlow_CheckedChanged);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(7, 44);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(58, 17);
            this.radNormal.TabIndex = 1;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.radNormal_CheckedChanged);
            // 
            // radFast
            // 
            this.radFast.AutoSize = true;
            this.radFast.Location = new System.Drawing.Point(7, 68);
            this.radFast.Name = "radFast";
            this.radFast.Size = new System.Drawing.Size(45, 17);
            this.radFast.TabIndex = 2;
            this.radFast.TabStop = true;
            this.radFast.Text = "Fast";
            this.radFast.UseVisualStyleBackColor = true;
            this.radFast.CheckedChanged += new System.EventHandler(this.radFast_CheckedChanged);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(17, 39);
            this.txtDays.Name = "txtDays";
            this.txtDays.ReadOnly = true;
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 0;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(123, 39);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 1;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(229, 39);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.ReadOnly = true;
            this.txtMinutes.Size = new System.Drawing.Size(100, 20);
            this.txtMinutes.TabIndex = 2;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(17, 18);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 3;
            this.lblDays.Text = "Days";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(120, 18);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Hours";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(226, 18);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "Minutes";
            // 
            // gbxUndead
            // 
            this.gbxUndead.Controls.Add(this.radUndead);
            this.gbxUndead.Controls.Add(this.radLiving);
            this.gbxUndead.Location = new System.Drawing.Point(12, 415);
            this.gbxUndead.Name = "gbxUndead";
            this.gbxUndead.Size = new System.Drawing.Size(200, 85);
            this.gbxUndead.TabIndex = 8;
            this.gbxUndead.TabStop = false;
            this.gbxUndead.Text = "Undead Mount";
            // 
            // radLiving
            // 
            this.radLiving.AutoSize = true;
            this.radLiving.Location = new System.Drawing.Point(7, 20);
            this.radLiving.Name = "radLiving";
            this.radLiving.Size = new System.Drawing.Size(39, 17);
            this.radLiving.TabIndex = 0;
            this.radLiving.TabStop = true;
            this.radLiving.Text = "No";
            this.radLiving.UseVisualStyleBackColor = true;
            this.radLiving.CheckedChanged += new System.EventHandler(this.radLiving_CheckedChanged);
            // 
            // radUndead
            // 
            this.radUndead.AutoSize = true;
            this.radUndead.Location = new System.Drawing.Point(7, 44);
            this.radUndead.Name = "radUndead";
            this.radUndead.Size = new System.Drawing.Size(43, 17);
            this.radUndead.TabIndex = 1;
            this.radUndead.TabStop = true;
            this.radUndead.Text = "Yes";
            this.radUndead.UseVisualStyleBackColor = true;
            this.radUndead.CheckedChanged += new System.EventHandler(this.radUndead_CheckedChanged);
            // 
            // gbxPlayerExhaust
            // 
            this.gbxPlayerExhaust.Controls.Add(this.radPlayerExhausted);
            this.gbxPlayerExhaust.Controls.Add(this.radPlayerHealthy);
            this.gbxPlayerExhaust.Location = new System.Drawing.Point(106, 323);
            this.gbxPlayerExhaust.Name = "gbxPlayerExhaust";
            this.gbxPlayerExhaust.Size = new System.Drawing.Size(106, 86);
            this.gbxPlayerExhaust.TabIndex = 9;
            this.gbxPlayerExhaust.TabStop = false;
            this.gbxPlayerExhaust.Text = "Player Exhaustion >2?";
            // 
            // radPlayerHealthy
            // 
            this.radPlayerHealthy.AutoSize = true;
            this.radPlayerHealthy.Location = new System.Drawing.Point(7, 34);
            this.radPlayerHealthy.Name = "radPlayerHealthy";
            this.radPlayerHealthy.Size = new System.Drawing.Size(39, 17);
            this.radPlayerHealthy.TabIndex = 0;
            this.radPlayerHealthy.TabStop = true;
            this.radPlayerHealthy.Text = "No";
            this.radPlayerHealthy.UseVisualStyleBackColor = true;
            this.radPlayerHealthy.CheckedChanged += new System.EventHandler(this.radPlayerHealthy_CheckedChanged);
            // 
            // radPlayerExhausted
            // 
            this.radPlayerExhausted.AutoSize = true;
            this.radPlayerExhausted.Location = new System.Drawing.Point(7, 58);
            this.radPlayerExhausted.Name = "radPlayerExhausted";
            this.radPlayerExhausted.Size = new System.Drawing.Size(43, 17);
            this.radPlayerExhausted.TabIndex = 1;
            this.radPlayerExhausted.TabStop = true;
            this.radPlayerExhausted.Text = "Yes";
            this.radPlayerExhausted.UseVisualStyleBackColor = true;
            this.radPlayerExhausted.CheckedChanged += new System.EventHandler(this.radPlayerExhausted_CheckedChanged);
            // 
            // txtUntraveled
            // 
            this.txtUntraveled.ForeColor = System.Drawing.Color.Red;
            this.txtUntraveled.Location = new System.Drawing.Point(6, 88);
            this.txtUntraveled.Name = "txtUntraveled";
            this.txtUntraveled.ReadOnly = true;
            this.txtUntraveled.Size = new System.Drawing.Size(64, 20);
            this.txtUntraveled.TabIndex = 6;
            // 
            // lblUntraveledDistance
            // 
            this.lblUntraveledDistance.AutoSize = true;
            this.lblUntraveledDistance.Location = new System.Drawing.Point(4, 72);
            this.lblUntraveledDistance.Name = "lblUntraveledDistance";
            this.lblUntraveledDistance.Size = new System.Drawing.Size(104, 13);
            this.lblUntraveledDistance.TabIndex = 7;
            this.lblUntraveledDistance.Text = "Untraveled Distance";
            // 
            // lblUDDesc
            // 
            this.lblUDDesc.AutoSize = true;
            this.lblUDDesc.Location = new System.Drawing.Point(76, 91);
            this.lblUDDesc.Name = "lblUDDesc";
            this.lblUDDesc.Size = new System.Drawing.Size(273, 13);
            this.lblUDDesc.TabIndex = 8;
            this.lblUDDesc.Text = "<--If this has a value the party will stop due to exhaustion";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 511);
            this.Controls.Add(this.gbxPlayerExhaust);
            this.Controls.Add(this.gbxUndead);
            this.Controls.Add(this.gbxPace);
            this.Controls.Add(this.gbxResults);
            this.Controls.Add(this.gbxDestination);
            this.Controls.Add(this.gbxOrigin);
            this.Controls.Add(this.gbxResting);
            this.Controls.Add(this.gbxMethod);
            this.Controls.Add(this.gbxTerrain);
            this.Name = "frmMain";
            this.Text = "Icewind Dale Distance Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxTerrain.ResumeLayout(false);
            this.gbxTerrain.PerformLayout();
            this.gbxMethod.ResumeLayout(false);
            this.gbxMethod.PerformLayout();
            this.gbxResting.ResumeLayout(false);
            this.gbxResting.PerformLayout();
            this.gbxOrigin.ResumeLayout(false);
            this.gbxOrigin.PerformLayout();
            this.gbxDestination.ResumeLayout(false);
            this.gbxDestination.PerformLayout();
            this.gbxResults.ResumeLayout(false);
            this.gbxResults.PerformLayout();
            this.gbxPace.ResumeLayout(false);
            this.gbxPace.PerformLayout();
            this.gbxUndead.ResumeLayout(false);
            this.gbxUndead.PerformLayout();
            this.gbxPlayerExhaust.ResumeLayout(false);
            this.gbxPlayerExhaust.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTerrain;
        private System.Windows.Forms.GroupBox gbxMethod;
        private System.Windows.Forms.GroupBox gbxResting;
        private System.Windows.Forms.RadioButton radMountain;
        private System.Windows.Forms.RadioButton radRoad;
        private System.Windows.Forms.RadioButton radTundra;
        private System.Windows.Forms.RadioButton radUnaided;
        private System.Windows.Forms.RadioButton radSnowshoes;
        private System.Windows.Forms.RadioButton radAxeBeak;
        private System.Windows.Forms.RadioButton radDogsled;
        private System.Windows.Forms.RadioButton radUnrested;
        private System.Windows.Forms.RadioButton radResting;
        private System.Windows.Forms.GroupBox gbxOrigin;
        private System.Windows.Forms.RadioButton radOriginOther;
        private System.Windows.Forms.RadioButton radOriginLonelywood;
        private System.Windows.Forms.RadioButton radOriginTermalaine;
        private System.Windows.Forms.RadioButton radOriginBremen;
        private System.Windows.Forms.RadioButton radOriginTargos;
        private System.Windows.Forms.RadioButton radOriginBrynShander;
        private System.Windows.Forms.RadioButton radOriginCaerKonig;
        private System.Windows.Forms.RadioButton radOriginCaerDineval;
        private System.Windows.Forms.RadioButton radOriginEasthaven;
        private System.Windows.Forms.RadioButton radOriginIntersection;
        private System.Windows.Forms.RadioButton radOriginGoodMead;
        private System.Windows.Forms.RadioButton radOriginDougansHole;
        private System.Windows.Forms.GroupBox gbxDestination;
        private System.Windows.Forms.Label lblOtherDistance;
        private System.Windows.Forms.TextBox txtOtherDistance;
        private System.Windows.Forms.RadioButton radDestOther;
        private System.Windows.Forms.RadioButton radDestLonelywood;
        private System.Windows.Forms.RadioButton radDestTermalaine;
        private System.Windows.Forms.RadioButton radDestBremen;
        private System.Windows.Forms.RadioButton radDestTargos;
        private System.Windows.Forms.RadioButton radDestBrynShander;
        private System.Windows.Forms.RadioButton radDestCaerKonig;
        private System.Windows.Forms.RadioButton radDestCaerDineval;
        private System.Windows.Forms.RadioButton radDestEasthaven;
        private System.Windows.Forms.RadioButton radDestIntersection;
        private System.Windows.Forms.RadioButton radDestGoodMead;
        private System.Windows.Forms.RadioButton radDestDougansHole;
        private System.Windows.Forms.GroupBox gbxResults;
        private System.Windows.Forms.GroupBox gbxPace;
        private System.Windows.Forms.RadioButton radFast;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radSlow;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.GroupBox gbxUndead;
        private System.Windows.Forms.RadioButton radUndead;
        private System.Windows.Forms.RadioButton radLiving;
        private System.Windows.Forms.GroupBox gbxPlayerExhaust;
        private System.Windows.Forms.RadioButton radPlayerExhausted;
        private System.Windows.Forms.RadioButton radPlayerHealthy;
        private System.Windows.Forms.Label lblUDDesc;
        private System.Windows.Forms.Label lblUntraveledDistance;
        private System.Windows.Forms.TextBox txtUntraveled;
    }
}

