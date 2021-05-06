
namespace TMap
{
    partial class Form1
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadIntoMap = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnGetRouteInfo = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnAddPoly = new System.Windows.Forms.Button();
            this.btnRemoveOverlay = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.chkMouseClick = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(757, 665);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(13, 13);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(734, 641);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ширина";
            // 
            // txtLat
            // 
            this.txtLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLat.Location = new System.Drawing.Point(847, 31);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(105, 22);
            this.txtLat.TabIndex = 3;
            // 
            // txtLng
            // 
            this.txtLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLng.Location = new System.Drawing.Point(847, 79);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(105, 22);
            this.txtLng.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Довгота";
            // 
            // btnLoadIntoMap
            // 
            this.btnLoadIntoMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadIntoMap.Location = new System.Drawing.Point(879, 128);
            this.btnLoadIntoMap.Name = "btnLoadIntoMap";
            this.btnLoadIntoMap.Size = new System.Drawing.Size(104, 30);
            this.btnLoadIntoMap.TabIndex = 6;
            this.btnLoadIntoMap.Text = "Шукати";
            this.btnLoadIntoMap.UseVisualStyleBackColor = true;
            this.btnLoadIntoMap.Click += new System.EventHandler(this.btnLoadIntoMap_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPoint.Location = new System.Drawing.Point(958, 27);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(141, 30);
            this.btnAddPoint.TabIndex = 7;
            this.btnAddPoint.Text = "Додати мітку";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(958, 75);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(141, 30);
            this.btnClearList.TabIndex = 8;
            this.btnClearList.Text = "Новий Маршрут";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnGetRouteInfo
            // 
            this.btnGetRouteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetRouteInfo.Location = new System.Drawing.Point(782, 128);
            this.btnGetRouteInfo.Name = "btnGetRouteInfo";
            this.btnGetRouteInfo.Size = new System.Drawing.Size(88, 30);
            this.btnGetRouteInfo.TabIndex = 9;
            this.btnGetRouteInfo.Text = "Маршрут";
            this.btnGetRouteInfo.UseVisualStyleBackColor = true;
            this.btnGetRouteInfo.Click += new System.EventHandler(this.btnGetRouteInfo_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(782, 186);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(111, 17);
            this.lblDistance.TabIndex = 10;
            this.lblDistance.Text = "Дистанція в КМ";
            // 
            // btnAddPoly
            // 
            this.btnAddPoly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPoly.Location = new System.Drawing.Point(995, 128);
            this.btnAddPoly.Name = "btnAddPoly";
            this.btnAddPoly.Size = new System.Drawing.Size(104, 30);
            this.btnAddPoly.TabIndex = 11;
            this.btnAddPoly.Text = "Полігон";
            this.btnAddPoly.UseVisualStyleBackColor = true;
            this.btnAddPoly.Click += new System.EventHandler(this.btnAddPoly_Click);
            // 
            // btnRemoveOverlay
            // 
            this.btnRemoveOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveOverlay.Location = new System.Drawing.Point(908, 179);
            this.btnRemoveOverlay.Name = "btnRemoveOverlay";
            this.btnRemoveOverlay.Size = new System.Drawing.Size(154, 30);
            this.btnRemoveOverlay.TabIndex = 12;
            this.btnRemoveOverlay.Text = "Очистити карту";
            this.btnRemoveOverlay.UseVisualStyleBackColor = true;
            this.btnRemoveOverlay.Click += new System.EventHandler(this.btnRemoveOverlay_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(817, 260);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(231, 166);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.Text = "";
            // 
            // chkMouseClick
            // 
            this.chkMouseClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMouseClick.AutoSize = true;
            this.chkMouseClick.Checked = true;
            this.chkMouseClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMouseClick.Location = new System.Drawing.Point(817, 233);
            this.chkMouseClick.Name = "chkMouseClick";
            this.chkMouseClick.Size = new System.Drawing.Size(135, 21);
            this.chkMouseClick.TabIndex = 14;
            this.chkMouseClick.Text = "Увімкнути п.к.м.";
            this.chkMouseClick.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(814, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Вікно для вводу-виводу адреси";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 665);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkMouseClick);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnRemoveOverlay);
            this.Controls.Add(this.btnAddPoly);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnGetRouteInfo);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.btnLoadIntoMap);
            this.Controls.Add(this.txtLng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadIntoMap;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnGetRouteInfo;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnAddPoly;
        private System.Windows.Forms.Button btnRemoveOverlay;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.CheckBox chkMouseClick;
        private System.Windows.Forms.Label label3;
    }
}

