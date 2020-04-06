// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="">
//   
// </copyright>
// <summary>
//   The form 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RightFootball
{
    using System;
    using System.ComponentModel;
    using System.Data.Entity;
    using System.Windows.Forms;

    using RightFootball.Database;

    /// <summary>
    /// The form 1.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        private FootballContext Context { get; set; }

        /// <summary>
        /// The on load.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Context = new FootballContext();
            this.Context.Commands.Load();
            this.footballCommandBindingSource.DataSource = this.Context.Commands.Local.ToBindingList();
        }

        /// <inheritdoc />
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.Context.Dispose();
        }

        /// <summary>
        /// The football command binding navigator save item_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void FootballCommandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

           this.Context.SaveChanges();

           this.footballCommandDataGridView.Refresh();
        }
    }
}