﻿namespace PZ13
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label u_nameLabel;
            System.Windows.Forms.Label u_surnameLabel;
            System.Windows.Forms.Label u_patronymicLabel;
            System.Windows.Forms.Label u_phoneLabel;
            System.Windows.Forms.Label u_emailLabel;
            System.Windows.Forms.Label u_statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bookshopDataSet = new PZ13.bookshopDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new PZ13.bookshopDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new PZ13.bookshopDataSetTableAdapters.TableAdapterManager();
            this.usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.u_nameTextBox = new System.Windows.Forms.TextBox();
            this.u_surnameTextBox = new System.Windows.Forms.TextBox();
            this.u_patronymicTextBox = new System.Windows.Forms.TextBox();
            this.u_phoneTextBox = new System.Windows.Forms.TextBox();
            this.u_emailTextBox = new System.Windows.Forms.TextBox();
            this.u_statusTextBox = new System.Windows.Forms.TextBox();
            u_nameLabel = new System.Windows.Forms.Label();
            u_surnameLabel = new System.Windows.Forms.Label();
            u_patronymicLabel = new System.Windows.Forms.Label();
            u_phoneLabel = new System.Windows.Forms.Label();
            u_emailLabel = new System.Windows.Forms.Label();
            u_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).BeginInit();
            this.usersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // u_nameLabel
            // 
            u_nameLabel.AutoSize = true;
            u_nameLabel.Location = new System.Drawing.Point(375, 152);
            u_nameLabel.Name = "u_nameLabel";
            u_nameLabel.Size = new System.Drawing.Size(66, 16);
            u_nameLabel.TabIndex = 1;
            u_nameLabel.Text = "Фамилия";
            // 
            // u_surnameLabel
            // 
            u_surnameLabel.AutoSize = true;
            u_surnameLabel.Location = new System.Drawing.Point(375, 208);
            u_surnameLabel.Name = "u_surnameLabel";
            u_surnameLabel.Size = new System.Drawing.Size(70, 16);
            u_surnameLabel.TabIndex = 3;
            u_surnameLabel.Text = "Отчество";
            // 
            // u_patronymicLabel
            // 
            u_patronymicLabel.AutoSize = true;
            u_patronymicLabel.Location = new System.Drawing.Point(375, 180);
            u_patronymicLabel.Name = "u_patronymicLabel";
            u_patronymicLabel.Size = new System.Drawing.Size(33, 16);
            u_patronymicLabel.TabIndex = 5;
            u_patronymicLabel.Text = "Имя";
            // 
            // u_phoneLabel
            // 
            u_phoneLabel.AutoSize = true;
            u_phoneLabel.Location = new System.Drawing.Point(375, 241);
            u_phoneLabel.Name = "u_phoneLabel";
            u_phoneLabel.Size = new System.Drawing.Size(67, 16);
            u_phoneLabel.TabIndex = 7;
            u_phoneLabel.Text = "Телефон";
            // 
            // u_emailLabel
            // 
            u_emailLabel.AutoSize = true;
            u_emailLabel.Location = new System.Drawing.Point(375, 271);
            u_emailLabel.Name = "u_emailLabel";
            u_emailLabel.Size = new System.Drawing.Size(41, 16);
            u_emailLabel.TabIndex = 9;
            u_emailLabel.Text = "Email";
            // 
            // u_statusLabel
            // 
            u_statusLabel.AutoSize = true;
            u_statusLabel.Location = new System.Drawing.Point(373, 304);
            u_statusLabel.Name = "u_statusLabel";
            u_statusLabel.Size = new System.Drawing.Size(53, 16);
            u_statusLabel.TabIndex = 11;
            u_statusLabel.Text = "Статус";
            // 
            // bookshopDataSet
            // 
            this.bookshopDataSet.DataSetName = "bookshopDataSet";
            this.bookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.bookshopDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = null;
            this.tableAdapterManager.catalogsTableAdapter = null;
            this.tableAdapterManager.februaryTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PZ13.bookshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // usersBindingNavigator
            // 
            this.usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usersBindingNavigator.BindingSource = this.usersBindingSource;
            this.usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usersBindingNavigatorSaveItem});
            this.usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usersBindingNavigator.Name = "usersBindingNavigator";
            this.usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usersBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.usersBindingNavigator.TabIndex = 0;
            this.usersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // usersBindingNavigatorSaveItem
            // 
            this.usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingNavigatorSaveItem.Image")));
            this.usersBindingNavigatorSaveItem.Name = "usersBindingNavigatorSaveItem";
            this.usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.usersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click);
            // 
            // u_nameTextBox
            // 
            this.u_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "u_name", true));
            this.u_nameTextBox.Location = new System.Drawing.Point(467, 149);
            this.u_nameTextBox.Name = "u_nameTextBox";
            this.u_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.u_nameTextBox.TabIndex = 2;
            // 
            // u_surnameTextBox
            // 
            this.u_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "u_surname", true));
            this.u_surnameTextBox.Location = new System.Drawing.Point(467, 205);
            this.u_surnameTextBox.Name = "u_surnameTextBox";
            this.u_surnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.u_surnameTextBox.TabIndex = 4;
            // 
            // u_patronymicTextBox
            // 
            this.u_patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "u_patronymic", true));
            this.u_patronymicTextBox.Location = new System.Drawing.Point(467, 177);
            this.u_patronymicTextBox.Name = "u_patronymicTextBox";
            this.u_patronymicTextBox.Size = new System.Drawing.Size(100, 22);
            this.u_patronymicTextBox.TabIndex = 6;
            // 
            // u_phoneTextBox
            // 
            this.u_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "u_phone", true));
            this.u_phoneTextBox.Location = new System.Drawing.Point(467, 238);
            this.u_phoneTextBox.Name = "u_phoneTextBox";
            this.u_phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.u_phoneTextBox.TabIndex = 8;
            // 
            // u_emailTextBox
            // 
            this.u_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "u_email", true));
            this.u_emailTextBox.Location = new System.Drawing.Point(467, 271);
            this.u_emailTextBox.Name = "u_emailTextBox";
            this.u_emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.u_emailTextBox.TabIndex = 10;
            // 
            // u_statusTextBox
            // 
            this.u_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "u_status", true));
            this.u_statusTextBox.Location = new System.Drawing.Point(467, 304);
            this.u_statusTextBox.Name = "u_statusTextBox";
            this.u_statusTextBox.Size = new System.Drawing.Size(100, 22);
            this.u_statusTextBox.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(u_statusLabel);
            this.Controls.Add(this.u_statusTextBox);
            this.Controls.Add(u_emailLabel);
            this.Controls.Add(this.u_emailTextBox);
            this.Controls.Add(u_phoneLabel);
            this.Controls.Add(this.u_phoneTextBox);
            this.Controls.Add(u_patronymicLabel);
            this.Controls.Add(this.u_patronymicTextBox);
            this.Controls.Add(u_surnameLabel);
            this.Controls.Add(this.u_surnameTextBox);
            this.Controls.Add(u_nameLabel);
            this.Controls.Add(this.u_nameTextBox);
            this.Controls.Add(this.usersBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).EndInit();
            this.usersBindingNavigator.ResumeLayout(false);
            this.usersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bookshopDataSet bookshopDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private bookshopDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private bookshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox u_nameTextBox;
        private System.Windows.Forms.TextBox u_surnameTextBox;
        private System.Windows.Forms.TextBox u_patronymicTextBox;
        private System.Windows.Forms.TextBox u_phoneTextBox;
        private System.Windows.Forms.TextBox u_emailTextBox;
        private System.Windows.Forms.TextBox u_statusTextBox;
    }
}